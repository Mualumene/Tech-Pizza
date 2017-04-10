using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPizzaWF.DAO
{
    class ItemPedidoDAO : Acesso    
    {
        

        // S E L E C T  - ITENS DO ATUAL PEDIDO
        public DataTable ItensPedAtual()
        {
            DataTable dt = new DataTable();

            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoSeleciona = String.Format("select p.idped,z.nome,i.qtd,i.valoritem,p.valortotal from pedido p,item i, pizza z where (p.idped = i.idpedid) and (z.idpizza = idpizz) and p.status = 1");
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(comandoSeleciona, Conexao))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.Close();
            }
            return dt;
        }
        // I N S E R I R -  ITEM AO PEDIDO ATUAL
        public void InserirItemAoPed(string pizza)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string cmdInserir = String.Format("insert into item(qtd, idpedid, idpizz, valoritem) values(1, (select idped from pedido where status = 1), (select idpizza from pizza where nome = '" + pizza + "'), (select valorunitario from pizza where nome = '" + pizza + "'))");
                    using (NpgsqlCommand Comando = new NpgsqlCommand(cmdInserir, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //ITENS DO PEDIDO PRNDENTE
        public DataTable ItensPendentes(int p)
        {
            DataTable dt = new DataTable();

            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoSeleciona = String.Format("select p.idped,z.nome,i.qtd from pedido p,item i, pizza z where ((p.idped = i.idpedid) and (z.idpizza = idpizz) and p.status = 2) and idped = {0}", p);
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(comandoSeleciona, Conexao))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.Close();
            }
            return dt;
        }

    }
}

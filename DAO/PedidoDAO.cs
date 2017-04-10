using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPizzaWF.DAO
{
    class PedidoDAO : Acesso
    {
        

        //INSERIR PEDIDO
        public void InserirNovoPed(int idcli)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string cmdInserir = String.Format("insert into pedido(dtpedido,idcli,status) values((select now()),'{0}','1')", idcli);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(cmdInserir, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }

        //ATUALIZA VALOR TOTAL DO PEDIDO
        public void UpdateValorPedido()
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoAtualiza = "update pedido p set valortotal = (select SUM(i.valoritem) from item i, pedido p where p.status = 1 and i.idpedid = p.idped) from item i where status = 1 and i.idpedid = p.idped";
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoAtualiza, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //FECHAR PEDIDO
        public void fecharPedido()
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoAtualiza = String.Format("update pedido set status = status + 1 where status = 1");
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoAtualiza, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //Cancela pedido
        public void CancelaPedido()
        {
            //Itens
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoDeletar = String.Format("delete from item using item i, pedido p where i.idpedid = p.idped and p.status = 1");
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoDeletar, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
            //Pedido
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoDeletar = String.Format("delete from pedido where status = 1");
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoDeletar, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //PEDIDOS PENDENTES
        public DataTable GetPedidosPendentes(int st)
        {
            DataTable dt = new DataTable();

            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoSeleciona = String.Format("select p.idped,c.nome,p.dtpedido,p.valortotal from pedido p,cliente c where (p.idcli = c.idcliente) and p.status = {0} order by p.idped", st);
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
        //PEDIDO PRONTO
        public void PedPronto(int p)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoAtualiza = String.Format("update pedido set status = status + 1 where idped = {0}", p);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoAtualiza, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        public DataTable GetEntregas()
        {
            DataTable dt = new DataTable();

            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoSeleciona = String.Format("select p.idped,c.nome,p.dtpedido,p.valortotal,p.status,c.idende from pedido p,cliente c where (p.idcli = c.idcliente) and p.status in (3,4) order by p.idped");
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
        //Vendas
        public DataTable getRelaPedidos()
        {
            DataTable dt = new DataTable();

            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoSeleciona = String.Format("select idped,dtpedido,valortotal,idcli,status,(select sum(valortotal) from pedido),(select count(idped) from pedido) from pedido group by idped");
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

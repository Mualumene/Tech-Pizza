using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPizzaWF.DAO
{
    class ClienteDAO : Acesso
    {
    
         
        //Select CLIENTES
        public DataTable getTodosClientes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoSeleciona = "select c.idcliente,c.nome, c.telefone, e.rua,e.numero,e.cep,e.uf,e.cidade from cliente c,endereco e where c.idende = e.idendereco";
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

        //CADASTRA CLIENTES
        public void cadastrarCliente(string nome, Int64 telefone)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string cmdInserir = String.Format("Insert Into cliente(nome,telefone) values('{0}','{1}')", nome, telefone);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(cmdInserir, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //ENCADEAR TABELAS
        public void EncadeandoChaves()
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoAtualiza = String.Format("update cliente set idende = (select e.idendereco from endereco e, cliente c where(cliente.idcliente = e.idendereco) and(c.idende is null)) from endereco e,cliente c where(cliente.idcliente = e.idendereco) and(c.idende is null); ");
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoAtualiza, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //ATUALIZA CLIENTES
        public void AtualizarCliente(int codigo, string nome, Int64 telefone)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoAtualiza = String.Format("Update cliente Set Nome = '" + nome + "' , telefone = " + telefone + " Where idcliente = " + codigo);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoAtualiza, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //EXCLUIR CLIENTE
        public void DeletarCliente(int codigo)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoDeletar = String.Format("Delete From cliente Where idcliente = '{0}'", codigo);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoDeletar, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //CLIENTES RELATORIOS
        public DataTable getRelaClientes(int cli)
        {
            DataTable dt = new DataTable();

            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoSeleciona = String.Format("select (select sum(valortotal) from pedido p,cliente c where p.idcli = c.idcliente and c.idcliente = {0}),(select count(idped) from pedido p, cliente c where p.idcli = c.idcliente and p.idcli = {0})", cli);
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

using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPizzaWF.DAO
{
    class EnderecoDAO : Acesso
    {
        //CADASTRA ENDERECO
        public void cadastrarEndereco(long CEP, string rua, int numero, string UF, string Cidade)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string cmdInserir = String.Format("Insert Into endereco(cep,rua,numero,uf,Cidade) values('{0}','{1}','{2}','{3}','{4}')", CEP, rua, numero, UF, Cidade);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(cmdInserir, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //Atualizar endereco
        public void AtualizarEndereco(string Rua, int numero, Int64 cep, string UF, string cidade, int codigo)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoAtualiza = String.Format("Update endereco Set rua = '{0}',numero ='{1}',cep ='{2}',uf = '{3}',cidade ='{4}'  where idendereco  = '{5}' ", Rua, numero, cep, UF, cidade, codigo);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoAtualiza, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //EXCLUIR ENDERECO
        public void DeletarEndereco(int codigo)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoDeletar = String.Format("Delete From endereco Where idendereco = '{0}'", codigo);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoDeletar, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //Get endereco
        public DataTable GetEndereco(int end)
        {
            DataTable dt = new DataTable();

            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoSeleciona = String.Format("select * from endereco e where e.idendereco = {0}", end);
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

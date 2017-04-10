using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPizzaWF.DAO
{
    class UsuarioDAO : Acesso
    {
        public string NomeUsuario = "";
        public string senha = "";
        public string Cargo = "";

        

        //LOGIN............................................................................................
        public string AcessoSistema(string login, string senha)
        {
            string resposta = "nao";
            NpgsqlDataReader dr = null;
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string cmdLogin = String.Format("Select * from usuario where upper(login) = upper('{0}') and senha = '{1}'", login, senha);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(cmdLogin, Conexao))
                    {
                        dr = Comando.ExecuteReader();
                        while (dr.Read())
                        {
                            this.NomeUsuario = Convert.ToString(dr[1]); //para salvar um dado do select emu ma variavel
                            this.Cargo = Convert.ToString(dr[3]);
                        }
                        if (dr.HasRows)
                        {
                            resposta = "ok";
                        }
                        else
                        {
                            resposta = "nao";
                        }
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
            return resposta;
        }
        //select usuarios
        public DataTable getUsuarios()
        {
            DataTable dt = new DataTable();

            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoSeleciona = "select * from usuario";
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
        //cadastra usuarios
        public void cadastrarUsuario(string nome, string senha, string cargo)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string cmdInserir = String.Format("Insert Into usuario(login,senha,cargo) values('{0}','{1}','{2}')", nome, senha, cargo);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(cmdInserir, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //atualizar usuario
        public void atualizaUsuario(int codigo, string nome, string senha, string cargo)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoAtualiza = String.Format("Update usuario Set login = '{0}' , senha = '{1}', cargo = '{2}' Where idusuario = '{3}' ", nome, senha, cargo, codigo);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoAtualiza, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
        //deletar usuario
        public void deletarUsuario(int codigo)
        {
            try
            {
                using (Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();
                    string comandoDeletar = String.Format("Delete From usuario Where idusuario = '{0}'", codigo);
                    using (NpgsqlCommand Comando = new NpgsqlCommand(comandoDeletar, Conexao)) { Comando.ExecuteNonQuery(); }
                }
            }
            catch (NpgsqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { Conexao.Close(); }
        }
    }
}

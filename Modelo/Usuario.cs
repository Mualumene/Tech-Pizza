using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPizzaWF.Model
{

    public class Usuario
    {

        private int id;
        private String nome;
        private String login;
        private String senha;
        private String tipoUsuario;

        public int getId()
        {
            return id;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getLogin()
        {
            return login;
        }

        public void setLogin(String login)
        {
            this.login = login;
        }

        public String getSenha()
        {
            return senha;
        }

        public void setSenha(String senha)
        {
            this.senha = senha;
        }

        public String getTipoUsuario()
        {
            return tipoUsuario;
        }

        public void setTipoUsuario(String tipoUsuario)
        {
            this.tipoUsuario = tipoUsuario;
        }

        public Usuario(int id, String login, String senha, String tipoUsuario)
        {
            this.id = id;
            this.login = login;
            this.senha = senha;
            this.tipoUsuario = tipoUsuario;
        }

        public Usuario()
        {
        }
    }

}

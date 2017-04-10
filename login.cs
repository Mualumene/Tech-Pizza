using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechPizzaWF.DAO;
using TechPizzaWF.Model;


namespace TechPizzaWF
{
    public partial class login : Form
    {
        //Instancia ObjetosDAO
        UsuarioDAO uDAO = new UsuarioDAO();

        public login()
        {
            InitializeComponent();
        }
        //Instancia novo usuario
        
        public void logar()
        {
            string resultado = "";
            resultado = uDAO.AcessoSistema(txtUsuario.Text, txtSenha.Text);
            if (resultado == "ok")
            {
                MessageBox.Show("Acesso permitido");
                this.Hide();
                Inicial ini = new Inicial();
                ini.nome = Convert.ToString(uDAO.NomeUsuario);
                ini.cargo = uDAO.Cargo;
                ini.ShowDialog();
            }
            else { MessageBox.Show("Usuário não existe"); }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.logar();
            }
        }
    }
}

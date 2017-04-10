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

namespace TechPizzaWF
{
    public partial class CadastroUsuario : Form
    {
        //Instancia ObjetosDAO

        UsuarioDAO uDAO = new UsuarioDAO();

        private string nome, senha, cargo,n,s,c;//Parâmetros que serão passados aos metodos
        private int codusu;

        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public void AtializaUsuario()
        {
            try
            {
                dgvUsuarios.DataSource = uDAO.getUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            AtializaUsuario();
        }

        //Excluir usuario
        private void btnExcluirUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja excluir o usuario?", "Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)//SIM
            {
                uDAO.deletarUsuario(codusu);
                MessageBox.Show("Usuario Excluido com Sucesso!!", "Excluido");
                AtializaUsuario();
            }
            else if (dialogResult == DialogResult.No)//NÃO
            {

            }
        }

        //Editar usuario
        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            btnInserirUser.Text = "Atualizar";
            txtUsuario.Text = n;
            txtSenha.Text = s;
            cbmCargo.Text = c;
        }

        private void dgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            codusu = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value);
            n = Convert.ToString(dgvUsuarios.Rows[e.RowIndex].Cells[1].Value);
            s = Convert.ToString(dgvUsuarios.Rows[e.RowIndex].Cells[2].Value);
            c = Convert.ToString(dgvUsuarios.Rows[e.RowIndex].Cells[3].Value);
        }

        //método para limpar os textbox do formulário (nesse caso, todos)
        public void limpaTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    limpaTextBox(c);
                }
            }
        }

        //Inserir novo usuario
        private void btnInserirUser_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty ||
                txtSenha.Text == string.Empty ||
                cbmCargo.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            else
            {
                if (btnInserirUser.Text == "Inserir usuario")
                {
                    nome = Convert.ToString(txtUsuario.Text);
                    senha = Convert.ToString(txtSenha.Text);
                    cargo = cbmCargo.Text;

                    DialogResult dialogResult = MessageBox.Show("Deseja Incluir " + nome + " como " + cargo + "?", "Controle de Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)//SIM
                    {
                        uDAO.cadastrarUsuario(nome, senha, cargo);
                        MessageBox.Show("Seu novo usuario foi cadastrado com sucesso!!", "Cadstrado!");
                        AtializaUsuario();
                        limpaTextBox(this);
                    }
                    else if (dialogResult == DialogResult.No)//NÃO
                    {

                    }
                }
                else if (btnInserirUser.Text == "Atualizar")// A T U A L I Z A R------------------
                {
                    nome = Convert.ToString(txtUsuario.Text);
                    senha = Convert.ToString(txtSenha.Text);
                    cargo = cbmCargo.Text;

                    DialogResult dialogResult = MessageBox.Show("Deseja salvar alterações?", "Controle de Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)//SIM
                    {
                        uDAO.atualizaUsuario(codusu, nome, senha, cargo);
                        MessageBox.Show("Seu usuario foi atualizado com sucesso!!", "Atualizado!");
                        AtializaUsuario();
                        limpaTextBox(this);
                        btnInserirUser.Text = "Inserir usuario";
                    }
                    else if (dialogResult == DialogResult.No)//NÃO
                    {

                    }
                }
            }    
        }
    }
}

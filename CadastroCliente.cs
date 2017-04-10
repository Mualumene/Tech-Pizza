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
    public partial class CadastroCliente : Form
    {
        //Instancia ObjetosDAO
        ClienteDAO cDAO = new ClienteDAO();
        EnderecoDAO eDAO = new EnderecoDAO();


        private bool edit = false;
        private int codigo;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*ATUALIZA CLIENTES*/
        public void atualizaGridCLi()
        {
            try
            {
                dgvClientes.DataSource = cDAO.getTodosClientes();
                dgvClientes.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            atualizaGridCLi();
        }
        //BOTÃO INSERIR ---------------------------------------------------------------------------------------------------------------------------------------------
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if(btnConcluir.Text == "Atualizar")
            {
                cDAO.AtualizarCliente(codigo, txtNome.Text, Convert.ToInt64(txtTelefone.Text));
                eDAO.AtualizarEndereco(txtRua.Text, Convert.ToInt32(NudNumero.Value), Convert.ToInt64(txtCEP.Text), cbmUF.Text, txtCidade.Text, codigo);
                atualizaGridCLi();
                txtNome.Focus();
                btnConcluir.Text = "Inserir";
                limpaTextBox(this);
            }
            if (btnConcluir.Text == "Inserir")
            {
                limpaTextBox(this);
                txtNome.Focus();
                btnConcluir.Text = "Concluir";
            }
            else
            {
                if (btnConcluir.Text == "Concluir")
                {
                    if (txtNome.Text == string.Empty ||
                        txtTelefone.Text == string.Empty ||
                        txtCEP.Text == string.Empty ||
                        txtRua.Text == string.Empty ||
                        cbmUF.Text == string.Empty ||
                        txtCidade.Text == string.Empty ||
                        NudNumero.Value == 0)
                    {
                        MessageBox.Show("Preencha todos os campos");
                        return;
                    }
                    //METODOS DE INSERÇÃO
                    eDAO.cadastrarEndereco(Convert.ToInt64(txtCEP.Text), txtRua.Text, Convert.ToInt32(NudNumero.Value), cbmUF.Text, txtCidade.Text);
                    cDAO.cadastrarCliente(txtNome.Text, Convert.ToInt64(txtTelefone.Text));
                    cDAO.EncadeandoChaves();
                    //----------------------------------------------------------------------------------------------------------------------------
                    btnConcluir.Text = "Inserir";
                    edit = false;
                    limpaTextBox(this);
                    atualizaGridCLi();
                    MessageBox.Show("Operação realizada com sucesso!");
                }
            }
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

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void dgvClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(edit == true)
            { 
            txtNome.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[1].Value);
            txtTelefone.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[2].Value);
            txtCEP.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[5].Value);
            txtRua.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[3].Value);
            NudNumero.Value = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[4].Value);
            cbmUF.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[6].Value);
            txtCidade.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells[7].Value);

                codigo = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            edit = true;
            btnConcluir.Text = "Atualizar";

            //Aqui começa a magica da atualização
            if (txtNome.Text == string.Empty ||
                        txtTelefone.Text == string.Empty ||
                        txtCEP.Text == string.Empty ||
                        txtRua.Text == string.Empty ||
                        cbmUF.Text == string.Empty ||
                        txtCidade.Text == string.Empty ||
                        NudNumero.Value == 0
                        )
            {
                txtNome.Focus(); return;
            }
            try
            {
                
                atualizaGridCLi();
                MessageBox.Show("Operação realizada com sucesso!");
            }
            catch (Exception ex)
            { MessageBox.Show("Erro : " + ex.Message); }
            btnConcluir.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                if (txtNome.Text == string.Empty ||
                        txtTelefone.Text == string.Empty ||
                        txtCEP.Text == string.Empty ||
                        txtRua.Text == string.Empty ||
                        cbmUF.Text == string.Empty ||
                        txtCidade.Text == string.Empty ||
                        NudNumero.Value == 0
                        )
                {
                    return;
                }
                try
                {
                    if (MessageBox.Show("Deseja realmente excluir esse dado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cDAO.DeletarCliente(codigo);
                        eDAO.DeletarEndereco(codigo);
                        atualizaGridCLi();
                        MessageBox.Show("Operação realizada com sucesso!");
                        btnConcluir.Text = "Concluir";
                        limpaTextBox(this);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Erro : " + ex.Message);
                }
            }
        }

        //método do datagridview quando selecionar uma célula
        //CELL ENTER NECESSÁRIO


    }
}

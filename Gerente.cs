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
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }
        //Instancia ObjetosDAO
        ClienteDAO cDAO = new ClienteDAO();
        PedidoDAO pDAO = new PedidoDAO();
        ItemPedidoDAO iDAO = new ItemPedidoDAO();
        EnderecoDAO eDAO = new EnderecoDAO();
        PizzaDAO zDAO = new PizzaDAO();

        //parametro que será passado para o método
        private int idCli;
        private string s,sabor;
        private double v,valor;
        private int codPizza;


        //Botão voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //DEIXA A TELA PREPARADA PARA VENDAS
        public void TelaVendas()
        {
            lblDGVGentente.Text = "Vendas";
            txtPizza.Visible = false;
            txtValor.Visible = false;
            lbl1Res.Visible = true;
            lbl2Res.Visible = true;
            btnEditarPizza.Visible = false;
            btnExcluirPizza.Visible = false;
            btnInserirPizza.Visible = false;
        }

        //DEIXA A TELA PREPARADA PARA CLIENTES
        public void TelaClientes()
        {
            lblDGVGentente.Text = "Clientes";
            txtPizza.Visible = false;
            txtValor.Visible = false;
            lbl1Res.Visible = true;
            lbl2Res.Visible = true;
            btnEditarPizza.Visible = false;
            btnExcluirPizza.Visible = false;
            btnInserirPizza.Visible = false;
        }

        //DEIXA A TELA PREPARADA PARA PIZZAS
        public void TelaPizzas()
        {
            lblDGVGentente.Text = "Pizzas";
            btnEditarPizza.Visible = true;
            btnExcluirPizza.Visible = true;
            btnInserirPizza.Visible = true;
            lbl1Res.Visible = false;
            lbl2Res.Visible = false;
            lbl1.Text = "Pizza: ";
            lbl2.Text = "Valor: ";
            txtPizza.Visible = true;
            txtValor.Visible = true;
        }

        //Carrega GRIDS
        public void atualizarClientes()
        {
            try
            {
                dgvGerente.DataSource = cDAO.getTodosClientes();
                dgvGerente.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        public void atualizaVendas()
        {
            try
            {
                dgvGerente.DataSource = pDAO.getRelaPedidos();
                dgvGerente.Columns[6].Visible = false;
                dgvGerente.Columns[5].Visible = false;
                dgvGerente.Columns[2].DefaultCellStyle.Format = "C2";
                dgvGerente.Columns[5].DefaultCellStyle.Format = "C2";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        public void AtualizarRelatorio()
        {
            try
            {
                dgvAuxiliar.DataSource = cDAO.getRelaClientes(idCli);
  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        public void AtualizaPizzas()
        {
            try
            {
                dgvGerente.DataSource = zDAO.getPizzasRela();
                dgvGerente.Columns[2].DefaultCellStyle.Format = "C2"; //VALOR MONETARIO

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
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

        private void Gerente_Load(object sender, EventArgs e)
        {
            atualizarClientes();
        }

        //CELL eNTER
        private void dgvGerente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(lblDGVGentente.Text == "Clientes")
            {
                idCli = Convert.ToInt32(dgvGerente.Rows[e.RowIndex].Cells[0].Value);
                AtualizarRelatorio();
                try
                {
                    lbl2Res.Text = Convert.ToString(dgvAuxiliar.Rows[e.RowIndex].Cells[0].Value);
                    lbl2Res.Text = Convert.ToDouble(lbl2Res.Text).ToString("C2");
                }
                catch (Exception ex)
                {
                    lbl2Res.Text = "R$ 0,00";
                }
                try
                {
                    lbl1Res.Text = Convert.ToString(dgvAuxiliar.Rows[e.RowIndex].Cells[1].Value) + " vezes";
                }
                catch (Exception ex)
                {
                    lbl1Res.Text = "0 vezes";
                }
            }else if(lblDGVGentente.Text == "Vendas")//------------------
            {
                lbl1.Text = "Lucro:";
                lbl1Res.Text = Convert.ToString(dgvGerente.Rows[e.RowIndex].Cells[5].Value);
                lbl1Res.Text = Convert.ToDouble(lbl1Res.Text).ToString("C2");
                lbl2.Text = "Vendas:";
                lbl2Res.Text = Convert.ToString(dgvGerente.Rows[e.RowIndex].Cells[6].Value);
            }else if(lblDGVGentente.Text == "Pizzas")
            {
                codPizza = Convert.ToInt32(dgvGerente.Rows[e.RowIndex].Cells[0].Value);
                s = Convert.ToString(dgvGerente.Rows[e.RowIndex].Cells[1].Value);
                v = Convert.ToInt32(dgvGerente.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            TelaClientes(); //Carrega elementos da tela
            atualizarClientes();//Carrega elementos da GRID
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            TelaVendas();   //Carrega elementos da tela
            atualizaVendas();//Carrega elementos da GRID
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPizzas();   //Carrega elementos da tela
            AtualizaPizzas();//Carrega elementos da GRID            
        }
        //INSERIR NOVO VALOR
        private void btnInserirPizza_Click(object sender, EventArgs e)
        {
            if (txtPizza.Text == string.Empty || txtValor.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            else
            {
                if(btnInserirPizza.Text == "Inserir Sabor")
                {  
                    sabor = Convert.ToString(txtPizza.Text);
                    valor = Convert.ToDouble(txtValor.Text);

                    DialogResult dialogResult = MessageBox.Show("Deseja Incluir "+sabor+" ao cardapio?", "Sabor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)//SIM
                    {
                        zDAO.cadastrarSabor(sabor, valor);
                        MessageBox.Show("Seu novo sabor foi cadastrado com sucesso!!", "Cadstrado!");
                        AtualizaPizzas();
                        limpaTextBox(this);
                    }
                    else if (dialogResult == DialogResult.No)//NÃO
                    {

                    }
                }else if(btnInserirPizza.Text == "Atualizar")// A T U A L I Z A R------------------
                {
                    sabor = Convert.ToString(txtPizza.Text);
                    valor = Convert.ToDouble(txtValor.Text);

                    DialogResult dialogResult = MessageBox.Show("Deseja salvar alterações?", "Sabor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)//SIM
                    {
                        zDAO.atualizarSabor(codPizza,sabor, valor);
                        MessageBox.Show("Seu sabor foi atualizado com sucesso!!", "Atualizado!");
                        AtualizaPizzas();
                        limpaTextBox(this);
                        btnInserirPizza.Text = "Inserir Sabor";
                    }
                    else if (dialogResult == DialogResult.No)//NÃO
                    {

                    }
                }
            }
        }

        //Eventos para formatar e validar o valor da pizza
        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("F");
        } 
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                   (e.KeyChar != ',' && e.KeyChar != '.' &&
                    e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
                {
                    e.KeyChar = (Char)0;
                }
                else
                {
                    if (e.KeyChar == '.' || e.KeyChar == ',')
                    {
                        if (!txtValor.Text.Contains(','))
                        {
                            e.KeyChar = ',';
                        }
                        else
                        {
                            e.KeyChar = (Char)0;
                        }
                    }
                }
            }

        }
        private void txtValor_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtValor.Text.Length - 1; i++)
            {
                if ((txtValor.Text[i] >= '0' &&
                    txtValor.Text[i] <= '9') ||
                    txtValor.Text[i] == ',')
                {
                    x += txtValor.Text[i];
                }
            }
            txtValor.Text = x;
            txtValor.SelectAll();
        }

        //Administração
        private void btnAdm_Click(object sender, EventArgs e)
        {
            CadastroUsuario cu = new CadastroUsuario();
            cu.ShowDialog();
        }

        //--------------------------------------------------------
        //EXCLUIR SABOR
        private void btnExcluirPizza_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja excluir o sabor do cardapio?", "Sabor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)//SIM
            {
                zDAO.deletarSabor(codPizza);
                MessageBox.Show("Sabor Excluido com Sucesso!!", "Excluido");
                AtualizaPizzas();
            }
            else if (dialogResult == DialogResult.No)//NÃO
            {

            }
        }

        private void btnEditarPizza_Click(object sender, EventArgs e)
        {
            btnInserirPizza.Text = "Atualizar";
            txtPizza.Text = s;
            txtValor.Text = v.ToString("C2");
        }
    }
}

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
    public partial class Atendente : Form
    {
        //Instancia ObjetosDAO
        ClienteDAO cDAO = new ClienteDAO();
        PedidoDAO pDAO = new PedidoDAO();
        ItemPedidoDAO iDAO = new ItemPedidoDAO();
        EnderecoDAO eDAO = new EnderecoDAO();
        PizzaDAO zDAO = new PizzaDAO();

        private string pizza;
        private int idcliente;
        
        public Atendente()
        {
            InitializeComponent();
        }
        
        //BOTÃO ADICIONAR PIZZA AO PEDIDO
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (btnAdicionar.Text == "Criar Pedido")
            {
                pDAO.InserirNovoPed(idcliente);
                btnAdicionar.Text = "Adicionar";
                lblExCli.Text = "Cliente Selecionado!";
                lblExPed.Text = "Escolha suas Pizzas";
                lblExCli.BackColor = System.Drawing.Color.Crimson;
            }
            else
            {

                pizza = cbmPizzasList.Text;
                iDAO.InserirItemAoPed(pizza);
                pDAO.UpdateValorPedido();
                AtualizaItens();
                lblValorPed.Text = Convert.ToString(dgvPedido.Rows[0].Cells[4].Value);
                lblValorPed.Text = Convert.ToDouble(lblValorPed.Text).ToString("C2");
                lblExPed.BackColor = System.Drawing.Color.Crimson;

            }
        }
        //BOTÃO VOLTAR
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if(btnAdicionar.Text == "Adicionar")
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Concluir o Pedido", "Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)//SIM
                {
                    pDAO.UpdateValorPedido();
                    pDAO.fecharPedido();
                    AtualizaItens();
                    lblExCli.Text = "Selecione um cliente";
                    lblExPed.Text = "Crie um novo Pedido";
                    lblExPed.BackColor = System.Drawing.Color.Black;
                    lblExCli.BackColor = System.Drawing.Color.Black;
                    lblValorPed.Text = "R$ 0,00";
                    btnAdicionar.Text = "Criar Pedido";
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)//NÃO
                {

                }
            }
            else
            {
                this.Close();
            }
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastroCliente cad = new CadastroCliente();

            cad.ShowDialog();
        }

        private void Atendente_Load(object sender, EventArgs e)
        {
            atualizaGridCLi();
            AtualizaPizzas();
            AtualizaItens();
            
        }
           /*GET CLIENTES*/
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

        //GET PIZZAS
        public void AtualizaPizzas()
        {
            try
            {
                cbmPizzasList.DataSource = zDAO.getTodasPizzas();
                cbmPizzasList.DisplayMember = "nome";

                cbmPizzasList.ValueMember = "idpizza";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        //GET Itens atuais
        public void AtualizaItens()
        {
            try
            {
                dgvPedido.DataSource = iDAO.ItensPedAtual();
                dgvPedido.Columns[0].Visible = false;
                dgvPedido.Columns[4].Visible = false;
                dgvPedido.Columns[4].DefaultCellStyle.Format = "C2";
                dgvPedido.Columns[3].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void Atendente_Activated(object sender, EventArgs e)
        {
            atualizaGridCLi();
        }

        private void dgvClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idcliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
        }

        //Botão concluir pedido___________________________________________________________________________________________________________________________________
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Concluir o Pedido", "Pedido", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)//SIM
            {
                pDAO.UpdateValorPedido();
                pDAO.fecharPedido();
                AtualizaItens();
                lblExCli.Text = "Selecione um cliente";
                lblExPed.Text = "Crie um novo Pedido";
                lblExPed.BackColor = System.Drawing.Color.Black;
                lblExCli.BackColor = System.Drawing.Color.Black;
                lblValorPed.Text = "R$ 0,00";
                btnAdicionar.Text = "Criar Pedido";

            }
            else if (dialogResult == DialogResult.No)//NÃO
            {
                
            }
        }

        // BOTÃO CANCELAR___________________________________________________________________________________________________________________________________________
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Cancelar o Pedido", "Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)//SIM
            {
                pDAO.CancelaPedido();
                AtualizaItens();
                lblExCli.Text = "Selecione um cliente";
                lblExPed.Text = "Crie um novo Pedido";
                lblExPed.BackColor = System.Drawing.Color.Black;
                lblExCli.BackColor = System.Drawing.Color.Black;
                lblValorPed.Text = "R$ 0,00"; 
                btnAdicionar.Text = "Criar Pedido";
            }
            else if (dialogResult == DialogResult.No)//NÃO
            {

            }
        }

        private void btnNovo_MouseHover(object sender, EventArgs e)
        {
            lblCliEdit.Visible = true;
        }

        private void btnNovo_MouseLeave(object sender, EventArgs e)
        {
            lblCliEdit.Visible = false;
        }

        private void Atendente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnAdicionar.Text == "Adicionar")
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Salvar o Pedido", "Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)//SIM
                {
                    pDAO.UpdateValorPedido();
                    pDAO.fecharPedido();
                    AtualizaItens();
                    lblExCli.Text = "Selecione um cliente";
                    lblExPed.Text = "Crie um novo Pedido";
                    lblExPed.BackColor = System.Drawing.Color.Black;
                    lblExCli.BackColor = System.Drawing.Color.Black;
                    lblValorPed.Text = "R$ 0,00";
                    btnAdicionar.Text = "Criar Pedido";

                }
                else if (dialogResult == DialogResult.No)//NÃO
                {
                    pDAO.CancelaPedido();
                }
            }
        }

        private void troco_CheckedChanged(object sender, EventArgs e)
        {
            if(troco.Checked == true)
            {
                cbmtroco.Visible = true;
            }
            else
            {
                cbmtroco.Visible = false;
            }
            
        }

 

        private void cbmtroco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
}

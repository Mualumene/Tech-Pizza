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
    public partial class Entregas : Form
    {
        public Entregas()
        {
            InitializeComponent();
        }

        //Instancia ObjetosDAO
        ClienteDAO cDAO = new ClienteDAO();
        PedidoDAO pDAO = new PedidoDAO();
        EnderecoDAO eDAO = new EnderecoDAO();

        private int status;
        private int pedidoAtual;
        private int idEndereco;

        //BOTÃO VOLTAR
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAndamento_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnEntregue_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnEntregue_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void btnAndamento_MouseLeave(object sender, EventArgs e)
        {
            
        }
        //____________________________________________________________________________________________________________________________________________
        public void atualizaPedidos()
        {
            try
            {
                dgvEntregas.DataSource = pDAO.GetEntregas();
                dgvEntregas.Columns[4].Visible = false;
                dgvEntregas.Columns[5].Visible = false;
                dgvEntregas.Columns[3].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        public void atulizarEndereco()
        {
            try
            {
                dgvEndereco.DataSource = eDAO.GetEndereco(idEndereco);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void Entregas_Load(object sender, EventArgs e)
        {
            atualizaPedidos();
            atulizarEndereco();
        }

        private void dgvEntregas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
             pedidoAtual = Convert.ToInt32(dgvEntregas.Rows[e.RowIndex].Cells[0].Value); // CONTINUE DAQUI..........
             status = Convert.ToInt32(dgvEntregas.Rows[e.RowIndex].Cells[4].Value);
             idEndereco = Convert.ToInt32(dgvEntregas.Rows[e.RowIndex].Cells[5].Value);

            atulizarEndereco();
            if (status == 3)
            {
                btnAndamento.Text = "Enviar...";
            }
            if (status == 4)
            {
                btnAndamento.Text = "Concluir entrega!";
            }

            
        }

        private void btnAndamento_Click(object sender, EventArgs e)
        {
          
            if(status == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Finalizar o Pedido?", "Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)//SIM
                {
                    pDAO.PedPronto(pedidoAtual);
                    atualizaPedidos();
                }
                else if (dialogResult == DialogResult.No)//NÃO
                {

                }
            }else if (status == 3)
            {
                pDAO.PedPronto(pedidoAtual);
                atualizaPedidos();
                MessageBox.Show("Seu pedido agora está em andamento...", "Entregando");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Finalizar o Pedido?", "Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)//SIM
            {
                pDAO.PedPronto(pedidoAtual);
                pDAO.PedPronto(pedidoAtual);
                atualizaPedidos();
            }
            else if (dialogResult == DialogResult.No)//NÃO
            {

            }
        }
    }
}

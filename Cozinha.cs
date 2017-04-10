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
    public partial class Cozinha : Form
    {
        //Instancia ObjetosDAO

        PedidoDAO pDAO = new PedidoDAO();
        ItemPedidoDAO iDAO = new ItemPedidoDAO();
        PizzaDAO zDAO = new PizzaDAO();

        public Cozinha()
        {
            InitializeComponent();
        }

        private int PedidoAtual;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCozinha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void atualizaItens()
        {
            try
            {
                dgvItens.DataSource = iDAO.ItensPendentes(PedidoAtual);
                dgvItens.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        public void atualizaPedidos()
        {
            try
            {
                dgvPedidos.DataSource = pDAO.GetPedidosPendentes(2);
                dgvPedidos.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void Cozinha_Load(object sender, EventArgs e)
        {
            atualizaItens();
            atualizaPedidos();
        }

        private void dgvPedidos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            PedidoAtual = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value);
            atualizaItens();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            pDAO.PedPronto(PedidoAtual);
            atualizaPedidos();
        }
    }
}
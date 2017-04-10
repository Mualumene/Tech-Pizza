using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechPizzaWF
{
    public partial class Inicial : Form
    {
        public string nome;
        public string cargo;

        public Inicial()
        {
            InitializeComponent();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            if (cargo == "Atendente")
            {
                btnGerente.Visible = false;
            }
            if (cargo == "Cozinha")
            {
                btnAtendente.Visible = false;
                btnEntregas.Visible = false;
                btnGerente.Visible = false;
            }
            if(cargo == "Entregas")
            {
                btnCozinha.Visible = false;
                btnAtendente.Visible = false;
                btnGerente.Visible = false;
            }
        }

        private void lblAtendente_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCozinheira_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Aparecer Labels*/
        private void btnAtendente_MouseHover(object sender, EventArgs e)
        {
            lblAtendente.Visible = true;
            lblCozinha.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnAtendente_MouseLeave(object sender, EventArgs e)
        {
            lblAtendente.Visible = false;
            lblCozinha.BackColor = System.Drawing.Color.MediumSpringGreen;
        }

        private void btnCozinha_MouseHover(object sender, EventArgs e)
        {
            lblCozinheira.Visible = true;
            lblCozinha.BackColor = System.Drawing.Color.DarkMagenta;
        }

        private void btnCozinha_MouseLeave(object sender, EventArgs e)
        {
            lblCozinheira.Visible = false;
            lblCozinha.BackColor = System.Drawing.Color.MediumSpringGreen;
        }

        private void btnEntregas_MouseHover(object sender, EventArgs e)
        {
            lblEntregas.Visible = true;
            lblCozinha.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void btnEntregas_MouseLeave(object sender, EventArgs e)
        {
            lblEntregas.Visible = false;
            lblCozinha.BackColor = System.Drawing.Color.MediumSpringGreen;
        }

        private void btnSair_MouseHover(object sender, EventArgs e)
        {
            lblCozinha.BackColor = System.Drawing.Color.Gold;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            lblCozinha.BackColor = System.Drawing.Color.MediumSpringGreen;
        }

        private void btnGerente_MouseHover(object sender, EventArgs e)
        {
            lblCozinha.BackColor = System.Drawing.Color.White;
            lblCozinha.ForeColor = System.Drawing.Color.Gray;
            lblGerente.Visible = true;
        }

        private void btnGerente_MouseLeave(object sender, EventArgs e)
        {
            lblCozinha.BackColor = System.Drawing.Color.MediumSpringGreen;
            lblCozinha.ForeColor = System.Drawing.Color.White;
            lblGerente.Visible = false;
        }

        /*Botoes das Forms                                                   ESTPU UTIIZANDO O THIS.CLOSE PARA CONTROLE DE FORMS E OTIMIZAÇÃO DA MEMORIA RAM*/
        private void btnAtendente_Click(object sender, EventArgs e)
        {
            Atendente ate = new Atendente();
            ate.ShowDialog();

        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            Cozinha coz = new Cozinha();
            coz.ShowDialog();
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            Entregas ent = new Entregas();
            ent.ShowDialog();
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            Gerente ger = new Gerente();
            ger.ShowDialog();
        }

        private void Inicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

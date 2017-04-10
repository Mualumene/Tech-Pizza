namespace TechPizzaWF
{
    partial class Gerente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerente));
            this.label8 = new System.Windows.Forms.Label();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.dgvGerente = new System.Windows.Forms.DataGridView();
            this.lblDGVGentente = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1Res = new System.Windows.Forms.Label();
            this.lbl2Res = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvAuxiliar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPizza = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInserirPizza = new System.Windows.Forms.Button();
            this.btnEditarPizza = new System.Windows.Forms.Button();
            this.btnExcluirPizza = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuxiliar)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Lobster 1.4", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(318, 9);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(217, 80);
            this.label8.TabIndex = 44;
            this.label8.Text = "Gerente";
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.White;
            this.btnVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Intro Inline", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.Gray;
            this.btnVendas.Location = new System.Drawing.Point(22, 334);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(234, 49);
            this.btnVendas.TabIndex = 45;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Intro Inline", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Gray;
            this.btnClientes.Location = new System.Drawing.Point(22, 389);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(234, 49);
            this.btnClientes.TabIndex = 46;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // dgvGerente
            // 
            this.dgvGerente.AllowUserToAddRows = false;
            this.dgvGerente.AllowUserToDeleteRows = false;
            this.dgvGerente.AllowUserToResizeColumns = false;
            this.dgvGerente.AllowUserToResizeRows = false;
            this.dgvGerente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGerente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGerente.BackgroundColor = System.Drawing.Color.White;
            this.dgvGerente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGerente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGerente.Location = new System.Drawing.Point(481, 256);
            this.dgvGerente.Name = "dgvGerente";
            this.dgvGerente.Size = new System.Drawing.Size(318, 329);
            this.dgvGerente.TabIndex = 47;
            this.dgvGerente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGerente_CellEnter);
            // 
            // lblDGVGentente
            // 
            this.lblDGVGentente.AutoSize = true;
            this.lblDGVGentente.BackColor = System.Drawing.Color.White;
            this.lblDGVGentente.Font = new System.Drawing.Font("Lobster 1.4", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGVGentente.Location = new System.Drawing.Point(606, 223);
            this.lblDGVGentente.Name = "lblDGVGentente";
            this.lblDGVGentente.Size = new System.Drawing.Size(81, 30);
            this.lblDGVGentente.TabIndex = 48;
            this.lblDGVGentente.Text = "Clientes";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Intro Inline", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(56, 522);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(117, 23);
            this.lbl1.TabIndex = 49;
            this.lbl1.Text = "Comprou:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Intro Inline", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(56, 560);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(97, 23);
            this.lbl2.TabIndex = 49;
            this.lbl2.Text = "Gastou:";
            // 
            // lbl1Res
            // 
            this.lbl1Res.AutoSize = true;
            this.lbl1Res.Font = new System.Drawing.Font("Intro ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Res.Location = new System.Drawing.Point(199, 522);
            this.lbl1Res.Name = "lbl1Res";
            this.lbl1Res.Size = new System.Drawing.Size(87, 23);
            this.lbl1Res.TabIndex = 49;
            this.lbl1Res.Text = "0 vezes";
            // 
            // lbl2Res
            // 
            this.lbl2Res.AutoSize = true;
            this.lbl2Res.Font = new System.Drawing.Font("Intro ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Res.Location = new System.Drawing.Point(199, 560);
            this.lbl2Res.Name = "lbl2Res";
            this.lbl2Res.Size = new System.Drawing.Size(80, 23);
            this.lbl2Res.TabIndex = 49;
            this.lbl2Res.Text = "R$ 0,00";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Gray;
            this.btnVoltar.Location = new System.Drawing.Point(34, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(80, 30);
            this.btnVoltar.TabIndex = 50;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvAuxiliar
            // 
            this.dgvAuxiliar.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuxiliar.Location = new System.Drawing.Point(800, 12);
            this.dgvAuxiliar.Name = "dgvAuxiliar";
            this.dgvAuxiliar.Size = new System.Drawing.Size(42, 41);
            this.dgvAuxiliar.TabIndex = 51;
            this.dgvAuxiliar.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Intro Inline", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(22, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 49);
            this.button1.TabIndex = 45;
            this.button1.Text = "Pizzas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intro ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "v";
            // 
            // txtPizza
            // 
            this.txtPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPizza.Font = new System.Drawing.Font("Intro ", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPizza.Location = new System.Drawing.Point(186, 524);
            this.txtPizza.Name = "txtPizza";
            this.txtPizza.Size = new System.Drawing.Size(100, 21);
            this.txtPizza.TabIndex = 1;
            this.txtPizza.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Intro ", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(186, 560);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 21);
            this.txtValor.TabIndex = 2;
            this.txtValor.Visible = false;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // btnInserirPizza
            // 
            this.btnInserirPizza.BackColor = System.Drawing.Color.White;
            this.btnInserirPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirPizza.Font = new System.Drawing.Font("Intro ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirPizza.Location = new System.Drawing.Point(91, 595);
            this.btnInserirPizza.Name = "btnInserirPizza";
            this.btnInserirPizza.Size = new System.Drawing.Size(138, 34);
            this.btnInserirPizza.TabIndex = 52;
            this.btnInserirPizza.Text = "Inserir Sabor";
            this.btnInserirPizza.UseVisualStyleBackColor = false;
            this.btnInserirPizza.Visible = false;
            this.btnInserirPizza.Click += new System.EventHandler(this.btnInserirPizza_Click);
            // 
            // btnEditarPizza
            // 
            this.btnEditarPizza.BackColor = System.Drawing.Color.White;
            this.btnEditarPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPizza.Font = new System.Drawing.Font("Intro ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPizza.Location = new System.Drawing.Point(535, 595);
            this.btnEditarPizza.Name = "btnEditarPizza";
            this.btnEditarPizza.Size = new System.Drawing.Size(92, 34);
            this.btnEditarPizza.TabIndex = 52;
            this.btnEditarPizza.Text = "Editar";
            this.btnEditarPizza.UseVisualStyleBackColor = false;
            this.btnEditarPizza.Visible = false;
            this.btnEditarPizza.Click += new System.EventHandler(this.btnEditarPizza_Click);
            // 
            // btnExcluirPizza
            // 
            this.btnExcluirPizza.BackColor = System.Drawing.Color.White;
            this.btnExcluirPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPizza.Font = new System.Drawing.Font("Intro ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPizza.Location = new System.Drawing.Point(656, 595);
            this.btnExcluirPizza.Name = "btnExcluirPizza";
            this.btnExcluirPizza.Size = new System.Drawing.Size(92, 34);
            this.btnExcluirPizza.TabIndex = 52;
            this.btnExcluirPizza.Text = "Excluir";
            this.btnExcluirPizza.UseVisualStyleBackColor = false;
            this.btnExcluirPizza.Visible = false;
            this.btnExcluirPizza.Click += new System.EventHandler(this.btnExcluirPizza_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.Color.White;
            this.btnAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Intro Inline", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.Gray;
            this.btnAdm.Location = new System.Drawing.Point(22, 279);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(234, 49);
            this.btnAdm.TabIndex = 45;
            this.btnAdm.Text = "Administração";
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(870, 653);
            this.Controls.Add(this.btnExcluirPizza);
            this.Controls.Add(this.btnEditarPizza);
            this.Controls.Add(this.btnInserirPizza);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtPizza);
            this.Controls.Add(this.dgvAuxiliar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl2Res);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1Res);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblDGVGentente);
            this.Controls.Add(this.dgvGerente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente";
            this.Load += new System.EventHandler(this.Gerente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuxiliar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.DataGridView dgvGerente;
        private System.Windows.Forms.Label lblDGVGentente;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1Res;
        private System.Windows.Forms.Label lbl2Res;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvAuxiliar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPizza;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnInserirPizza;
        private System.Windows.Forms.Button btnEditarPizza;
        private System.Windows.Forms.Button btnExcluirPizza;
        private System.Windows.Forms.Button btnAdm;
    }
}
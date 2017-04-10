namespace TechPizzaWF
{
    partial class Atendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atendente));
            this.label1 = new System.Windows.Forms.Label();
            this.lblExCli = new System.Windows.Forms.Label();
            this.lblExPed = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.lblValorPed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbmPizzasList = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCliEdit = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.troco = new System.Windows.Forms.CheckBox();
            this.cbmtroco = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Lobster 1.4", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(227, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedidos";
            // 
            // lblExCli
            // 
            this.lblExCli.AutoSize = true;
            this.lblExCli.BackColor = System.Drawing.Color.Black;
            this.lblExCli.Font = new System.Drawing.Font("Intro ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExCli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExCli.Location = new System.Drawing.Point(68, 10);
            this.lblExCli.Name = "lblExCli";
            this.lblExCli.Size = new System.Drawing.Size(241, 23);
            this.lblExCli.TabIndex = 2;
            this.lblExCli.Text = "Selecione um cliente";
            // 
            // lblExPed
            // 
            this.lblExPed.AutoSize = true;
            this.lblExPed.BackColor = System.Drawing.Color.Black;
            this.lblExPed.Font = new System.Drawing.Font("Intro ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExPed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExPed.Location = new System.Drawing.Point(103, 10);
            this.lblExPed.Name = "lblExPed";
            this.lblExPed.Size = new System.Drawing.Size(235, 23);
            this.lblExPed.TabIndex = 3;
            this.lblExPed.Text = "Crie um novo Pedido";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 56);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(351, 261);
            this.dgvClientes.TabIndex = 4;
            this.dgvClientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellEnter);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AllowUserToResizeColumns = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(38, 83);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(351, 224);
            this.dgvPedido.TabIndex = 4;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Crimson;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.Location = new System.Drawing.Point(12, 351);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 33);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = " Clientes";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.MouseLeave += new System.EventHandler(this.btnNovo_MouseLeave);
            this.btnNovo.MouseHover += new System.EventHandler(this.btnNovo_MouseHover);
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.Crimson;
            this.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConcluir.Location = new System.Drawing.Point(38, 379);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(105, 33);
            this.btnConcluir.TabIndex = 6;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lblValorPed
            // 
            this.lblValorPed.AutoSize = true;
            this.lblValorPed.BackColor = System.Drawing.Color.Black;
            this.lblValorPed.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValorPed.Location = new System.Drawing.Point(333, 379);
            this.lblValorPed.Name = "lblValorPed";
            this.lblValorPed.Size = new System.Drawing.Size(43, 23);
            this.lblValorPed.TabIndex = 3;
            this.lblValorPed.Text = "0,00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbmtroco);
            this.panel1.Controls.Add(this.troco);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.cbmPizzasList);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.btnConcluir);
            this.panel1.Controls.Add(this.lblValorPed);
            this.panel1.Controls.Add(this.lblExPed);
            this.panel1.Controls.Add(this.dgvPedido);
            this.panel1.Location = new System.Drawing.Point(461, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 415);
            this.panel1.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(165, 379);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbmPizzasList
            // 
            this.cbmPizzasList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbmPizzasList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbmPizzasList.BackColor = System.Drawing.Color.Crimson;
            this.cbmPizzasList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmPizzasList.Font = new System.Drawing.Font("Intro ", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmPizzasList.ForeColor = System.Drawing.Color.White;
            this.cbmPizzasList.FormattingEnabled = true;
            this.cbmPizzasList.Location = new System.Drawing.Point(38, 53);
            this.cbmPizzasList.Name = "cbmPizzasList";
            this.cbmPizzasList.Size = new System.Drawing.Size(199, 24);
            this.cbmPizzasList.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Crimson;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionar.Location = new System.Drawing.Point(296, 47);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(93, 30);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Criar Pedido";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblCliEdit);
            this.panel2.Controls.Add(this.lblExCli);
            this.panel2.Controls.Add(this.dgvClientes);
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Location = new System.Drawing.Point(36, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 415);
            this.panel2.TabIndex = 8;
            // 
            // lblCliEdit
            // 
            this.lblCliEdit.AutoSize = true;
            this.lblCliEdit.BackColor = System.Drawing.Color.Black;
            this.lblCliEdit.Font = new System.Drawing.Font("Intro ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCliEdit.Location = new System.Drawing.Point(122, 354);
            this.lblCliEdit.Name = "lblCliEdit";
            this.lblCliEdit.Size = new System.Drawing.Size(224, 23);
            this.lblCliEdit.TabIndex = 7;
            this.lblCliEdit.Text = "Gerenciar clientes";
            this.lblCliEdit.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Crimson;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(24, 29);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(80, 30);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // troco
            // 
            this.troco.AutoSize = true;
            this.troco.BackColor = System.Drawing.Color.White;
            this.troco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.troco.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troco.Location = new System.Drawing.Point(38, 329);
            this.troco.Name = "troco";
            this.troco.Size = new System.Drawing.Size(93, 23);
            this.troco.TabIndex = 10;
            this.troco.Text = "Troco?";
            this.troco.UseVisualStyleBackColor = false;
            this.troco.CheckedChanged += new System.EventHandler(this.troco_CheckedChanged);
            // 
            // cbmtroco
            // 
            this.cbmtroco.AutoCompleteCustomSource.AddRange(new string[] {
            "20",
            "50",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cbmtroco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmtroco.FormattingEnabled = true;
            this.cbmtroco.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cbmtroco.Location = new System.Drawing.Point(165, 329);
            this.cbmtroco.Name = "cbmtroco";
            this.cbmtroco.Size = new System.Drawing.Size(105, 21);
            this.cbmtroco.TabIndex = 11;
            this.cbmtroco.Text = "R$ 0,00";
            this.cbmtroco.Visible = false;
            this.cbmtroco.SelectionChangeCommitted += new System.EventHandler(this.cbmtroco_SelectionChangeCommitted);
            // 
            // Atendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(908, 606);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Atendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Activated += new System.EventHandler(this.Atendente_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Atendente_FormClosing);
            this.Load += new System.EventHandler(this.Atendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExCli;
        private System.Windows.Forms.Label lblExPed;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label lblValorPed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbmPizzasList;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCliEdit;
        private System.Windows.Forms.CheckBox troco;
        private System.Windows.Forms.ComboBox cbmtroco;
    }
}
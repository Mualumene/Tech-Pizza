namespace TechPizzaWF
{
    partial class Entregas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entregas));
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.lblEntregas = new System.Windows.Forms.Label();
            this.btnAndamento = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.AllowUserToAddRows = false;
            this.dgvEntregas.AllowUserToDeleteRows = false;
            this.dgvEntregas.AllowUserToResizeColumns = false;
            this.dgvEntregas.AllowUserToResizeRows = false;
            this.dgvEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntregas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEntregas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.GridColor = System.Drawing.Color.LightGray;
            this.dgvEntregas.Location = new System.Drawing.Point(197, 294);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.ReadOnly = true;
            this.dgvEntregas.Size = new System.Drawing.Size(407, 230);
            this.dgvEntregas.TabIndex = 0;
            this.dgvEntregas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntregas_CellEnter);
            // 
            // lblEntregas
            // 
            this.lblEntregas.AutoSize = true;
            this.lblEntregas.BackColor = System.Drawing.Color.SteelBlue;
            this.lblEntregas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblEntregas.Font = new System.Drawing.Font("Lobster 1.4", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregas.ForeColor = System.Drawing.Color.White;
            this.lblEntregas.Location = new System.Drawing.Point(351, 25);
            this.lblEntregas.Name = "lblEntregas";
            this.lblEntregas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEntregas.Size = new System.Drawing.Size(247, 80);
            this.lblEntregas.TabIndex = 3;
            this.lblEntregas.Text = "Entregas";
            // 
            // btnAndamento
            // 
            this.btnAndamento.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAndamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAndamento.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndamento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAndamento.Location = new System.Drawing.Point(31, 375);
            this.btnAndamento.Name = "btnAndamento";
            this.btnAndamento.Size = new System.Drawing.Size(150, 51);
            this.btnAndamento.TabIndex = 4;
            this.btnAndamento.Text = "Enviar...";
            this.btnAndamento.UseVisualStyleBackColor = false;
            this.btnAndamento.Click += new System.EventHandler(this.btnAndamento_Click);
            this.btnAndamento.MouseLeave += new System.EventHandler(this.btnAndamento_MouseLeave);
            this.btnAndamento.MouseHover += new System.EventHandler(this.btnAndamento_MouseHover);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(31, 25);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(80, 30);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(31, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retirada no Local";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnAndamento_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnAndamento_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(-552, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(664, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Retirada no Local";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            this.button3.MouseLeave += new System.EventHandler(this.btnAndamento_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.btnAndamento_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lobster 1.4", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pedidos";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Lobster 1.4", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.ForeColor = System.Drawing.Color.White;
            this.lblend.Location = new System.Drawing.Point(715, 265);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(86, 26);
            this.lblend.TabIndex = 11;
            this.lblend.Text = "Endereço";
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.AllowUserToResizeColumns = false;
            this.dgvEndereco.AllowUserToResizeRows = false;
            this.dgvEndereco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEndereco.BackgroundColor = System.Drawing.Color.White;
            this.dgvEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Location = new System.Drawing.Point(628, 309);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.ReadOnly = true;
            this.dgvEndereco.Size = new System.Drawing.Size(240, 150);
            this.dgvEndereco.TabIndex = 12;
            // 
            // Entregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(891, 556);
            this.Controls.Add(this.dgvEndereco);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAndamento);
            this.Controls.Add(this.lblEntregas);
            this.Controls.Add(this.dgvEntregas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entregas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregas";
            this.Load += new System.EventHandler(this.Entregas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.Label lblEntregas;
        private System.Windows.Forms.Button btnAndamento;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.DataGridView dgvEndereco;
    }
}
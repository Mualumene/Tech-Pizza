namespace TechPizzaWF
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.label8 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnExcluirUser = new System.Windows.Forms.Button();
            this.btnEditarUser = new System.Windows.Forms.Button();
            this.btnInserirUser = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cbmCargo = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Lobster 1.4", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(253, 9);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(257, 80);
            this.label8.TabIndex = 45;
            this.label8.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(24, 146);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(318, 329);
            this.dgvUsuarios.TabIndex = 48;
            this.dgvUsuarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellEnter);
            // 
            // btnExcluirUser
            // 
            this.btnExcluirUser.BackColor = System.Drawing.Color.White;
            this.btnExcluirUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUser.Font = new System.Drawing.Font("Intro ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUser.Location = new System.Drawing.Point(200, 490);
            this.btnExcluirUser.Name = "btnExcluirUser";
            this.btnExcluirUser.Size = new System.Drawing.Size(92, 34);
            this.btnExcluirUser.TabIndex = 55;
            this.btnExcluirUser.Text = "Excluir";
            this.btnExcluirUser.UseVisualStyleBackColor = false;
            this.btnExcluirUser.Click += new System.EventHandler(this.btnExcluirUser_Click);
            // 
            // btnEditarUser
            // 
            this.btnEditarUser.BackColor = System.Drawing.Color.White;
            this.btnEditarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUser.Font = new System.Drawing.Font("Intro ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUser.Location = new System.Drawing.Point(79, 490);
            this.btnEditarUser.Name = "btnEditarUser";
            this.btnEditarUser.Size = new System.Drawing.Size(92, 34);
            this.btnEditarUser.TabIndex = 56;
            this.btnEditarUser.Text = "Editar";
            this.btnEditarUser.UseVisualStyleBackColor = false;
            this.btnEditarUser.Click += new System.EventHandler(this.btnEditarUser_Click);
            // 
            // btnInserirUser
            // 
            this.btnInserirUser.BackColor = System.Drawing.Color.White;
            this.btnInserirUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirUser.Font = new System.Drawing.Font("Intro ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirUser.Location = new System.Drawing.Point(557, 479);
            this.btnInserirUser.Name = "btnInserirUser";
            this.btnInserirUser.Size = new System.Drawing.Size(176, 45);
            this.btnInserirUser.TabIndex = 57;
            this.btnInserirUser.Text = "Inserir usuario";
            this.btnInserirUser.UseVisualStyleBackColor = false;
            this.btnInserirUser.Click += new System.EventHandler(this.btnInserirUser_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(596, 397);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(137, 27);
            this.txtSenha.TabIndex = 54;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(596, 361);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(137, 27);
            this.txtUsuario.TabIndex = 53;
            // 
            // cbmCargo
            // 
            this.cbmCargo.AutoCompleteCustomSource.AddRange(new string[] {
            "Atendente",
            "Entregas",
            "Cozinha",
            "Gerente"});
            this.cbmCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbmCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cbmCargo.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmCargo.FormattingEnabled = true;
            this.cbmCargo.Items.AddRange(new object[] {
            "Atendente",
            "Entregas",
            "Cozinha",
            "Gerente"});
            this.cbmCargo.Location = new System.Drawing.Point(596, 433);
            this.cbmCargo.Name = "cbmCargo";
            this.cbmCargo.Size = new System.Drawing.Size(137, 27);
            this.cbmCargo.TabIndex = 58;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUsuario.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(497, 363);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 19);
            this.lblUsuario.TabIndex = 59;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.White;
            this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSenha.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(516, 403);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 19);
            this.lblSenha.TabIndex = 59;
            this.lblSenha.Text = "Senha:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.White;
            this.lblCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCargo.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(510, 441);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(75, 19);
            this.lblCargo.TabIndex = 59;
            this.lblCargo.Text = "Cargo:";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(776, 536);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbmCargo);
            this.Controls.Add(this.btnExcluirUser);
            this.Controls.Add(this.btnEditarUser);
            this.Controls.Add(this.btnInserirUser);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnExcluirUser;
        private System.Windows.Forms.Button btnEditarUser;
        private System.Windows.Forms.Button btnInserirUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cbmCargo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCargo;
    }
}
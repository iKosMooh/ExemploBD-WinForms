namespace ExemploBD
{
    partial class frmCadastroUsers
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
            this.txtNivelAcesso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.txtIdConsultar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNivelAcesso
            // 
            this.txtNivelAcesso.Location = new System.Drawing.Point(156, 118);
            this.txtNivelAcesso.Name = "txtNivelAcesso";
            this.txtNivelAcesso.Size = new System.Drawing.Size(379, 28);
            this.txtNivelAcesso.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nivel Acesso:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(444, 154);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(348, 154);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 30);
            this.btnAlterar.TabIndex = 32;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(252, 154);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 30);
            this.btnInserir.TabIndex = 31;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(156, 154);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 30);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgUsers);
            this.groupBox1.Controls.Add(this.txtIdConsultar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 276);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // dgUsers
            // 
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Location = new System.Drawing.Point(30, 100);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RowHeadersWidth = 47;
            this.dgUsers.Size = new System.Drawing.Size(487, 158);
            this.dgUsers.TabIndex = 11;
            this.dgUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsers_CellClick);
            // 
            // txtIdConsultar
            // 
            this.txtIdConsultar.Location = new System.Drawing.Point(66, 44);
            this.txtIdConsultar.Name = "txtIdConsultar";
            this.txtIdConsultar.Size = new System.Drawing.Size(100, 28);
            this.txtIdConsultar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(383, 43);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(134, 30);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(155, 83);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(379, 28);
            this.txtSenha.TabIndex = 29;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(156, 47);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(378, 28);
            this.txtLogin.TabIndex = 28;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(156, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(179, 28);
            this.txtId.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID:";
            // 
            // frmCadastroUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(574, 491);
            this.Controls.Add(this.txtNivelAcesso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmCadastroUsers";
            this.Text = "frmCadastroUsers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNivelAcesso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.TextBox txtIdConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
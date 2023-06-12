namespace ExemploBD
{
    partial class frmConsultaFornecedor
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
            this.dgFornecedores = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gpxOpcoesColsulta = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).BeginInit();
            this.gpxOpcoesColsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFornecedores
            // 
            this.dgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedores.Location = new System.Drawing.Point(24, 195);
            this.dgFornecedores.Margin = new System.Windows.Forms.Padding(6);
            this.dgFornecedores.Name = "dgFornecedores";
            this.dgFornecedores.RowHeadersWidth = 47;
            this.dgFornecedores.Size = new System.Drawing.Size(600, 289);
            this.dgFornecedores.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1426, 798);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gpxOpcoesColsulta
            // 
            this.gpxOpcoesColsulta.Controls.Add(this.rbTodos);
            this.gpxOpcoesColsulta.Controls.Add(this.rbCNPJ);
            this.gpxOpcoesColsulta.Controls.Add(this.rbNome);
            this.gpxOpcoesColsulta.Controls.Add(this.rbID);
            this.gpxOpcoesColsulta.Location = new System.Drawing.Point(24, 23);
            this.gpxOpcoesColsulta.Margin = new System.Windows.Forms.Padding(6);
            this.gpxOpcoesColsulta.Name = "gpxOpcoesColsulta";
            this.gpxOpcoesColsulta.Padding = new System.Windows.Forms.Padding(6);
            this.gpxOpcoesColsulta.Size = new System.Drawing.Size(600, 122);
            this.gpxOpcoesColsulta.TabIndex = 2;
            this.gpxOpcoesColsulta.TabStop = false;
            this.gpxOpcoesColsulta.Text = "Opções Consulta";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(499, 37);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(6);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(89, 30);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(330, 37);
            this.rbCNPJ.Margin = new System.Windows.Forms.Padding(6);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(88, 30);
            this.rbCNPJ.TabIndex = 2;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(167, 37);
            this.rbNome.Margin = new System.Windows.Forms.Padding(6);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(89, 30);
            this.rbNome.TabIndex = 1;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(27, 37);
            this.rbID.Margin = new System.Windows.Forms.Padding(6);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(52, 30);
            this.rbID.TabIndex = 0;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(498, 495);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(126, 40);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(24, 154);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(282, 32);
            this.txtConsulta.TabIndex = 4;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(24, 495);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(126, 40);
            this.btnSelecionar.TabIndex = 5;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Visible = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // frmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(639, 547);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpxOpcoesColsulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgFornecedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmConsultaFornecedor";
            this.Text = "Consulta Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).EndInit();
            this.gpxOpcoesColsulta.ResumeLayout(false);
            this.gpxOpcoesColsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFornecedores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpxOpcoesColsulta;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnSelecionar;
    }
}
namespace ExemploBD
{
    partial class frmConsultaProdutos
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gpxOpcoesColsulta = new System.Windows.Forms.GroupBox();
            this.rbPrecoVenda = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbPrecoCusto = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.gpxOpcoesColsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(15, 146);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(282, 28);
            this.txtConsulta.TabIndex = 11;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(557, 485);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(126, 40);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gpxOpcoesColsulta
            // 
            this.gpxOpcoesColsulta.Controls.Add(this.rbPrecoVenda);
            this.gpxOpcoesColsulta.Controls.Add(this.rbTodos);
            this.gpxOpcoesColsulta.Controls.Add(this.rbPrecoCusto);
            this.gpxOpcoesColsulta.Controls.Add(this.rbDescricao);
            this.gpxOpcoesColsulta.Controls.Add(this.rbID);
            this.gpxOpcoesColsulta.Location = new System.Drawing.Point(15, 15);
            this.gpxOpcoesColsulta.Margin = new System.Windows.Forms.Padding(6);
            this.gpxOpcoesColsulta.Name = "gpxOpcoesColsulta";
            this.gpxOpcoesColsulta.Padding = new System.Windows.Forms.Padding(6);
            this.gpxOpcoesColsulta.Size = new System.Drawing.Size(668, 122);
            this.gpxOpcoesColsulta.TabIndex = 10;
            this.gpxOpcoesColsulta.TabStop = false;
            this.gpxOpcoesColsulta.Text = "Opções Consulta";
            // 
            // rbPrecoVenda
            // 
            this.rbPrecoVenda.AutoSize = true;
            this.rbPrecoVenda.Location = new System.Drawing.Point(409, 37);
            this.rbPrecoVenda.Margin = new System.Windows.Forms.Padding(6);
            this.rbPrecoVenda.Name = "rbPrecoVenda";
            this.rbPrecoVenda.Size = new System.Drawing.Size(139, 28);
            this.rbPrecoVenda.TabIndex = 4;
            this.rbPrecoVenda.Text = "Preço Venda";
            this.rbPrecoVenda.UseVisualStyleBackColor = true;
            this.rbPrecoVenda.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(574, 37);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(6);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(82, 28);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // rbPrecoCusto
            // 
            this.rbPrecoCusto.AutoSize = true;
            this.rbPrecoCusto.Location = new System.Drawing.Point(255, 37);
            this.rbPrecoCusto.Margin = new System.Windows.Forms.Padding(6);
            this.rbPrecoCusto.Name = "rbPrecoCusto";
            this.rbPrecoCusto.Size = new System.Drawing.Size(131, 28);
            this.rbPrecoCusto.TabIndex = 2;
            this.rbPrecoCusto.Text = "Preço Custo";
            this.rbPrecoCusto.UseVisualStyleBackColor = true;
            this.rbPrecoCusto.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Location = new System.Drawing.Point(116, 37);
            this.rbDescricao.Margin = new System.Windows.Forms.Padding(6);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(112, 28);
            this.rbDescricao.TabIndex = 1;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(27, 37);
            this.rbID.Margin = new System.Windows.Forms.Padding(6);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(45, 28);
            this.rbID.TabIndex = 0;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // dgProdutos
            // 
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(15, 187);
            this.dgProdutos.Margin = new System.Windows.Forms.Padding(6);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.RowHeadersWidth = 47;
            this.dgProdutos.Size = new System.Drawing.Size(668, 289);
            this.dgProdutos.TabIndex = 9;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(12, 485);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(126, 40);
            this.btnSelecionar.TabIndex = 13;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Visible = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // frmConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(698, 546);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpxOpcoesColsulta);
            this.Controls.Add(this.dgProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmConsultaProdutos";
            this.Text = "frmConsultaProduto";
            this.gpxOpcoesColsulta.ResumeLayout(false);
            this.gpxOpcoesColsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox gpxOpcoesColsulta;
        private System.Windows.Forms.RadioButton rbPrecoVenda;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbPrecoCusto;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button btnSelecionar;
    }
}
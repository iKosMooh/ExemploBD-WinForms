namespace ExemploBD
{
    partial class frmNotasEntrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.btnLocalizarFornecedor = new System.Windows.Forms.Button();
            this.txtNumeroNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLocalizarProduto = new System.Windows.Forms.Button();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecoCustoProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarNota = new System.Windows.Forms.Button();
            this.btnInserirNota = new System.Windows.Forms.Button();
            this.txtTotalNota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notas de Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fornecedor:";
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.Location = new System.Drawing.Point(133, 85);
            this.txtIDFornecedor.Name = "txtIDFornecedor";
            this.txtIDFornecedor.Size = new System.Drawing.Size(100, 28);
            this.txtIDFornecedor.TabIndex = 2;
            this.txtIDFornecedor.Leave += new System.EventHandler(this.txtIDFornecedor_Leave);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(239, 85);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.ReadOnly = true;
            this.txtNomeFornecedor.Size = new System.Drawing.Size(356, 28);
            this.txtNomeFornecedor.TabIndex = 3;
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(601, 84);
            this.btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            this.btnLocalizarFornecedor.Size = new System.Drawing.Size(106, 31);
            this.btnLocalizarFornecedor.TabIndex = 4;
            this.btnLocalizarFornecedor.Text = "Localizar";
            this.btnLocalizarFornecedor.UseVisualStyleBackColor = true;
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // txtNumeroNota
            // 
            this.txtNumeroNota.Location = new System.Drawing.Point(133, 119);
            this.txtNumeroNota.Name = "txtNumeroNota";
            this.txtNumeroNota.Size = new System.Drawing.Size(100, 28);
            this.txtNumeroNota.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número:";
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(332, 119);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(131, 28);
            this.dtpEmissao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Emissão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Entrada:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(573, 119);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(134, 28);
            this.dtpEntrada.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Produtos Comprados";
            // 
            // btnLocalizarProduto
            // 
            this.btnLocalizarProduto.Location = new System.Drawing.Point(601, 241);
            this.btnLocalizarProduto.Name = "btnLocalizarProduto";
            this.btnLocalizarProduto.Size = new System.Drawing.Size(106, 31);
            this.btnLocalizarProduto.TabIndex = 15;
            this.btnLocalizarProduto.Text = "Localizar";
            this.btnLocalizarProduto.UseVisualStyleBackColor = true;
            this.btnLocalizarProduto.Click += new System.EventHandler(this.btnLocalizarProduto_Click);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(239, 242);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(356, 28);
            this.txtDescricaoProduto.TabIndex = 14;
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(133, 242);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(100, 28);
            this.txtIDProduto.TabIndex = 13;
            this.txtIDProduto.Leave += new System.EventHandler(this.txtIDProduto_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Produto:";
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(133, 276);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(100, 28);
            this.txtQuantidadeProduto.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantidade:";
            // 
            // txtPrecoCustoProduto
            // 
            this.txtPrecoCustoProduto.Location = new System.Drawing.Point(362, 276);
            this.txtPrecoCustoProduto.Name = "txtPrecoCustoProduto";
            this.txtPrecoCustoProduto.Size = new System.Drawing.Size(345, 28);
            this.txtPrecoCustoProduto.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Preço Custo:";
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(16, 337);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(152, 43);
            this.btnInserirProduto.TabIndex = 20;
            this.btnInserirProduto.Text = "Inserir Produto";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Location = new System.Drawing.Point(174, 337);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(197, 43);
            this.btnCancelarProduto.TabIndex = 21;
            this.btnCancelarProduto.Text = "Cancelar Produto";
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Item,
            this.Descricao,
            this.Quantidade,
            this.PrecoCusto,
            this.Total});
            this.dgProdutos.Location = new System.Drawing.Point(16, 386);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.RowHeadersWidth = 47;
            this.dgProdutos.Size = new System.Drawing.Size(691, 179);
            this.dgProdutos.TabIndex = 22;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MaxInputLength = 20;
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MaxInputLength = 200;
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 115;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MaxInputLength = 50;
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 115;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 115;
            // 
            // PrecoCusto
            // 
            this.PrecoCusto.HeaderText = "Preço Custo";
            this.PrecoCusto.MinimumWidth = 6;
            this.PrecoCusto.Name = "PrecoCusto";
            this.PrecoCusto.Width = 115;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 115;
            // 
            // btnCancelarNota
            // 
            this.btnCancelarNota.Location = new System.Drawing.Point(555, 571);
            this.btnCancelarNota.Name = "btnCancelarNota";
            this.btnCancelarNota.Size = new System.Drawing.Size(152, 43);
            this.btnCancelarNota.TabIndex = 23;
            this.btnCancelarNota.Text = "Cancelar Nota";
            this.btnCancelarNota.UseVisualStyleBackColor = true;
            this.btnCancelarNota.Click += new System.EventHandler(this.btnCancelarNota_Click);
            // 
            // btnInserirNota
            // 
            this.btnInserirNota.Location = new System.Drawing.Point(397, 571);
            this.btnInserirNota.Name = "btnInserirNota";
            this.btnInserirNota.Size = new System.Drawing.Size(152, 43);
            this.btnInserirNota.TabIndex = 24;
            this.btnInserirNota.Text = "Inserir Nota";
            this.btnInserirNota.UseVisualStyleBackColor = true;
            this.btnInserirNota.Click += new System.EventHandler(this.btnInserirNota_Click);
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.Location = new System.Drawing.Point(133, 578);
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.ReadOnly = true;
            this.txtTotalNota.Size = new System.Drawing.Size(258, 28);
            this.txtTotalNota.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total Nota:";
            // 
            // frmNotasEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(723, 652);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalNota);
            this.Controls.Add(this.btnInserirNota);
            this.Controls.Add(this.btnCancelarNota);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btnCancelarProduto);
            this.Controls.Add(this.btnInserirProduto);
            this.Controls.Add(this.txtPrecoCustoProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantidadeProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLocalizarProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEmissao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroNota);
            this.Controls.Add(this.btnLocalizarFornecedor);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.txtIDFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNotasEntrada";
            this.Text = "Notas de Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIDFornecedor;
        public System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Button btnLocalizarFornecedor;
        private System.Windows.Forms.TextBox txtNumeroNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLocalizarProduto;
        public System.Windows.Forms.TextBox txtDescricaoProduto;
        public System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPrecoCustoProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnCancelarNota;
        private System.Windows.Forms.Button btnInserirNota;
        private System.Windows.Forms.TextBox txtTotalNota;
        private System.Windows.Forms.Label label9;
    }
}
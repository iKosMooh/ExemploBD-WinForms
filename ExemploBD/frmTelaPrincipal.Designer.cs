
namespace ExemploBD
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNomePC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem1,
            this.produtosToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // fornecedoresToolStripMenuItem1
            // 
            this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(206, 24);
            this.fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(206, 24);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsuario,
            this.tsslNomePC,
            this.tsslIP,
            this.tsslData,
            this.tsslHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1055, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(76, 19);
            this.tsslUsuario.Text = "tsslUsuario";
            // 
            // tsslNomePC
            // 
            this.tsslNomePC.Name = "tsslNomePC";
            this.tsslNomePC.Size = new System.Drawing.Size(83, 19);
            this.tsslNomePC.Text = "tsslNomePC";
            // 
            // tsslIP
            // 
            this.tsslIP.Name = "tsslIP";
            this.tsslIP.Size = new System.Drawing.Size(41, 19);
            this.tsslIP.Text = "tsslIP";
            // 
            // tsslData
            // 
            this.tsslData.Name = "tsslData";
            this.tsslData.Size = new System.Drawing.Size(58, 19);
            this.tsslData.Text = "tsslData";
            // 
            // tsslHora
            // 
            this.tsslHora.Name = "tsslHora";
            this.tsslHora.Size = new System.Drawing.Size(59, 19);
            this.tsslHora.Text = "tsslHora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1055, 521);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslNomePC;
        private System.Windows.Forms.ToolStripStatusLabel tsslIP;
        private System.Windows.Forms.ToolStripStatusLabel tsslData;
        private System.Windows.Forms.ToolStripStatusLabel tsslHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
    }
}


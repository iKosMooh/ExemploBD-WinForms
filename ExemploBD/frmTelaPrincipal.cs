using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBD
{
    public partial class frmTelaPrincipal : Form
    {

        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        MySqlDataReader SQLDr;

        string SQLString;
        string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            if (frmLogin.nivelAcesso == "Operador")
            {
                usuáriosToolStripMenuItem.Visible = false;
            }
            tsslUsuario.Text = "Usuário: " + frmLogin.usuarioConectado + " | " + frmLogin.nivelAcesso;

            string mHost = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "| Nome do PC: " + mHost;

            System.Net.IPHostEntry mIps = System.Net.Dns.GetHostEntry(mHost);

            foreach (System.Net.IPAddress mIP in mIps.AddressList)
            {
                tsslIP.Text = "| IP: " + mIP;
            }
            tsslData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFornecedores fornecedores = null;
                //Faz uma varredura nos forms criados

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmFornecedores)
                    {
                        fornecedores = (frmFornecedores)frm;
                        break;
                    }
                }

                //Se não está instanciado instanciar
                if (fornecedores == null)
                {
                    fornecedores = new frmFornecedores();
                    fornecedores.MdiParent = this;
                    fornecedores.Show();
                }
                fornecedores.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaFornecedor consultaFornecedores = null;
                //Faz uma varredura nos forms criados

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmFornecedores)
                    {
                        consultaFornecedores = (frmConsultaFornecedor)frm;
                        break;
                    }
                }

                //Se não está instanciado instanciar
                if (consultaFornecedores == null)
                {
                    consultaFornecedores = new frmConsultaFornecedor();
                    consultaFornecedores.MdiParent = this;
                    consultaFornecedores.Show();
                }
                consultaFornecedores.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaProdutos consultaProdutos = null;
                //Faz uma varredura nos forms criados

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmConsultaProdutos)
                    {
                        consultaProdutos = (frmConsultaProdutos)frm;
                        break;
                    }
                }

                //Se não está instanciado instanciar
                if (consultaProdutos == null)
                {
                    consultaProdutos = new frmConsultaProdutos();
                    consultaProdutos.MdiParent = this;
                    consultaProdutos.Show();
                }
                consultaProdutos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProdutos produtos = null;
                //Faz uma varredura nos forms criados

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmProdutos)
                    {
                        produtos = (frmProdutos)frm;
                        break;
                    }
                }

                //Se não está instanciado instanciar
                if (produtos == null)
                {
                    produtos = new frmProdutos();
                    produtos.MdiParent = this;
                    produtos.Show();
                }
                produtos.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmLogin.nivelAcesso.Equals("Administrador"))
                {
                    frmCadastroUsers cadastroUsers = null;
                    //Faz uma varredura nos forms criados

                    foreach (Form frm in this.MdiChildren)
                    {
                        if (frm is frmProdutos)
                        {
                            cadastroUsers = (frmCadastroUsers)frm;
                            break;
                        }
                    }

                    //Se não está instanciado instanciar
                    if (cadastroUsers == null)
                    {
                        cadastroUsers = new frmCadastroUsers();
                        cadastroUsers.MdiParent = this;
                        cadastroUsers.Show();
                    }
                    cadastroUsers.Focus();
                }

                else
                {
                    MessageBox.Show("Você não tem permissão para acessar esta área!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmLogin.nivelAcesso.Equals("Administrador"))
                {
                    frmNotasEntrada notasEntrada = null;
                    //Faz uma varredura nos forms criados

                    foreach (Form frm in this.MdiChildren)
                    {
                        if (frm is frmNotasEntrada)
                        {
                            notasEntrada = (frmNotasEntrada)frm;
                            break;
                        }
                    }

                    //Se não está instanciado instanciar
                    if (notasEntrada == null)
                    {
                        notasEntrada = new frmNotasEntrada();
                        notasEntrada.MdiParent = this;
                        notasEntrada.Show();
                    }
                    notasEntrada.Focus();
                }

                else
                {
                    MessageBox.Show("Você não tem permissão para acessar esta área!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

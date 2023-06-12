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
using MySql.Data.MySqlClient;

namespace ExemploBD
{
    public partial class frmLogin : Form
    {
        public static string nivelAcesso;
        public static string usuarioConectado;

        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataReader SQLDr;

        string SQLString;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtLogin.Text.Equals(string.Empty) && !txtSenha.Text.Equals(string.Empty))
                {
                    string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;

                    SQLConexao = new MySqlConnection(stringConexao);
                    SQLConexao.Open();

                    SQLString = "select * from usuarios where login = @login and senha = @senha";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@login", txtLogin.Text);
                    SQLComando.Parameters.AddWithValue("@senha", txtSenha.Text);

                    SQLDr = SQLComando.ExecuteReader();

                    if (SQLDr.Read())
                    {
                        usuarioConectado = Convert.ToString(SQLDr["login"]);
                        nivelAcesso = Convert.ToString(SQLDr["nivelacesso"]);

                        frmTelaPrincipal p = new frmTelaPrincipal();
                        // esconda o form login
                        this.Hide();

                        // mostra o form tela principal
                        p.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretos", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatórios", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class frmCadastroUsers : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        MySqlDataReader SQLDr;

        string SQLString;
        string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
        public frmCadastroUsers()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios()
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);

                SQLString = "select * from usuarios order by id ASC";

                SQLDa = new MySqlDataAdapter(SQLString, SQLConexao);

                DataTable dtUsuarios = new DataTable();

                SQLDa.Fill(dtUsuarios);

                dgUsers.DataSource = dtUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }
        }

        private void LimparControles()
        {
            txtIdConsultar.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtNivelAcesso.Clear();
            txtId.Clear();
            txtIdConsultar.Clear();
            dgUsers.ClearSelection();
            txtLogin.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparControles();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLConexao.Open();

                SQLString = "insert into usuarios(login, senha,nivelacesso) value" + "(@login,@senha,@nivel)";
                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@login", txtLogin.Text);
                SQLComando.Parameters.AddWithValue("@senha", txtSenha.Text);
                SQLComando.Parameters.AddWithValue("@nivel", txtNivelAcesso.Text);

                SQLComando.ExecuteNonQuery();

                // mostrar o ID do registro inserido
                if (SQLComando.LastInsertedId != 0)
                {
                    SQLComando.Parameters.Add(new MySqlParameter("ultimoId", SQLComando.LastInsertedId));
                    txtId.Text = Convert.ToString(SQLComando.Parameters["ultimoId"].Value);
                }
                MessageBox.Show("Usuário registrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }
            MostrarUsuarios();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLString = "update usuarios set login = @login, senha = @senha, nivelacesso = @nivel where id = @id";

                SQLConexao.Open();

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);
                SQLComando.Parameters.AddWithValue("@login", txtLogin.Text);
                SQLComando.Parameters.AddWithValue("@senha", txtSenha.Text);
                SQLComando.Parameters.AddWithValue("@nivel", txtNivelAcesso.Text);

                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Usuário alterado com sucessor!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }
            MostrarUsuarios();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLString = "delete from usuarios where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);

                SQLConexao.Open();
                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Usuário excluído com sucessor!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }
            MostrarUsuarios();
            LimparControles();
        }

        private void dgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            txtId.Text = Convert.ToString(dgUsers[0, e.RowIndex].Value);
            txtLogin.Text = Convert.ToString(dgUsers[1, e.RowIndex].Value);
            txtSenha.Text = Convert.ToString(dgUsers[2, e.RowIndex].Value);
            txtNivelAcesso.Text = Convert.ToString(dgUsers[3, e.RowIndex].Value);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdConsultar.Text.Equals(string.Empty))
                MostrarUsuarios();
            else
            {
                try
                {
                    SQLConexao = new MySqlConnection(stringConexao);
                    SQLConexao.Open();
                    SQLString = "select * from usuarios where id = @id";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtIdConsultar.Text);

                    SQLDr = SQLComando.ExecuteReader();
                    while (SQLDr.Read())
                    {
                        txtId.Text = Convert.ToString(SQLDr["id"]);
                        txtLogin.Text = Convert.ToString(SQLDr["login"]);
                        txtSenha.Text = Convert.ToString(SQLDr["senha"]);
                        txtNivelAcesso.Text = Convert.ToString(SQLDr["nivelacesso"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    SQLConexao.Close();
                    SQLConexao = null;
                    SQLComando = null;
                }
            }
        }
    }
}

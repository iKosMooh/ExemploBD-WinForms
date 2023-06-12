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
    public partial class frmFornecedores : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        MySqlDataReader SQLDr;

        string SQLString;

        string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MostrarFornecedores()
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);

                SQLString = "select id, nome, cnpj from fornecedores order by nome";

                SQLDa = new MySqlDataAdapter(SQLString, SQLConexao);

                DataTable dtFornecedores = new DataTable();

                SQLDa.Fill(dtFornecedores);

                dgFornecedores.DataSource = dtFornecedores;
            }
            catch(Exception ex)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtIdConsultar.Text.Equals(string.Empty))
            MostrarFornecedores();
            else
            {
                try
                {
                    SQLConexao = new MySqlConnection(stringConexao);
                    SQLConexao.Open();
                    SQLString = "select id, nome, cnpj from fornecedores where id = @id";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtIdConsultar.Text);

                    SQLDr = SQLComando.ExecuteReader();
                    while (SQLDr.Read())
                    {
                        txtId.Text = Convert.ToString(SQLDr["id"]);
                        txtNome.Text = Convert.ToString(SQLDr["nome"]);
                        txtCNPJ.Text = Convert.ToString(SQLDr["cnpj"]);
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
        private void LimparControles()
        {
            txtIdConsultar.Clear();
            txtCNPJ.Clear();
            txtId.Clear();
            txtNome.Clear();
            dgFornecedores.ClearSelection();
            txtNome.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLConexao.Open();

                SQLString = "insert into fornecedores(nome, cnpj) value" + "(@nome,@cnpj)";
                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@nome", txtNome.Text);
                SQLComando.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);

                SQLComando.ExecuteNonQuery();

                // mostrar o ID do registro inserido
                if (SQLComando.LastInsertedId != 0)
                {
                    SQLComando.Parameters.Add(new MySqlParameter("ultimoId", SQLComando.LastInsertedId));
                    txtId.Text = Convert.ToString(SQLComando.Parameters["ultimoId"].Value);
                }
                MessageBox.Show("Fornecedor registrado com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }
            MostrarFornecedores();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparControles();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLString = "update fornecedores set nome = @nome, cnpj = @cnpj where id = @id";

                SQLConexao.Open();

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);
                SQLComando.Parameters.AddWithValue("@nome", txtNome.Text);
                SQLComando.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);

                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Fornecedor alterado com sucessor!");
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
            MostrarFornecedores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLString = "delete from fornecedores where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);

                SQLConexao.Open();
                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucessor!");
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
            MostrarFornecedores();
            LimparControles();
        }

        private void dgFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            txtId.Text = Convert.ToString(dgFornecedores[0, e.RowIndex].Value);
            txtNome.Text = Convert.ToString(dgFornecedores[1, e.RowIndex].Value);
            txtCNPJ.Text = Convert.ToString(dgFornecedores[2, e.RowIndex].Value);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

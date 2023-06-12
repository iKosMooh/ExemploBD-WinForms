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
    public partial class frmProdutos : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        MySqlDataReader SQLDr;

        string SQLString;

        string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void MostrarProdutos()
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);

                SQLString = "select id, descricao, precocusto, precovenda from produtos order by precovenda";

                SQLDa = new MySqlDataAdapter(SQLString, SQLConexao);

                DataTable dtProdutos = new DataTable();

                SQLDa.Fill(dtProdutos);

                dgProdutos.DataSource = dtProdutos;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdConsultar.Text.Equals(string.Empty))
                MostrarProdutos();
            else
            {
                try
                {
                    SQLConexao = new MySqlConnection(stringConexao);
                    SQLConexao.Open();
                    SQLString = "select id, descricao, precocusto,precovenda from produtos where id = @id";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtIdConsultar.Text);

                    SQLDr = SQLComando.ExecuteReader();
                    while (SQLDr.Read())
                    {
                        txtId.Text = Convert.ToString(SQLDr["id"]);
                        txtDescricao.Text = Convert.ToString(SQLDr["descricao"]);
                        txtPrecoCusto.Text = Convert.ToString(SQLDr["precocusto"]);
                        txtPrecoVenda.Text = Convert.ToString(SQLDr["precovenda"]);
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
            txtDescricao.Clear();
            txtId.Clear();
            txtPrecoCusto.Clear();
            txtPrecoVenda.Clear();
            txtIdConsultar.Clear();
            dgProdutos.ClearSelection();
            txtDescricao.Focus();
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
                SQLString = "update produtos set descricao = @descricao, precocusto = @precocusto, precovenda = @precovenda where id = @id";

                SQLConexao.Open();

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);
                SQLComando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                SQLComando.Parameters.AddWithValue("@precocusto", txtPrecoCusto.Text);
                SQLComando.Parameters.AddWithValue("@precovenda", txtPrecoVenda.Text);

                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucessor!");
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
            MostrarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLString = "delete from produtos where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);

                SQLConexao.Open();
                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucessor!");
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
            MostrarProdutos();
            LimparControles();
        }

        private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            txtId.Text = Convert.ToString(dgProdutos[0, e.RowIndex].Value);
            txtDescricao.Text = Convert.ToString(dgProdutos[1, e.RowIndex].Value);
            txtPrecoCusto.Text = Convert.ToString(dgProdutos[2, e.RowIndex].Value);
            txtPrecoVenda.Text = Convert.ToString(dgProdutos[3, e.RowIndex].Value);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLConexao.Open();

                SQLString = "insert into produtos(descricao, precocusto,precovenda) value" + "(@descricao,@precocusto,@precovenda)";
                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                SQLComando.Parameters.AddWithValue("@precocusto", txtPrecoCusto.Text);
                SQLComando.Parameters.AddWithValue("@precovenda", txtPrecoVenda.Text);

                SQLComando.ExecuteNonQuery();

                // mostrar o ID do registro inserido
                if (SQLComando.LastInsertedId != 0)
                {
                    SQLComando.Parameters.Add(new MySqlParameter("ultimoId", SQLComando.LastInsertedId));
                    txtId.Text = Convert.ToString(SQLComando.Parameters["ultimoId"].Value);
                }
                MessageBox.Show("Produto registrado com sucesso");
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
            MostrarProdutos();
        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

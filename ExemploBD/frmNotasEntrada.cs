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
    public partial class frmNotasEntrada : Form
    {

        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        MySqlDataReader SQLDr;

        string SQLString;
        string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;

        int numLinha = 0;
        int idNota = 0;
        double totalNota = 0;
        double totalProduto = 0;

        public static int idFornecedor = 0;
        public frmNotasEntrada()
        {
            InitializeComponent();
        }

        private void LimparControlesProdutos()
        {
            txtIDProduto.Clear();
            txtDescricaoProduto.Clear();
            txtPrecoCustoProduto.Clear();
            txtQuantidadeProduto.Clear();
            txtIDProduto.Focus();
        }

        private void LimparTodosControles()
        {
            LimparControlesProdutos();
            txtIDFornecedor.Clear();
            txtNomeFornecedor.Clear();
            txtNumeroNota.Clear();
            txtTotalNota.Clear();
            dtpEmissao.Value = DateTime.Now.Date;
            dtpEntrada.Value = DateTime.Now.Date;
            dgProdutos.Rows.Clear();
            txtIDFornecedor.Focus();
        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            LimparControlesProdutos();
        }

        private void btnCancelarNota_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja cancelar a entrada de dados?","Confirmação",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimparTodosControles();
            }
        }

        private void txtIDFornecedor_Leave(object sender, EventArgs e)
        {
            if (!txtIDFornecedor.Text.Equals(String.Empty))
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLString = "select nome from fornecedores where id = @id";
                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtIDFornecedor.Text);

                SQLConexao.Open();

                SQLDr = SQLComando.ExecuteReader();

                if (SQLDr.Read())
                {
                    txtNomeFornecedor.Text = Convert.ToString(SQLDr["nome"]);
                    txtNumeroNota.Focus();
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                    txtIDFornecedor.Focus();
                }
            }
        }

        private void txtIDProduto_Leave(object sender, EventArgs e)
        {
            if (!txtIDProduto.Text.Equals(String.Empty))
            {
                SQLConexao = new MySqlConnection(stringConexao);
                SQLString = "select descricao from produtos where id = @id";
                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtIDProduto.Text);

                SQLConexao.Open();

                SQLDr = SQLComando.ExecuteReader();

                if (SQLDr.Read())
                {
                    txtDescricaoProduto.Text = Convert.ToString(SQLDr["descricao"]);
                    txtQuantidadeProduto.Focus();
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                    txtIDProduto.Focus();
                }
            }
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            if (!txtIDProduto.Text.Equals (String.Empty) && 
                !txtDescricaoProduto.Text.Equals(String.Empty) && 
                !txtPrecoCustoProduto.Text.Equals(String.Empty) && 
                !txtQuantidadeProduto.Text.Equals(String.Empty))
            {
                dgProdutos.Rows.Add();
                dgProdutos[0, numLinha].Value = txtIDProduto.Text;
                dgProdutos[1, numLinha].Value = Convert.ToString(numLinha + 1);
                dgProdutos[2, numLinha].Value = txtDescricaoProduto.Text;
                dgProdutos[3, numLinha].Value = txtQuantidadeProduto.Text;
                dgProdutos[4, numLinha].Value = txtPrecoCustoProduto.Text;

                totalProduto = Convert.ToDouble(txtPrecoCustoProduto.Text) * Convert.ToDouble(txtQuantidadeProduto.Text);

                dgProdutos[5, numLinha].Value = totalProduto;
                numLinha++;

                totalNota += totalProduto;
                txtTotalNota.Text = totalNota.ToString("F2");

                LimparControlesProdutos();


            }
        }

        private void btnInserirNota_Click(object sender, EventArgs e)
        {
            try { 
                SQLConexao = new MySqlConnection(stringConexao);
                SQLConexao.Open();

                SQLString = "insert into notasentrada (idfornecedor,numero,dataemissao,dataentrada,valortotal)" +
                            "values (@idfornecedor,@numero,@dataemissao,@dataentrada,@valortotal)";

                SQLComando = new MySqlCommand(SQLString,SQLConexao);
                SQLComando.Parameters.AddWithValue("@idfornecedor", txtIDFornecedor.Text);
                SQLComando.Parameters.AddWithValue("@numero", txtNomeFornecedor.Text);
                SQLComando.Parameters.AddWithValue("@dataemissao", dtpEmissao.Value);
                SQLComando.Parameters.AddWithValue("@dataentrada", dtpEntrada.Value);
                SQLComando.Parameters.AddWithValue("@valortotal", Convert.ToDouble(txtTotalNota.Text));
                SQLComando.ExecuteNonQuery();

                if (SQLComando.LastInsertedId != 0)
                {
                    SQLComando.Parameters.Add(new MySqlParameter("ultimoID", SQLComando.LastInsertedId));
                    idNota = Convert.ToInt32(SQLComando.Parameters["@ultimoID"].Value);
                }
                for (int i = 0; i < dgProdutos.RowCount - 1; i++)
                {
                    SQLString = "insert into produtosnotasentrada (idnotaentrada,idproduto,precocustocompra,quantidadecompra)" +
                        " values (@idnotaentrada,@idproduto,@precocustocompra,@quantidadecompra)";
                    SQLComando = new MySqlCommand( SQLString, SQLConexao);

                    SQLComando.Parameters.AddWithValue("@idnotaentrada", idNota);
                    SQLComando.Parameters.AddWithValue("@idproduto", dgProdutos[0,i].Value);
                    SQLComando.Parameters.AddWithValue("@quantidadecompra", Convert.ToDouble(dgProdutos[3,i].Value));
                    SQLComando.Parameters.AddWithValue("@precocustocompra", Convert.ToDouble(dgProdutos[4,i].Value));
                    SQLComando.ExecuteNonQuery();

                    SQLString = "update produtos set estoque = estoque + @quantidade, precocusto = @precocusto, precovenda = @precocusto * 2 where id = @id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", dgProdutos[0, i].Value);
                    SQLComando.Parameters.AddWithValue("@quantidade", Convert.ToDouble(dgProdutos[3, i].Value));
                    SQLComando.Parameters.AddWithValue("@precocusto", Convert.ToDouble(dgProdutos[4, i].Value));

                    MessageBox.Show("Nota de entrada registrada com sucesso!");
                    LimparTodosControles();
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

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            try { 
                frmConsultaFornecedor consultaFornecedor = new frmConsultaFornecedor(this);
                consultaFornecedor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLocalizarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaProdutos consultaProdutos = new frmConsultaProdutos(this);
                consultaProdutos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

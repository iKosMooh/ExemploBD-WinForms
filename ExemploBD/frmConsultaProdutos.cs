using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBD
{
    public partial class frmConsultaProdutos : Form
    {

        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        DataTable dtFornecedores;

        string SQLString;

        frmNotasEntrada notasEntrada;
        public frmConsultaProdutos()
        {
            InitializeComponent();
        }

        public frmConsultaProdutos(frmNotasEntrada ne)
        {
            InitializeComponent();
            notasEntrada = ne;
            btnSelecionar.Visible = true;
            Consultas();
        }

        public void Consultas()
        {
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);
                SQLConexao.Open();

                if (rbID.Checked)
                {
                    SQLString = "select * from produtos where id = @id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtConsulta.Text);
                }
                if (rbDescricao.Checked)
                {
                    SQLString = "select * from produtos where descricao like @descricao";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@descricao", txtConsulta.Text + "%");
                }
                if (rbPrecoCusto.Checked)
                {
                    SQLString = "select * from produtos order by precocusto ASC";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                }
                if (rbPrecoVenda.Checked)
                {
                    SQLString = "select * from produtos order by precovenda ASC";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                }
                if (rbTodos.Checked)
                {
                    SQLString = "select * from produtos order by id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                }
                SQLDa = new MySqlDataAdapter(SQLComando);
                dtFornecedores = new DataTable();
                SQLDa.Fill(dtFornecedores);
                dgProdutos.DataSource = dtFornecedores;
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (!txtConsulta.Text.Equals(String.Empty))
            {
                Consultas();
            }
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            Consultas();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dtFornecedores.Rows.Count > 0)
            {
                notasEntrada.txtIDProduto.Text = Convert.ToString(dgProdutos[0, dgProdutos.CurrentRow.Index].Value);
                notasEntrada.txtDescricaoProduto.Text = Convert.ToString(dgProdutos[1, dgProdutos.CurrentRow.Index].Value);
                notasEntrada.txtPrecoCustoProduto.Text = Convert.ToString(dgProdutos[2, dgProdutos.CurrentRow.Index].Value);
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }
    }

}

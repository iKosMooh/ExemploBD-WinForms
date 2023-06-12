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
    public partial class frmConsultaFornecedor : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        DataTable dtFornecedores;

        string SQLString;

        frmNotasEntrada notasEntrada;
        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        public frmConsultaFornecedor(frmNotasEntrada ne)
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
                    SQLString = "select id,nome,cnpj from fornecedores where id = @id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtConsulta.Text);
                }
                if (rbNome.Checked)
                {
                    SQLString = "select id,nome,cnpj from fornecedores where nome like @nome";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@nome", txtConsulta.Text + "%");
                }
                if (rbCNPJ.Checked)
                {
                    SQLString = "select id,nome,cnpj from fornecedores where cpnj like @cnpj";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@cnpj", txtConsulta.Text + "%");
                }
                if (rbTodos.Checked)
                {
                    SQLString = "select id,nome,cnpj from fornecedores order by id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                }
                SQLDa = new MySqlDataAdapter(SQLComando);
                dtFornecedores = new DataTable();
                SQLDa.Fill(dtFornecedores);
                dgFornecedores.DataSource = dtFornecedores;
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

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (!txtConsulta.Text.Equals(String.Empty))
            {
                Consultas();
            }
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            txtConsulta.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                Consultas();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dtFornecedores.Rows.Count > 0)
            {
                notasEntrada.txtIDFornecedor.Text = Convert.ToString(dgFornecedores[0,dgFornecedores.CurrentRow.Index].Value);
                notasEntrada.txtNomeFornecedor.Text = Convert.ToString(dgFornecedores[1, dgFornecedores.CurrentRow.Index].Value);
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }
    }
}

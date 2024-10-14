using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Logistica
{
    public partial class PaginaBuscaTransportador : Form
    {
        public PaginaBuscaTransportador()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Persist Security Info=True;User ID=senac;Password=senac;Initial Catalog=ProjetoIntegrador;Server=TAU0588410W10-1;Encrypt=false;");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void btnBuscaTransportadorCadastrarveiculo_Click(object sender, EventArgs e)
        {
            PaginaCadastroVeiculoNovo CadastVeicu = new PaginaCadastroVeiculoNovo();
            CadastVeicu.Show();
            this.Hide();
        }

        private void tbxBuscaTransportadorLocalpartida_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaTransportadorLocalpartida.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Contratante where Local_partida like ('%" + tbxBuscaTransportadorLocalpartida.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaTransportador.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaTransportador.DataSource = null;

            }
        }

        private void dvgBuscaTransportador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxBuscaTransportadorDestino_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaTransportadorDestino.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Contratante where Destido like ('%" + tbxBuscaTransportadorDestino.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaTransportador.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaTransportador.DataSource = null;

            }
        }

        private void tbxBuscaTransportadorDatasaida_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaTransportadorDatasaida.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Contratante where Data_saida like ('%" + tbxBuscaTransportadorDatasaida.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaTransportador.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaTransportador.DataSource = null;

            }
        }

        private void tbxBuscaTransportadorDatachegada_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaTransportadorDatachegada.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Contratante where Data_Chegada like ('%" + tbxBuscaTransportadorDatachegada.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaTransportador.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaTransportador.DataSource = null;

            }
        }

        private void cbxBuscaTransportadorTipocarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscaTransportadorTipocarga.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Contratante where TipoCaçamba like ('%" + cbxBuscaTransportadorTipocarga.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaTransportador.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    cn.Close();
                }

            }
            else
            {
                dvgBuscaTransportador.DataSource = null;

            }
        }

        private void tbxBuscaTransportadorCargamaxima_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaTransportadorCargamaxima.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Contratante where Carga like ('%" + tbxBuscaTransportadorCargamaxima.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaTransportador.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    cn.Close();
                }

            }
        }
        private void carregaAtendente()
        {
            lbl_cod_zu.Text        = dvgBuscaTransportador.SelectedRows[0].Cells[0].ToString();
            tbx_nome_employe.Text  = dvgBuscaTransportador.SelectedRows[0].Cells[1].ToString();
            tbx_login_employe.Text = dvgBuscaTransportador.SelectedRows[0].Cells[2].ToString();
            tbx_senha_employe.Text = dvgBuscaTransportador.SelectedRows[0].Cells[3].ToString();
            
        }
        private void dvgBuscaTransportador_DoubleClick(object sender, EventArgs e)
        {
            
            PaginaConfirmacaoNovo Pconf = new PaginaConfirmacaoNovo();
            Pconf.Show();
            this.Hide();

            carregaAtendente();

        }
    }
}

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
    public partial class PaginaBuscaContratanteNovo : Form
    {
        public PaginaBuscaContratanteNovo()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Persist Security Info=True;User ID=senac;Password=senac;Initial Catalog=ProjetoIntegrador;Server=TAU0588410W10-1;Encrypt=false;");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        //private void manipularDados()
        //{
        //    //lbl_cod_zu.Visible = true;
        //    //lbl_codigo.Visible = true;
        //    //tbx_nome_employe.Enabled = true;
        //    //tbx_login_employe.Enabled = true;
        //    //tbx_senha_employe.Enabled = true;
        //    //btn_gravar.Enabled = false;
        //    //btn_cancelar.Enabled = true;
        //    //btn_remover.Enabled = true;0
        //    //btn_alterar.Enabled = true;
        //    //btn_novo.Enabled = false;
        //}

        private void tbx_pesquisaF_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaContratanteCargamaxima.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente01 ";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaContratante.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaContratante.DataSource = null;

            }
        }
        private void carregaAtendente()
        {
            //lbl_cod_zu.Text = dvgBuscaContratante.SelectedRows[0].Cells[0].ToString();
            //tbx_nome_employe.Text = dvgBuscaContratante.SelectedRows[0].Cells[1].ToString();
            //tbx_login_employe.Text = dvgBuscaContratante.SelectedRows[0].Cells[2].ToString();
            //tbx_senha_employe.Text = dvgBuscaContratante.SelectedRows[0].Cells[3].ToString();
            tbxBuscaContratanteLocalpartida.Text = dvgBuscaContratante.SelectedRows[0].Cells[0].ToString();
            tbxBuscaContratanteDestino.Text = dvgBuscaContratante.SelectedRows[1].Cells[0].ToString();
            tbxBuscaContratanteDatasaida.Text = dvgBuscaContratante.SelectedRows[2].Cells[0].ToString();
            tbxBuscaContratanteDatachegada.Text = dvgBuscaContratante.SelectedRows[3].Cells[0].ToString();
            cbxBuscaContratanteTipocarga.Text = dvgBuscaContratante.SelectedRows[4].Cells[0].ToString();
            tbxBuscaContratanteCargamaxima.Text = dvgBuscaContratante.SelectedRows[5].Cells[0].ToString();





            //manipularDados();
        }
        private void dvgBuscaContratante_DoubleClick(object sender, EventArgs e)
        {
            //manipularDados();
        }

        private void dvgBuscaContratante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxBuscaContratanteLocalpartida_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaContratanteLocalpartida.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Trasportador where Local_partida like ('%"+ tbxBuscaContratanteLocalpartida.Text+"%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaContratante.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaContratante.DataSource = null;

            }
        }

        private void tbxBuscaContratanteDestino_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaContratanteDestino.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Trasportador where Destido like ('%" + tbxBuscaContratanteDestino.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaContratante.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaContratante.DataSource = null;

            }
        }

        private void tbxBuscaContratanteDatasaida_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaContratanteDatasaida.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Trasportador where Data_saida like ('%" + tbxBuscaContratanteDatasaida.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaContratante.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaContratante.DataSource = null;

            }
        }

        private void tbxBuscaContratanteDatachegada_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaContratanteDatachegada.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Trasportador where Data_Chegada like ('%" + tbxBuscaContratanteDatachegada.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaContratante.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaContratante.DataSource = null;

            }
        }

        private void cbxBuscaContratanteTipocarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscaContratanteTipocarga.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Trasportador where TipoCaçamba like ('%" + cbxBuscaContratanteTipocarga.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaContratante.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaContratante.DataSource = null;

            }
        }

        private void tbxBuscaContratanteCargamaxima_TextChanged(object sender, EventArgs e)
        {
            if (tbxBuscaContratanteCargamaxima.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Rota_Trasportador where Carga like ('%" + tbxBuscaContratanteCargamaxima.Text + "%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dvgBuscaContratante.DataSource = dt;
                    cn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
            else
            {
                dvgBuscaContratante.DataSource = null;

            }
        }

        private void btnBuscaContratanteCadastrarNovaRota_Click(object sender, EventArgs e)
        {
            CadastroNovaRotaContratante NovaRotaContra = new CadastroNovaRotaContratante();
            NovaRotaContra.Show();
            this.Hide();
        }
    }
 }

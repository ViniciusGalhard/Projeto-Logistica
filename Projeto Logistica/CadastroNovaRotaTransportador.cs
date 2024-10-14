using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Projeto_Logistica
{
    public partial class CadastroNovaRotaTransportador :Form
    {
        public CadastroNovaRotaTransportador()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Persist Security Info=True;User ID=senac;Password=senac;Initial Catalog=ProjetoIntegrador;Server=TAU0588410W10-1;Encrypt=false;");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void btnCadastroNovaRotaContratanteCadastrar_Click(object sender, EventArgs e)
        {
            {
                //Local de Partida
                if (tbxCadastroNovaRotaTransportadorLocalpartida.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o Local de Partida", "Local de Partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxCadastroNovaRotaTransportadorLocalpartida.Focus();
                }

                //Destino
                else if (tbxCadastroNovaRotaTransportadorDestino.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o campo 'Destino'", "Destino", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxCadastroNovaRotaTransportadorDestino.Focus();
                }

                //Data de Saida
                else if (tbxCadastroNovaRotaTransportadorDatasaida.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o campo Data de Saída", "Data de saída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxCadastroNovaRotaTransportadorDatasaida.Focus();
                }

                //Data de chegada
                else if (tbxCadastroNovaRotaTransportadorDatachegada.Text == "")
                {
                    MessageBox.Show("obrigatorio informar o campo Data de Chegada", "Data de Chegada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxCadastroNovaRotaTransportadorDatachegada.Focus();
                }

                //Tipo de Carga
                else if (cbxCadastroNovaRotaTransportadorTipocarga.Text == "")
                {
                    MessageBox.Show("obrigatorio selecionar uma opcção no campo Tipo de Carga", "Tipo de Carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxCadastroNovaRotaTransportadorTipocarga.Focus();
                }

                //Carga Máxima
                else if (tbxCadastroNovaRotaTransportadorCargamaxima.Text == "")
                {
                    MessageBox.Show("obrigatorio informar o campo Carga Máxima", "Carga Máxima", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxCadastroNovaRotaTransportadorCargamaxima.Focus();
                }
                //else if (tbx_senha_employe.Text.Length < 8)//Length(conta caracteres) ,o computar começa a contar apartir do '0' então '<8' = '01234567'
                //{
                //    MessageBox.Show("Obrigatorio ter no mínimo 8 caracteres", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    tbx_senha_employe.Focus();
                //}
                else
                {
                    try
                    {

                        //MUITO IMPORTANTE
                        string LocaldePartida = tbxCadastroNovaRotaTransportadorLocalpartida.Text;
                        string Destino = tbxCadastroNovaRotaTransportadorDestino.Text;
                        string DataSaida = tbxCadastroNovaRotaTransportadorDatasaida.Text;
                        string DataChegada = tbxCadastroNovaRotaTransportadorDatachegada.Text;
                        string TipodeCarga = cbxCadastroNovaRotaTransportadorTipocarga.Text;
                        string CargaMaxima = tbxCadastroNovaRotaTransportadorCargamaxima.Text;

                        
                        string NC = "aaaaa"; // °_°

                        string strSql = "insert into Rota_Trasportador(Local_Partida,Destido,Data_Saida,Data_chegada,TipoCaçamba,Carga,Nome_Contratante) values (@Local_Partida,@Destino,@Data_Saida,@Data_Chegada,@Tipo_Cacamba,@Carga,@NC)";

                        cm.CommandText = strSql;
                        cm.Connection = cn;

                        // SqlCommand cm = new SqlCommand(sql, cn);

                        cm.Parameters.Add("@Local_Partida", SqlDbType.VarChar).Value = LocaldePartida;// essa estrutura deve ser do mesmo tipo q esta na tabela/banco de dados
                        cm.Parameters.Add("@Destino", SqlDbType.VarChar).Value = Destino;
                        cm.Parameters.Add("@Data_Saida", SqlDbType.VarChar).Value = DataSaida;
                        cm.Parameters.Add("@Data_Chegada", SqlDbType.VarChar).Value = DataChegada;
                        cm.Parameters.Add("@Tipo_Cacamba", SqlDbType.VarChar).Value = TipodeCarga;
                        cm.Parameters.Add("@Carga", SqlDbType.VarChar).Value = CargaMaxima;

                        cm.Parameters.Add("@NC", SqlDbType.VarChar).Value = NC;// °_°

                        //cm.Parameters.AddwithValue("@login",tbx_login_employe.Text);

                        cn.Open();
                        cm.ExecuteNonQuery();

                        MessageBox.Show("Os dados foram gravados", "Inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }
                    finally
                    {
                        cn.Close();
                        //Extremamente importante;
                        //PaginaBuscaContratanteNovo buscaVcon = new PaginaBuscaContratanteNovo();
                        //buscaVcon.Show();
                        //this.Hide();
                        PaginaBuscaContratanteNovo buscaContra = new PaginaBuscaContratanteNovo();
                        buscaContra.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void CadastroNovaRotaTransportador_Load(object sender, EventArgs e)
        {

        }
    }
}

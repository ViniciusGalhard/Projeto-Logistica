using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_Logistica
{
    public partial class PaginaCadastroVeiculoNovo : Form
    {
        public PaginaCadastroVeiculoNovo()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Persist Security Info=True;User ID=senac;Password=senac;Initial Catalog=ProjetoIntegrador;Server=TAU0588410W10-1;Encrypt=false;");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void btnCadastroVeiculoAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                string marcamodelo = cbxCadastroVeiculoMarca.Text;
                string tipocacamba = cbxCadastroVeiculoTipocacamba.Text;
                string carga = tbxCadastroVeiculoCargamaxima.Text;
                int numcarga = int.Parse(carga);

                string strSql = "insert into veiculos (Marca_Modelo, Tipo_de_Caçamba, Carga_maxima) values (@marcamodelo, @tipocacamba ,@numcarga)";

                cm.CommandText = strSql;
                cm.Connection = cn;

                cm.Parameters.Add("@marcamodelo", SqlDbType.VarChar).Value = marcamodelo;
                cm.Parameters.Add("@tipocacamba", SqlDbType.VarChar).Value = tipocacamba;
                cm.Parameters.Add("@numcarga", SqlDbType.VarChar).Value = numcarga;

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
                PaginaBuscaTransportador buscaVtra = new PaginaBuscaTransportador();
                buscaVtra.Show();
                this.Hide();
            }
        }

        
    }
}

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
using System.Xml.Linq;



namespace Projeto_Logistica
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }
        // Estabelecer conexão com o banco de dados TAU0588410w10-1

        SqlConnection cn = new SqlConnection(@"Persist Security Info=True;User ID=senac;Password=senac;Initial Catalog=ProjetoIntegrador;Server=TAU0588410W10-1;Encrypt=false;");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click_1(object sender, EventArgs e)
        {

        }

        private void tbxPaginaInicialLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastroContratante_Click(object sender, EventArgs e)
        {

            PaginaCadastroContratanteNovo cadastrocon = new PaginaCadastroContratanteNovo();
            cadastrocon.Show();
            this.Hide();
               

        }

        private void btnCadastroTransportador_Click(object sender, EventArgs e)
        {

                    PaginaCadastroTransportador cadastrotran = new PaginaCadastroTransportador();
                    cadastrotran.Show();
                    this.Hide();
                
              
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxPaginaInicialLogin.Text == "" || tbxPaginaInicialSenha.Text == "")
            {
                MessageBox.Show("Prencher nome e senha de usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//login contratante
            else if (rbtnContratante.Checked == true)
            {
                try//Tentar
                {
                    cn.Open();
                    cm.CommandText = "select * from Contratante where login= ('" + tbxPaginaInicialLogin.Text + "') and senha= ('" + tbxPaginaInicialSenha.Text + "')";
                    cm.Connection = cn;
                    dt = cm.ExecuteReader();


                    if (dt.HasRows)
                    {
                        //PaginaBuscaContratanteNovo buscaVcon = new PaginaBuscaContratanteNovo();
                        //buscaVcon.Show();
                        //this.Hide();

                        PaginaBuscaTransportador buscaVtra = new PaginaBuscaTransportador();
                        buscaVtra.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha incorretos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxPaginaInicialLogin.Clear();
                        tbxPaginaInicialSenha.Clear();
                        tbxPaginaInicialLogin.Focus();
                    }


                }
                catch (Exception erro)//Pegar
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();

                    //old->this.Close();
                }
            }//login transportador
            else if (rbtnTransportador.Checked == true)
            {
                try//Tentar
                {
                    cn.Open();
                    cm.CommandText = "select * from Transportador where loginT= ('" + tbxPaginaInicialLogin.Text + "') and senhaT= ('" + tbxPaginaInicialSenha.Text + "')";
                    cm.Connection = cn;
                    dt = cm.ExecuteReader();


                    if (dt.HasRows)
                    {
                        //PaginaBuscaTransportador buscaVtra = new PaginaBuscaTransportador();
                        //buscaVtra.Show();
                        //this.Hide()


                        PaginaBuscaContratanteNovo buscaVcon = new PaginaBuscaContratanteNovo();
                        buscaVcon.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha incorretos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxPaginaInicialLogin.Clear();
                        tbxPaginaInicialSenha.Clear();
                        tbxPaginaInicialLogin.Focus();
                    }


                }
                catch (Exception erro)//Pegar
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();

                    //old->this.Close();
                }
            }
            else
            {
                cn.Close();
            }
        }

        private void tbxPaginaInicialSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnContratante_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnTransportador_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}

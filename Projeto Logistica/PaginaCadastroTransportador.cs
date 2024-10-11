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
    public partial class PaginaCadastroTransportador : Form
    {
        public PaginaCadastroTransportador()
        {
            InitializeComponent();
        }

         SqlConnection cn = new SqlConnection(@"Persist Security Info=True;User ID=senac;Password=senac;Initial Catalog=ProjetoIntegrador;Server=TAU0588410W10-1;Encrypt=false;");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void btnCadastroTransportadorAvancar_Click(object sender, EventArgs e)
        {
            //NOME
            if (tbxCadastroTransportadorNome.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o campo Nome", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCadastroTransportadorNome.Focus();
            }

            //CPF/CNPJ
            else if (tbxCadastroTransportadorCPFCNPJ.Text == "")
            {
                MessageBox.Show("obrugatorio informar o campo CPF/CNPJ", "CPF/CNPJ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCadastroTransportadorCPFCNPJ.Focus();
            }

            //EMAIL
            else if (tbxCadastroTransportadoremail.Text == "")
            {
                MessageBox.Show("obrugatorio informar o campo email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCadastroTransportadoremail.Focus();
            }

            //TELEFONE
            else if (tbxCadastroTransportadorTelefone.Text == "")
            {
                MessageBox.Show("obrugatorio informar o campo  Telefone", " telefone ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCadastroTransportadorTelefone.Focus();
            }

            //LOGIN
            else if (tbxCadastroTransportadorLogin.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o campo 'Login'", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCadastroTransportadorLogin.Focus();
            }

            //SENHA
            else if (tbxCadastroTransportadorSenha.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o campo Senha", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCadastroTransportadorSenha.Focus();
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
                    string nomeT = tbxCadastroTransportadorNome.Text;
                    string cpfcnpjT = tbxCadastroTransportadorCPFCNPJ.Text;
                    string emailT = tbxCadastroTransportadoremail.Text;
                    string telefoneT = tbxCadastroTransportadorTelefone.Text;
                    string loginT = tbxCadastroTransportadorLogin.Text;
                    string senhaT = tbxCadastroTransportadorSenha.Text;                   
                    
                    

                    string strSql = "insert into Transportador (nome,cpf_cnpj,email,telefone,login,senha) values (@nomeT,@cpfT,@emailT,@telefoneT, @loginT, @senhaT)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    // SqlCommand cm = new SqlCommand(sql, cn);

                    cm.Parameters.Add("@nomeT", SqlDbType.VarChar).Value = nomeT;
                    cm.Parameters.Add("@cpfT", SqlDbType.VarChar).Value = cpfcnpjT;
                    cm.Parameters.Add("@emailT", SqlDbType.VarChar).Value = emailT;
                    cm.Parameters.Add("@telefoneT", SqlDbType.VarChar).Value = telefoneT;
                    cm.Parameters.Add("@loginT", SqlDbType.VarChar).Value = loginT;// essa estrutura deve ser do mesmo tipo q esta na tabela/banco de dados
                    cm.Parameters.Add("@senhaT", SqlDbType.VarChar).Value = senhaT;
                    
                    //cm.Parameters.AddwithValue("@login",tbx_login_employe.Text);

                    cn.Open();
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Os dados foram gravados", "Inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxCadastroTransportadorSenha.Focus();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                    ////Extremamente importante;
                    //////PaginaBuscaTransportador buscaVtra = new PaginaBuscaTransportador();
                    //////buscaVtra.Show();
                    //////this.Hide();
                    //PaginaCadastroVeiculoNovo cadveicle = new PaginaCadastroVeiculoNovo();
                    //cadveicle.Show();
                    //this.Hide();
                    PaginaBuscaTransportador buscaTransp = new PaginaBuscaTransportador();
                    buscaTransp.Show();
                    this.Hide();
                }
            }
        }

        private void tbxCadastroTransportadorNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCadastroTransportadorCPFCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCadastroTransportadorLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCadastroTransportadorSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCadastroTransportadoremail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCadastroTransportadorTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaginaCadastroTransportador_Load(object sender, EventArgs e)
        {

        }
    }
}

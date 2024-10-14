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
    public partial class PaginaCadastroContratanteNovo : Form
    {
        public PaginaCadastroContratanteNovo()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Persist Security Info=True;User ID=senac;Password=senac;Initial Catalog=ProjetoIntegrador;Server=TAU0588410W10-1;Encrypt=false;");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void btnCasdastroContratanteAvancar_Click(object sender, EventArgs e)
        {   //NOME
            if (tbxCasdastroContratanteNome.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o campo Nome", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCasdastroContratanteNome.Focus();
            }

            //CPF/CNPJ
            else if (tbxCasdastroContratanteCPFCNPJ.Text == "")
            {
                MessageBox.Show("obrugatorio informar o campo CPF/CNPJ", "CPF/CNPJ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCasdastroContratanteCPFCNPJ.Focus();
            }

            //EMAIL
            else if (tbxCadastroContratanteemail.Text == "")
            {
                MessageBox.Show("obrugatorio informar o campo email", "senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCadastroContratanteemail.Focus();
            }

            //TELEFONE
            else if (tbxCadastroContratanteTelefone.Text == "")
            {
                MessageBox.Show("obrugatorio informar o campo  Telefone", " telefone ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCadastroContratanteTelefone.Focus();
            }

            //LOGIN
            else if (tbxCasdastroContratanteLogin.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o campo 'Login'", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCasdastroContratanteLogin.Focus();
            }

            //SENHA
            else if (tbxCasdastroContratanteSenha.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o campo Senha", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCasdastroContratanteSenha.Focus();
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
                    string nome = tbxCasdastroContratanteNome.Text;
                    string cpfcnpj = tbxCasdastroContratanteCPFCNPJ.Text;
                    string email = tbxCadastroContratanteemail.Text;
                    string telefone = tbxCadastroContratanteTelefone.Text;
                    string login = tbxCasdastroContratanteLogin.Text;
                    string senha = tbxCasdastroContratanteSenha.Text;


                    string strSql = "insert into Contratante (nome, cpf_cnpj,email,telefone,login,senha) values (@nome,@cpf_cnpj,@email,@telefone,@login,@senha)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    // SqlCommand cm = new SqlCommand(sql, cn);


                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cpf_cnpj", SqlDbType.VarChar).Value = cpfcnpj;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;// essa estrutura deve ser do mesmo tipo q esta na tabela/banco de dados
                    cm.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                    //cm.Parameters.AddwithValue("@login",tbx_login_employe.Text);

                    cn.Open();
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Os dados foram gravados", "Inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxCasdastroContratanteSenha.Focus();

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
}
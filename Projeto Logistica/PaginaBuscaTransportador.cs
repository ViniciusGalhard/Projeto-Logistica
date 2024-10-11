using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Logistica
{
    public partial class PaginaBuscaTransportador : Form
    {
        public PaginaBuscaTransportador()
        {
            InitializeComponent();
        }

        private void btnBuscaTransportadorCadastrarveiculo_Click(object sender, EventArgs e)
        {
            PaginaCadastroVeiculoNovo CadastVeicu = new PaginaCadastroVeiculoNovo();
            CadastVeicu.Show();
            this.Hide();
        }
    }
}

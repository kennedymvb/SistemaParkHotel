using Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormEntradaProdutos : Form
    {
        public FormEntradaProdutos()
        {
            InitializeComponent();
        }

        EntradaProdutos entradaProdutos;

        private EntradaProdutos InstanciarEntradaProdutos()
        {
            DateTime dataEntrada = dateTimeEntrada.Value;
            return new EntradaProdutos(Usuario.UsuarioLogado.id, dataEntrada);
        }

        private void btnProximaPagina_Click(object sender, EventArgs e)
        {
            FormEntradaProdutosDetalhes formDetalhes = new FormEntradaProdutosDetalhes(InstanciarEntradaProdutos());
            formDetalhes.ShowDialog();
        }
    }
}

using BLL;
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
    public partial class FormSaidaProdutos : Form
    {
        CheckinBLL checkinBLL = new CheckinBLL();
        public FormSaidaProdutos()
        {
            InitializeComponent();
            dataGridSelecionarCheckin.Hide();
        }


        public int idCheckin { get; set; }

        private SaidaProdutos InstanciarSaidaProdutos()
        {
            DateTime dataEntrada = dateTimeVenda.Value;
            return new SaidaProdutos(Usuario.UsuarioLogado.id, dataEntrada, idCheckin);
        }

        private void tratarTxtBox()
        {
            txtNumCheckin.Text = Convert.ToString(idCheckin);
            txtNumCheckin.Enabled = false;
        }

        private void btnSelecionarCliente_Click_1(object sender, EventArgs e)
        {
            dataGridSelecionarCheckin.DataSource =checkinBLL.LerCheckinViewModels();
            dataGridSelecionarCheckin.Show();
        }

        private void btnProximaPagina_Click_1(object sender, EventArgs e)
        {
            FormSaidaProdutosDetalhes frm = new FormSaidaProdutosDetalhes(InstanciarSaidaProdutos());
            frm.ShowDialog();
        }

        private void dataGridSelecionarCheckin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumCheckin.Text = dataGridSelecionarCheckin.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNumCheckin.Enabled = false;
        }
    }
}

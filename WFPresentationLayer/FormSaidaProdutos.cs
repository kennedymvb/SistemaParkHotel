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
        }
        public FormSaidaProdutos(int idCheckin)
        {
            InitializeComponent();
            this.idCheckin = idCheckin;
            tratarTxtBox();
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
        private void btnCadastrarEntrada_Click(object sender, EventArgs e)
        {
            FormEntradaProdutosDetalhes frm = new FormEntradaProdutosDetalhes();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnSelecionarCliente_Click_1(object sender, EventArgs e)
        {
            dataGridDia.DataSource = checkinBLL.LerCheckinViewModels();
            FormSelecionarCheckin frm = new FormSelecionarCheckin(dataGridDia);
            frm.Show();
            this.Dispose();
        }

        private void btnProximaPagina_Click_1(object sender, EventArgs e)
        {
            FormSaidaProdutosDetalhes frm = new FormSaidaProdutosDetalhes(InstanciarSaidaProdutos());
            frm.Show();
            this.Hide();
        }
    }
}

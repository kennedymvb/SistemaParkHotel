using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metadata;
using BLL;

namespace WFPresentationLayer
{
    public partial class FormSaidaProdutosDetalhes : Form
    {
        SaidaProdutosBLL saidaProdutosBLL = new SaidaProdutosBLL();
        ProdutoBLL produtosBLL = new ProdutoBLL();
        SaidaProdutos saidaProdutos = new SaidaProdutos();
        CheckinBLL checkinBLL = new CheckinBLL();
        public FormSaidaProdutosDetalhes(int idCheckin)
        {
            InitializeComponent();
            dataGridDia.Hide();
            txtNumCheckin.Text = Convert.ToString(idCheckin);
            txtNumCheckin.Enabled = false;
            carregarComboBox();
        }
        public FormSaidaProdutosDetalhes()
        {
            InitializeComponent();
            dataGridDia.Hide();
            carregarComboBox();
        }

        private void carregarComboBox()
        {
            cmbProduto.DisplayMember = "NOME";
            cmbProduto.ValueMember = "ID";
            cmbProduto.DataSource = produtosBLL.LerTodos();
        }
        private ItensSaida InstanciarSaidaProdutosDetalhes()
        {
            int idProduto = (int)cmbProduto.SelectedValue;
            int idCheckin = int.Parse(txtNumCheckin.Text);
            int quantidade = int.Parse(txtQuantidadeEntrada.Text);
            double valorUnitario = double.Parse(txtValorEntrada.Text) / int.Parse(txtQuantidadeEntrada.Text);
            return new ItensSaida(idProduto, idCheckin, quantidade, valorUnitario); 
        }

        private void btnAdicionarAoLote_Click(object sender, EventArgs e)
        {
            saidaProdutos.itens.Add(InstanciarSaidaProdutosDetalhes());
            limparTextBox();
        }

        private void limparTextBox()
        {
            txtQuantidadeEntrada.Clear();
            txtValorEntrada.Clear();
        }
        

        private SaidaProdutos InstanciarSaidaProdutos()
        {
            DateTime dataEntrada = dateTimeVenda.Value;
            return new SaidaProdutos(Usuario.UsuarioLogado.id,  dataEntrada);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            saidaProdutosBLL.inserir(saidaProdutos);
        }

        private void btnExibirEntradas_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarAoLote_Click_1(object sender, EventArgs e)
        {
            saidaProdutos = InstanciarSaidaProdutos();
            saidaProdutos.itens.Add(InstanciarSaidaProdutosDetalhes());
        }

        private void btnExibirEntradas_Click_1(object sender, EventArgs e)
        {
            dataGridDia.DataSource = checkinBLL.LerCheckinViewModels();
            FormDialog frm = new FormDialog(dataGridDia);
            frm.Show();
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPesquisarCheckin_Click(object sender, EventArgs e)
        {
            dataGridDia.DataSource = checkinBLL.LerCheckinViewModels();
            FormDialog frm = new FormDialog(dataGridDia);
            frm.Show();
            this.Dispose();
        }

        private void dataGridDia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

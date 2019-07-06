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
    public partial class FormEntradaProdutosDetalhes : Form
    {
        EntradaProdutosBLL entradaProdutosBLL = new EntradaProdutosBLL();
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        EntradaProdutos entradaProdutos = new EntradaProdutos();
        public FormEntradaProdutosDetalhes()
        {
            InitializeComponent();
            carregarComboBox();
            configurarGroupBox();
        }

        private void configurarGroupBox()
        {
            groupBoxDetalhes.Hide();
            groupBoxEntrada.Show();
        }

        private void carregarComboBox()
        {
            cmbProduto.DisplayMember = "NOME";
            cmbProduto.ValueMember = "ID";
            cmbProduto.DataSource = produtoBLL.LerTodos();
            cmbFornecedor.DisplayMember = "razaoSocial";
            cmbFornecedor.ValueMember = "ID";
            cmbFornecedor.DataSource = fornecedorBLL.LerTodos();

        }
        private ItensEntrada InstanciarEntradaProdutosDetalhes()
        {
            int idProduto = (int)cmbProduto.SelectedValue;
            int idFornecedor = encontrarIdFornecedor();
            int quantidade = int.Parse(txtQuantidadeEntrada.Text);
            double valorUnitario = double.Parse(txtValorEntrada.Text) / int.Parse(txtQuantidadeEntrada.Text);
            return new ItensEntrada(idProduto, idFornecedor, quantidade, valorUnitario); 
        }

        private int encontrarIdFornecedor()
        {
            return (int)cmbFornecedor.SelectedValue;
        }

        private void btnAdicionarAoLote_Click(object sender, EventArgs e)
        {
            entradaProdutos.itens.Add(InstanciarEntradaProdutosDetalhes());
            LblValorUnitarioCompra.Text = (double.Parse(txtValorEntrada.Text) / double.Parse(txtQuantidadeEntrada.Text)).ToString("C2");
            limparTextBox();
        }

        private void limparTextBox()
        {
            txtQuantidadeEntrada.Clear();
            txtValorEntrada.Clear();
        }

        

        private void FormEntradaProdutosDetalhes_Load(object sender, EventArgs e)
        {

        }

        private void btnProximaPagina_Click(object sender, EventArgs e)
        {
            entradaProdutos = InstanciarEntradaProdutos();
            groupBoxDetalhes.Show();
        }

        private EntradaProdutos InstanciarEntradaProdutos()
        {
            DateTime dataEntrada = dateTimeEntrada.Value;
            double valorTotal = double.Parse(txtValorTotalLote.Text);
            return new EntradaProdutos(Usuario.UsuarioLogado.id, dataEntrada, valorTotal);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            entradaProdutosBLL.inserir(entradaProdutos);
        }

        private void btnExibirEntradas_Click(object sender, EventArgs e)
        {

        }
    }
}

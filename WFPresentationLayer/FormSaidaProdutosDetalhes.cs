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
        ClienteBLL clienteBLL = new ClienteBLL();
        ProdutoBLL produtosBLL = new ProdutoBLL();
        SaidaProdutos saidaProdutos = new SaidaProdutos();
        public FormSaidaProdutosDetalhes()
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
            cmbProduto.DataSource = produtosBLL.LerTodos();
        }
        private ItensSaida InstanciarSaidaProdutosDetalhes()
        {
            int idProduto = (int)cmbProduto.SelectedValue;
            int idCliente = int.Parse(txtNumClienteSaidaDetalhes.Text);
            int quantidade = int.Parse(txtQuantidadeEntrada.Text);
            double valorUnitario = double.Parse(txtValorEntrada.Text) / int.Parse(txtQuantidadeEntrada.Text);
            return new ItensSaida(idProduto, idCliente, quantidade, valorUnitario); 
        }

        private void btnAdicionarAoLote_Click(object sender, EventArgs e)
        {
            saidaProdutos.itens.Add(InstanciarSaidaProdutosDetalhes());
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
            saidaProdutos = InstanciarSaidaProdutos();
            groupBoxDetalhes.Show();
        }

        private SaidaProdutos InstanciarSaidaProdutos()
        {
            DateTime dataEntrada = dateTimeEntrada.Value;
            double valorTotal = double.Parse(txtValorTotalLote.Text);
            return new SaidaProdutos(Usuario.UsuarioLogado.id, valorTotal, dataEntrada);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            saidaProdutosBLL.inserir(saidaProdutos);
        }

        private void btnExibirEntradas_Click(object sender, EventArgs e)
        {

        }
    }
}

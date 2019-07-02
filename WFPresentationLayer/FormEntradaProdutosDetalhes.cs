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
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        EntradaProdutosDetalhesBLL entradaDetalhesBLL = new EntradaProdutosDetalhesBLL();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        public FormEntradaProdutosDetalhes()
        {
            
            InitializeComponent();
            carregarComboBox();
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
        private EntradaProdutosDetalhes InstanciarEntradaProdutosDetalhes()
        {
            int idProduto = (int)cmbProduto.SelectedValue;
            int idFornecedor = encontrarIdFornecedor();
            int quantidade = int.Parse(txtQuantidadeEntrada.Text);
            double valorUnitario = double.Parse(txtValorEntrada.Text) / int.Parse(txtQuantidadeEntrada.Text);
            produtoBLL.atualizarQuantidadeEstoque(produtoBLL.LerPorID(idProduto));
            return new EntradaProdutosDetalhes(Form1.idEntradaCorrespondente, idProduto, idFornecedor, quantidade, valorUnitario); 
        }

        private int encontrarIdFornecedor()
        {
            return (int)cmbFornecedor.SelectedValue;

        }

        private void btnAdicionarAoLote_Click(object sender, EventArgs e)
        {
            EntradaProdutosDetalhes entradaProdutosDetalhes = InstanciarEntradaProdutosDetalhes();
            MessageBox.Show(entradaDetalhesBLL.inserir(entradaProdutosDetalhes));
            LblValorUnitarioCompra.Text = (double.Parse(txtValorEntrada.Text) / double.Parse(txtQuantidadeEntrada.Text)).ToString("C2");
            limparTextBox();
        }

        private void limparTextBox()
        {
            txtQuantidadeEntrada.Clear();
            txtValorEntrada.Clear();
        }

        private void btnCadastrarEntrada_Click_1(object sender, EventArgs e)
        {
            this.Hide();
       
        }

        private void FormEntradaProdutosDetalhes_Load(object sender, EventArgs e)
        {

        }
    }
}

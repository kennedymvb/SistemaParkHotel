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
        public static int idEntradaCorrespondente;
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        EntradaProdutosDetalhesBLL entradaDetalhesBLL = new EntradaProdutosDetalhesBLL();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        public FormEntradaProdutosDetalhes()
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Hide();
            InitializeComponent();
            carregarComboBox();
        }
        
        private void carregarComboBox()
        {
            List<string> nomesFornecedores = new List<string>();
            List<string> nomesProdutos = new List<string>();

            foreach (Fornecedor item in fornecedorBLL.LerTodos())
            {
                nomesFornecedores.Add(item.razaoSocial);
            }
            cmbFornecedor.DataSource = nomesFornecedores;
            foreach (Produto item in produtoBLL.LerTodos())
            {
                nomesProdutos.Add(item.nome);
            }
            cmbProduto.DataSource = nomesProdutos;
        }
        private EntradaProdutosDetalhes InstanciarEntradaProdutosDetalhes()
        {
            Produto produto = encontrarIdProduto();

            int idProduto = produto.id;
            int idFornecedor = encontrarIdFornecedor();
            int quantidade = int.Parse(txtQuantidadeEntrada.Text);
            double valorUnitario = double.Parse(txtValorEntrada.Text) / int.Parse(txtQuantidadeEntrada.Text);

            produtoBLL.atualizarQuantidadeEstoque(produto);
            return new EntradaProdutosDetalhes(idEntradaCorrespondente, idProduto, idFornecedor, quantidade, valorUnitario); 
        }

        private int encontrarIdFornecedor()
        {
            return produtoBLL.LerTodos()[cmbFornecedor.SelectedIndex].id;

        }
        //gambiarra
        private Produto encontrarIdProduto()
        {
            return produtoBLL.LerTodos()[cmbProduto.SelectedIndex];
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
            this.Dispose();
        }

        
    }
}

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
            FormLogin formLogin = new FormLogin();
            formLogin.Hide();
            InitializeComponent();
            carregarComboBox();
        }

        

        private void btnCadastrarEntrada_Click(object sender, EventArgs e)
        {

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
        private EntradaProdutosDetalhes InstanciarEntradaProdutosDetalhes(int idEntradaProduto)
        {
            Produto produto = encontrarIdProduto();
            int idProduto = produto.id;
            int idFornecedor = encontrarIdFornecedor();
            int quantidade = int.Parse(txtQuantidadeEntrada.Text);
            double valorUnitario = double.Parse(txtValorEntrada.Text) / int.Parse(txtQuantidadeEntrada.Text);
            LblValorUnitarioCompra.Text = valorUnitario.ToString("C2");
            produtoBLL.atualizarQuantidadeEstoque(produto);
            return new EntradaProdutosDetalhes(idEntradaProduto, idProduto, idFornecedor, quantidade, valorUnitario); ;
        }

        private int encontrarIdFornecedor()
        {
            foreach (Fornecedor item in fornecedorBLL.LerTodos())
            {
                if (item.razaoSocial == cmbProduto.SelectedText)
                {
                    return item.id;
                }
            }
            return 0;
        }

        private Produto encontrarIdProduto()
        {
            foreach (Produto item in produtoBLL.LerTodos())
            {
                if (item.nome == cmbProduto.SelectedText)
                {
                    return item;
                }
            }
            return null;
        }

        

        private void btnAdicionarAoLote_Click(object sender, EventArgs e)
        {

        }
    }
}

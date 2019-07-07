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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }
        ProdutoBLL produtoBLL = new ProdutoBLL(); 

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto = InstanciarProduto();
            MessageBox.Show(produtoBLL.inserir(produto));
            exibirProdutos();
        }

        private void btnAtualizarProdutos_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogoProdutos_Click(object sender, EventArgs e)
        {
            exibirProdutos();
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Produto InstanciarProduto()
        {
            string nome = txtnomeproduto.Text;
            string descricao = txtdescricaoproduto.Text;
            double preco = Double.Parse(txtvalorunitarioproduto.Text);
            int idUsuario = Usuario.UsuarioLogado.id;
            Produto produto = new Produto(nome, descricao, preco, idUsuario, 0);
            return produto;
        }

        private void exibirProdutos()
        {
            dataGridViewProdutos.DataSource = produtoBLL.LerTodos();
            this.dataGridViewProdutos.Show();
        }

       
    }
}

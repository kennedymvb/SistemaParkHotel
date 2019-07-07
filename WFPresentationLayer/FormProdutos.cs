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
        private int idProduto { get; set; }
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

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idProduto = (int)dataGridViewProdutos.Rows[e.RowIndex].Cells[0].Value;
            txtnomeproduto.Text = (string)dataGridViewProdutos.Rows[e.RowIndex].Cells[1].Value;
            txtdescricaoproduto.Text = (string)dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value;
            txtvalorunitarioproduto.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }


    }
}

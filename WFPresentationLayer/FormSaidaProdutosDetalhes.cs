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
        SaidaProdutos saidaProdutos;
        CheckinBLL checkinBLL = new CheckinBLL();

        public double valorTotalCompra { get; set; }

        public FormSaidaProdutosDetalhes(SaidaProdutos saidaProdutos)
        {
            InitializeComponent();
            dataGridDia.Hide();
            carregarComboBox();
            this.saidaProdutos = saidaProdutos;
            this.valorTotalCompra = 0;
        }
        
        private ItensSaida InstanciarSaidaProdutosDetalhes()
        {
            int idProduto = (int)cmbProduto.SelectedValue;
            double valorProduto = getValorProduto();
            int quantidade = int.Parse(txtQuantidadeProdutos.Text);
            return new ItensSaida(idProduto, quantidade, valorProduto); 
        }


        private void btnAdicionarAoLote_Click_1(object sender, EventArgs e)
        {
            try{
                tratarRepeticaoId();
                saidaProdutos.itens.Add(InstanciarSaidaProdutosDetalhes());
                VisualizarItensAdicionados();
                atualizarValorTotal();
                MessageBox.Show("Adicionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void atualizarValorTotal()
        {
            double precoUnitario=saidaProdutos.itens[saidaProdutos.itens.Count - 1].valorUnitario;
            int quantidade = saidaProdutos.itens[saidaProdutos.itens.Count - 1].quantidade;
            valorTotalCompra += precoUnitario * quantidade;
        }

        public double getValorProduto()
        {
            return produtosBLL.LerPorID((int)cmbProduto.SelectedValue).preco;
        }

        private void limparTextBox()
        {
            txtQuantidadeProdutos.Clear();
        }
        private void carregarComboBox()
        {
            cmbProduto.DisplayMember = "NOME";
            cmbProduto.ValueMember = "ID";
            cmbProduto.DataSource = produtosBLL.LerTodos();
        }

        private void btnApagarRegistro_Click(object sender, EventArgs e)
        {
            int index= dataGridsaidaLote.CurrentRow.Index;
            saidaProdutos.itens.RemoveAt(index);
            VisualizarProdutosLote();
        }

        private void txtQuantidadeProdutos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int qtdProdutos = int.Parse(txtQuantidadeProdutos.Text);
                lblValorCompra.Text = Math.Round(((getValorProduto() * qtdProdutos)+valorTotalCompra),2).ToString("C2");
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um valor válido");
                lblValorCompra.Text = valorTotalCompra.ToString("C2");
            }
        }
        private void VisualizarProdutosLote()
        {
            dataGridsaidaLote.DataSource = saidaProdutos.itens;
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                saidaProdutos.valorTotal = valorTotalCompra;
                saidaProdutosBLL.inserir(saidaProdutos);
                MessageBox.Show("Finalizado com sucesso");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de cadastro: " + ex.Message);
            }
        }
        
        private void tratarRepeticaoId()
        {

            for (int i = 0; i < saidaProdutos.itens.Count; i++)
            {
                if ((int)cmbProduto.SelectedValue == saidaProdutos.itens[i].idProduto)
                {
                    saidaProdutos.itens.RemoveAt(saidaProdutos.itens.Count-1);
                    throw new Exception("Você não pode inserir duas vezes o mesmo produto.\n" +
                        " Preencha novamente!\n Agora, com a quantidade completa de uma só vez.");
                }
            }
        }

        private void VisualizarItensAdicionados()
        {
            List<ItensAdicionados> ProdutosAdicionados = new List<ItensAdicionados>();
            ItensAdicionados i = new ItensAdicionados();

            foreach (ItensSaida item in saidaProdutos.itens)
            {
                Produto p = produtosBLL.LerPorID(item.idProduto);
                i.Produto = p.nome;
                i.Valor = p.preco;
                i.Venda = item.id;
                ProdutosAdicionados.Add(i);
            }
            dataGridDia.DataSource = ProdutosAdicionados;
        }
    }
}

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
using BLL;

namespace WFPresentationLayer
{
    
    public partial class Form1 : Form
    {
        ClienteBLL clienteBLL = new ClienteBLL();
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        QuartoBLL quartoBLL = new QuartoBLL();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo " + Usuario.UsuarioLogado.nome);
        }
      
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = InstanciarCliente();
            clienteBLL.Inserir(cliente);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private Cliente InstanciarCliente()
        {
            string nome = txtnomeCliente.Text;
            string rg = txtrgCliente.Text;
            string email = txtemailCliente.Text;
            string cpf = txtcpfCliente.Text;
            string telefone1 = txttelefone1Cliente.Text;
            string telefone2 = txttelefone2Cliente.Text;
            Cliente cliente = new Cliente(nome, rg, cpf, telefone1, telefone2, email, Usuario.UsuarioLogado.id);
            return cliente;
        }
        private void btncadastrarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor = InstanciarFornecedor();
            fornecedorBLL.inserir(fornecedor);
        }

        private Fornecedor InstanciarFornecedor()
        {
            string RazaoSocial = txtrazaoSocial.Text;
            string CNPJ = txtcnpjFornecedor.Text;
            string Telefone = txtTelefoneFornecedor.Text;
            string Email = txtEmailFornecedor.Text;
            int IDusuario = Usuario.UsuarioLogado.id;
            string Nomecontato = txtNomecontatoFornecedor.Text;
            Fornecedor fornecedor = new Fornecedor(RazaoSocial, CNPJ, Telefone, Email, IDusuario, Nomecontato);
            return fornecedor;
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto = InstanciarProduto();
            produtoBLL.inserir(produto);
        }

        private Produto InstanciarProduto()
        {
            string nome = txtnomeproduto.Text;
            string descricao = txtdescricaoproduto.Text;
            double preco = Double.Parse(txtvalorunitarioproduto.Text); 
            int idUsuario = Usuario.UsuarioLogado.id;
            int qtdEstoque = Convert.ToInt32(txtQuantidadeCadastroProduto.Text);
            Produto produto = new Produto(nome, descricao, preco, idUsuario, qtdEstoque);
            return produto;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            quarto = InstanciarQuarto();
            quartoBLL.inserir(quarto);
        }

        private Quarto InstanciarQuarto()
        {
            double ValorDiaria = Double.Parse(txtValorDiaria.Text);
            int IDUsuario = Usuario.UsuarioLogado.id;
            string tipoQuarto = cmbTipoQuarto.Text;
            Quarto quarto = new Quarto( ValorDiaria, IDUsuario, tipoQuarto);
            return quarto;
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = instanciarUsuario();
        }

        private Usuario instanciarUsuario()
        {
            Usuario usuario = new Usuario();
            string Nome = txtnomeUsuario.Text;
            string RG = txtRGUsuario.Text;
            string CPF = txtCPFUsuario.Text;
            string Endereco = txtEnderecoUsuario.Text;
            string Telefone = txtTelefoneUsuario.Text;
            string Email = txtEmailUsuario.Text;
            string Senha = txtSenhaUsuario.Text;
            bool IsAdmin = false;
            return usuario;
        }

    }
}

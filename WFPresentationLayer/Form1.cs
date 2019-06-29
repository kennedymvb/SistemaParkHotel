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
        SaidaProdutosBLL saidaProdutosBLL = new SaidaProdutosBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        ReservaBLL ReservaBLL = new ReservaBLL();
        CheckinBLL checkinBLL = new CheckinBLL();
        CheckoutBLL checkoutBLL = new CheckoutBLL();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo " + Usuario.UsuarioLogado.nome);
        }

        #region Operações Cliente
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = InstanciarCliente();
            MessageBox.Show(clienteBLL.Inserir(cliente));
            dataGridView1.DataSource = clienteBLL.LerTodos();
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

        private void btnExibirClientes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=clienteBLL.LerTodos();
        }
        #endregion

        #region Operações Fornecedor
        private void btncadastrarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor = InstanciarFornecedor();
            MessageBox.Show(fornecedorBLL.inserir(fornecedor));
            dataGridViewFornecedor.DataSource = fornecedorBLL.LerTodos();

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

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            dataGridViewFornecedor.DataSource = fornecedorBLL.LerTodos();
        }
        #endregion

        #region Operações produto
        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto = InstanciarProduto();
            MessageBox.Show(produtoBLL.inserir(produto));
            dataGridViewProdutos.DataSource = produtoBLL.LerTodos();
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

        private void btnCatalogoProdutos_Click(object sender, EventArgs e)
        {
            dataGridViewProdutos.DataSource = produtoBLL.LerTodos();
        }
        #endregion

        #region Operações Quarto
        private void button4_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            quarto = InstanciarQuarto();
            MessageBox.Show(quartoBLL.inserir(quarto));
            dataGridViewQuartos.DataSource = quartoBLL.LerTodos();

        }

        private Quarto InstanciarQuarto()
        {
            double ValorDiaria = Double.Parse(txtValorDiaria.Text);
            int IDUsuario = Usuario.UsuarioLogado.id;
            string tipoQuarto = cmbTipoQuarto.Text;
            Quarto quarto = new Quarto( ValorDiaria, IDUsuario, tipoQuarto);
            return quarto;
        }
        private void btnExibirQuartos_Click(object sender, EventArgs e)
        {
            dataGridViewQuartos.DataSource = quartoBLL.LerTodos();
        }
        #endregion


        #region Operações Usuário
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = instanciarUsuario();
            MessageBox.Show(usuarioBLL.Inserir(usuario));
            dataGridViewUsuarios.DataSource = usuarioBLL.LerTodos();

        }

        private Usuario instanciarUsuario()
        {
            string Nome = txtnomeUsuario.Text;
            string RG = txtRGUsuario.Text;
            string CPF = txtCPFUsuario.Text;
            string Endereco = txtEnderecoUsuario.Text;
            string Telefone = txtTelefoneUsuario.Text;
            string Email = txtEmailUsuario.Text;
            string Senha = txtSenhaUsuario.Text;
            bool IsAdmin = false;
            return new Usuario(Nome, RG, CPF, Endereco, Telefone, Email, Senha, IsAdmin);
        }
        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = usuarioBLL.LerTodos();
        }
        #endregion

        #region Operações Vendas
        private void btnCadastrarVendas_Click(object sender, EventArgs e)
        {
            SaidaProdutos saida= InstanciarVenda();
            saidaProdutosBLL.inserir(saida);
            
        }

        private SaidaProdutos InstanciarVenda()
        {
            int idVendedor = int.Parse(txtnumUsuarioVenda.Text);
            int idProduto = int.Parse(txtNumProdutoVenda.Text);
            int idCliente = int.Parse(txtnumClienteVenda.Text);
            DateTime dataSaida = dateTimeVenda.Value;
            SaidaProdutos saida = new SaidaProdutos(idVendedor,idProduto, idCliente, dataSaida);
            return saida;
        }
        #endregion


        #region Operações Reserva
        private void btncadastrarReservas_Click(object sender, EventArgs e)
        {
            Reserva reserva = InstanciarReserva();
            MessageBox.Show(ReservaBLL.inserir(reserva));
            dataGridViewReservas.DataSource = ReservaBLL.LerTodos();
        }

        private Reserva InstanciarReserva()
        {
            int idCliente = int.Parse(txtnumClienteReserva.Text);
            int idUsuario = Usuario.UsuarioLogado.id;
            DateTime dataPrevistaChegada = DateTimeChegadaReserva.Value;
            DateTime dataPrevistaSaida = dateTimeSaidaReserva.Value;
            int idQuarto = int.Parse(txtnumQuartoReserva.Text);
            Reserva reserva = new Reserva(idCliente, idUsuario, dataPrevistaChegada, dataPrevistaSaida, idQuarto);
            return reserva;
        }
        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            dataGridViewReservas.DataSource = ReservaBLL.LerTodos();
        }
        #endregion

        #region Operações Checkout
        private void btnFinalizarHospedagem_Click(object sender, EventArgs e)
        {
            Checkout checkout = InstanciarCheckout();
            checkoutBLL.inserir(checkout);
            DesocuparQuarto(checkout.idCheckin);
        }

        private void DesocuparQuarto(int idCheckin)
        {
            Checkin checkin= checkinBLL.LerPorID(idCheckin);
            quartoBLL.Desocupar(checkin.quartoId);

        }

        private Checkout InstanciarCheckout()
        {
            //calcular valor total

            int idUsuario = Usuario.UsuarioLogado.id;
            int idCheckin = int.Parse(txtnumeroCheckinCheckout.Text);
            double valorTotal = double.Parse(labelValorTotalPagar.Text);
            DateTime dataaSaida = dateTimeCheckoutDataSaida.Value;
            DateTime dataEntrada = BuscarDataEntrada(idCheckin);
            return new Checkout(idUsuario, idCheckin, valorTotal, dataaSaida, dataEntrada);

        }

        private DateTime BuscarDataEntrada(int idCheckin)
        {
            Checkin checkin=checkinBLL.LerPorID(idCheckin);
            return checkin.dataEntrada;
        }
        #endregion


        #region Operações checkin
        private void btnFazerCheckin_Click(object sender, EventArgs e)
        {
            Checkin checkin = InstanciarCheckin();
            checkinBLL.inserir(checkin);
            quartoBLL.Ocupar(checkin.quartoId);
        }

        private Checkin InstanciarCheckin()
        {
            int idUsuario = Usuario.UsuarioLogado.id;
            DateTime dataEntrada = dateTimeCheckinDataentrada.Value;
            DateTime dataPrevistaSaida = dateTimeDataPSaidaCheckin.Value;
            int idQuarto = int.Parse(txtnumeroQuartoCheckin.Text);
            int idCliente = int.Parse(txtNumeroClienteCheckin.Text);
            int idReserva = int.Parse(txtnumeroReservaCheckin.Text);
            return new Checkin(idUsuario, dataEntrada, dataPrevistaSaida, idQuarto, idCliente, idReserva);

        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

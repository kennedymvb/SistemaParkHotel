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
        EntradaProdutosBLL entradaProdutosBLL = new EntradaProdutosBLL();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            carregarCmbBox();
            if (!Usuario.UsuarioLogado.isAdmin) {
                TabAdministrador.Dispose();
            }
            carregarLabels();
        }
        public Form1(int idCheckin)
        {
            InitializeComponent();
            this.Load += Form1_Load;
            carregarCmbBox();
            if (!Usuario.UsuarioLogado.isAdmin)
            {
                TabAdministrador.Dispose();
            }
            carregarLabels();
        }

        private void carregarLabels()
        {
            lblUsuarioAtual.Text = usuarioBLL.LerPorID(Usuario.UsuarioLogado.id).nome;
        }

        public static int idEntradaCorrespondente;


        private void carregarCmbBox()
        {
            List<String> tipoQuarto = new List<string>();
            tipoQuarto.Add("Comum");
            tipoQuarto.Add("Suite");
            tipoQuarto.Add("Supreme");
            tipoQuarto.Add("Diamante");

            cmbTipoQuarto.DataSource = tipoQuarto;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            esconderDataGridViews();
            
            if (!Usuario.UsuarioLogado.isAdmin)
            {
                this.TabAdministrador.Hide();
            }
            MessageBox.Show("Bem-vindo " + Usuario.UsuarioLogado.nome);
        }

        

        #region Operações Cliente
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = InstanciarCliente();
            MessageBox.Show(clienteBLL.Inserir(cliente));
            this.dataGridView1.Show();
            dataGridView1.DataSource = clienteBLL.LerTodos();
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
            this.dataGridView1.Show();
            dataGridView1.DataSource=clienteBLL.LerTodos();
        }

        int idCliente;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente= (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            txtnomeCliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            txtrgCliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            txtcpfCliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            txttelefone1Cliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            txttelefone2Cliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            txtemailCliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
        }

        private void BtnAtualizarClientes_Click(object sender, EventArgs e)
        {
            Cliente clienteAtualizar = InstanciarCliente();
            clienteAtualizar.id = idCliente;
            MessageBox.Show(clienteBLL.Atualizar(clienteAtualizar));
            dataGridView1.DataSource = clienteBLL.LerTodos();
        }
        #endregion

        #region Operações Fornecedor
        private void btncadastrarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor = InstanciarFornecedor();
            MessageBox.Show(fornecedorBLL.inserir(fornecedor));
            dataGridViewFornecedor.DataSource = fornecedorBLL.LerTodos();
            this.dataGridViewFornecedor.Show();

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
            this.dataGridViewFornecedor.Show();
        }
        int idFornecedor;
        private void dataGridViewFornecedor_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idFornecedor = (int)dataGridViewFornecedor.Rows[e.RowIndex].Cells[0].Value;
            txtrazaoSocial.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[1].Value;
            txtcnpjFornecedor.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[2].Value;
            txtNomecontatoFornecedor.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[6].Value;
            txtTelefoneFornecedor.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[3].Value;
            txtEmailFornecedor.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[4].Value;
        }
        
        private void btnAtualizarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedorAtualizar = InstanciarFornecedor();
            fornecedorAtualizar.id = idFornecedor;
            MessageBox.Show(fornecedorBLL.Atualizar(fornecedorAtualizar));
            dataGridViewFornecedor.DataSource = fornecedorBLL.LerTodos();
        }
        #endregion

        #region produto

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto = InstanciarProduto();
            MessageBox.Show(produtoBLL.inserir(produto));
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

        private void btnCatalogoProdutos_Click(object sender, EventArgs e)
        {
            exibirProdutos();
        }

        private void exibirProdutos()
        {
            dataGridViewProdutos.DataSource = produtoBLL.LerTodos();
            this.dataGridViewProdutos.Show();
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
            try
            {
                dataGridViewQuartos.DataSource = quartoBLL.LerTodos();
                dataGridViewQuartos.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion


        #region Operações Usuário
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = instanciarUsuario();
            MessageBox.Show(usuarioBLL.Inserir(usuario));
            dataGridViewAdministrador.DataSource = usuarioBLL.LerTodos();
            this.dataGridViewAdministrador.Show();
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
            dataGridViewAdministrador.DataSource = usuarioBLL.LerTodos();
            this.dataGridViewAdministrador.Show();

        }
        int idUsuario;
        private void dataGridViewAdministrador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuario = (int)dataGridViewAdministrador.Rows[e.RowIndex].Cells[0].Value;
            txtnomeUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[1].Value;
            txtRGUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[2].Value;
            txtCPFUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[3].Value;
            txtEnderecoUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[4].Value;
            txtTelefoneUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[5].Value;
            txtEmailUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[6].Value;
            txtSenhaUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[7].Value;
        }
        private void atualizarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuarioAtualizar = instanciarUsuario();
            usuarioAtualizar.id = idUsuario;
            MessageBox.Show(usuarioBLL.Atualizar(usuarioAtualizar));
            dataGridViewAdministrador.DataSource = usuarioBLL.LerTodos();
        }
        #endregion


        #region Operações Reserva
        private void btncadastrarReservas_Click(object sender, EventArgs e)
        {
            Reserva reserva = InstanciarReserva();
            MessageBox.Show(ReservaBLL.inserir(reserva));
            dataGridViewReservas.DataSource = ReservaBLL.LerTodos();
            this.dataGridViewReservas.Show();
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
            this.dataGridViewReservas.Show();
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
            try
            {
                checkinBLL.inserir(checkin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //só posso ocupar o quarto após ser inserido o checkin
        }

        private Checkin InstanciarCheckin()
        {
            int idUsuario = Usuario.UsuarioLogado.id;
            DateTime dataEntrada = dateTimeCheckinDataentrada.Value;
            DateTime dataPrevistaSaida = dateTimeDataPSaidaCheckin.Value;
            int idQuarto = int.Parse(txtQuartoCheckin.Text);
            int idCliente = int.Parse(txtNumCliente.Text);
            if (ckbNaoTem.Checked)
            {
                return new Checkin(idUsuario, dataEntrada, dataPrevistaSaida, idQuarto, idCliente);
            }
            int idReserva = int.Parse(txtNumReserva.Text);
            return new Checkin(idUsuario, dataEntrada, dataPrevistaSaida, idQuarto, idCliente, idReserva);
        }
        //
        //
        /// <summary>
        /// Melhorar aqui: reusar lerNaoOcupados.
        /// </summary>
        /// <returns></returns>
        private void dataGridViewQuartosLivres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQuartoCheckin.Text =dataGridViewQuartosLivres.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtQuartoCheckin.Enabled = false;
        }

        private void ckbNaoTem_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNaoTem.Checked)
            {
                txtNumReserva.Enabled = false;
            }
            else
            {
                txtNumReserva.Enabled = true;
            }
        }

        private void BtnPesquisarCliente_Click(object sender, EventArgs e)
        {
            dataGridViewClientesCheckin.Show();
            dataGridViewClientesCheckin.DataSource = clienteBLL.LerTodos();
        }

        private void dataGridViewClientesCheckin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumCliente.Text = dataGridViewClientesCheckin.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNumCliente.Enabled = false;
        }
        private void btnPesquisarQuartosLivres_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewQuartosLivres.DataSource = quartoBLL.LerNaoOcupados();
                dataGridViewQuartosLivres.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion
        private void esconderDataGridViews()
        {
            this.dataGridView1.Hide();
            this.dataGridViewFornecedor.Hide();
            this.dataGridViewProdutos.Hide();
            this.dataGridViewQuartos.Hide();
            this.dataGridViewReservas.Hide();
            this.dataGridViewAdministrador.Hide();
            this.dataGridViewClientesCheckin.Hide();
            this.dataGridViewQuartosLivres.Hide();
            
        }

        

        private void btnExibirEntradas_Click(object sender, EventArgs e)
        {
            dataGridViewEntradaProdutos.DataSource = entradaProdutosBLL.LerTodos();
        }

        private void btnPesquisarCheckin_Click(object sender, EventArgs e)
        {
            FormSelecionarCheckin frm = new FormSelecionarCheckin();
            frm.Show();

        }

        private void btnProximaPagina_Click(object sender, EventArgs e)
        {
            FormSaidaProdutos frmsaida = new FormSaidaProdutos();
            this.Hide();
            frmsaida.Show();
            this.Show();
        }
    }
}

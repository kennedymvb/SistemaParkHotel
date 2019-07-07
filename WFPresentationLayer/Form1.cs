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

        

       




        #region Operações Quarto
        
        
        #endregion


        #region Operações Usuário
       
        #endregion


      

        #region Operações Checkout
        private void btnFinalizarHospedagem_Click(object sender, EventArgs e)
        {
            
        }

        

        

        
        #endregion


        #region Operações checkin
        


        #endregion
       

        

        private void btnExibirEntradas_Click(object sender, EventArgs e)
        {
            dataGridViewEntradaProdutos.DataSource = entradaProdutosBLL.LerTodos();
        }

       

        private void btnProximaPagina_Click(object sender, EventArgs e)
        {
            FormSaidaProdutos frmsaida = new FormSaidaProdutos();
            frmsaida.ShowDialog();
        }

        private void btnFazerCheckout_Click(object sender, EventArgs e)
        {
            FormCheckout frmCheckout = new FormCheckout();
            
            frmCheckout.ShowDialog();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

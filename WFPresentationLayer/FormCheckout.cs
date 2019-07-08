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
using System.Transactions;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormCheckout:Form
    {
        SaidaProdutosBLL saidaProdutosBLL = new SaidaProdutosBLL();

        public FormCheckout()
        {
            InitializeComponent();
            dataGridSelecionarCheckin.Hide();

        }

        CheckoutBLL checkoutBLL = new CheckoutBLL();
        QuartoBLL quartoBLL = new QuartoBLL();
        CheckinBLL checkinBLL = new CheckinBLL();

        private void btnPesquisarCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                atualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro na pesquisa: "+ex.Message);
            }
        }

        private void btnFinalizarHospedagem_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Checkout checkout = InstanciarCheckout();
                    Checkin checkinCorrespondente = getCheckinCorrespondente(checkout);
                    VerificarDuplicidade(checkinCorrespondente);
                    checkoutBLL.inserir(checkout);
                    checkout.valorTotal=checkoutBLL.calcularValorTotal(checkinCorrespondente, checkout);
                    checkoutBLL.atualizarValorTotal(checkout);
                    scope.Complete();
                    MessageBox.Show("O valor total a pagar é: " + checkout.valorTotal.ToString("C2"));
                    atualizarLabelValorTotal(checkout.valorTotal);
                }
                atualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no checkout: "+ex.Message);
            }

        }

        private void atualizarDataGrid()
        {
            dataGridSelecionarCheckin.DataSource = checkinBLL.LerCheckinViewModels();
            dataGridSelecionarCheckin.Show();
        }

        private void VerificarDuplicidade(Checkin checkin)
        {
            if (!checkin.PendenteCheckout)
            {
                atualizarDataGrid();
                throw new Exception("O checkout desse checkin já foi efetuado\n Confira no textBox o id escolhido");
            }
        }

        private Checkin getCheckinCorrespondente(Checkout checkout)
        {
            return checkinBLL.LerPorID(checkout.idCheckin);
        }

        private Checkout InstanciarCheckout()
        {
            //calcular valor total

            int idUsuario = Usuario.UsuarioLogado.id;
            int idCheckin = int.Parse(txtnumeroCheckinCheckout.Text);
            DateTime dataSaida;
            if (lblAgora.Checked)
            {
                dataSaida = DateTime.Now;
            }
            else
            {
                dataSaida = dateTimeCheckoutDataSaida.Value;

            }
            DateTime dataEntrada = BuscarDataEntrada(idCheckin);
            return new Checkout(idUsuario, idCheckin, dataSaida, dataEntrada);
        }
        
        private DateTime BuscarDataEntrada(int idCheckin)
        {
            Checkin checkin = checkinBLL.LerPorID(idCheckin);
            return checkin.dataEntrada;
        }


        private void atualizarLabelValorTotal(double valorTotal)
        {
            labelValorTotalPagar.Text = valorTotal.ToString("C2");
        }

        private void lblAgora_CheckedChanged(object sender, EventArgs e)
        {
            if (lblAgora.Checked)
            {
                dateTimeCheckoutDataSaida.Enabled = false;
            }
            else
            {
                dateTimeCheckoutDataSaida.Enabled = true;
            }
        }

        private void dataGridSelecionarCheckin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnumeroCheckinCheckout.Text = dataGridSelecionarCheckin.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnumeroCheckinCheckout.Enabled = false;
        }
    }
}

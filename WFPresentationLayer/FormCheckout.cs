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
            dataGridSelecionarCheckin.DataSource=checkinBLL.LerCheckinViewModels();
            dataGridSelecionarCheckin.Show();
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
                    checkout.valorTotal=calcularValorTotal(checkinCorrespondente, checkout);
                    checkoutBLL.atualizarValorTotal(checkout);
                    scope.Complete();
                    MessageBox.Show("O valor total a pagar é: " + checkout.valorTotal.ToString("C2"));
                    atualizarLabelValorTotal(checkout.valorTotal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no checkout: "+ex.Message);
            }

        }

        private void VerificarDuplicidade(Checkin checkin)
        {
            if (!checkin.PendenteCheckout)
            {
                throw new Exception("O checkout desse checkin já foi efetuado");
            }
        }

        private Checkin getCheckinCorrespondente(Checkout checkout)
        {
            return checkinBLL.LerPorID(checkout.idCheckin);
        }

        private double calcularValorTotal(Checkin checkin, Checkout checkout)
        {
            return  getValorDiarias(checkin, checkout) + getValorCompras(checkin);
        }

        private double getValorCompras(Checkin checkin)
        {
            double somaTotal = 0;
            int idCheckin = int.Parse(txtnumeroCheckinCheckout.Text);
            List<double> ListaTotalCompras =saidaProdutosBLL.LerPorCheckinId(idCheckin);
            foreach (double item in ListaTotalCompras)
            {
                somaTotal += item;
            }
            return somaTotal;
        }

        private double getValorDiarias(Checkin checkin, Checkout checkout)
        {
            return getTotalDias(checkout) * getvalorDiario(checkin);
        }

        private double getvalorDiario(Checkin checkin)
        {
            return quartoBLL.LerPorID(checkin.quartoId).valorDiaria;
        }

        private double getTotalDias(Checkout checkout)
        {
            DateTime dataEntrada = checkout.dataEntrada;
            DateTime dataSaida = checkout.dataSaida;
            TimeSpan diferenca = dataSaida.Subtract(dataEntrada);
            double totalDias = Math.Ceiling(diferenca.TotalDays);
            return totalDias;
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

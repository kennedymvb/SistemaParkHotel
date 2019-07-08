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
    public partial class FormCheckin : Form
    {
        public FormCheckin()
        {
            InitializeComponent();
        }
        CheckinBLL checkinBLL = new CheckinBLL();
        QuartoBLL quartoBLL = new QuartoBLL();
        ClienteBLL clienteBLL = new ClienteBLL();
        ReservaBLL reservaBLL = new ReservaBLL();

        private void btnFazerCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                Checkin checkin = InstanciarCheckin();
                checkinBLL.inserir(checkin);
                tratarReserva(checkin);
                MessageBox.Show("Checkin efetuado com sucesso");
                atualizarDataGridClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tratarReserva(Checkin checkin)
        {
            Reserva r=reservaBLL.LerPorID(checkin.idReserva);
            r.pendenteCheckout = false;
            reservaBLL.Atualizar(r);
            
        }

        private void btnPendenciasCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                FormSelecionarCheckin frm = new FormSelecionarCheckin(checkinBLL.LerCheckinViewModels());
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro na pesquisa: " + ex.Message);
            }
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
                MessageBox.Show("erro na pesquisa: " + ex.Message);
            }
        }

        private void BtnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                atualizarDataGridClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro na pesquisa: " + ex.Message);
            }
        }

        private Checkin InstanciarCheckin()
        {
            int idUsuario = Usuario.UsuarioLogado.id;
            DateTime dataEntrada = dateTimeCheckinDataentrada.Value;
            if (lblAgora.Checked)
            {
                dataEntrada = DateTime.Now;
            }
            DateTime dataPrevistaSaida = dateTimeDataSaida.Value;
            int idQuarto = int.Parse(txtQuartoCheckin.Text);
            int idCliente = int.Parse(txtNumCliente.Text);
            if (ckbNaoTem.Checked)
            {
                return new Checkin(idUsuario, dataEntrada, dataPrevistaSaida, idQuarto, idCliente);
            }
            int idReserva = int.Parse(txtNumReserva.Text);
            return new Checkin(idUsuario, dataEntrada, dataPrevistaSaida, idQuarto, idCliente, idReserva);
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

        private void dataGridViewClientesCheckin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumCliente.Text = dataGridViewClientesCheckin.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNumCliente.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca: " + ex.Message);
            }
        }

        private void dataGridViewQuartosLivres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQuartoCheckin.Text = dataGridViewQuartosLivres.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtQuartoCheckin.Enabled = false;
        }

        private void lblAgora_CheckedChanged(object sender, EventArgs e)
        {
            if (lblAgora.Checked)
            {
                dateTimeCheckinDataentrada.Enabled = false;
                txtQuartoCheckin.Enabled = false;
            }
            else
            {
                dateTimeCheckinDataentrada.Enabled = true;
                txtQuartoCheckin.Enabled = true;
            }
        }

        private void atualizarDataGridClientes()
        {
            try
            {
                dataGridViewClientesCheckin.DataSource = clienteBLL.lerClientesDisponiveis();
                dataGridViewClientesCheckin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na solicitação");
            }
            
        }

        private void btnPesquisarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                atualizarDataReserva();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no acesso ao banco: " + ex.Message);
            }
        }

        private void atualizarDataReserva()
        {
            dataGridReservas.DataSource = reservaBLL.lerReservasPendentes();
        }

        private void dataGridReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumReserva.Text=dataGridReservas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtQuartoCheckin.Text= dataGridReservas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNumReserva.Enabled = false;
            txtQuartoCheckin.Enabled = false;
            BtnPesquisarCliente.Enabled = false;
            txtNumCliente.Text = reservaBLL.LerPorID(int.Parse(txtNumReserva.Text)).idCliente.ToString();
            txtNumCliente.Enabled = false;

        }
    }
}

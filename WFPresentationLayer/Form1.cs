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
        
        public Form1()
        {
            InitializeComponent();
            if (!Usuario.UsuarioLogado.isAdmin) {
                btnAdministrador.Dispose();
            }
            lblBemVindo.Text = "Bem vindo, " + Usuario.UsuarioLogado.nome + "!";
        }
        FormEntradaProdutos formEntrada = new FormEntradaProdutos();
        FormSaidaProdutos formSaida = new FormSaidaProdutos();
        FormCheckin formCheckin = new FormCheckin();
        FormCheckout formCheckout = new FormCheckout();
        FormUsuarios formUsuarios = new FormUsuarios();
        FormClientes formClientes = new FormClientes();
        FormQuartos formQuartos = new FormQuartos();
        FormReservas formReservas = new FormReservas();
        FormProdutos formProdutos = new FormProdutos();

        private void timer1_Tick(object sender, EventArgs e)
        {
            AjustarHoras();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            formEntrada.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            formSaida.ShowDialog();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            formCheckin.ShowDialog();
        }

        private void btnFazerCheckout_Click(object sender, EventArgs e)
        {
            formCheckout.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            formClientes.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            formProdutos.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            formReservas.ShowDialog();
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            formQuartos.ShowDialog();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            formUsuarios.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEntrada.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSaida.ShowDialog();
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCheckin.ShowDialog();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCheckout.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formClientes.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProdutos.ShowDialog();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReservas.ShowDialog();
        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formQuartos.ShowDialog();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsuarios.ShowDialog();
        }

        private void AjustarHoras()
        {
            string horas;
            string minutos;
            string segundo;

            int hora = int.Parse(DateTime.Now.Hour.ToString());
            int minuto = int.Parse(DateTime.Now.Minute.ToString());
            int segundos = int.Parse(DateTime.Now.Second.ToString());

            if (hora < 10)
            {
                horas = "0" + hora.ToString();
            }
            else
            {
                horas = hora.ToString();
            }
            if (minuto < 10)
            {
                minutos = "0" + minuto.ToString();
            }
            else
            {
                minutos = minuto.ToString();
            }
            if (segundos < 10)
            {
                segundo = "0" + segundos.ToString();
            }
            else
            {
                segundo = segundos.ToString();
            }
            lblHoras.Text = horas + ":" + minutos + ":" + segundo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

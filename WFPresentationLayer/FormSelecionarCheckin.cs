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
    public partial class FormSelecionarCheckin : Form
    {
        public int QuemChamou { get; set; }
        public FormSelecionarCheckin(DataGridView dataGridDia)
        {
            this.QuemChamou = 0;
            InitializeComponent();
            inicializar(dataGridDia);
        }
        public FormSelecionarCheckin()
        {
            this.QuemChamou = 1;
            InitializeComponent();
        }

        private void inicializar(DataGridView dataGridDia)
        {
            dataGridDialog1.DataSource = dataGridDia.DataSource;
        }

        private void dataGridDialog1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (QuemChamou == 0)
            {
                int idCliente = int.Parse(dataGridDialog1.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormSaidaProdutos f = new FormSaidaProdutos(idCliente);
                f.Show();
                this.Dispose();
            }
            else
            {

            }
            
        }

        private void dataGridDialog1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

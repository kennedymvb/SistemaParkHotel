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
    public partial class FormDialog : Form
    {
        public FormDialog(DataGridView dataGridDia)
        {
            InitializeComponent();
            inicializar(dataGridDia);
        }

        private void inicializar(DataGridView dataGridDia)
        {
            dataGridDialog1.DataSource = dataGridDia.DataSource;
        }

        private void dataGridDialog1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCliente = int.Parse(dataGridDialog1.Rows[e.RowIndex].Cells[0].Value.ToString());
            FormSaidaProdutosDetalhes f = new FormSaidaProdutosDetalhes(idCliente);
            f.Show();
            this.Dispose();
        }

        private void dataGridDialog1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

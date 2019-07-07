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
    public partial class FormQuartos : Form
    {
        public FormQuartos()
        {
            InitializeComponent();
        }

        QuartoBLL quartoBLL = new QuartoBLL();

        private void CadastrarQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                Quarto quarto = new Quarto();
                quarto = InstanciarQuarto();
                MessageBox.Show(quartoBLL.inserir(quarto));
                VisualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na solicitação: "+ex.Message);
            }
        }

        private void VisualizarDataGrid()
        {
            dataGridViewQuartos.DataSource = quartoBLL.LerTodos();
            dataGridViewQuartos.Show();
        }

        private void btnExibirQuartos_Click(object sender, EventArgs e)
        {
            try
            {
                VisualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na solicitação: " + ex.Message);
            }
        }

        private Quarto InstanciarQuarto()
        {
            double ValorDiaria = Double.Parse(txtValorDiaria.Text);
            int IDUsuario = Usuario.UsuarioLogado.id;
            string tipoQuarto = cmbTipoQuarto.Text;
            Quarto quarto = new Quarto(ValorDiaria, IDUsuario, tipoQuarto);
            return quarto;
        }
    }
}

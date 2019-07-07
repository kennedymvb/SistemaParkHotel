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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }
        ClienteBLL clienteBLL = new ClienteBLL();

        int idCliente;
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = InstanciarCliente();
            MessageBox.Show(clienteBLL.Inserir(cliente));
            this.dataGridView1.Show();
            dataGridView1.DataSource = clienteBLL.LerTodos();
        }

        private void btnExibirClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Show();
            dataGridView1.DataSource = clienteBLL.LerTodos();
        }

        private void BtnAtualizarClientes_Click(object sender, EventArgs e)
        {
            Cliente clienteAtualizar = InstanciarCliente();
            clienteAtualizar.id = idCliente;
            MessageBox.Show(clienteBLL.Atualizar(clienteAtualizar));
            dataGridView1.DataSource = clienteBLL.LerTodos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            txtnomeCliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            txtrgCliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            txtcpfCliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            txttelefone1Cliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            txttelefone2Cliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            txtemailCliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
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
        
    }
}

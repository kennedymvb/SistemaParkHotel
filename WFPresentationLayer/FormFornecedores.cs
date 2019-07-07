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
    public partial class FormFornecedores : Form
    {
        FornecedorBLL fornecedorBLL = new FornecedorBLL();
        public FormFornecedores()
        {
            InitializeComponent();
        }
        int idFornecedor;
        private void btncadastrarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor = InstanciarFornecedor();
            MessageBox.Show(fornecedorBLL.inserir(fornecedor));
            dataGridViewFornecedor.DataSource = fornecedorBLL.LerTodos();
            this.dataGridViewFornecedor.Show();
        }

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            dataGridViewFornecedor.DataSource = fornecedorBLL.LerTodos();
            this.dataGridViewFornecedor.Show();
        }

        private void btnAtualizarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedorAtualizar = InstanciarFornecedor();
            fornecedorAtualizar.id = idFornecedor;
            MessageBox.Show(fornecedorBLL.Atualizar(fornecedorAtualizar));
            dataGridViewFornecedor.DataSource = fornecedorBLL.LerTodos();
        }

        private void dataGridViewFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idFornecedor = (int)dataGridViewFornecedor.Rows[e.RowIndex].Cells[0].Value;
            txtrazaoSocial.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[1].Value;
            txtcnpjFornecedor.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[2].Value;
            txtNomecontatoFornecedor.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[6].Value;
            txtTelefoneFornecedor.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[3].Value;
            txtEmailFornecedor.Text = (string)dataGridViewFornecedor.Rows[e.RowIndex].Cells[4].Value;
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
        
    }
}

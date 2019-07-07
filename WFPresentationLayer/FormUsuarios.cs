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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        int idUsuario;

        UsuarioBLL usuarioBLL = new UsuarioBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Usuario usuario = instanciarUsuario();
                MessageBox.Show(usuarioBLL.Inserir(usuario));
                VisualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na solicitação: " + ex.Message);
            }
        }

        private void atualizarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuarioAtualizar = instanciarUsuario();
                usuarioAtualizar.id = idUsuario;
                MessageBox.Show(usuarioBLL.Atualizar(usuarioAtualizar));
                VisualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na solicitação: " + ex.Message);
            }
        }

        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                VisualizarDataGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na solicitação: "+ex.Message);
            }
        }

        private void VisualizarDataGrid()
        {
            dataGridViewAdministrador.DataSource = usuarioBLL.LerTodos();
            this.dataGridViewAdministrador.Show();
        }

        private Usuario instanciarUsuario()
        {
            string Nome = txtnomeUsuario.Text;
            string RG = txtRGUsuario.Text;
            string CPF = txtCPFUsuario.Text;
            string Endereco = txtEnderecoUsuario.Text;
            string Telefone = txtTelefoneUsuario.Text;
            string Email = txtEmailUsuario.Text;
            string Senha = txtSenhaUsuario.Text;
            bool IsAdmin = false;
            return new Usuario(Nome, RG, CPF, Endereco, Telefone, Email, Senha, IsAdmin);
        }

        private void dataGridViewAdministrador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuario = (int)dataGridViewAdministrador.Rows[e.RowIndex].Cells[0].Value;
            txtnomeUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[1].Value;
            txtRGUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[2].Value;
            txtCPFUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[3].Value;
            txtEnderecoUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[4].Value;
            txtTelefoneUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[5].Value;
            txtEmailUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[6].Value;
            txtSenhaUsuario.Text = (string)dataGridViewAdministrador.Rows[e.RowIndex].Cells[7].Value;
        }
    }
}

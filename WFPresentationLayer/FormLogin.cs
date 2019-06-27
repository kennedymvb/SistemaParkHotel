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
using Metadata;

namespace WFPresentationLayer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            String senha = txtSenha.Text;
            String email = txtEmail.Text;
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            try
            {
                usuarioBLL.Autenticar(email, senha);
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

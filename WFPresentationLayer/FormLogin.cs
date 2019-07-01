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
            logar();
        }

        private void logar()
        {
            String senha = txtSenha.Text;
            String email = txtEmail.Text;
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            try
            {
                if (usuarioBLL.Autenticar(email, senha))
                {
                    Form1 frm = new Form1();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha errados");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                logar();
            }
        }
    }
}

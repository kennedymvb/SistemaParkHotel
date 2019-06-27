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
            String login = txtUsername.Text;
            bool IsAdmin;
            UsuarioBLL usuarioBLL = new UsuarioBLL();

            List<Usuario> listaUsuarios = usuarioBLL.LerTodos();

            foreach (Usuario user in listaUsuarios)
            {
                if(user.id)
            }

            
            

        }
    }
}

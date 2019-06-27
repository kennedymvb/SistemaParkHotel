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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo " + Usuario.UsuarioLogado.nome);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoquarto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

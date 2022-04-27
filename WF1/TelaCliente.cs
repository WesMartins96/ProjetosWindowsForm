using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lblCliente.Text = txtCliente.Text;
            lblEndereco.Text = txtEndereco.Text;
            lblTelefone.Text = txtTelefone.Text;
            lblEmail.Text = txtEmail.Text;
            lblCpf.Text = txtCpf.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}

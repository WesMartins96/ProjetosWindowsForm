using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            InfoCliente info = new InfoCliente();
            string login = "wesley";
            string senha = "123";
            
            if (txtLogin.Text == login && txtSenha.Text == senha)
            {
                info.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROU O LOGIN/SENHA","Falha ", MessageBoxButtons.OK);
            }

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

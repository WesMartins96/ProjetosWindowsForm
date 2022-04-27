using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string pastaCriada = @"C:\" + txtCriarArquivo.Text;
            if (!Directory.Exists(pastaCriada))
            {
                Directory.CreateDirectory(pastaCriada);
            }
            else
            {
                MessageBox.Show("Pasta já existe", "", MessageBoxButtons.OK);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string deletarPasta = @"C:\" + txtRemoveArquivo.Text;
            if (!Directory.Exists(deletarPasta))
            {
                MessageBox.Show("Pasta não Existe");
            }
            else
            {
                Directory.Delete(deletarPasta);
                MessageBox.Show("Pasta Deletada!");
                txtRemoveArquivo.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            try
            {
                string origem = Path.Combine(@"C:\" + txtOrigem.Text, txtDestino.Text);
                string destino = Path.Combine(@"C:\" + txtDestino.Text, txtOrigem.Text);

                File.Move(origem, destino);
                MessageBox.Show("Arquivo Movido! ALELUIA CONSEGUI, NÃO ACREDITO!!!");

                txtCriarArquivo.Clear();                
                txtDestino.Clear();
                txtOrigem.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

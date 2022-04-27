using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numberOne;
            numberOne = double.Parse(txtNumberOne.Text);
            double numberTwo;
            numberTwo = double.Parse(txtNumberTwo.Text);
            double result = double.Parse(txtResult.Text);
            result = numberOne - numberTwo;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double numberOne;
            numberOne = double.Parse(txtNumberOne.Text);
            double numberTwo;
            numberTwo = double.Parse(txtNumberTwo.Text);
            double result = double.Parse(txtResult.Text);
            result = numberOne / numberTwo;
            
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            double numberOne;
            numberOne = double.Parse(txtNumberOne.Text);
            double numberTwo;
            numberTwo = double.Parse(txtNumberTwo.Text);
            double result = double.Parse(txtResult.Text);
            result = numberOne + numberTwo;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double numberOne;
            numberOne = double.Parse(txtNumberOne.Text);
            double numberTwo;
            numberTwo = double.Parse(txtNumberTwo.Text);
            double result = double.Parse(txtResult.Text);
            result = numberOne * numberTwo;
        }
    }
}

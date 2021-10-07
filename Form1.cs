using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova01_Dalila_Gimenez
{
    public partial class Form1 : Form
    {
        double v1, v2, total;

        public Form1()
        {
            InitializeComponent();
        }

        private void sub_CheckedChanged(object sender, EventArgs e)
        {
            if (num1.Text != "" & num2.Text != "")
            {
                v1 = Convert.ToDouble(num1.Text);
                v2 = Convert.ToDouble(num2.Text);
                total = v1 - v2;
                txtresult.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Insira os valores a ser calculados!");
            }
        }

        private void div_CheckedChanged(object sender, EventArgs e)
        {
        
            if (num1.Text != "" & num2.Text != "")
            {
                v1 = Convert.ToDouble(num1.Text);
                v2 = Convert.ToDouble(num2.Text);
                total = v1 / v2;
                txtresult.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Insira os valores a ser calculados!");
            }
        }

        private void mult_CheckedChanged(object sender, EventArgs e)
        {
            if (num1.Text != "" & num2.Text != "")
            {
                v1 = Convert.ToDouble(num1.Text);
                v2 = Convert.ToDouble(num2.Text);
                total = v1 * v2;
                txtresult.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Insira os valores a ser calculados!");
            }
        }


        private void soma_CheckedChanged(object sender, EventArgs e)
        {
            if (num1.Text != "" & num2.Text != "")
            {
                v1 = Convert.ToDouble(num1.Text);
                v2 = Convert.ToDouble(num2.Text);
                total = v1 + v2;
                txtresult.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Insira os valores a ser calculados!");
            }
        }
       
    }
}

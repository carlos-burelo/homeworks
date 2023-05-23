using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(numero1.Text);
            int num2 = int.Parse(numero2.Text);
            int suma = num1 + num2;
            resultado.Text = "" + suma;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(numero1.Text);
            int num2 = int.Parse(numero2.Text);
            int suma = num1 - num2;
            resultado.Text = "" + suma;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(numero1.Text);
            int num2 = int.Parse(numero2.Text);
            int suma = num1 * num2;
            resultado.Text = "" + suma;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(numero1.Text);
            int num2 = int.Parse(numero2.Text);

            if (num2 == 0) {
                resultado.Text = "No se puede dividir entre 0";
            } else
            {

                int suma = num1 / num2;
                resultado.Text = "" + suma;
            }
        }
    }
}

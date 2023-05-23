using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipoDeTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lado1 = int.Parse(textBox1.Text);
            int lado2 = int.Parse(textBox2.Text);
            int lado3 = int.Parse(textBox3.Text);

            if (lado1 == lado2 && lado2 == lado3)
            {
                label4.Text = "\"El triangulo es Equilatero";
            }
            else if (lado1 == lado2 && lado1 != lado3 || // el ultimo diferente
                lado1 == lado3 && lado2 != lado1 || // el de enmedio diferente
                lado2 == lado3 && lado1 != lado3 // el primero diferente
            )
            {
                label4.Text = "El triangulo es isoceles";
            }
            else
            {
                label4.Text = "El triangulo es esceleno";
            }
        }
    }
}

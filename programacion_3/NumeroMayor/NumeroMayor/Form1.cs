using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroMayor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);
            if (num1 > num2 && num1 > num3)
            {
                result.Text = "El primero es mayor";
            }
            else if (num2 > num1 && num2 > num3)
            {
                result.Text = "El segundo es mayor";
            }
            else
            {
                result.Text = "El tercero es mayor";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            if (num1 <  num2) {
                label3.Text = "El hermano 2 es mayor";
            } else
            {
                label3.Text = "El hermano 1 es mayor";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

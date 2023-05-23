using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incentivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lunes = int.Parse(textBox1.Text);
            int martes = int.Parse(textBox1.Text);
            int miercoles = int.Parse(textBox1.Text);
            int jueves = int.Parse(textBox1.Text);
            int viernes = int.Parse(textBox1.Text);
            int sabado = int.Parse(textBox1.Text);
            float promedio = (lunes + martes + miercoles + jueves + viernes + sabado) / 6;

            if (promedio > 100)
            {
                label7.Text ="El operario recibira incentivo";
            }
            else
            {
                label7.Text = "El operario no recibira incentivo";
            }
        }
    }
}

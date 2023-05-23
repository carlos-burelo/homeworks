using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class HermanoExample : UserControl {
    public HermanoExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      int num1 = int.Parse(textBox1.Text);
      int num2 = int.Parse(textBox2.Text);
      if (num1 < num2) {
        label3.Text = "El hermano 2 es mayor";
      } else {
        label3.Text = "El hermano 1 es mayor";
      }
    }
  }
}

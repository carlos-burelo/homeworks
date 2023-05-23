using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class NumeroMayorExample : UserControl {
    public NumeroMayorExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      int num1 = int.Parse(textBox1.Text);
      int num2 = int.Parse(textBox2.Text);
      int num3 = int.Parse(textBox3.Text);
      if (num1 > num2 && num1 > num3) {
        result.Text = "El primero es mayor";
      } else if (num2 > num1 && num2 > num3) {
        result.Text = "El segundo es mayor";
      } else {
        result.Text = "El tercero es mayor";
      }
    }
  }
}

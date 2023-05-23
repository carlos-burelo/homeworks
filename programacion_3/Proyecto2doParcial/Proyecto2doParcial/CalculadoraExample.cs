using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class CalculadoraExample : UserControl {
    public CalculadoraExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      int num1 = int.Parse(numero1.Text);
      int num2 = int.Parse(numero2.Text);
      int suma = num1 + num2;
      resultado.Text = "" + suma;
    }

    private void Button2_Click (object sender, EventArgs e) {
      int num1 = int.Parse(numero1.Text);
      int num2 = int.Parse(numero2.Text);
      int suma = num1 - num2;
      resultado.Text = "" + suma;
    }

    private void Button3_Click (object sender, EventArgs e) {
      int num1 = int.Parse(numero1.Text);
      int num2 = int.Parse(numero2.Text);
      int suma = num1 * num2;
      resultado.Text = "" + suma;
    }

    private void Button4_Click (object sender, EventArgs e) {
      int num1 = int.Parse(numero1.Text);
      int num2 = int.Parse(numero2.Text);

      if (num2 == 0) {
        resultado.Text = "No se puede dividir entre 0";
      } else {
        int suma = num1 / num2;
        resultado.Text = "" + suma;
      }
    }
  }
}

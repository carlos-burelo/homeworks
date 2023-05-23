using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class TipoTrianguloExample : UserControl {
    public TipoTrianguloExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      int lado1 = int.Parse(textBox1.Text);
      int lado2 = int.Parse(textBox2.Text);
      int lado3 = int.Parse(textBox3.Text);

      if (lado1 == lado2 && lado2 == lado3) {
        label4.Text = "\"El triangulo es Equilatero";
      } else if (lado1 == lado2 && lado1 != lado3 || // el ultimo diferente
            lado1 == lado3 && lado2 != lado1 || // el de enmedio diferente
            lado2 == lado3 && lado1 != lado3 // el primero diferente
        ) {
        label4.Text = "El triangulo es isoceles";
      } else {
        label4.Text = "El triangulo es esceleno";
      }
    }
  }
}

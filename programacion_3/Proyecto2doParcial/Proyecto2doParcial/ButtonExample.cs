using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class ButtonExample : UserControl {
    public ButtonExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      int numero1 = int.Parse(this.n1.Text);
      int numero2 = int.Parse(this.n2.Text);
      this.resultado.Text = "" + (numero1 + numero2);
    }

    private void Button2_Click (object sender, EventArgs e) {
      int numero1 = int.Parse(this.n1.Text);
      int numero2 = int.Parse(this.n2.Text);
      this.resultado.Text = "" + (numero1 - numero2);
    }

    private void Button3_Click (object sender, EventArgs e) {
      int numero1 = int.Parse(this.n1.Text);
      int numero2 = int.Parse(this.n2.Text);
      this.resultado.Text = "" + (numero1 * numero2);
    }

    private void Button4_Click (object sender, EventArgs e) {
      int numero1 = int.Parse(this.n1.Text);
      int numero2 = int.Parse(this.n2.Text);
      if (numero2 <= 0) {
        this.resultado.Text = "No calculable";
      } else {
        float result = (float)numero2 / (float)numero1;
        this.resultado.Text = "" + result;
      }
    }
  }
}

using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class TextBoxExample : UserControl {
    public TextBoxExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      int num1 = int.Parse(this.n1.Text);
      int num2 = int.Parse(this.n2.Text);
      int result = num1 + num2;
      string res = result.ToString();
      this.result.Text = "El resultado es: " + res;
    }
  }
}

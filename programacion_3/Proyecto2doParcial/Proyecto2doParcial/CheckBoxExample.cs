using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class CheckBoxExample : UserControl {
    public CheckBoxExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      int precio = 0;
      if (checkBox1.Checked)
        precio += 100;
      if (checkBox2.Checked)
        precio += 200;
      if (checkBox3.Checked)
        precio += 250;
      resultado.Text = "El precio del servicio es: $" + precio.ToString();
    }
  }
}

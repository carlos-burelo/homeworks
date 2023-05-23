using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class IncentivosExample : UserControl {
    public IncentivosExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      int lunes = int.Parse(textBox1.Text);
      int martes = int.Parse(textBox1.Text);
      int miercoles = int.Parse(textBox1.Text);
      int jueves = int.Parse(textBox1.Text);
      int viernes = int.Parse(textBox1.Text);
      int sabado = int.Parse(textBox1.Text);
      float promedio = (lunes + martes + miercoles + jueves + viernes + sabado) / 6;

      if (promedio > 100) {
        label7.Text = "El operario recibira incentivo";
      } else {
        label7.Text = "El operario no recibira incentivo";
      }
    }
  }
}

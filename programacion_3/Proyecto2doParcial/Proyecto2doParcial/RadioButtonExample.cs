using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class RadioButtonExample : UserControl {
    public RadioButtonExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, System.EventArgs e) {
      if (radioButton1.Checked) {
        MessageBox.Show("Compra realizada");
      } else {
        MessageBox.Show("Compra cancelada");
      }
    }
  }
}

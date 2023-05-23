using System.Windows.Forms;

namespace Exposicion3 {
  public partial class Form1 : Form {
    public Form1 () {
      InitializeComponent();
    }

    private void Image1Btn_Click (object sender, System.EventArgs e) {
      this.pictureBox1.Image = Properties.Resources._20493729;
    }

    private void Image2Btn_Click (object sender, System.EventArgs e) {
      this.pictureBox1.Image = Properties.Resources.R;
    }

    private void AddToCardBtn_Click (object sender, System.EventArgs e) {
      if (listaCompras.Items.Count > 0) {
        foreach (string item in listaCompras.CheckedItems) {
          listaMateriales.Items.Add(item.ToString());
        }
        for (int i = 0; i > listaCompras.Items.Count; i++) {
          listaMateriales.SetItemChecked(i, false);
        }
      }
    }

    private void ClearBtn_Click (object sender, System.EventArgs e) {
      listaMateriales.Items.Clear();
    }

    private void Button1_Click (object sender, System.EventArgs e) {
      if (acceptPayment.Checked) {
        MessageBox.Show("Compra realizada");
      } else {
        MessageBox.Show("Compra cancelada");
      }
    }
  }
}

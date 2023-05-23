using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class PictureBoxExample : UserControl {
    public PictureBoxExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      this.pictureBox1.Image = Properties.Resources.cafe1;
    }

    private void Button2_Click (object sender, EventArgs e) {
      this.pictureBox1.Image = Properties.Resources.cafe2;
    }
  }
}

using System;
using System.Windows.Forms;

namespace Exposicion4 {
  public partial class Form1 : Form {
    public Form1 () {
      InitializeComponent();
      this.comboBox1.Text = "Apple";
    }

    private void SumBtn_Click (object sender, EventArgs e) {
      int num1 = int.Parse(this.num1.Text);
      int num2 = int.Parse(this.num2.Text);
      int result = num1 + num2;
      string res = result.ToString();
      this.result.Text = "El resultado es: " + res;
    }
  }
}

using System.Windows.Forms;

namespace Menu {
  public partial class Form1 : Form {
    public Form1 () {
      InitializeComponent();
    }
    private void Btn1_Click (object sender, System.EventArgs e) {
      spc.Panel2.Controls.Clear();
      spc.Panel2.Controls.Add(new ButtonExample());
    }
    private void Btn2_Click (object sender, System.EventArgs e) {
      spc.Panel2.Controls.Clear();
      spc.Panel2.Controls.Add(new CheckBoxExample());
    }
  }
}

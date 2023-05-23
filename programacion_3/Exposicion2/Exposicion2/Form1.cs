using System;
using System.Windows.Forms;

namespace Exposicion2 {
  public partial class Form1 : Form {
    public Form1 () {
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
      label2.Text = "El precio del servicio es: $" + precio.ToString();
    }
    private void Button2_Click (object sender, EventArgs e) {
      treeView1.Nodes.Add(textBox1.Text);
      textBox1.Text = "";
    }
    private void Button3_Click (object sender, EventArgs e) {
      treeView1.SelectedNode.Nodes.Add(textBox2.Text);
      textBox2.Text = "";
    }
    private void button4_Click (object sender, EventArgs e) {
      treeView1.Nodes.Clear();
    }
    private void button5_Click (object sender, EventArgs e) {
      treeView1.Nodes.Remove(treeView1.SelectedNode);
    }
  }
}
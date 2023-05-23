using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class TreeViewExample : UserControl {
    public TreeViewExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, System.EventArgs e) {
      TreeNode currentNode = treeView1.Nodes.Add(textBox1.Text);
      textBox1.Text = "";
      // cambia el nodo seleccionado al nodo recién creado
      treeView1.SelectedNode = currentNode;
    }

    private void Button2_Click (object sender, System.EventArgs e) {
      treeView1.SelectedNode.Nodes.Add(textBox2.Text);
      textBox2.Text = "";
    }

    private void Button3_Click (object sender, System.EventArgs e) {
      treeView1.Nodes.Remove(treeView1.SelectedNode);
    }

    private void Button4_Click (object sender, System.EventArgs e) {
      treeView1.Nodes.Clear();
    }
  }
}

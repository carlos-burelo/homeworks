using System;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class CheckedListBoxExample : UserControl {
    public CheckedListBoxExample () {
      InitializeComponent();
    }

    private void Button1_Click (object sender, EventArgs e) {
      if (listaMateriales.Items.Count > 0) {
        foreach (string item in listaMateriales.CheckedItems) {
          listaCompras.Items.Add(item.ToString());
        }
        for (int i = 0; i > listaMateriales.Items.Count; i++) {
          listaCompras.SetItemChecked(i, false);
        }
      }
    }

    private void Button2_Click (object sender, EventArgs e) {
      listaCompras.Items.Clear();
    }
  }
}

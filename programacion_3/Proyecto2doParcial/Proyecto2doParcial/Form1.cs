using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class Form1 : Form {
    public Form1 () {
      InitializeComponent();
      GetItems();
      this.splitContainer1.Panel2.Controls.Add(new Default());
    }

    readonly Dictionary<string, UserControl> items = new Dictionary<string, UserControl> {
      // 1er parcial
      { "Calculadora", new CalculadoraExample() },
      { "Caricatura", new CaricaturaExample() },
      { "Hermano", new HermanoExample() },
      { "Tipo de triangulo", new TipoTrianguloExample() },
      { "Incentivos", new IncentivosExample() },
      { "Numero mayor", new NumeroMayorExample() },
      // 2do parcial
      { "Button", new ButtonExample() },
      { "ToolTip", new ToolTipExample() },
      { "CheckBox", new CheckBoxExample() },
      { "TreeView", new TreeViewExample() },
      { "CheckedListBox", new CheckedListBoxExample() },
      { "PictureBox", new PictureBoxExample() },
      { "RadioButton", new RadioButtonExample() },
      { "Label", new LabelExample() },
      { "TextBox", new TextBoxExample() },
      { "ComboBox", new ComboBoxExample() }
    };


    private void GetItems () {
      // Creamos un diccionario para guardar el Elemento asociado a su nombre
      foreach (ToolStripMenuItem menuItem in menuStrip1.Items) {
        foreach (ToolStripItem subItem in menuItem.DropDownItems) {
          subItem.Click += new EventHandler(SubItemEventHandler);
          foreach (ToolStripItem subSubItem in ((ToolStripMenuItem)subItem).DropDownItems) {
            subSubItem.Click += new EventHandler(SubItemEventHandler);
          }
        }
      }
    }

    private void SubItemEventHandler (object sender, EventArgs e) {
      // Obtener el nombre del subitem
      ToolStripItem subItem = (ToolStripItem)sender;
      string subItemName = subItem.Text;
      // Mostrar el nombre del subitem en el título del formulario
      Text = subItemName;
      // Obtener el elemento asociado al nombre del subitem dentro de un bloque try/catch para evitar errores
      try {
        UserControl item = items[subItemName];
        splitContainer1.Panel2.Controls.Clear();
        splitContainer1.Panel2.Controls.Add(item);
      } catch (Exception) {
        // Si no se encuentra el elemento, mostrar un mensaje de error
        MessageBox.Show("No se encontró el elemento");
      }
    }
  }
}

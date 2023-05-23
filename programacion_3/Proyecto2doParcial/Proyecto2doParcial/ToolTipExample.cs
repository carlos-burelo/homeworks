using System.Windows.Forms;

namespace Proyecto2doParcial {
  public partial class ToolTipExample : UserControl {
    public ToolTipExample () {
      InitializeComponent();
      // Crear un ToolTip y asociarlo al Formulario.
      ToolTip toolTip1 = new ToolTip();
      // Establecer el retraso para el ToolTip.
      toolTip1.InitialDelay = 1000;
      // Establecer el tiempo que el ToolTip permanecerá visible si el cursor está sobre el control.
      toolTip1.AutoPopDelay = 5000;
      // Establecer el tiempo que el ToolTip tardará en aparecer.
      toolTip1.ReshowDelay = 100;
      toolTip1.SetToolTip(this.button1, "Hello, I am a ToolTip!");
    }
  }
}

namespace Proyecto2doParcial {
  partial class CheckBoxExample {
    /// <summary> 
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose (bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de componentes

    /// <summary> 
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent () {
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.button1 = new System.Windows.Forms.Button();
      this.resultado = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBox1.Location = new System.Drawing.Point(108, 80);
      this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(118, 21);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "Checkeo $100";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBox2.Location = new System.Drawing.Point(108, 127);
      this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(155, 21);
      this.checkBox2.TabIndex = 1;
      this.checkBox2.Text = "Mantenimiento $200";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBox3.Location = new System.Drawing.Point(108, 174);
      this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(168, 21);
      this.checkBox3.TabIndex = 2;
      this.checkBox3.Text = "Cambio de pieza $250";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(108, 225);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(89, 31);
      this.button1.TabIndex = 3;
      this.button1.Text = "Calcular";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // resultado
      // 
      this.resultado.AutoSize = true;
      this.resultado.Location = new System.Drawing.Point(297, 131);
      this.resultado.Name = "resultado";
      this.resultado.Size = new System.Drawing.Size(0, 17);
      this.resultado.TabIndex = 4;
      // 
      // CheckBoxExample
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.resultado);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.checkBox3);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.checkBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "CheckBoxExample";
      this.Size = new System.Drawing.Size(591, 378);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label resultado;
  }
}

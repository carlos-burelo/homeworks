﻿namespace Proyecto2doParcial {
  partial class TextBoxExample {
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
      this.n1 = new System.Windows.Forms.TextBox();
      this.n2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.result = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // n1
      // 
      this.n1.Location = new System.Drawing.Point(58, 125);
      this.n1.Name = "n1";
      this.n1.Size = new System.Drawing.Size(100, 20);
      this.n1.TabIndex = 0;
      // 
      // n2
      // 
      this.n2.Location = new System.Drawing.Point(58, 179);
      this.n2.Name = "n2";
      this.n2.Size = new System.Drawing.Size(100, 20);
      this.n2.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(58, 106);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Numero 1";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(58, 163);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Numero 2";
      // 
      // result
      // 
      this.result.AutoSize = true;
      this.result.Location = new System.Drawing.Point(192, 148);
      this.result.Name = "result";
      this.result.Size = new System.Drawing.Size(0, 13);
      this.result.TabIndex = 4;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(58, 217);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Sumar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // UserControl2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.button1);
      this.Controls.Add(this.result);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.n2);
      this.Controls.Add(this.n1);
      this.Name = "UserControl2";
      this.Size = new System.Drawing.Size(434, 318);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox n1;
    private System.Windows.Forms.TextBox n2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label result;
    private System.Windows.Forms.Button button1;
  }
}

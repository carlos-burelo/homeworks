namespace Proyecto2doParcial {
  partial class CalculadoraExample {
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
      this.numero2 = new System.Windows.Forms.TextBox();
      this.numero1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.resultado = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // numero2
      // 
      this.numero2.Location = new System.Drawing.Point(40, 98);
      this.numero2.Name = "numero2";
      this.numero2.Size = new System.Drawing.Size(100, 20);
      this.numero2.TabIndex = 0;
      // 
      // numero1
      // 
      this.numero1.Location = new System.Drawing.Point(40, 53);
      this.numero1.Name = "numero1";
      this.numero1.Size = new System.Drawing.Size(100, 20);
      this.numero1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(40, 138);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(44, 41);
      this.button1.TabIndex = 2;
      this.button1.Text = "+";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(90, 138);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(44, 41);
      this.button2.TabIndex = 3;
      this.button2.Text = "-";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Button2_Click);
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.Location = new System.Drawing.Point(40, 185);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(44, 41);
      this.button3.TabIndex = 4;
      this.button3.Text = "*";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.Button3_Click);
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.Location = new System.Drawing.Point(90, 185);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(44, 41);
      this.button4.TabIndex = 5;
      this.button4.Text = "/";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.Button4_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(40, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Numero 1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(40, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Numero 2";
      // 
      // resultado
      // 
      this.resultado.AutoSize = true;
      this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resultado.Location = new System.Drawing.Point(171, 80);
      this.resultado.Name = "resultado";
      this.resultado.Size = new System.Drawing.Size(0, 25);
      this.resultado.TabIndex = 8;
      // 
      // CalculadoraExample
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.resultado);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.numero1);
      this.Controls.Add(this.numero2);
      this.Name = "CalculadoraExample";
      this.Size = new System.Drawing.Size(430, 341);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox numero2;
    private System.Windows.Forms.TextBox numero1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label resultado;
  }
}

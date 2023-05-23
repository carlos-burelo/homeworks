namespace Exposicion4 {
  partial class Form1 {
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

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent () {
      this.label1 = new System.Windows.Forms.Label();
      this.num1 = new System.Windows.Forms.TextBox();
      this.num2 = new System.Windows.Forms.TextBox();
      this.sumBtn = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.result = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(37, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 27);
      this.label1.TabIndex = 0;
      this.label1.Text = "Test Form";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // num1
      // 
      this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num1.Location = new System.Drawing.Point(34, 92);
      this.num1.Name = "num1";
      this.num1.Size = new System.Drawing.Size(201, 23);
      this.num1.TabIndex = 1;
      // 
      // num2
      // 
      this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.num2.Location = new System.Drawing.Point(34, 158);
      this.num2.Name = "num2";
      this.num2.Size = new System.Drawing.Size(201, 23);
      this.num2.TabIndex = 2;
      // 
      // sumBtn
      // 
      this.sumBtn.Location = new System.Drawing.Point(34, 201);
      this.sumBtn.Name = "sumBtn";
      this.sumBtn.Size = new System.Drawing.Size(75, 23);
      this.sumBtn.TabIndex = 3;
      this.sumBtn.Text = "Sumar";
      this.sumBtn.UseVisualStyleBackColor = true;
      this.sumBtn.Click += new System.EventHandler(this.SumBtn_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(34, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Numero  1";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(34, 139);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Numero 2";
      // 
      // result
      // 
      this.result.AutoSize = true;
      this.result.Location = new System.Drawing.Point(264, 139);
      this.result.Name = "result";
      this.result.Size = new System.Drawing.Size(0, 13);
      this.result.TabIndex = 6;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Samsung",
            "Nokia",
            "Motorola",
            "LG",
            "Apple"});
      this.comboBox1.Location = new System.Drawing.Point(340, 94);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 7;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(580, 300);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.result);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.sumBtn);
      this.Controls.Add(this.num2);
      this.Controls.Add(this.num1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = " ";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox num1;
    private System.Windows.Forms.TextBox num2;
    private System.Windows.Forms.Button sumBtn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label result;
    private System.Windows.Forms.ComboBox comboBox1;
  }
}


using System.Drawing;

namespace Menu {
  partial class Form1 {

    private System.ComponentModel.IContainer components = null;

    protected override void Dispose (bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    private void InitializeComponent () {
      this.spc = new System.Windows.Forms.SplitContainer();
      this.label1 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.btn1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.spc)).BeginInit();
      this.spc.Panel1.SuspendLayout();
      this.spc.SuspendLayout();
      this.SuspendLayout();
      // 
      // spc
      // 
      this.spc.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spc.Location = new System.Drawing.Point(0, 0);
      this.spc.Name = "spc";
      // 
      // spc.Panel1
      // 
      this.spc.Panel1.BackColor = System.Drawing.SystemColors.Window;
      this.spc.Panel1.Controls.Add(this.label1);
      this.spc.Panel1.Controls.Add(this.button4);
      this.spc.Panel1.Controls.Add(this.button3);
      this.spc.Panel1.Controls.Add(this.btn2);
      this.spc.Panel1.Controls.Add(this.btn1);
      // 
      // spc.Panel2
      // 
      this.spc.Panel2.BackColor = System.Drawing.SystemColors.Window;
      this.spc.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.spc.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.spc.Size = new System.Drawing.Size(755, 425);
      this.spc.SplitterDistance = 189;
      this.spc.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(113, 28);
      this.label1.TabIndex = 4;
      this.label1.Text = "1er Parcial";
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.button4.Location = new System.Drawing.Point(12, 217);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(123, 43);
      this.button4.TabIndex = 3;
      this.button4.Text = "Label";
      this.button4.UseVisualStyleBackColor = false;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.button3.Location = new System.Drawing.Point(12, 161);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(123, 43);
      this.button3.TabIndex = 2;
      this.button3.Text = "CheckedListBox";
      this.button3.UseVisualStyleBackColor = false;
      // 
      // btn2
      // 
      this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btn2.Location = new System.Drawing.Point(12, 105);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(123, 43);
      this.btn2.TabIndex = 1;
      this.btn2.Text = "CheckBox";
      this.btn2.UseVisualStyleBackColor = false;
      this.btn2.Click += new System.EventHandler(this.Btn2_Click);
      // 
      // btn1
      // 
      this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btn1.Location = new System.Drawing.Point(12, 49);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(123, 43);
      this.btn1.TabIndex = 0;
      this.btn1.Text = "Button";
      this.btn1.UseVisualStyleBackColor = false;
      this.btn1.Click += new System.EventHandler(this.Btn1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(755, 425);
      this.Controls.Add(this.spc);
      this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.Opacity = 0.99D;
      this.Text = "Menu";
      this.spc.Panel1.ResumeLayout(false);
      this.spc.Panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spc)).EndInit();
      this.spc.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer spc;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Label label1;
  }
}


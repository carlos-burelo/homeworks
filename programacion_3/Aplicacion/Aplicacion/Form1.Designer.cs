namespace Aplicacion {
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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ejemplo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ejemplo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ejemplo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.exposicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.menuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
      this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
      this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
      this.splitContainer1.Panel2.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.splitContainer1.Size = new System.Drawing.Size(680, 372);
      this.splitContainer1.SplitterDistance = 256;
      this.splitContainer1.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplosToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(20, 44);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(216, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // ejemplosToolStripMenuItem
      // 
      this.ejemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplo1ToolStripMenuItem,
            this.ejemplo2ToolStripMenuItem,
            this.ejemplo3ToolStripMenuItem});
      this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
      this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.ejemplosToolStripMenuItem.Text = "Ejemplos";
      // 
      // ejemplo1ToolStripMenuItem
      // 
      this.ejemplo1ToolStripMenuItem.Name = "ejemplo1ToolStripMenuItem";
      this.ejemplo1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.ejemplo1ToolStripMenuItem.Text = "Ejemplo 1";
      // 
      // ejemplo2ToolStripMenuItem
      // 
      this.ejemplo2ToolStripMenuItem.Name = "ejemplo2ToolStripMenuItem";
      this.ejemplo2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.ejemplo2ToolStripMenuItem.Text = "Ejemplo 2";
      // 
      // ejemplo3ToolStripMenuItem
      // 
      this.ejemplo3ToolStripMenuItem.Name = "ejemplo3ToolStripMenuItem";
      this.ejemplo3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.ejemplo3ToolStripMenuItem.Text = "Ejemplo 3";
      // 
      // menuStrip2
      // 
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exposicionesToolStripMenuItem});
      this.menuStrip2.Location = new System.Drawing.Point(20, 20);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(216, 24);
      this.menuStrip2.TabIndex = 1;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // exposicionesToolStripMenuItem
      // 
      this.exposicionesToolStripMenuItem.Name = "exposicionesToolStripMenuItem";
      this.exposicionesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
      this.exposicionesToolStripMenuItem.Text = "Exposiciones";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
      this.ClientSize = new System.Drawing.Size(680, 372);
      this.Controls.Add(this.splitContainer1);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem ejemplosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ejemplo1ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ejemplo2ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ejemplo3ToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem exposicionesToolStripMenuItem;
  }
}


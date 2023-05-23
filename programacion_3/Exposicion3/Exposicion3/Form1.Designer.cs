namespace Exposicion3 {
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
      this.image1Btn = new System.Windows.Forms.Button();
      this.image2Btn = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.listaCompras = new System.Windows.Forms.CheckedListBox();
      this.listaMateriales = new System.Windows.Forms.CheckedListBox();
      this.addToCardBtn = new System.Windows.Forms.Button();
      this.clearBtn = new System.Windows.Forms.Button();
      this.acceptPayment = new System.Windows.Forms.RadioButton();
      this.deniedPayment = new System.Windows.Forms.RadioButton();
      this.button1 = new System.Windows.Forms.Button();
      this.labelPayment = new System.Windows.Forms.Label();
      this.labelListaCompras = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // image1Btn
      // 
      this.image1Btn.Location = new System.Drawing.Point(304, 372);
      this.image1Btn.Name = "image1Btn";
      this.image1Btn.Size = new System.Drawing.Size(75, 23);
      this.image1Btn.TabIndex = 1;
      this.image1Btn.Text = "Imagen 1";
      this.image1Btn.UseVisualStyleBackColor = true;
      this.image1Btn.Click += new System.EventHandler(this.Image1Btn_Click);
      // 
      // image2Btn
      // 
      this.image2Btn.Location = new System.Drawing.Point(304, 415);
      this.image2Btn.Name = "image2Btn";
      this.image2Btn.Size = new System.Drawing.Size(75, 23);
      this.image2Btn.TabIndex = 2;
      this.image2Btn.Text = "Imagen 2";
      this.image2Btn.UseVisualStyleBackColor = true;
      this.image2Btn.Click += new System.EventHandler(this.Image2Btn_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackgroundImage = global::Exposicion3.Properties.Resources._20493729;
      this.pictureBox1.Image = global::Exposicion3.Properties.Resources.R;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(262, 426);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // listaCompras
      // 
      this.listaCompras.FormattingEnabled = true;
      this.listaCompras.Items.AddRange(new object[] {
            "Lapiz",
            "Borrador",
            "Boligrafo",
            "Colores"});
      this.listaCompras.Location = new System.Drawing.Point(320, 104);
      this.listaCompras.Name = "listaCompras";
      this.listaCompras.Size = new System.Drawing.Size(120, 94);
      this.listaCompras.TabIndex = 3;
      // 
      // listaMateriales
      // 
      this.listaMateriales.FormattingEnabled = true;
      this.listaMateriales.Location = new System.Drawing.Point(651, 104);
      this.listaMateriales.Name = "listaMateriales";
      this.listaMateriales.Size = new System.Drawing.Size(120, 94);
      this.listaMateriales.TabIndex = 4;
      // 
      // addToCardBtn
      // 
      this.addToCardBtn.Location = new System.Drawing.Point(456, 104);
      this.addToCardBtn.Name = "addToCardBtn";
      this.addToCardBtn.Size = new System.Drawing.Size(75, 39);
      this.addToCardBtn.TabIndex = 5;
      this.addToCardBtn.Text = "Agregar compras";
      this.addToCardBtn.UseVisualStyleBackColor = true;
      this.addToCardBtn.Click += new System.EventHandler(this.AddToCardBtn_Click);
      // 
      // clearBtn
      // 
      this.clearBtn.Location = new System.Drawing.Point(456, 160);
      this.clearBtn.Name = "clearBtn";
      this.clearBtn.Size = new System.Drawing.Size(75, 23);
      this.clearBtn.TabIndex = 6;
      this.clearBtn.Text = "Limpiar";
      this.clearBtn.UseVisualStyleBackColor = true;
      this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
      // 
      // acceptPayment
      // 
      this.acceptPayment.AutoSize = true;
      this.acceptPayment.Location = new System.Drawing.Point(487, 245);
      this.acceptPayment.Name = "acceptPayment";
      this.acceptPayment.Size = new System.Drawing.Size(34, 17);
      this.acceptPayment.TabIndex = 7;
      this.acceptPayment.TabStop = true;
      this.acceptPayment.Text = "Si";
      this.acceptPayment.UseVisualStyleBackColor = true;
      // 
      // deniedPayment
      // 
      this.deniedPayment.AutoSize = true;
      this.deniedPayment.Location = new System.Drawing.Point(487, 269);
      this.deniedPayment.Name = "deniedPayment";
      this.deniedPayment.Size = new System.Drawing.Size(39, 17);
      this.deniedPayment.TabIndex = 8;
      this.deniedPayment.TabStop = true;
      this.deniedPayment.Text = "No";
      this.deniedPayment.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(500, 312);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "Resultado";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // labelPayment
      // 
      this.labelPayment.AutoSize = true;
      this.labelPayment.Location = new System.Drawing.Point(484, 219);
      this.labelPayment.Name = "labelPayment";
      this.labelPayment.Size = new System.Drawing.Size(91, 13);
      this.labelPayment.TabIndex = 10;
      this.labelPayment.Text = "¿Desea comprar?";
      // 
      // labelListaCompras
      // 
      this.labelListaCompras.AutoSize = true;
      this.labelListaCompras.Location = new System.Drawing.Point(318, 82);
      this.labelListaCompras.Name = "labelListaCompras";
      this.labelListaCompras.Size = new System.Drawing.Size(94, 13);
      this.labelListaCompras.TabIndex = 11;
      this.labelListaCompras.Text = "Lista de materiales";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(648, 82);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 13);
      this.label1.TabIndex = 12;
      this.label1.Text = "Lista de compras";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.labelListaCompras);
      this.Controls.Add(this.labelPayment);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.deniedPayment);
      this.Controls.Add(this.acceptPayment);
      this.Controls.Add(this.clearBtn);
      this.Controls.Add(this.addToCardBtn);
      this.Controls.Add(this.listaMateriales);
      this.Controls.Add(this.listaCompras);
      this.Controls.Add(this.image2Btn);
      this.Controls.Add(this.image1Btn);
      this.Controls.Add(this.pictureBox1);
      this.Name = "Form1";
      this.Text = "Exposicion 3";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button image1Btn;
    private System.Windows.Forms.Button image2Btn;
    private System.Windows.Forms.CheckedListBox listaCompras;
    private System.Windows.Forms.CheckedListBox listaMateriales;
    private System.Windows.Forms.Button addToCardBtn;
    private System.Windows.Forms.Button clearBtn;
    private System.Windows.Forms.RadioButton acceptPayment;
    private System.Windows.Forms.RadioButton deniedPayment;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label labelPayment;
    private System.Windows.Forms.Label labelListaCompras;
    private System.Windows.Forms.Label label1;
  }
}


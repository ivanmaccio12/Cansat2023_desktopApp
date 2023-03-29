namespace Cansat2023
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.velocimetro1 = new TestGdiSpeedometerApp.GDISpeedometer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // velocimetro1
            // 
            this.velocimetro1.CurrentValueFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.velocimetro1.Font = new System.Drawing.Font("Arial", 8F);
            this.velocimetro1.GaugeColor = System.Drawing.Color.Black;
            this.velocimetro1.GaugeThickness = 3;
            this.velocimetro1.Location = new System.Drawing.Point(274, 104);
            this.velocimetro1.MaxSpeed = 100D;
            this.velocimetro1.MinSpeed = 0D;
            this.velocimetro1.Name = "velocimetro1";
            this.velocimetro1.NeedleColor = System.Drawing.Color.Red;
            this.velocimetro1.ShowGaugeScale = true;
            this.velocimetro1.ShowNeedle = true;
            this.velocimetro1.Size = new System.Drawing.Size(150, 150);
            this.velocimetro1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.velocimetro1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TestGdiSpeedometerApp.GDISpeedometer velocimetro1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}


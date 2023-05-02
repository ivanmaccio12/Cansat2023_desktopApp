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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.velocimetro1 = new TestGdiSpeedometerApp.GDISpeedometer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.chartAltitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitude)).BeginInit();
            this.SuspendLayout();
            // 
            // velocimetro1
            // 
            this.velocimetro1.CurrentValueFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.velocimetro1.Font = new System.Drawing.Font("Arial", 8F);
            this.velocimetro1.GaugeColor = System.Drawing.Color.Black;
            this.velocimetro1.GaugeThickness = 3;
            this.velocimetro1.Location = new System.Drawing.Point(405, 0);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblAltitude);
            this.flowLayoutPanel1.Controls.Add(this.chartAltitude);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(363, 319);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(3, 0);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(83, 13);
            this.lblAltitude.TabIndex = 4;
            this.lblAltitude.Text = "Payload Altitude";
            // 
            // chartAltitude
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAltitude.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartAltitude.Legends.Add(legend1);
            this.chartAltitude.Location = new System.Drawing.Point(3, 16);
            this.chartAltitude.Name = "chartAltitude";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAltitude.Series.Add(series1);
            this.chartAltitude.Size = new System.Drawing.Size(344, 300);
            this.chartAltitude.TabIndex = 4;
            this.chartAltitude.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.velocimetro1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TestGdiSpeedometerApp.GDISpeedometer velocimetro1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAltitude;
    }
}


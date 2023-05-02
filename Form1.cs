using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cansat2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chartAltitude.Series["Series1"].ChartType = SeriesChartType.Spline; // Tipo de grafica: Bar, Column
            chartAltitude.Series["Series1"].BorderWidth = 2; // Borde de la grafica
            chartAltitude.Series["Series1"].Color = Color.DarkRed; // Color de la grafica
            //chartAltitude.Series["Series1"].LegendText; // Label o etiqueta
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("00:00:02", 576);
            dic.Add("00:00:03", 687);
            dic.Add("00:00:04", 761);
            dic.Add("00:00:05", 860);
            dic.Add("00:00:06", 774);
            dic.Add("00:00:07", 576);
            dic.Add("00:00:08", 487);
            dic.Add("00:00:09", 261);
            dic.Add("00:00:10", 200);
            dic.Add("00:00:11", 174);
            foreach (KeyValuePair<string, int> d in dic)
            {
                chartAltitude.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            velocimetro1.Speed = Convert.ToDouble(textBox1.Text);///
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
using GMap.NET.MapProviders;
using GMap.NET;
using System.Net;

namespace Cansat2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //EJEMPLO USO DE CHART

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

            //EJEMPLO USO DEL MAPA

            //GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            //GMapProvider.WebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            //this.gMapControl1.MapProvider = OpenStreet4UMapProvider.Instance; // Establecer la fuente del mapa

          
            gMapControl1.Manager.Mode = AccessMode.ServerAndCache; // modo de trabajo GMap
            gMapControl1.AutoScroll = true;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.DragButton = MouseButtons.Left;

            // Establecer el centro del mapa usando latitud y longitud
            // gMapControl1.Position = new GMap.NET.PointLatLng(39.923518, 116.539009);
            //gMapControl1.SetPositionByKeywords("Argentina"); // posición central del mapa
            gMapControl1.Position = new GMap.NET.PointLatLng(-24.789300, -65.410320);
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 17;
            gMapControl1.Zoom = 5;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            velocimetroPressure.Speed = Convert.ToDouble(100);///

        
        }

    

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

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
        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        System.Drawing.Font font;
        public Form1()
        {
            InitializeComponent();
            
            cambiarImagenStage();

            //AGREGO NUEVAS FUENTES
          
            privateFonts.AddFontFile(@"C:\Users\micae\code\Cansat2023_desktopApp\Resources\Fonts\Guardians.ttf");
            font = new Font(privateFonts.Families[0], 12);
            aplicarFuentes();

            
            //EJEMPLO USO DE CHART

            chartAltitude.Series["Series1"].ChartType = SeriesChartType.Spline; // Tipo de grafica: Bar, Column
            chartAltitude.Series["Series1"].BorderWidth = 2; // Borde de la grafica
            chartAltitude.Series["Series1"].Color = Color.DarkRed; // Color de la grafica

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
            gMapControl1.Manager.Mode = AccessMode.ServerAndCache; // modo de trabajo GMap
            gMapControl1.AutoScroll = true;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.DragButton = MouseButtons.Left;

            // Establecer el centro del mapa usando latitud y longitud
            //gMapControl1.MapProvider = OpenStreet4UMapProvider.Instance; // Establecer la fuente del mapa
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

        private void aplicarFuentes()
        {
            lblTeam.Font = new Font("Guardians", 30);
            lblTitleMissionTime.Font = new Font("Guardians", 10);
            lblTitlePacketCount.Font = new Font("Guardians", 10);
            lblStageTitle.Font = new Font("Guardians", 10);
            lblTitleAltitude.Font = new Font("Guardians", 9);
            lblTitleGPS.Font = new Font("Guardians", 9);
            lblTitleAltitude.Font = new Font("Guardians", 9);
            lblTitleVelocs.Font = new Font("Guardians", 9);
            lblTitleTelemetry.Font = new Font("Guardians", 9);

        }

        private void cambiarImagenStage()
        {
            picStage.ImageLocation = @"C:\Users\micae\code\Cansat2023_desktopApp\Resources\Images\Ascendiendo.png";
            picStage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

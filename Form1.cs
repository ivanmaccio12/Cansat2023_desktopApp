using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System;
using System.IO.Ports;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Net;
using Cansat2023.Clases;

namespace Cansat2023
{
    public partial class Form1 : Form
    {
        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        Font font;
        int stageNumber;
        public static string export;
        public static SerialPort _serialPort;
        public static string portname;
        public static List<byte> buffer = new List<byte>(); //buffer de tramas entrantes
        public static List<byte> bufferout = new List<byte>(); //buffer de tramas salientes
        public static List<string> telemetry = new List<string>();
        public static int packetCount = 0;
        Dictionary<string, int> arrayAltitudes = new Dictionary<string, int>(); //Array de datos para el grafico
        public Form1()
        {
            InitializeComponent();

            //INICIALIZO IMÁGENES EN ESTADO DISABLE DE FLAG, HEAT SHIELD Y PARACHUTE
            picFlag.ImageLocation = @"..\..\Resources\Images\Flag2Transp.png";
            picHeatShield.ImageLocation = @"..\..\Resources\Images\HeatShieldDeploySmallTransp.png";
            picParachute.ImageLocation = @"..\..\Resources\Images\FirstParachuteSmallTransp.png";

            //FUNCIÓN PARA CAMBIAR EL ESTADO SEGÚN NÚMEROS DEL 0 AL 6. AVISAR SI FALTAN
            //0 = Despegar, 1= Ascender, 2= FirstParachute, 3= Payload 500m,4= HeatShiel, 5= SecondParachute, 6= Flag

            stageNumber = 4;
            cambiarImagenStage(stageNumber);

            //AGREGO NUEVAS FUENTES
          
            privateFonts.AddFontFile(@"..\..\Resources\Fonts\Guardians.ttf");
            font = new Font(privateFonts.Families[0], 12);
            aplicarFuentes();

            
            //EJEMPLO USO DE CHART

            chartAltitude.Series["Series1"].ChartType = SeriesChartType.Spline; // Tipo de grafica: Bar, Column
            chartAltitude.Series["Series1"].BorderWidth = 2; // Borde de la grafica
            chartAltitude.Series["Series1"].Color = Color.DarkRed; // Color de la grafica
            arrayAltitudes.Clear(); // inicializa el arrayAltitudes


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

            export = "C:/cansat 2023/csv/"; //Direccion para ubicar el archivo csv

            string[] ports = SerialPort.GetPortNames();
            this.comboSerialPorts.Items.AddRange(ports);
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
            lblTitleMissionTime.Font = new Font("Guardians", 9);
            lblTitleSerialPort.Font = new Font("Guardians", 9);
            lblTitlePacketCount.Font = new Font("Guardians", 9);
            lblTitleMode.Font = new Font("Guardians", 9);
            lblStageTitle.Font = new Font("Guardians", 10);
            lblTitleAltitude.Font = new Font("Guardians", 9);
            lblTitleGPS.Font = new Font("Guardians", 9);
            lblTitleAltitude.Font = new Font("Guardians", 9);
            lblTitleVelocs.Font = new Font("Guardians", 9);
            lblTitleTelemetry.Font = new Font("Guardians", 9);

        }

        private void cambiarImagenStage(int stage)
        {
            switch (stage)
            {
                case 0:
                    lblStage.Text = "Take Off";
                    picStage.ImageLocation = @"..\..\Resources\Images\Despegando.png";
                    picStage.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 1:
                    lblStage.Text = "Ascent";
                    picStage.ImageLocation = @"..\..\Resources\Images\Ascent.png";
                    picStage.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
         
                case 2:
                    lblStage.Text = "First Parachute";
                    picStage.ImageLocation = @"..\..\Resources\Images\FirstParachuteSmall.png";
                    picStage.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 3:
                    lblStage.Text = "Payload at 500m";
                    picStage.ImageLocation = @"..\..\Resources\Images\PayloadAt500Small.png";
                    picStage.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 4:
                    lblStage.Text = "Heat Shield Deploy";
                    picStage.ImageLocation = @"..\..\Resources\Images\HeatShieldDeploySmall.png";
                    picStage.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 5:
                    lblStage.Text = "Second Parachute";
                    picStage.ImageLocation = @"..\..\Resources\Images\SecondParachuteSmall.png";
                    picStage.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 6:
                    lblStage.Text = "Flag Display";
                    picStage.ImageLocation = @"..\..\Resources\Images\Flag2.png";
                    picStage.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }
            
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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            init();
            btnConnect.BackColor = Color.PaleGreen;
        }

        static bool _continue;
        public void init()
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            serialPort1.PortName = portname;
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_OnReceiveData); //Activa el metodo que se pone a escuchar lo que entra por el puerto serie
            }

            telemetryOn(); //enciende la telemetria
            _continue = true;



        }

        private void telemetryOn ()
        {
            try
            {
                if (txtReceived.Text == "")
                {
                    string cmd = "CMD,1022,CX,ON";

                    bufferout.Clear();
                    bufferout.Add(0x7E);
                    bufferout.Add(0x00);
                    bufferout.Add((byte)(cmd.Length + 5));
                    bufferout.Add(0x01);
                    bufferout.Add(0x01);
                    bufferout.Add(0x00); //0x01 
                    bufferout.Add(0x10); //0x11
                    bufferout.Add(0x00);

                    for (int i = 0; i < cmd.Length; i++)
                    {
                        bufferout.Add((byte)cmd[i]);
                    }
                    byte chkaux = 0;
                    for (int i = 3; i < cmd.Length + 8; i++)
                    {
                        chkaux += bufferout[i];
                    }
                    chkaux = (byte)(0xFF - chkaux);
                    bufferout.Add(chkaux);




                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();

                    }
                    serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        private void port_OnReceiveData(object sender,
                                  SerialDataReceivedEventArgs e)
        {
            while (serialPort1.BytesToRead > 1)
            {
                var byteReaded = serialPort1.ReadByte();
                if (byteReaded == 0x7E)
                {
                    buffer.Clear();
                    telemetry.Clear();
                }
                buffer.Add((byte)byteReaded);

                if (buffer.Count >= 9)
                {
                    var buffer2 = buffer[2];
                    byte aux;
                    aux = (byte)(buffer[2] + 0x04);
                    if (aux == (byte)buffer.Count) //pregunta si ya tenemos toda la trama dentro de buffer
                    {
                        var message = "";
                        for (int i = 8; i < (buffer.Count - 1); i++)
                        {
                            message += (char)buffer[i];
                        }

                        // escribe el mensaje en el txtReceived para ser detectado por evento "txtReceived_TextChanged"
                        SetText(message.Trim().Replace("NAN", "0"));
                        //Split message and send to CsvHelper class to create or append 
                        telemetry = message.Split(',').ToList();

                        telemetry[2] = packetCount.ToString();




                    }
                }

            }
        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtReceived.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtReceived.Text = text;
            }
        }


        private void comboSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            portname = this.comboSerialPorts.Text; //guarda en la variable global el puerto que se eligio
        }

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            packetCount++; //suma un paquete recibido
            fillForm(txtReceived.Text.Split(',').ToList()); //muestra los datos en pantalla

            Cansat2023.CsvHelper.writeCsvFromList(txtReceived.Text.Split(',').ToList(), export); //escribe los datos en un CSV file
        }

        public void fillForm(List<string> telemetryList)
        {
            Payload payloadTelemetry = new Payload
            {
                TeamId = telemetryList[0],
                MissionTime = telemetryList[1],
                PacketCount = telemetryList[2],
                Mode = telemetryList[3],
                State = telemetryList[4],
                Altitude = telemetryList[5],
                HS_DEPLOYED = telemetryList[6],
                PC_DEPLOYED = telemetryList[7],
                MAST_RAISED = telemetryList[8],
                TEMPERATURE = telemetryList[9],
                PRESSURE = telemetryList[10],
                VOLTAGE = telemetryList[11],
                GPS_TIME = telemetryList[12],
                GPS_ALTITUDE = telemetryList[13].Trim() == "NAN" ? "0" : telemetryList[13],
                GPS_LATITUDE = telemetryList[14].Trim() == "NAN" ? "0" : telemetryList[14],
                GPS_LONGITUDE = telemetryList[15].Trim() == "NAN" ? "0" : telemetryList[15],
                GPS_SATS = telemetryList[16] == "NAN" ? "0" : telemetryList[16],
                TILT_XTILT_Y = telemetryList[17] + ", " + telemetryList[18],
                CMD_ECHO = telemetryList[19]
            };

            lblMissionTime.Text = payloadTelemetry.MissionTime;
            lblPacketCount.Text = payloadTelemetry.PacketCount;
            lblMode.Text = payloadTelemetry.Mode;
            lblGPSTime.Text = payloadTelemetry.GPS_TIME;
            lblGPSAlt.Text = payloadTelemetry.GPS_ALTITUDE;
            lblGPSLat.Text = payloadTelemetry.GPS_LATITUDE;
            lblGPSLong.Text = payloadTelemetry.GPS_LONGITUDE;
            lblGPSSat.Text = payloadTelemetry.GPS_SATS;
            lblTilt.Text = payloadTelemetry.TILT_XTILT_Y;


            //velocimetros
            velocimetroTemp.Speed = Convert.ToDouble(payloadTelemetry.TEMPERATURE);
            velocimetroPressure.Speed = Convert.ToDouble(payloadTelemetry.PRESSURE);
            velocimetroVoltage.Speed = Convert.ToDouble(payloadTelemetry.VOLTAGE);

            //grafico altitud

            arrayAltitudes.Add(payloadTelemetry.MissionTime, Convert.ToInt32(payloadTelemetry.Altitude));//agrega el nuevo elemento al array
            chartAltitude.Series["Series1"].Points.Clear(); //limpia el grafico

            foreach (KeyValuePair<string, int> d in arrayAltitudes)
            {
                chartAltitude.Series["Series1"].Points.AddXY(d.Key, d.Value); //dibuja el grafico desde cero, con el nuevo valor incluido
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bufferout.Clear();
            bufferout.Add(0x7E);
            bufferout.Add(0x00);
            bufferout.Add((byte)(txtCommand.Text.Length + 5));
            bufferout.Add(0x01);
            bufferout.Add(0x01);
            bufferout.Add(0x00); //0x01 
            bufferout.Add(0x10); //0x11
            bufferout.Add(0x00);

            for (int i = 0; i < txtCommand.Text.Length; i++)
            {
                bufferout.Add((byte)txtCommand.Text[i]);
            }
            byte chkaux = 0;
            for (int i = 3; i < txtCommand.Text.Length + 8; i++)
            {
                chkaux += bufferout[i];
            }
            chkaux = (byte)(0xFF - chkaux);
            bufferout.Add(chkaux);
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();

            }
            serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
            
        }

        private void lblGPSTime_Click(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            btnConnect.BackColor = Color.White;
        }
    }
}

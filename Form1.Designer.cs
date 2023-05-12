using System;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblPacketCount = new System.Windows.Forms.Label();
            this.lblMissionTime = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.lblStageTitle = new System.Windows.Forms.Label();
            this.picStage = new System.Windows.Forms.PictureBox();
            this.lblTitlePacketCount = new System.Windows.Forms.Label();
            this.lblTitleMissionTime = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.panelTelemetry = new System.Windows.Forms.Panel();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.lblTitleTelemetry = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.panelVeloc = new System.Windows.Forms.Panel();
            this.lblVolt = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTitleVelocs = new System.Windows.Forms.Label();
            this.velocimetroVoltage = new TestGdiSpeedometerApp.GDISpeedometer();
            this.velocimetroTemp = new TestGdiSpeedometerApp.GDISpeedometer();
            this.velocimetroPressure = new TestGdiSpeedometerApp.GDISpeedometer();
            this.panelGPS = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.lblTitleGPS = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lblFlag = new System.Windows.Forms.Label();
            this.lblHeatShield = new System.Windows.Forms.Label();
            this.lblParachute = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.picHeatShield = new System.Windows.Forms.PictureBox();
            this.picParachute = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblTitleAltitude = new System.Windows.Forms.Label();
            this.chartAltitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCsvPath = new System.Windows.Forms.Label();
            this.txtCsvPath = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStage)).BeginInit();
            this.panelTelemetry.SuspendLayout();
            this.panelVeloc.SuspendLayout();
            this.panelGPS.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeatShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParachute)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitude)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblPacketCount);
            this.panelHeader.Controls.Add(this.lblMissionTime);
            this.panelHeader.Controls.Add(this.lblStage);
            this.panelHeader.Controls.Add(this.lblStageTitle);
            this.panelHeader.Controls.Add(this.picStage);
            this.panelHeader.Controls.Add(this.lblTitlePacketCount);
            this.panelHeader.Controls.Add(this.lblTitleMissionTime);
            this.panelHeader.Controls.Add(this.lblTeam);
            this.panelHeader.Location = new System.Drawing.Point(12, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1326, 123);
            this.panelHeader.TabIndex = 4;
            // 
            // lblPacketCount
            // 
            this.lblPacketCount.AutoSize = true;
            this.lblPacketCount.Font = new System.Drawing.Font("Guardians", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacketCount.Location = new System.Drawing.Point(214, 70);
            this.lblPacketCount.Name = "lblPacketCount";
            this.lblPacketCount.Size = new System.Drawing.Size(21, 18);
            this.lblPacketCount.TabIndex = 9;
            this.lblPacketCount.Text = "0";
            // 
            // lblMissionTime
            // 
            this.lblMissionTime.AutoSize = true;
            this.lblMissionTime.Font = new System.Drawing.Font("Guardians", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionTime.Location = new System.Drawing.Point(193, 33);
            this.lblMissionTime.Name = "lblMissionTime";
            this.lblMissionTime.Size = new System.Drawing.Size(92, 18);
            this.lblMissionTime.TabIndex = 8;
            this.lblMissionTime.Text = "00:00:00";
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStage.Location = new System.Drawing.Point(959, 64);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(53, 19);
            this.lblStage.TabIndex = 7;
            this.lblStage.Text = "ASCENT";
            // 
            // lblStageTitle
            // 
            this.lblStageTitle.AutoSize = true;
            this.lblStageTitle.Font = new System.Drawing.Font("Guardians", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStageTitle.Location = new System.Drawing.Point(959, 33);
            this.lblStageTitle.Name = "lblStageTitle";
            this.lblStageTitle.Size = new System.Drawing.Size(78, 18);
            this.lblStageTitle.TabIndex = 6;
            this.lblStageTitle.Text = "Stage:";
            // 
            // picStage
            // 
            this.picStage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStage.ImageLocation = "";
            this.picStage.Location = new System.Drawing.Point(1136, 8);
            this.picStage.Name = "picStage";
            this.picStage.Size = new System.Drawing.Size(102, 100);
            this.picStage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStage.TabIndex = 5;
            this.picStage.TabStop = false;
            // 
            // lblTitlePacketCount
            // 
            this.lblTitlePacketCount.AutoSize = true;
            this.lblTitlePacketCount.Font = new System.Drawing.Font("Guardians", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePacketCount.Location = new System.Drawing.Point(28, 70);
            this.lblTitlePacketCount.Name = "lblTitlePacketCount";
            this.lblTitlePacketCount.Size = new System.Drawing.Size(169, 18);
            this.lblTitlePacketCount.TabIndex = 2;
            this.lblTitlePacketCount.Text = "Packet Count:";
            // 
            // lblTitleMissionTime
            // 
            this.lblTitleMissionTime.AutoSize = true;
            this.lblTitleMissionTime.Font = new System.Drawing.Font("Guardians", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMissionTime.Location = new System.Drawing.Point(28, 33);
            this.lblTitleMissionTime.Name = "lblTitleMissionTime";
            this.lblTitleMissionTime.Size = new System.Drawing.Size(159, 18);
            this.lblTitleMissionTime.TabIndex = 1;
            this.lblTitleMissionTime.Text = "Mission Time: ";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Guardians", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTeam.Location = new System.Drawing.Point(428, 33);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(398, 55);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Text = "TEAM 1022";
            // 
            // panelTelemetry
            // 
            this.panelTelemetry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTelemetry.Controls.Add(this.lblCommand);
            this.panelTelemetry.Controls.Add(this.lblReceived);
            this.panelTelemetry.Controls.Add(this.lblTitleTelemetry);
            this.panelTelemetry.Controls.Add(this.btnSend);
            this.panelTelemetry.Controls.Add(this.txtCommand);
            this.panelTelemetry.Controls.Add(this.txtReceived);
            this.panelTelemetry.Location = new System.Drawing.Point(12, 612);
            this.panelTelemetry.Name = "panelTelemetry";
            this.panelTelemetry.Size = new System.Drawing.Size(1326, 121);
            this.panelTelemetry.TabIndex = 5;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.Location = new System.Drawing.Point(54, 67);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(63, 17);
            this.lblCommand.TabIndex = 16;
            this.lblCommand.Text = "Command";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceived.Location = new System.Drawing.Point(54, 40);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(58, 17);
            this.lblReceived.TabIndex = 12;
            this.lblReceived.Text = "Received";
            // 
            // lblTitleTelemetry
            // 
            this.lblTitleTelemetry.AutoSize = true;
            this.lblTitleTelemetry.Font = new System.Drawing.Font("Guardians", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTelemetry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleTelemetry.Location = new System.Drawing.Point(18, 12);
            this.lblTitleTelemetry.Name = "lblTitleTelemetry";
            this.lblTitleTelemetry.Size = new System.Drawing.Size(112, 17);
            this.lblTitleTelemetry.TabIndex = 15;
            this.lblTitleTelemetry.Text = "Telemetry";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(1114, 52);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(129, 64);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(948, 22);
            this.txtCommand.TabIndex = 1;
            // 
            // txtReceived
            // 
            this.txtReceived.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceived.Location = new System.Drawing.Point(129, 38);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(948, 22);
            this.txtReceived.TabIndex = 0;
            // 
            // panelVeloc
            // 
            this.panelVeloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVeloc.Controls.Add(this.lblVolt);
            this.panelVeloc.Controls.Add(this.lblPress);
            this.panelVeloc.Controls.Add(this.lblTemp);
            this.panelVeloc.Controls.Add(this.lblTitleVelocs);
            this.panelVeloc.Controls.Add(this.velocimetroVoltage);
            this.panelVeloc.Controls.Add(this.velocimetroTemp);
            this.panelVeloc.Controls.Add(this.velocimetroPressure);
            this.panelVeloc.Location = new System.Drawing.Point(12, 125);
            this.panelVeloc.Name = "panelVeloc";
            this.panelVeloc.Size = new System.Drawing.Size(639, 208);
            this.panelVeloc.TabIndex = 5;
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolt.Location = new System.Drawing.Point(480, 177);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(66, 17);
            this.lblVolt.TabIndex = 11;
            this.lblVolt.Text = "Voltage (v)";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPress.Location = new System.Drawing.Point(271, 177);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(88, 17);
            this.lblPress.TabIndex = 10;
            this.lblPress.Text = "Pressure (kPa)";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(72, 177);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(101, 17);
            this.lblTemp.TabIndex = 9;
            this.lblTemp.Text = "Temperature (C°)";
            // 
            // lblTitleVelocs
            // 
            this.lblTitleVelocs.AutoSize = true;
            this.lblTitleVelocs.Font = new System.Drawing.Font("Guardians", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleVelocs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleVelocs.Location = new System.Drawing.Point(54, 6);
            this.lblTitleVelocs.Name = "lblTitleVelocs";
            this.lblTitleVelocs.Size = new System.Drawing.Size(505, 17);
            this.lblTitleVelocs.TabIndex = 8;
            this.lblTitleVelocs.Text = "Payload Temperature, Pressure and Voltage";
            // 
            // velocimetroVoltage
            // 
            this.velocimetroVoltage.CurrentValueFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.velocimetroVoltage.Font = new System.Drawing.Font("Arial", 8F);
            this.velocimetroVoltage.GaugeColor = System.Drawing.Color.Black;
            this.velocimetroVoltage.GaugeThickness = 3;
            this.velocimetroVoltage.Location = new System.Drawing.Point(438, 26);
            this.velocimetroVoltage.MaxSpeed = 100D;
            this.velocimetroVoltage.MinSpeed = 0D;
            this.velocimetroVoltage.Name = "velocimetroVoltage";
            this.velocimetroVoltage.NeedleColor = System.Drawing.Color.Red;
            this.velocimetroVoltage.ShowGaugeScale = true;
            this.velocimetroVoltage.ShowNeedle = true;
            this.velocimetroVoltage.Size = new System.Drawing.Size(150, 150);
            this.velocimetroVoltage.TabIndex = 3;
            // 
            // velocimetroTemp
            // 
            this.velocimetroTemp.CurrentValueFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.velocimetroTemp.Font = new System.Drawing.Font("Arial", 8F);
            this.velocimetroTemp.GaugeColor = System.Drawing.Color.Black;
            this.velocimetroTemp.GaugeThickness = 3;
            this.velocimetroTemp.Location = new System.Drawing.Point(47, 24);
            this.velocimetroTemp.MaxSpeed = 100D;
            this.velocimetroTemp.MinSpeed = 0D;
            this.velocimetroTemp.Name = "velocimetroTemp";
            this.velocimetroTemp.NeedleColor = System.Drawing.Color.Red;
            this.velocimetroTemp.ShowGaugeScale = true;
            this.velocimetroTemp.ShowNeedle = true;
            this.velocimetroTemp.Size = new System.Drawing.Size(150, 150);
            this.velocimetroTemp.TabIndex = 2;
            // 
            // velocimetroPressure
            // 
            this.velocimetroPressure.CurrentValueFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.velocimetroPressure.Font = new System.Drawing.Font("Arial", 8F);
            this.velocimetroPressure.GaugeColor = System.Drawing.Color.Black;
            this.velocimetroPressure.GaugeThickness = 3;
            this.velocimetroPressure.Location = new System.Drawing.Point(241, 24);
            this.velocimetroPressure.MaxSpeed = 100D;
            this.velocimetroPressure.MinSpeed = 0D;
            this.velocimetroPressure.Name = "velocimetroPressure";
            this.velocimetroPressure.NeedleColor = System.Drawing.Color.Red;
            this.velocimetroPressure.ShowGaugeScale = true;
            this.velocimetroPressure.ShowNeedle = true;
            this.velocimetroPressure.Size = new System.Drawing.Size(150, 150);
            this.velocimetroPressure.TabIndex = 1;
            // 
            // panelGPS
            // 
            this.panelGPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGPS.Controls.Add(this.gMapControl1);
            this.panelGPS.Controls.Add(this.lblTitleGPS);
            this.panelGPS.Location = new System.Drawing.Point(650, 125);
            this.panelGPS.Name = "panelGPS";
            this.panelGPS.Size = new System.Drawing.Size(466, 413);
            this.panelGPS.TabIndex = 5;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(45, 35);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 17;
            this.gMapControl1.MinZoom = 3;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(379, 359);
            this.gMapControl1.TabIndex = 13;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // lblTitleGPS
            // 
            this.lblTitleGPS.AutoSize = true;
            this.lblTitleGPS.Font = new System.Drawing.Font("Guardians", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleGPS.Location = new System.Drawing.Point(71, 6);
            this.lblTitleGPS.Name = "lblTitleGPS";
            this.lblTitleGPS.Size = new System.Drawing.Size(310, 17);
            this.lblTitleGPS.TabIndex = 12;
            this.lblTitleGPS.Text = "GPS Latitude and Longitude";
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.lblFlag);
            this.panelButtons.Controls.Add(this.lblHeatShield);
            this.panelButtons.Controls.Add(this.lblParachute);
            this.panelButtons.Controls.Add(this.button4);
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.picFlag);
            this.panelButtons.Controls.Add(this.picHeatShield);
            this.panelButtons.Controls.Add(this.picParachute);
            this.panelButtons.Location = new System.Drawing.Point(1114, 125);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(224, 488);
            this.panelButtons.TabIndex = 6;
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.Font = new System.Drawing.Font("Guardians", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlag.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFlag.Location = new System.Drawing.Point(89, 210);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(54, 15);
            this.lblFlag.TabIndex = 16;
            this.lblFlag.Text = "Flag";
            // 
            // lblHeatShield
            // 
            this.lblHeatShield.AutoSize = true;
            this.lblHeatShield.Font = new System.Drawing.Font("Guardians", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatShield.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHeatShield.Location = new System.Drawing.Point(55, 109);
            this.lblHeatShield.Name = "lblHeatShield";
            this.lblHeatShield.Size = new System.Drawing.Size(121, 15);
            this.lblHeatShield.TabIndex = 15;
            this.lblHeatShield.Text = "Heat shield";
            // 
            // lblParachute
            // 
            this.lblParachute.AutoSize = true;
            this.lblParachute.Font = new System.Drawing.Font("Guardians", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParachute.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblParachute.Location = new System.Drawing.Point(58, 6);
            this.lblParachute.Name = "lblParachute";
            this.lblParachute.Size = new System.Drawing.Size(110, 15);
            this.lblParachute.TabIndex = 14;
            this.lblParachute.Text = "Parachute";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(72, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(72, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(72, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // picFlag
            // 
            this.picFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFlag.Location = new System.Drawing.Point(60, 228);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(108, 82);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlag.TabIndex = 2;
            this.picFlag.TabStop = false;
            // 
            // picHeatShield
            // 
            this.picHeatShield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHeatShield.Location = new System.Drawing.Point(59, 128);
            this.picHeatShield.Name = "picHeatShield";
            this.picHeatShield.Size = new System.Drawing.Size(108, 79);
            this.picHeatShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeatShield.TabIndex = 1;
            this.picHeatShield.TabStop = false;
            // 
            // picParachute
            // 
            this.picParachute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picParachute.Location = new System.Drawing.Point(60, 26);
            this.picParachute.Name = "picParachute";
            this.picParachute.Size = new System.Drawing.Size(108, 80);
            this.picParachute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picParachute.TabIndex = 0;
            this.picParachute.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblAlt);
            this.panel1.Controls.Add(this.lblTitleAltitude);
            this.panel1.Controls.Add(this.chartAltitude);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 281);
            this.panel1.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(581, 250);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 17);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt.Location = new System.Drawing.Point(18, 21);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(72, 17);
            this.lblAlt.TabIndex = 13;
            this.lblAlt.Text = "Altitude (m)";
            // 
            // lblTitleAltitude
            // 
            this.lblTitleAltitude.AutoSize = true;
            this.lblTitleAltitude.Font = new System.Drawing.Font("Guardians", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAltitude.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleAltitude.Location = new System.Drawing.Point(201, 7);
            this.lblTitleAltitude.Name = "lblTitleAltitude";
            this.lblTitleAltitude.Size = new System.Drawing.Size(200, 17);
            this.lblTitleAltitude.TabIndex = 12;
            this.lblTitleAltitude.Text = "Payload Altitude";
            // 
            // chartAltitude
            // 
            this.chartAltitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.chartAltitude.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartAltitude.Legends.Add(legend2);
            this.chartAltitude.Location = new System.Drawing.Point(47, 41);
            this.chartAltitude.Name = "chartAltitude";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAltitude.Series.Add(series2);
            this.chartAltitude.Size = new System.Drawing.Size(528, 223);
            this.chartAltitude.TabIndex = 5;
            this.chartAltitude.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(638, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 85);
            this.panel2.TabIndex = 8;
            // 
            // lblCsvPath
            // 
            this.lblCsvPath.AutoSize = true;
            this.lblCsvPath.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsvPath.Location = new System.Drawing.Point(683, 565);
            this.lblCsvPath.Name = "lblCsvPath";
            this.lblCsvPath.Size = new System.Drawing.Size(57, 17);
            this.lblCsvPath.TabIndex = 13;
            this.lblCsvPath.Text = "CSV PATH";
            // 
            // txtCsvPath
            // 
            this.txtCsvPath.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsvPath.Location = new System.Drawing.Point(760, 563);
            this.txtCsvPath.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtCsvPath.Name = "txtCsvPath";
            this.txtCsvPath.Size = new System.Drawing.Size(315, 22);
            this.txtCsvPath.TabIndex = 17;
            this.txtCsvPath.Text = "C:\\cansat2023\\csv\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtCsvPath);
            this.Controls.Add(this.lblCsvPath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelGPS);
            this.Controls.Add(this.panelVeloc);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelTelemetry);
            this.Name = "Form1";
            this.Text = "CanSat Competition 2023 - Team 1022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStage)).EndInit();
            this.panelTelemetry.ResumeLayout(false);
            this.panelTelemetry.PerformLayout();
            this.panelVeloc.ResumeLayout(false);
            this.panelVeloc.PerformLayout();
            this.panelGPS.ResumeLayout(false);
            this.panelGPS.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeatShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParachute)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTelemetry;
        private System.Windows.Forms.Panel panelVeloc;
        private TestGdiSpeedometerApp.GDISpeedometer velocimetroVoltage;
        private TestGdiSpeedometerApp.GDISpeedometer velocimetroTemp;
        private TestGdiSpeedometerApp.GDISpeedometer velocimetroPressure;
        private System.Windows.Forms.Panel panelGPS;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAltitude;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblStageTitle;
        private System.Windows.Forms.PictureBox picStage;
        private System.Windows.Forms.Label lblTitlePacketCount;
        private System.Windows.Forms.Label lblTitleMissionTime;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Label lblTitleVelocs;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.Label lblTitleAltitude;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblTitleGPS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picFlag;
        private System.Windows.Forms.PictureBox picHeatShield;
        private System.Windows.Forms.PictureBox picParachute;
        private System.Windows.Forms.Label lblTime;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label lblTitleTelemetry;
        private System.Windows.Forms.Label lblMissionTime;
        private System.Windows.Forms.Label lblPacketCount;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCsvPath;
        private System.Windows.Forms.TextBox txtCsvPath;
        private System.Windows.Forms.Label lblHeatShield;
        private System.Windows.Forms.Label lblParachute;
        private System.Windows.Forms.Label lblFlag;
    }
}


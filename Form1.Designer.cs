using System;
using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitleSerialPort = new System.Windows.Forms.Label();
            this.comboSerialPorts = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPacketCount = new System.Windows.Forms.Label();
            this.lblTitleMode = new System.Windows.Forms.Label();
            this.lblMissionTime = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.lblStageTitle = new System.Windows.Forms.Label();
            this.picStage = new System.Windows.Forms.PictureBox();
            this.lblTitlePacketCount = new System.Windows.Forms.Label();
            this.lblTitleMissionTime = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.panelTelemetry = new System.Windows.Forms.Panel();
            this.btnBuzzer = new System.Windows.Forms.Button();
            this.btnMastRaised = new System.Windows.Forms.Button();
            this.btnParachuteRelease = new System.Windows.Forms.Button();
            this.btnPLRelease = new System.Windows.Forms.Button();
            this.btnTelemetryOff = new System.Windows.Forms.Button();
            this.btnOnTelemetry = new System.Windows.Forms.Button();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.lblTitleTelemetry = new System.Windows.Forms.Label();
            this.btnHSHigh = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnHSMid = new System.Windows.Forms.Button();
            this.btnSimActivate = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.btnSimEnable = new System.Windows.Forms.Button();
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
            this.lblHeatShield = new System.Windows.Forms.Label();
            this.picHeatShield = new System.Windows.Forms.PictureBox();
            this.lblFlag = new System.Windows.Forms.Label();
            this.lblParachute = new System.Windows.Forms.Label();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.picParachute = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblTitleAltitude = new System.Windows.Forms.Label();
            this.chartAltitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGPSSat = new System.Windows.Forms.Label();
            this.lblTilt = new System.Windows.Forms.Label();
            this.lblTitleGPSSats = new System.Windows.Forms.Label();
            this.lblTitleTilt = new System.Windows.Forms.Label();
            this.lblGPSLong = new System.Windows.Forms.Label();
            this.lblGPSLat = new System.Windows.Forms.Label();
            this.lblGPSAlt = new System.Windows.Forms.Label();
            this.lblGPSTime = new System.Windows.Forms.Label();
            this.lblTitleGPSLongitude = new System.Windows.Forms.Label();
            this.lblTitleGPSLatitude = new System.Windows.Forms.Label();
            this.lblTitleGPSAltitude = new System.Windows.Forms.Label();
            this.lblTitleGPSTime = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStage)).BeginInit();
            this.panelTelemetry.SuspendLayout();
            this.panelVeloc.SuspendLayout();
            this.panelGPS.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeatShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParachute)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitude)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblTitleSerialPort);
            this.panelHeader.Controls.Add(this.comboSerialPorts);
            this.panelHeader.Controls.Add(this.lblMode);
            this.panelHeader.Controls.Add(this.btnDisconnect);
            this.panelHeader.Controls.Add(this.btnConnect);
            this.panelHeader.Controls.Add(this.lblPacketCount);
            this.panelHeader.Controls.Add(this.lblTitleMode);
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
            // lblTitleSerialPort
            // 
            this.lblTitleSerialPort.AutoSize = true;
            this.lblTitleSerialPort.Font = new System.Drawing.Font("Guardians", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSerialPort.Location = new System.Drawing.Point(158, 10);
            this.lblTitleSerialPort.Name = "lblTitleSerialPort";
            this.lblTitleSerialPort.Size = new System.Drawing.Size(151, 17);
            this.lblTitleSerialPort.TabIndex = 13;
            this.lblTitleSerialPort.Text = "Serial Port: ";
            // 
            // comboSerialPorts
            // 
            this.comboSerialPorts.FormattingEnabled = true;
            this.comboSerialPorts.Location = new System.Drawing.Point(327, 9);
            this.comboSerialPorts.Name = "comboSerialPorts";
            this.comboSerialPorts.Size = new System.Drawing.Size(76, 21);
            this.comboSerialPorts.TabIndex = 12;
            this.comboSerialPorts.Text = "Select port";
            this.comboSerialPorts.SelectedIndexChanged += new System.EventHandler(this.comboSerialPorts_SelectedIndexChanged);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(324, 93);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(12, 16);
            this.lblMode.TabIndex = 20;
            this.lblMode.Text = "-";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(30, 65);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 38);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(30, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 38);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPacketCount
            // 
            this.lblPacketCount.AutoSize = true;
            this.lblPacketCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacketCount.Location = new System.Drawing.Point(324, 67);
            this.lblPacketCount.Name = "lblPacketCount";
            this.lblPacketCount.Size = new System.Drawing.Size(15, 16);
            this.lblPacketCount.TabIndex = 9;
            this.lblPacketCount.Text = "0";
            // 
            // lblTitleMode
            // 
            this.lblTitleMode.AutoSize = true;
            this.lblTitleMode.Font = new System.Drawing.Font("Guardians", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMode.Location = new System.Drawing.Point(158, 93);
            this.lblTitleMode.Name = "lblTitleMode";
            this.lblTitleMode.Size = new System.Drawing.Size(58, 17);
            this.lblTitleMode.TabIndex = 16;
            this.lblTitleMode.Text = "Mode:";
            // 
            // lblMissionTime
            // 
            this.lblMissionTime.AutoSize = true;
            this.lblMissionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionTime.Location = new System.Drawing.Point(324, 38);
            this.lblMissionTime.Name = "lblMissionTime";
            this.lblMissionTime.Size = new System.Drawing.Size(56, 16);
            this.lblMissionTime.TabIndex = 8;
            this.lblMissionTime.Text = "00:00:00";
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStage.Location = new System.Drawing.Point(1048, 65);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(56, 16);
            this.lblStage.TabIndex = 7;
            this.lblStage.Text = "ASCENT";
            // 
            // lblStageTitle
            // 
            this.lblStageTitle.AutoSize = true;
            this.lblStageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStageTitle.Location = new System.Drawing.Point(1048, 23);
            this.lblStageTitle.Name = "lblStageTitle";
            this.lblStageTitle.Size = new System.Drawing.Size(47, 16);
            this.lblStageTitle.TabIndex = 6;
            this.lblStageTitle.Text = "Stage:";
            // 
            // picStage
            // 
            this.picStage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStage.ImageLocation = "";
            this.picStage.Location = new System.Drawing.Point(1203, 9);
            this.picStage.Name = "picStage";
            this.picStage.Size = new System.Drawing.Size(102, 100);
            this.picStage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStage.TabIndex = 5;
            this.picStage.TabStop = false;
            // 
            // lblTitlePacketCount
            // 
            this.lblTitlePacketCount.AutoSize = true;
            this.lblTitlePacketCount.Font = new System.Drawing.Font("Guardians", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePacketCount.Location = new System.Drawing.Point(158, 67);
            this.lblTitlePacketCount.Name = "lblTitlePacketCount";
            this.lblTitlePacketCount.Size = new System.Drawing.Size(157, 17);
            this.lblTitlePacketCount.TabIndex = 2;
            this.lblTitlePacketCount.Text = "Packet Count:";
            // 
            // lblTitleMissionTime
            // 
            this.lblTitleMissionTime.AutoSize = true;
            this.lblTitleMissionTime.Font = new System.Drawing.Font("Guardians", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMissionTime.Location = new System.Drawing.Point(158, 38);
            this.lblTitleMissionTime.Name = "lblTitleMissionTime";
            this.lblTitleMissionTime.Size = new System.Drawing.Size(146, 17);
            this.lblTitleMissionTime.TabIndex = 1;
            this.lblTitleMissionTime.Text = "Mission Time: ";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTeam.Location = new System.Drawing.Point(531, 23);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(239, 46);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Text = "TEAM 1022";
            this.lblTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTelemetry
            // 
            this.panelTelemetry.BackColor = System.Drawing.Color.White;
            this.panelTelemetry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTelemetry.Controls.Add(this.btnBuzzer);
            this.panelTelemetry.Controls.Add(this.btnMastRaised);
            this.panelTelemetry.Controls.Add(this.btnParachuteRelease);
            this.panelTelemetry.Controls.Add(this.btnPLRelease);
            this.panelTelemetry.Controls.Add(this.btnTelemetryOff);
            this.panelTelemetry.Controls.Add(this.btnOnTelemetry);
            this.panelTelemetry.Controls.Add(this.lblCommand);
            this.panelTelemetry.Controls.Add(this.lblReceived);
            this.panelTelemetry.Controls.Add(this.lblTitleTelemetry);
            this.panelTelemetry.Controls.Add(this.btnHSHigh);
            this.panelTelemetry.Controls.Add(this.btnSend);
            this.panelTelemetry.Controls.Add(this.btnHSMid);
            this.panelTelemetry.Controls.Add(this.btnSimActivate);
            this.panelTelemetry.Controls.Add(this.txtCommand);
            this.panelTelemetry.Controls.Add(this.txtReceived);
            this.panelTelemetry.Controls.Add(this.btnSimEnable);
            this.panelTelemetry.Location = new System.Drawing.Point(12, 612);
            this.panelTelemetry.Name = "panelTelemetry";
            this.panelTelemetry.Size = new System.Drawing.Size(1326, 121);
            this.panelTelemetry.TabIndex = 5;
            // 
            // btnBuzzer
            // 
            this.btnBuzzer.Enabled = false;
            this.btnBuzzer.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuzzer.Location = new System.Drawing.Point(1206, 89);
            this.btnBuzzer.Name = "btnBuzzer";
            this.btnBuzzer.Size = new System.Drawing.Size(99, 21);
            this.btnBuzzer.TabIndex = 22;
            this.btnBuzzer.Text = "BUZZER";
            this.btnBuzzer.UseVisualStyleBackColor = true;
            this.btnBuzzer.Click += new System.EventHandler(this.btnBuzzer_Click);
            // 
            // btnMastRaised
            // 
            this.btnMastRaised.Enabled = false;
            this.btnMastRaised.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMastRaised.Location = new System.Drawing.Point(1101, 89);
            this.btnMastRaised.Name = "btnMastRaised";
            this.btnMastRaised.Size = new System.Drawing.Size(99, 21);
            this.btnMastRaised.TabIndex = 21;
            this.btnMastRaised.Text = "FLAG";
            this.btnMastRaised.UseVisualStyleBackColor = true;
            this.btnMastRaised.Click += new System.EventHandler(this.btnMastRaised_Click);
            // 
            // btnParachuteRelease
            // 
            this.btnParachuteRelease.Enabled = false;
            this.btnParachuteRelease.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParachuteRelease.Location = new System.Drawing.Point(1206, 63);
            this.btnParachuteRelease.Name = "btnParachuteRelease";
            this.btnParachuteRelease.Size = new System.Drawing.Size(99, 21);
            this.btnParachuteRelease.TabIndex = 20;
            this.btnParachuteRelease.Text = "PARACHUTE";
            this.btnParachuteRelease.UseVisualStyleBackColor = true;
            this.btnParachuteRelease.Click += new System.EventHandler(this.btnParachuteRelease_Click);
            // 
            // btnPLRelease
            // 
            this.btnPLRelease.Enabled = false;
            this.btnPLRelease.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPLRelease.Location = new System.Drawing.Point(1101, 63);
            this.btnPLRelease.Name = "btnPLRelease";
            this.btnPLRelease.Size = new System.Drawing.Size(99, 21);
            this.btnPLRelease.TabIndex = 19;
            this.btnPLRelease.Text = "PL RELEASE";
            this.btnPLRelease.UseVisualStyleBackColor = true;
            this.btnPLRelease.Click += new System.EventHandler(this.btnPLRelease_Click);
            // 
            // btnTelemetryOff
            // 
            this.btnTelemetryOff.Enabled = false;
            this.btnTelemetryOff.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelemetryOff.Location = new System.Drawing.Point(285, 6);
            this.btnTelemetryOff.Name = "btnTelemetryOff";
            this.btnTelemetryOff.Size = new System.Drawing.Size(135, 23);
            this.btnTelemetryOff.TabIndex = 18;
            this.btnTelemetryOff.Text = "TELEMETRY OFF";
            this.btnTelemetryOff.UseVisualStyleBackColor = true;
            this.btnTelemetryOff.Click += new System.EventHandler(this.btnTelemetryOff_Click);
            // 
            // btnOnTelemetry
            // 
            this.btnOnTelemetry.Enabled = false;
            this.btnOnTelemetry.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnTelemetry.Location = new System.Drawing.Point(133, 6);
            this.btnOnTelemetry.Name = "btnOnTelemetry";
            this.btnOnTelemetry.Size = new System.Drawing.Size(135, 23);
            this.btnOnTelemetry.TabIndex = 17;
            this.btnOnTelemetry.Text = "TELEMETRY ON";
            this.btnOnTelemetry.UseVisualStyleBackColor = true;
            this.btnOnTelemetry.Click += new System.EventHandler(this.btnOnTelemetry_Click);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Guardians", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.Location = new System.Drawing.Point(38, 68);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(89, 15);
            this.lblCommand.TabIndex = 16;
            this.lblCommand.Text = "Command";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Font = new System.Drawing.Font("Guardians", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceived.Location = new System.Drawing.Point(39, 42);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(86, 15);
            this.lblReceived.TabIndex = 12;
            this.lblReceived.Text = "Received";
            // 
            // lblTitleTelemetry
            // 
            this.lblTitleTelemetry.AutoSize = true;
            this.lblTitleTelemetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTelemetry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleTelemetry.Location = new System.Drawing.Point(17, 10);
            this.lblTitleTelemetry.Name = "lblTitleTelemetry";
            this.lblTitleTelemetry.Size = new System.Drawing.Size(61, 15);
            this.lblTitleTelemetry.TabIndex = 15;
            this.lblTitleTelemetry.Text = "Telemetry";
            // 
            // btnHSHigh
            // 
            this.btnHSHigh.Enabled = false;
            this.btnHSHigh.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSHigh.Location = new System.Drawing.Point(1206, 35);
            this.btnHSHigh.Name = "btnHSHigh";
            this.btnHSHigh.Size = new System.Drawing.Size(99, 21);
            this.btnHSHigh.TabIndex = 6;
            this.btnHSHigh.Text = "HS CLOSE";
            this.btnHSHigh.UseVisualStyleBackColor = true;
            this.btnHSHigh.Click += new System.EventHandler(this.btnHSHigh_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(962, 64);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnHSMid
            // 
            this.btnHSMid.Enabled = false;
            this.btnHSMid.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSMid.Location = new System.Drawing.Point(1101, 35);
            this.btnHSMid.Name = "btnHSMid";
            this.btnHSMid.Size = new System.Drawing.Size(99, 21);
            this.btnHSMid.TabIndex = 4;
            this.btnHSMid.Text = "HS OPEN";
            this.btnHSMid.UseVisualStyleBackColor = true;
            this.btnHSMid.Click += new System.EventHandler(this.btnHSMid_Click);
            // 
            // btnSimActivate
            // 
            this.btnSimActivate.Enabled = false;
            this.btnSimActivate.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimActivate.Location = new System.Drawing.Point(1206, 8);
            this.btnSimActivate.Name = "btnSimActivate";
            this.btnSimActivate.Size = new System.Drawing.Size(99, 21);
            this.btnSimActivate.TabIndex = 5;
            this.btnSimActivate.Text = "SIM ACTIVATE";
            this.btnSimActivate.UseVisualStyleBackColor = true;
            this.btnSimActivate.Click += new System.EventHandler(this.btnSimActivate_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(133, 64);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(806, 22);
            this.txtCommand.TabIndex = 1;
            // 
            // txtReceived
            // 
            this.txtReceived.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceived.Location = new System.Drawing.Point(133, 38);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(944, 22);
            this.txtReceived.TabIndex = 0;
            this.txtReceived.TextChanged += new System.EventHandler(this.txtReceived_TextChanged);
            // 
            // btnSimEnable
            // 
            this.btnSimEnable.Enabled = false;
            this.btnSimEnable.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimEnable.Location = new System.Drawing.Point(1101, 8);
            this.btnSimEnable.Name = "btnSimEnable";
            this.btnSimEnable.Size = new System.Drawing.Size(99, 21);
            this.btnSimEnable.TabIndex = 3;
            this.btnSimEnable.Text = "SIM ENABLE";
            this.btnSimEnable.UseVisualStyleBackColor = true;
            this.btnSimEnable.Click += new System.EventHandler(this.btnSimEnable_Click);
            // 
            // panelVeloc
            // 
            this.panelVeloc.BackColor = System.Drawing.Color.White;
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
            this.lblVolt.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolt.Location = new System.Drawing.Point(470, 177);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(84, 16);
            this.lblVolt.TabIndex = 11;
            this.lblVolt.Text = "Voltage (v)";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPress.Location = new System.Drawing.Point(259, 177);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(112, 16);
            this.lblPress.TabIndex = 10;
            this.lblPress.Text = "Pressure (kPa)";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(54, 177);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(129, 16);
            this.lblTemp.TabIndex = 9;
            this.lblTemp.Text = "Temperature (C°)";
            // 
            // lblTitleVelocs
            // 
            this.lblTitleVelocs.AutoSize = true;
            this.lblTitleVelocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleVelocs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleVelocs.Location = new System.Drawing.Point(54, 6);
            this.lblTitleVelocs.Name = "lblTitleVelocs";
            this.lblTitleVelocs.Size = new System.Drawing.Size(248, 15);
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
            this.velocimetroTemp.MaxSpeed = 60D;
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
            this.panelGPS.BackColor = System.Drawing.Color.White;
            this.panelGPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGPS.Controls.Add(this.gMapControl1);
            this.panelGPS.Controls.Add(this.lblTitleGPS);
            this.panelGPS.Location = new System.Drawing.Point(650, 125);
            this.panelGPS.Name = "panelGPS";
            this.panelGPS.Size = new System.Drawing.Size(466, 379);
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
            this.gMapControl1.Location = new System.Drawing.Point(63, 35);
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
            this.gMapControl1.Size = new System.Drawing.Size(340, 318);
            this.gMapControl1.TabIndex = 13;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // lblTitleGPS
            // 
            this.lblTitleGPS.AutoSize = true;
            this.lblTitleGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleGPS.Location = new System.Drawing.Point(71, 6);
            this.lblTitleGPS.Name = "lblTitleGPS";
            this.lblTitleGPS.Size = new System.Drawing.Size(161, 15);
            this.lblTitleGPS.TabIndex = 12;
            this.lblTitleGPS.Text = "GPS Latitude and Longitude";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.White;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.lblHeatShield);
            this.panelButtons.Controls.Add(this.picHeatShield);
            this.panelButtons.Controls.Add(this.lblFlag);
            this.panelButtons.Controls.Add(this.lblParachute);
            this.panelButtons.Controls.Add(this.picFlag);
            this.panelButtons.Controls.Add(this.picParachute);
            this.panelButtons.Location = new System.Drawing.Point(1114, 125);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(224, 379);
            this.panelButtons.TabIndex = 6;
            // 
            // lblHeatShield
            // 
            this.lblHeatShield.AutoSize = true;
            this.lblHeatShield.Font = new System.Drawing.Font("Guardians", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatShield.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHeatShield.Location = new System.Drawing.Point(55, 17);
            this.lblHeatShield.Name = "lblHeatShield";
            this.lblHeatShield.Size = new System.Drawing.Size(121, 15);
            this.lblHeatShield.TabIndex = 18;
            this.lblHeatShield.Text = "Heat shield";
            // 
            // picHeatShield
            // 
            this.picHeatShield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHeatShield.Location = new System.Drawing.Point(61, 35);
            this.picHeatShield.Name = "picHeatShield";
            this.picHeatShield.Size = new System.Drawing.Size(108, 79);
            this.picHeatShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeatShield.TabIndex = 17;
            this.picHeatShield.TabStop = false;
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.Font = new System.Drawing.Font("Guardians", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlag.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFlag.Location = new System.Drawing.Point(87, 243);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(54, 15);
            this.lblFlag.TabIndex = 16;
            this.lblFlag.Text = "Flag";
            // 
            // lblParachute
            // 
            this.lblParachute.AutoSize = true;
            this.lblParachute.Font = new System.Drawing.Font("Guardians", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParachute.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblParachute.Location = new System.Drawing.Point(58, 131);
            this.lblParachute.Name = "lblParachute";
            this.lblParachute.Size = new System.Drawing.Size(110, 15);
            this.lblParachute.TabIndex = 14;
            this.lblParachute.Text = "Parachute";
            // 
            // picFlag
            // 
            this.picFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFlag.Location = new System.Drawing.Point(58, 261);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(108, 82);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlag.TabIndex = 2;
            this.picFlag.TabStop = false;
            // 
            // picParachute
            // 
            this.picParachute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picParachute.Location = new System.Drawing.Point(60, 149);
            this.picParachute.Name = "picParachute";
            this.picParachute.Size = new System.Drawing.Size(108, 80);
            this.picParachute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picParachute.TabIndex = 0;
            this.picParachute.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
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
            this.lblTime.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(581, 250);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 16);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt.Location = new System.Drawing.Point(18, 21);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(92, 16);
            this.lblAlt.TabIndex = 13;
            this.lblAlt.Text = "Altitude (m)";
            // 
            // lblTitleAltitude
            // 
            this.lblTitleAltitude.AutoSize = true;
            this.lblTitleAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAltitude.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleAltitude.Location = new System.Drawing.Point(201, 7);
            this.lblTitleAltitude.Name = "lblTitleAltitude";
            this.lblTitleAltitude.Size = new System.Drawing.Size(94, 15);
            this.lblTitleAltitude.TabIndex = 12;
            this.lblTitleAltitude.Text = "Payload Altitude";
            // 
            // chartAltitude
            // 
            this.chartAltitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea3.Name = "ChartArea1";
            this.chartAltitude.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartAltitude.Legends.Add(legend3);
            this.chartAltitude.Location = new System.Drawing.Point(47, 41);
            this.chartAltitude.Name = "chartAltitude";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartAltitude.Series.Add(series3);
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
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblGPSSat);
            this.panel3.Controls.Add(this.lblTilt);
            this.panel3.Controls.Add(this.lblTitleGPSSats);
            this.panel3.Controls.Add(this.lblTitleTilt);
            this.panel3.Controls.Add(this.lblGPSLong);
            this.panel3.Controls.Add(this.lblGPSLat);
            this.panel3.Controls.Add(this.lblGPSAlt);
            this.panel3.Controls.Add(this.lblGPSTime);
            this.panel3.Controls.Add(this.lblTitleGPSLongitude);
            this.panel3.Controls.Add(this.lblTitleGPSLatitude);
            this.panel3.Controls.Add(this.lblTitleGPSAltitude);
            this.panel3.Controls.Add(this.lblTitleGPSTime);
            this.panel3.Location = new System.Drawing.Point(650, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 110);
            this.panel3.TabIndex = 27;
            // 
            // lblGPSSat
            // 
            this.lblGPSSat.AutoSize = true;
            this.lblGPSSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSSat.Location = new System.Drawing.Point(557, 67);
            this.lblGPSSat.Name = "lblGPSSat";
            this.lblGPSSat.Size = new System.Drawing.Size(15, 16);
            this.lblGPSSat.TabIndex = 38;
            this.lblGPSSat.Text = "0";
            // 
            // lblTilt
            // 
            this.lblTilt.AutoSize = true;
            this.lblTilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilt.Location = new System.Drawing.Point(590, 25);
            this.lblTilt.Name = "lblTilt";
            this.lblTilt.Size = new System.Drawing.Size(59, 16);
            this.lblTilt.TabIndex = 37;
            this.lblTilt.Text = "0.00,0.00";
            // 
            // lblTitleGPSSats
            // 
            this.lblTitleGPSSats.AutoSize = true;
            this.lblTitleGPSSats.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSSats.Location = new System.Drawing.Point(476, 66);
            this.lblTitleGPSSats.Name = "lblTitleGPSSats";
            this.lblTitleGPSSats.Size = new System.Drawing.Size(78, 18);
            this.lblTitleGPSSats.TabIndex = 36;
            this.lblTitleGPSSats.Text = "GPS Sats:";
            // 
            // lblTitleTilt
            // 
            this.lblTitleTilt.AutoSize = true;
            this.lblTitleTilt.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTilt.Location = new System.Drawing.Point(476, 24);
            this.lblTitleTilt.Name = "lblTitleTilt";
            this.lblTitleTilt.Size = new System.Drawing.Size(112, 18);
            this.lblTitleTilt.TabIndex = 35;
            this.lblTitleTilt.Text = "Tilt X, Tilt Y:";
            // 
            // lblGPSLong
            // 
            this.lblGPSLong.AutoSize = true;
            this.lblGPSLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSLong.Location = new System.Drawing.Point(370, 67);
            this.lblGPSLong.Name = "lblGPSLong";
            this.lblGPSLong.Size = new System.Drawing.Size(12, 16);
            this.lblGPSLong.TabIndex = 34;
            this.lblGPSLong.Text = "-";
            // 
            // lblGPSLat
            // 
            this.lblGPSLat.AutoSize = true;
            this.lblGPSLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSLat.Location = new System.Drawing.Point(359, 25);
            this.lblGPSLat.Name = "lblGPSLat";
            this.lblGPSLat.Size = new System.Drawing.Size(12, 16);
            this.lblGPSLat.TabIndex = 33;
            this.lblGPSLat.Text = "-";
            // 
            // lblGPSAlt
            // 
            this.lblGPSAlt.AutoSize = true;
            this.lblGPSAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSAlt.Location = new System.Drawing.Point(149, 65);
            this.lblGPSAlt.Name = "lblGPSAlt";
            this.lblGPSAlt.Size = new System.Drawing.Size(12, 16);
            this.lblGPSAlt.TabIndex = 32;
            this.lblGPSAlt.Text = "-";
            // 
            // lblGPSTime
            // 
            this.lblGPSTime.AutoSize = true;
            this.lblGPSTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSTime.Location = new System.Drawing.Point(113, 24);
            this.lblGPSTime.Name = "lblGPSTime";
            this.lblGPSTime.Size = new System.Drawing.Size(56, 16);
            this.lblGPSTime.TabIndex = 31;
            this.lblGPSTime.Text = "00:00:00";
            // 
            // lblTitleGPSLongitude
            // 
            this.lblTitleGPSLongitude.AutoSize = true;
            this.lblTitleGPSLongitude.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSLongitude.Location = new System.Drawing.Point(242, 65);
            this.lblTitleGPSLongitude.Name = "lblTitleGPSLongitude";
            this.lblTitleGPSLongitude.Size = new System.Drawing.Size(125, 18);
            this.lblTitleGPSLongitude.TabIndex = 30;
            this.lblTitleGPSLongitude.Text = "GPS Longitude:";
            // 
            // lblTitleGPSLatitude
            // 
            this.lblTitleGPSLatitude.AutoSize = true;
            this.lblTitleGPSLatitude.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSLatitude.Location = new System.Drawing.Point(242, 23);
            this.lblTitleGPSLatitude.Name = "lblTitleGPSLatitude";
            this.lblTitleGPSLatitude.Size = new System.Drawing.Size(114, 18);
            this.lblTitleGPSLatitude.TabIndex = 29;
            this.lblTitleGPSLatitude.Text = "GPS Latitude:";
            // 
            // lblTitleGPSAltitude
            // 
            this.lblTitleGPSAltitude.AutoSize = true;
            this.lblTitleGPSAltitude.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSAltitude.Location = new System.Drawing.Point(32, 65);
            this.lblTitleGPSAltitude.Name = "lblTitleGPSAltitude";
            this.lblTitleGPSAltitude.Size = new System.Drawing.Size(114, 18);
            this.lblTitleGPSAltitude.TabIndex = 28;
            this.lblTitleGPSAltitude.Text = "GPS Altitude:";
            // 
            // lblTitleGPSTime
            // 
            this.lblTitleGPSTime.AutoSize = true;
            this.lblTitleGPSTime.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSTime.Location = new System.Drawing.Point(32, 23);
            this.lblTitleGPSTime.Name = "lblTitleGPSTime";
            this.lblTitleGPSTime.Size = new System.Drawing.Size(80, 18);
            this.lblTitleGPSTime.TabIndex = 27;
            this.lblTitleGPSTime.Text = "GPS Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
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
            ((System.ComponentModel.ISupportInitialize)(this.picHeatShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParachute)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitude)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnHSHigh;
        private System.Windows.Forms.Button btnSimActivate;
        private System.Windows.Forms.Button btnHSMid;
        private System.Windows.Forms.Button btnSimEnable;
        private System.Windows.Forms.PictureBox picFlag;
        private System.Windows.Forms.PictureBox picParachute;
        private System.Windows.Forms.Label lblTime;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label lblTitleTelemetry;
        private System.Windows.Forms.Label lblMissionTime;
        private System.Windows.Forms.Label lblPacketCount;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblParachute;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comboSerialPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblTitleMode;
        private System.Windows.Forms.Label lblTitleSerialPort;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGPSSat;
        private System.Windows.Forms.Label lblTilt;
        private System.Windows.Forms.Label lblTitleGPSSats;
        private System.Windows.Forms.Label lblTitleTilt;
        private System.Windows.Forms.Label lblGPSLong;
        private System.Windows.Forms.Label lblGPSLat;
        private System.Windows.Forms.Label lblGPSAlt;
        private System.Windows.Forms.Label lblGPSTime;
        private System.Windows.Forms.Label lblTitleGPSLongitude;
        private System.Windows.Forms.Label lblTitleGPSLatitude;
        private System.Windows.Forms.Label lblTitleGPSAltitude;
        private System.Windows.Forms.Label lblTitleGPSTime;
        private System.Windows.Forms.Button btnOnTelemetry;
        private System.Windows.Forms.Button btnTelemetryOff;
        private System.Windows.Forms.Label lblHeatShield;
        private System.Windows.Forms.PictureBox picHeatShield;
        private System.Windows.Forms.Button btnParachuteRelease;
        private System.Windows.Forms.Button btnPLRelease;
        private System.Windows.Forms.Button btnMastRaised;
        private System.Windows.Forms.Button btnBuzzer;
    }
}


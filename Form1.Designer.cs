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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitleSerialPort = new System.Windows.Forms.Label();
            this.comboSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lblTitleGPSSats = new System.Windows.Forms.Label();
            this.lblTitleTilt = new System.Windows.Forms.Label();
            this.lblTitleMode = new System.Windows.Forms.Label();
            this.lblFlag = new System.Windows.Forms.Label();
            this.lblHeatShield = new System.Windows.Forms.Label();
            this.lblParachute = new System.Windows.Forms.Label();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.picHeatShield = new System.Windows.Forms.PictureBox();
            this.picParachute = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblTitleAltitude = new System.Windows.Forms.Label();
            this.chartAltitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblTitleGPSTime = new System.Windows.Forms.Label();
            this.lblTitleGPSAltitude = new System.Windows.Forms.Label();
            this.lblTitleGPSLatitude = new System.Windows.Forms.Label();
            this.lblTitleGPSLongitude = new System.Windows.Forms.Label();
            this.lblGPSTime = new System.Windows.Forms.Label();
            this.lblGPSAlt = new System.Windows.Forms.Label();
            this.lblGPSLat = new System.Windows.Forms.Label();
            this.lblGPSLong = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblTilt = new System.Windows.Forms.Label();
            this.lblGPSSat = new System.Windows.Forms.Label();
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
            this.panelHeader.Controls.Add(this.lblTitleSerialPort);
            this.panelHeader.Controls.Add(this.comboSerialPorts);
            this.panelHeader.Controls.Add(this.btnDisconnect);
            this.panelHeader.Controls.Add(this.btnConnect);
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
            // lblTitleSerialPort
            // 
            this.lblTitleSerialPort.AutoSize = true;
            this.lblTitleSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSerialPort.Location = new System.Drawing.Point(167, 19);
            this.lblTitleSerialPort.Name = "lblTitleSerialPort";
            this.lblTitleSerialPort.Size = new System.Drawing.Size(76, 16);
            this.lblTitleSerialPort.TabIndex = 13;
            this.lblTitleSerialPort.Text = "Serial Port: ";
            // 
            // comboSerialPorts
            // 
            this.comboSerialPorts.FormattingEnabled = true;
            this.comboSerialPorts.Location = new System.Drawing.Point(318, 18);
            this.comboSerialPorts.Name = "comboSerialPorts";
            this.comboSerialPorts.Size = new System.Drawing.Size(105, 21);
            this.comboSerialPorts.TabIndex = 12;
            this.comboSerialPorts.SelectedIndexChanged += new System.EventHandler(this.comboSerialPorts_SelectedIndexChanged);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(21, 65);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 38);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(21, 19);
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
            this.lblPacketCount.Location = new System.Drawing.Point(337, 82);
            this.lblPacketCount.Name = "lblPacketCount";
            this.lblPacketCount.Size = new System.Drawing.Size(15, 16);
            this.lblPacketCount.TabIndex = 9;
            this.lblPacketCount.Text = "0";
            // 
            // lblMissionTime
            // 
            this.lblMissionTime.AutoSize = true;
            this.lblMissionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionTime.Location = new System.Drawing.Point(335, 54);
            this.lblMissionTime.Name = "lblMissionTime";
            this.lblMissionTime.Size = new System.Drawing.Size(56, 16);
            this.lblMissionTime.TabIndex = 8;
            this.lblMissionTime.Text = "00:00:00";
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStage.Location = new System.Drawing.Point(1053, 69);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(47, 17);
            this.lblStage.TabIndex = 7;
            this.lblStage.Text = "ASCENT";
            // 
            // lblStageTitle
            // 
            this.lblStageTitle.AutoSize = true;
            this.lblStageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStageTitle.Location = new System.Drawing.Point(1056, 23);
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
            this.lblTitlePacketCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePacketCount.Location = new System.Drawing.Point(167, 83);
            this.lblTitlePacketCount.Name = "lblTitlePacketCount";
            this.lblTitlePacketCount.Size = new System.Drawing.Size(90, 16);
            this.lblTitlePacketCount.TabIndex = 2;
            this.lblTitlePacketCount.Text = "Packet Count:";
            // 
            // lblTitleMissionTime
            // 
            this.lblTitleMissionTime.AutoSize = true;
            this.lblTitleMissionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMissionTime.Location = new System.Drawing.Point(167, 52);
            this.lblTitleMissionTime.Name = "lblTitleMissionTime";
            this.lblTitleMissionTime.Size = new System.Drawing.Size(94, 16);
            this.lblTitleMissionTime.TabIndex = 1;
            this.lblTitleMissionTime.Text = "Mission Time: ";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTeam.Location = new System.Drawing.Point(547, 23);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(239, 46);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Text = "TEAM 1022";
            this.lblTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTelemetry
            // 
            this.panelTelemetry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTelemetry.Controls.Add(this.lblCommand);
            this.panelTelemetry.Controls.Add(this.lblReceived);
            this.panelTelemetry.Controls.Add(this.lblTitleTelemetry);
            this.panelTelemetry.Controls.Add(this.button4);
            this.panelTelemetry.Controls.Add(this.btnSend);
            this.panelTelemetry.Controls.Add(this.button2);
            this.panelTelemetry.Controls.Add(this.button3);
            this.panelTelemetry.Controls.Add(this.txtCommand);
            this.panelTelemetry.Controls.Add(this.txtReceived);
            this.panelTelemetry.Controls.Add(this.button1);
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
            this.lblTitleTelemetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTelemetry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleTelemetry.Location = new System.Drawing.Point(18, 12);
            this.lblTitleTelemetry.Name = "lblTitleTelemetry";
            this.lblTitleTelemetry.Size = new System.Drawing.Size(61, 15);
            this.lblTitleTelemetry.TabIndex = 15;
            this.lblTitleTelemetry.Text = "Telemetry";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1222, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(962, 64);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1117, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1222, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(129, 64);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(810, 22);
            this.txtCommand.TabIndex = 1;
            // 
            // txtReceived
            // 
            this.txtReceived.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceived.Location = new System.Drawing.Point(129, 38);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(948, 22);
            this.txtReceived.TabIndex = 0;
            this.txtReceived.TextChanged += new System.EventHandler(this.txtReceived_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1117, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.lblGPSSat);
            this.panelButtons.Controls.Add(this.lblTilt);
            this.panelButtons.Controls.Add(this.lblMode);
            this.panelButtons.Controls.Add(this.lblTitleGPSSats);
            this.panelButtons.Controls.Add(this.lblTitleTilt);
            this.panelButtons.Controls.Add(this.lblTitleMode);
            this.panelButtons.Controls.Add(this.lblFlag);
            this.panelButtons.Controls.Add(this.lblHeatShield);
            this.panelButtons.Controls.Add(this.lblParachute);
            this.panelButtons.Controls.Add(this.picFlag);
            this.panelButtons.Controls.Add(this.picHeatShield);
            this.panelButtons.Controls.Add(this.picParachute);
            this.panelButtons.Location = new System.Drawing.Point(1114, 125);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(224, 488);
            this.panelButtons.TabIndex = 6;
            // 
            // lblTitleGPSSats
            // 
            this.lblTitleGPSSats.AutoSize = true;
            this.lblTitleGPSSats.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSSats.Location = new System.Drawing.Point(12, 443);
            this.lblTitleGPSSats.Name = "lblTitleGPSSats";
            this.lblTitleGPSSats.Size = new System.Drawing.Size(58, 17);
            this.lblTitleGPSSats.TabIndex = 18;
            this.lblTitleGPSSats.Text = "GPS Sats:";
            // 
            // lblTitleTilt
            // 
            this.lblTitleTilt.AutoSize = true;
            this.lblTitleTilt.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTilt.Location = new System.Drawing.Point(12, 401);
            this.lblTitleTilt.Name = "lblTitleTilt";
            this.lblTitleTilt.Size = new System.Drawing.Size(66, 17);
            this.lblTitleTilt.TabIndex = 17;
            this.lblTitleTilt.Text = "Tilt X, Tilt Y:";
            // 
            // lblTitleMode
            // 
            this.lblTitleMode.AutoSize = true;
            this.lblTitleMode.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMode.Location = new System.Drawing.Point(12, 361);
            this.lblTitleMode.Name = "lblTitleMode";
            this.lblTitleMode.Size = new System.Drawing.Size(41, 17);
            this.lblTitleMode.TabIndex = 16;
            this.lblTitleMode.Text = "Mode:";
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
            // lblHeatShield
            // 
            this.lblHeatShield.AutoSize = true;
            this.lblHeatShield.Font = new System.Drawing.Font("Guardians", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatShield.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHeatShield.Location = new System.Drawing.Point(51, 132);
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
            this.lblParachute.Location = new System.Drawing.Point(58, 20);
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
            // picHeatShield
            // 
            this.picHeatShield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHeatShield.Location = new System.Drawing.Point(58, 150);
            this.picHeatShield.Name = "picHeatShield";
            this.picHeatShield.Size = new System.Drawing.Size(108, 79);
            this.picHeatShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeatShield.TabIndex = 1;
            this.picHeatShield.TabStop = false;
            // 
            // picParachute
            // 
            this.picParachute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picParachute.Location = new System.Drawing.Point(58, 38);
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
            chartArea1.Name = "ChartArea1";
            this.chartAltitude.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartAltitude.Legends.Add(legend1);
            this.chartAltitude.Location = new System.Drawing.Point(47, 41);
            this.chartAltitude.Name = "chartAltitude";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAltitude.Series.Add(series1);
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
            // lblTitleGPSTime
            // 
            this.lblTitleGPSTime.AutoSize = true;
            this.lblTitleGPSTime.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSTime.Location = new System.Drawing.Point(683, 527);
            this.lblTitleGPSTime.Name = "lblTitleGPSTime";
            this.lblTitleGPSTime.Size = new System.Drawing.Size(61, 17);
            this.lblTitleGPSTime.TabIndex = 12;
            this.lblTitleGPSTime.Text = "GPS Time:";
            this.lblTitleGPSTime.Click += new System.EventHandler(this.lblGPSTime_Click);
            // 
            // lblTitleGPSAltitude
            // 
            this.lblTitleGPSAltitude.AutoSize = true;
            this.lblTitleGPSAltitude.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSAltitude.Location = new System.Drawing.Point(683, 569);
            this.lblTitleGPSAltitude.Name = "lblTitleGPSAltitude";
            this.lblTitleGPSAltitude.Size = new System.Drawing.Size(78, 17);
            this.lblTitleGPSAltitude.TabIndex = 13;
            this.lblTitleGPSAltitude.Text = "GPS Altitude:";
            // 
            // lblTitleGPSLatitude
            // 
            this.lblTitleGPSLatitude.AutoSize = true;
            this.lblTitleGPSLatitude.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSLatitude.Location = new System.Drawing.Point(893, 527);
            this.lblTitleGPSLatitude.Name = "lblTitleGPSLatitude";
            this.lblTitleGPSLatitude.Size = new System.Drawing.Size(79, 17);
            this.lblTitleGPSLatitude.TabIndex = 14;
            this.lblTitleGPSLatitude.Text = "GPS Latitude:";
            // 
            // lblTitleGPSLongitude
            // 
            this.lblTitleGPSLongitude.AutoSize = true;
            this.lblTitleGPSLongitude.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGPSLongitude.Location = new System.Drawing.Point(893, 569);
            this.lblTitleGPSLongitude.Name = "lblTitleGPSLongitude";
            this.lblTitleGPSLongitude.Size = new System.Drawing.Size(89, 17);
            this.lblTitleGPSLongitude.TabIndex = 15;
            this.lblTitleGPSLongitude.Text = "GPS Longitude:";
            // 
            // lblGPSTime
            // 
            this.lblGPSTime.AutoSize = true;
            this.lblGPSTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSTime.Location = new System.Drawing.Point(750, 528);
            this.lblGPSTime.Name = "lblGPSTime";
            this.lblGPSTime.Size = new System.Drawing.Size(67, 16);
            this.lblGPSTime.TabIndex = 16;
            this.lblGPSTime.Text = "GPSTime";
            // 
            // lblGPSAlt
            // 
            this.lblGPSAlt.AutoSize = true;
            this.lblGPSAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSAlt.Location = new System.Drawing.Point(767, 570);
            this.lblGPSAlt.Name = "lblGPSAlt";
            this.lblGPSAlt.Size = new System.Drawing.Size(83, 16);
            this.lblGPSAlt.TabIndex = 17;
            this.lblGPSAlt.Text = "GPS Altitude";
            // 
            // lblGPSLat
            // 
            this.lblGPSLat.AutoSize = true;
            this.lblGPSLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSLat.Location = new System.Drawing.Point(978, 528);
            this.lblGPSLat.Name = "lblGPSLat";
            this.lblGPSLat.Size = new System.Drawing.Size(86, 16);
            this.lblGPSLat.TabIndex = 18;
            this.lblGPSLat.Text = "GPS Latitude";
            // 
            // lblGPSLong
            // 
            this.lblGPSLong.AutoSize = true;
            this.lblGPSLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSLong.Location = new System.Drawing.Point(988, 570);
            this.lblGPSLong.Name = "lblGPSLong";
            this.lblGPSLong.Size = new System.Drawing.Size(98, 16);
            this.lblGPSLong.TabIndex = 19;
            this.lblGPSLong.Text = "GPS Longitude";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(58, 362);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(16, 16);
            this.lblMode.TabIndex = 20;
            this.lblMode.Text = "F";
            // 
            // lblTilt
            // 
            this.lblTilt.AutoSize = true;
            this.lblTilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilt.Location = new System.Drawing.Point(87, 401);
            this.lblTilt.Name = "lblTilt";
            this.lblTilt.Size = new System.Drawing.Size(59, 16);
            this.lblTilt.TabIndex = 21;
            this.lblTilt.Text = "0.00,0.45";
            // 
            // lblGPSSat
            // 
            this.lblGPSSat.AutoSize = true;
            this.lblGPSSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSSat.Location = new System.Drawing.Point(82, 443);
            this.lblGPSSat.Name = "lblGPSSat";
            this.lblGPSSat.Size = new System.Drawing.Size(15, 16);
            this.lblGPSSat.TabIndex = 22;
            this.lblGPSSat.Text = "6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblGPSLong);
            this.Controls.Add(this.lblGPSLat);
            this.Controls.Add(this.lblGPSAlt);
            this.Controls.Add(this.lblGPSTime);
            this.Controls.Add(this.lblTitleGPSLongitude);
            this.Controls.Add(this.lblTitleGPSLatitude);
            this.Controls.Add(this.lblTitleGPSAltitude);
            this.Controls.Add(this.lblTitleGPSTime);
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
        private System.Windows.Forms.Label lblHeatShield;
        private System.Windows.Forms.Label lblParachute;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comboSerialPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblTitleGPSTime;
        private System.Windows.Forms.Label lblTitleGPSAltitude;
        private System.Windows.Forms.Label lblTitleGPSLatitude;
        private System.Windows.Forms.Label lblTitleGPSLongitude;
        private System.Windows.Forms.Label lblTitleGPSSats;
        private System.Windows.Forms.Label lblTitleTilt;
        private System.Windows.Forms.Label lblTitleMode;
        private System.Windows.Forms.Label lblTitleSerialPort;
        private System.Windows.Forms.Label lblGPSTime;
        private System.Windows.Forms.Label lblGPSAlt;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblGPSLat;
        private System.Windows.Forms.Label lblGPSLong;
        private System.Windows.Forms.Label lblGPSSat;
        private System.Windows.Forms.Label lblTilt;
    }
}


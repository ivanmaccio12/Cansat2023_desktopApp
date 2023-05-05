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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblStage = new System.Windows.Forms.Label();
            this.lblStageTitle = new System.Windows.Forms.Label();
            this.picStage = new System.Windows.Forms.PictureBox();
            this.txtPacketCount = new System.Windows.Forms.TextBox();
            this.txtMissionTime = new System.Windows.Forms.TextBox();
            this.lblPacketCount = new System.Windows.Forms.Label();
            this.lblMissionTime = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.panelTelemetry = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.panelVeloc = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.velocimetroVoltage = new TestGdiSpeedometerApp.GDISpeedometer();
            this.velocimetroTemp = new TestGdiSpeedometerApp.GDISpeedometer();
            this.velocimetroPressure = new TestGdiSpeedometerApp.GDISpeedometer();
            this.panelGPS = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label8 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartAltitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStage)).BeginInit();
            this.panelTelemetry.SuspendLayout();
            this.panelVeloc.SuspendLayout();
            this.panelGPS.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitude)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblStage);
            this.panelHeader.Controls.Add(this.lblStageTitle);
            this.panelHeader.Controls.Add(this.picStage);
            this.panelHeader.Controls.Add(this.txtPacketCount);
            this.panelHeader.Controls.Add(this.txtMissionTime);
            this.panelHeader.Controls.Add(this.lblPacketCount);
            this.panelHeader.Controls.Add(this.lblMissionTime);
            this.panelHeader.Controls.Add(this.lblTeam);
            this.panelHeader.Location = new System.Drawing.Point(32, 6);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1273, 138);
            this.panelHeader.TabIndex = 4;
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Location = new System.Drawing.Point(922, 76);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(95, 13);
            this.lblStage.TabIndex = 7;
            this.lblStage.Text = "Ingrese aqui etapa";
            // 
            // lblStageTitle
            // 
            this.lblStageTitle.AutoSize = true;
            this.lblStageTitle.Location = new System.Drawing.Point(948, 38);
            this.lblStageTitle.Name = "lblStageTitle";
            this.lblStageTitle.Size = new System.Drawing.Size(38, 13);
            this.lblStageTitle.TabIndex = 6;
            this.lblStageTitle.Text = "Stage:";
            // 
            // picStage
            // 
            this.picStage.ImageLocation = "C:\\Universidad\\Robotica\\Docs\\LogoCansat.jfif";
            this.picStage.Location = new System.Drawing.Point(1044, 14);
            this.picStage.Name = "picStage";
            this.picStage.Size = new System.Drawing.Size(185, 100);
            this.picStage.TabIndex = 5;
            this.picStage.TabStop = false;
            // 
            // txtPacketCount
            // 
            this.txtPacketCount.Location = new System.Drawing.Point(210, 85);
            this.txtPacketCount.Name = "txtPacketCount";
            this.txtPacketCount.ReadOnly = true;
            this.txtPacketCount.Size = new System.Drawing.Size(173, 20);
            this.txtPacketCount.TabIndex = 4;
            // 
            // txtMissionTime
            // 
            this.txtMissionTime.Location = new System.Drawing.Point(210, 38);
            this.txtMissionTime.Name = "txtMissionTime";
            this.txtMissionTime.ReadOnly = true;
            this.txtMissionTime.Size = new System.Drawing.Size(173, 20);
            this.txtMissionTime.TabIndex = 3;
            // 
            // lblPacketCount
            // 
            this.lblPacketCount.AutoSize = true;
            this.lblPacketCount.Location = new System.Drawing.Point(85, 88);
            this.lblPacketCount.Name = "lblPacketCount";
            this.lblPacketCount.Size = new System.Drawing.Size(75, 13);
            this.lblPacketCount.TabIndex = 2;
            this.lblPacketCount.Text = "Packet Count:";
            // 
            // lblMissionTime
            // 
            this.lblMissionTime.AutoSize = true;
            this.lblMissionTime.Location = new System.Drawing.Point(85, 41);
            this.lblMissionTime.Name = "lblMissionTime";
            this.lblMissionTime.Size = new System.Drawing.Size(74, 13);
            this.lblMissionTime.TabIndex = 1;
            this.lblMissionTime.Text = "Mission Time: ";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(615, 27);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(64, 13);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Text = "TEAM 1022";
            // 
            // panelTelemetry
            // 
            this.panelTelemetry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTelemetry.Controls.Add(this.btnSend);
            this.panelTelemetry.Controls.Add(this.txtCommand);
            this.panelTelemetry.Controls.Add(this.txtReceived);
            this.panelTelemetry.Location = new System.Drawing.Point(32, 603);
            this.panelTelemetry.Name = "panelTelemetry";
            this.panelTelemetry.Size = new System.Drawing.Size(1273, 114);
            this.panelTelemetry.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1114, 52);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(21, 64);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(1056, 20);
            this.txtCommand.TabIndex = 1;
            this.txtCommand.Text = "Command";
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(21, 38);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(1056, 20);
            this.txtReceived.TabIndex = 0;
            this.txtReceived.Text = "Received";
            // 
            // panelVeloc
            // 
            this.panelVeloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVeloc.Controls.Add(this.label4);
            this.panelVeloc.Controls.Add(this.label3);
            this.panelVeloc.Controls.Add(this.label2);
            this.panelVeloc.Controls.Add(this.label1);
            this.panelVeloc.Controls.Add(this.velocimetroVoltage);
            this.panelVeloc.Controls.Add(this.velocimetroTemp);
            this.panelVeloc.Controls.Add(this.velocimetroPressure);
            this.panelVeloc.Location = new System.Drawing.Point(32, 140);
            this.panelVeloc.Name = "panelVeloc";
            this.panelVeloc.Size = new System.Drawing.Size(619, 197);
            this.panelVeloc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Voltage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Temperature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payload Temperature, Pressure and Voltage";
            // 
            // velocimetroVoltage
            // 
            this.velocimetroVoltage.CurrentValueFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.velocimetroVoltage.Font = new System.Drawing.Font("Arial", 8F);
            this.velocimetroVoltage.GaugeColor = System.Drawing.Color.Black;
            this.velocimetroVoltage.GaugeThickness = 3;
            this.velocimetroVoltage.Location = new System.Drawing.Point(425, 24);
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
            this.velocimetroPressure.Location = new System.Drawing.Point(233, 24);
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
            this.panelGPS.Controls.Add(this.label8);
            this.panelGPS.Location = new System.Drawing.Point(651, 140);
            this.panelGPS.Name = "panelGPS";
            this.panelGPS.Size = new System.Drawing.Size(466, 473);
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
            this.gMapControl1.Location = new System.Drawing.Point(26, 71);
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
            this.gMapControl1.Size = new System.Drawing.Size(404, 371);
            this.gMapControl1.TabIndex = 13;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "GPS Latitude and Longitude";
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.button4);
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.pictureBox3);
            this.panelButtons.Controls.Add(this.pictureBox2);
            this.panelButtons.Controls.Add(this.pictureBox1);
            this.panelButtons.Location = new System.Drawing.Point(1114, 140);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(191, 473);
            this.panelButtons.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(59, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(47, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 82);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(47, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 79);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.chartAltitude);
            this.panel1.Location = new System.Drawing.Point(32, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 281);
            this.panel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Altitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Payload Altitude";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelGPS);
            this.Controls.Add(this.panelVeloc);
            this.Controls.Add(this.panelTelemetry);
            this.Controls.Add(this.panelHeader);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltitude)).EndInit();
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
        private System.Windows.Forms.TextBox txtPacketCount;
        private System.Windows.Forms.TextBox txtMissionTime;
        private System.Windows.Forms.Label lblPacketCount;
        private System.Windows.Forms.Label lblMissionTime;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}


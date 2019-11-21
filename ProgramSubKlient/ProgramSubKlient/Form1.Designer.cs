namespace ProgramSubKlient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.subSettings = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sekund = new MetroFramework.Controls.MetroLabel();
            this.textTime = new MetroFramework.Controls.MetroTextBox();
            this.pickEvery = new MetroFramework.Controls.MetroCheckBox();
            this.setRequest = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.askTime = new MetroFramework.Controls.MetroCheckBox();
            this.askServer = new MetroFramework.Controls.MetroButton();
            this.askTopics = new MetroFramework.Controls.MetroCheckBox();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.subDisk = new MetroFramework.Controls.MetroCheckBox();
            this.subRAM = new MetroFramework.Controls.MetroCheckBox();
            this.subCPU = new MetroFramework.Controls.MetroCheckBox();
            this.windowLogs = new System.Windows.Forms.ListBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressDisk = new MetroFramework.Controls.MetroProgressBar();
            this.labelCPU = new MetroFramework.Controls.MetroLabel();
            this.labelRAM = new MetroFramework.Controls.MetroLabel();
            this.labelDisk = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.subSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // subSettings
            // 
            this.subSettings.BackColor = System.Drawing.Color.AliceBlue;
            this.subSettings.Controls.Add(this.groupBox2);
            this.subSettings.Controls.Add(this.setRequest);
            this.subSettings.Controls.Add(this.groupBox1);
            this.subSettings.Controls.Add(this.btnStop);
            this.subSettings.Controls.Add(this.btnStart);
            this.subSettings.Controls.Add(this.subDisk);
            this.subSettings.Controls.Add(this.subRAM);
            this.subSettings.Controls.Add(this.subCPU);
            this.subSettings.Location = new System.Drawing.Point(23, 63);
            this.subSettings.Name = "subSettings";
            this.subSettings.Size = new System.Drawing.Size(552, 183);
            this.subSettings.TabIndex = 0;
            this.subSettings.TabStop = false;
            this.subSettings.Text = "Ustawienia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sekund);
            this.groupBox2.Controls.Add(this.textTime);
            this.groupBox2.Controls.Add(this.pickEvery);
            this.groupBox2.Location = new System.Drawing.Point(16, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustaw czas";
            // 
            // sekund
            // 
            this.sekund.AutoSize = true;
            this.sekund.Location = new System.Drawing.Point(54, 49);
            this.sekund.Name = "sekund";
            this.sekund.Size = new System.Drawing.Size(49, 19);
            this.sekund.TabIndex = 2;
            this.sekund.Text = "sekund";
            this.sekund.UseCustomBackColor = true;
            // 
            // textTime
            // 
            // 
            // 
            // 
            this.textTime.CustomButton.Image = null;
            this.textTime.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.textTime.CustomButton.Name = "";
            this.textTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textTime.CustomButton.TabIndex = 1;
            this.textTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textTime.CustomButton.UseSelectable = true;
            this.textTime.CustomButton.Visible = false;
            this.textTime.Lines = new string[] {
        "10"};
            this.textTime.Location = new System.Drawing.Point(6, 49);
            this.textTime.MaxLength = 32767;
            this.textTime.Name = "textTime";
            this.textTime.PasswordChar = '\0';
            this.textTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textTime.SelectedText = "";
            this.textTime.SelectionLength = 0;
            this.textTime.SelectionStart = 0;
            this.textTime.ShortcutsEnabled = true;
            this.textTime.Size = new System.Drawing.Size(41, 23);
            this.textTime.TabIndex = 1;
            this.textTime.Text = "10";
            this.textTime.UseSelectable = true;
            this.textTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textTime.TextChanged += new System.EventHandler(this.textTime_TextChanged);
            // 
            // pickEvery
            // 
            this.pickEvery.AutoSize = true;
            this.pickEvery.DisplayFocus = true;
            this.pickEvery.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.pickEvery.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.pickEvery.Location = new System.Drawing.Point(7, 20);
            this.pickEvery.Name = "pickEvery";
            this.pickEvery.Size = new System.Drawing.Size(94, 19);
            this.pickEvery.TabIndex = 0;
            this.pickEvery.Text = "Pobieraj co:";
            this.pickEvery.UseCustomBackColor = true;
            this.pickEvery.UseSelectable = true;
            this.pickEvery.CheckedChanged += new System.EventHandler(this.pickEvery_CheckedChanged);
            // 
            // setRequest
            // 
            this.setRequest.DisplayFocus = true;
            this.setRequest.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.setRequest.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.setRequest.Location = new System.Drawing.Point(177, 103);
            this.setRequest.Name = "setRequest";
            this.setRequest.Size = new System.Drawing.Size(149, 23);
            this.setRequest.TabIndex = 4;
            this.setRequest.Text = "Ustaw subskrypcje";
            this.setRequest.UseSelectable = true;
            this.setRequest.Click += new System.EventHandler(this.setRequest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.askTime);
            this.groupBox1.Controls.Add(this.askServer);
            this.groupBox1.Controls.Add(this.askTopics);
            this.groupBox1.Location = new System.Drawing.Point(332, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zapytania";
            // 
            // askTime
            // 
            this.askTime.AutoSize = true;
            this.askTime.DisplayFocus = true;
            this.askTime.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.askTime.ForeColor = System.Drawing.Color.Black;
            this.askTime.Location = new System.Drawing.Point(16, 19);
            this.askTime.Name = "askTime";
            this.askTime.Size = new System.Drawing.Size(135, 19);
            this.askTime.TabIndex = 0;
            this.askTime.Text = "Zapytaj o interwał";
            this.askTime.UseCustomBackColor = true;
            this.askTime.UseCustomForeColor = true;
            this.askTime.UseSelectable = true;
            // 
            // askServer
            // 
            this.askServer.BackColor = System.Drawing.Color.Cyan;
            this.askServer.DisplayFocus = true;
            this.askServer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.askServer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.askServer.Location = new System.Drawing.Point(14, 71);
            this.askServer.Name = "askServer";
            this.askServer.Size = new System.Drawing.Size(155, 23);
            this.askServer.TabIndex = 2;
            this.askServer.Text = "Zapytaj serwer";
            this.askServer.UseCustomBackColor = true;
            this.askServer.UseSelectable = true;
            this.askServer.Click += new System.EventHandler(this.askServer_Click);
            // 
            // askTopics
            // 
            this.askTopics.AutoSize = true;
            this.askTopics.DisplayFocus = true;
            this.askTopics.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.askTopics.ForeColor = System.Drawing.Color.Black;
            this.askTopics.Location = new System.Drawing.Point(16, 42);
            this.askTopics.Name = "askTopics";
            this.askTopics.Size = new System.Drawing.Size(120, 19);
            this.askTopics.TabIndex = 0;
            this.askTopics.Text = "Zapytaj o topiki";
            this.askTopics.UseCustomBackColor = true;
            this.askTopics.UseCustomForeColor = true;
            this.askTopics.UseSelectable = true;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.DisplayFocus = true;
            this.btnStop.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStop.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnStop.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnStop.Location = new System.Drawing.Point(177, 61);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(149, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Zatrzymaj subskrypcję";
            this.btnStop.UseCustomBackColor = true;
            this.btnStop.UseCustomForeColor = true;
            this.btnStop.UseSelectable = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.DisplayFocus = true;
            this.btnStart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStart.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnStart.Location = new System.Drawing.Point(177, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Subskrybuj";
            this.btnStart.UseCustomBackColor = true;
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // subDisk
            // 
            this.subDisk.AutoSize = true;
            this.subDisk.DisplayFocus = true;
            this.subDisk.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.subDisk.ForeColor = System.Drawing.Color.Black;
            this.subDisk.Location = new System.Drawing.Point(16, 74);
            this.subDisk.Name = "subDisk";
            this.subDisk.Size = new System.Drawing.Size(126, 19);
            this.subDisk.TabIndex = 0;
            this.subDisk.Text = "Subskrybuj Dysk";
            this.subDisk.UseCustomBackColor = true;
            this.subDisk.UseCustomForeColor = true;
            this.subDisk.UseSelectable = true;
            // 
            // subRAM
            // 
            this.subRAM.AutoSize = true;
            this.subRAM.DisplayFocus = true;
            this.subRAM.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.subRAM.ForeColor = System.Drawing.Color.Black;
            this.subRAM.Location = new System.Drawing.Point(16, 53);
            this.subRAM.Name = "subRAM";
            this.subRAM.Size = new System.Drawing.Size(126, 19);
            this.subRAM.TabIndex = 0;
            this.subRAM.Text = "Subskrybuj RAM";
            this.subRAM.UseCustomBackColor = true;
            this.subRAM.UseCustomForeColor = true;
            this.subRAM.UseSelectable = true;
            // 
            // subCPU
            // 
            this.subCPU.AutoSize = true;
            this.subCPU.DisplayFocus = true;
            this.subCPU.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.subCPU.ForeColor = System.Drawing.Color.Black;
            this.subCPU.Location = new System.Drawing.Point(16, 32);
            this.subCPU.Name = "subCPU";
            this.subCPU.Size = new System.Drawing.Size(123, 19);
            this.subCPU.TabIndex = 0;
            this.subCPU.Text = "Subksrybuj CPU";
            this.subCPU.UseCustomBackColor = true;
            this.subCPU.UseCustomForeColor = true;
            this.subCPU.UseSelectable = true;
            // 
            // windowLogs
            // 
            this.windowLogs.BackColor = System.Drawing.SystemColors.Info;
            this.windowLogs.FormattingEnabled = true;
            this.windowLogs.Location = new System.Drawing.Point(24, 252);
            this.windowLogs.Name = "windowLogs";
            this.windowLogs.Size = new System.Drawing.Size(551, 264);
            this.windowLogs.TabIndex = 1;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(630, 216);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "CPU";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "RAM";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "DYSK";
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(575, 300);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(658, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "CPU:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(658, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "RAM:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(656, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "DYSK:";
            // 
            // metroProgressCPU
            // 
            this.metroProgressCPU.Location = new System.Drawing.Point(714, 95);
            this.metroProgressCPU.Name = "metroProgressCPU";
            this.metroProgressCPU.Size = new System.Drawing.Size(398, 23);
            this.metroProgressCPU.TabIndex = 4;
            // 
            // metroProgressRAM
            // 
            this.metroProgressRAM.Location = new System.Drawing.Point(714, 133);
            this.metroProgressRAM.Name = "metroProgressRAM";
            this.metroProgressRAM.Size = new System.Drawing.Size(398, 23);
            this.metroProgressRAM.TabIndex = 4;
            // 
            // metroProgressDisk
            // 
            this.metroProgressDisk.Location = new System.Drawing.Point(714, 171);
            this.metroProgressDisk.Name = "metroProgressDisk";
            this.metroProgressDisk.Size = new System.Drawing.Size(398, 23);
            this.metroProgressDisk.TabIndex = 4;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(1118, 95);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(27, 19);
            this.labelCPU.TabIndex = 3;
            this.labelCPU.Text = "0%";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Location = new System.Drawing.Point(1118, 133);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(27, 19);
            this.labelRAM.TabIndex = 3;
            this.labelRAM.Text = "0%";
            // 
            // labelDisk
            // 
            this.labelDisk.AutoSize = true;
            this.labelDisk.Location = new System.Drawing.Point(1118, 171);
            this.labelDisk.Name = "labelDisk";
            this.labelDisk.Size = new System.Drawing.Size(27, 19);
            this.labelDisk.TabIndex = 3;
            this.labelDisk.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 562);
            this.Controls.Add(this.metroProgressDisk);
            this.Controls.Add(this.metroProgressRAM);
            this.Controls.Add(this.metroProgressCPU);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.labelDisk);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.windowLogs);
            this.Controls.Add(this.subSettings);
            this.Name = "Form1";
            this.Text = "SubKlient";
            this.subSettings.ResumeLayout(false);
            this.subSettings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox subSettings;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroCheckBox subDisk;
        private MetroFramework.Controls.MetroCheckBox subRAM;
        private MetroFramework.Controls.MetroCheckBox subCPU;
        private System.Windows.Forms.ListBox windowLogs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressBar metroProgressCPU;
        private MetroFramework.Controls.MetroProgressBar metroProgressRAM;
        private MetroFramework.Controls.MetroProgressBar metroProgressDisk;
        private MetroFramework.Controls.MetroLabel labelCPU;
        private MetroFramework.Controls.MetroLabel labelRAM;
        private MetroFramework.Controls.MetroLabel labelDisk;
        private MetroFramework.Controls.MetroButton askServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox askTime;
        private MetroFramework.Controls.MetroCheckBox askTopics;
        private MetroFramework.Controls.MetroButton setRequest;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel sekund;
        private MetroFramework.Controls.MetroTextBox textTime;
        private MetroFramework.Controls.MetroCheckBox pickEvery;
        private System.Windows.Forms.Timer timer1;
    }
}


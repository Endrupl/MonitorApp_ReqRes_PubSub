namespace ProgramSubMonitor
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
            this.settingBox = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.timeText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.pubDisk = new MetroFramework.Controls.MetroCheckBox();
            this.pubRAM = new MetroFramework.Controls.MetroCheckBox();
            this.pubCPU = new MetroFramework.Controls.MetroCheckBox();
            this.windowLogs = new System.Windows.Forms.ListBox();
            this.perfRAM = new System.Diagnostics.PerformanceCounter();
            this.perfCPU = new System.Diagnostics.PerformanceCounter();
            this.perfDisk = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.settingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfDisk)).BeginInit();
            this.SuspendLayout();
            // 
            // settingBox
            // 
            this.settingBox.Controls.Add(this.metroLabel2);
            this.settingBox.Controls.Add(this.timeText);
            this.settingBox.Controls.Add(this.metroLabel1);
            this.settingBox.Controls.Add(this.btnStart);
            this.settingBox.Controls.Add(this.pubDisk);
            this.settingBox.Controls.Add(this.pubRAM);
            this.settingBox.Controls.Add(this.pubCPU);
            this.settingBox.Location = new System.Drawing.Point(23, 76);
            this.settingBox.Name = "settingBox";
            this.settingBox.Size = new System.Drawing.Size(596, 160);
            this.settingBox.TabIndex = 1;
            this.settingBox.TabStop = false;
            this.settingBox.Text = "Ustawienia";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(395, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "sekund";
            // 
            // timeText
            // 
            // 
            // 
            // 
            this.timeText.CustomButton.Image = null;
            this.timeText.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.timeText.CustomButton.Name = "";
            this.timeText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timeText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeText.CustomButton.TabIndex = 1;
            this.timeText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeText.CustomButton.UseSelectable = true;
            this.timeText.CustomButton.Visible = false;
            this.timeText.Lines = new string[] {
        "10"};
            this.timeText.Location = new System.Drawing.Point(314, 51);
            this.timeText.MaxLength = 32767;
            this.timeText.Name = "timeText";
            this.timeText.PasswordChar = '\0';
            this.timeText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeText.SelectedText = "";
            this.timeText.SelectionLength = 0;
            this.timeText.SelectionStart = 0;
            this.timeText.ShortcutsEnabled = true;
            this.timeText.Size = new System.Drawing.Size(75, 23);
            this.timeText.TabIndex = 3;
            this.timeText.Text = "10";
            this.timeText.UseSelectable = true;
            this.timeText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(305, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Publikuj informacje co:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SkyBlue;
            this.btnStart.DisplayFocus = true;
            this.btnStart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStart.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnStart.Location = new System.Drawing.Point(16, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(562, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseCustomBackColor = true;
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pubDisk
            // 
            this.pubDisk.AutoSize = true;
            this.pubDisk.DisplayFocus = true;
            this.pubDisk.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.pubDisk.Location = new System.Drawing.Point(16, 71);
            this.pubDisk.Name = "pubDisk";
            this.pubDisk.Size = new System.Drawing.Size(107, 19);
            this.pubDisk.TabIndex = 0;
            this.pubDisk.Text = "Publikuj Dysk";
            this.pubDisk.UseSelectable = true;
            // 
            // pubRAM
            // 
            this.pubRAM.AutoSize = true;
            this.pubRAM.DisplayFocus = true;
            this.pubRAM.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.pubRAM.Location = new System.Drawing.Point(16, 50);
            this.pubRAM.Name = "pubRAM";
            this.pubRAM.Size = new System.Drawing.Size(107, 19);
            this.pubRAM.TabIndex = 0;
            this.pubRAM.Text = "Publikuj RAM";
            this.pubRAM.UseSelectable = true;
            // 
            // pubCPU
            // 
            this.pubCPU.AutoSize = true;
            this.pubCPU.DisplayFocus = true;
            this.pubCPU.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.pubCPU.Location = new System.Drawing.Point(16, 29);
            this.pubCPU.Name = "pubCPU";
            this.pubCPU.Size = new System.Drawing.Size(104, 19);
            this.pubCPU.TabIndex = 0;
            this.pubCPU.Text = "Publikuj CPU";
            this.pubCPU.UseSelectable = true;
            // 
            // windowLogs
            // 
            this.windowLogs.FormattingEnabled = true;
            this.windowLogs.Location = new System.Drawing.Point(23, 242);
            this.windowLogs.Name = "windowLogs";
            this.windowLogs.Size = new System.Drawing.Size(596, 342);
            this.windowLogs.TabIndex = 2;
            // 
            // perfRAM
            // 
            this.perfRAM.CategoryName = "Pamięć";
            this.perfRAM.CounterName = "Zadeklarowane bajty w użyciu (%)";
            // 
            // perfCPU
            // 
            this.perfCPU.CategoryName = "Procesor";
            this.perfCPU.CounterName = "Czas procesora (%)";
            this.perfCPU.InstanceName = "_Total";
            // 
            // perfDisk
            // 
            this.perfDisk.CategoryName = "Dysk logiczny";
            this.perfDisk.CounterName = "Czas dysku (%)";
            this.perfDisk.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 611);
            this.Controls.Add(this.windowLogs);
            this.Controls.Add(this.settingBox);
            this.Name = "Form1";
            this.Text = "PubSerwer";
            this.settingBox.ResumeLayout(false);
            this.settingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfDisk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox settingBox;
        private System.Windows.Forms.ListBox windowLogs;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroCheckBox pubDisk;
        private MetroFramework.Controls.MetroCheckBox pubRAM;
        private MetroFramework.Controls.MetroCheckBox pubCPU;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox timeText;
        private System.Diagnostics.PerformanceCounter perfRAM;
        private System.Diagnostics.PerformanceCounter perfCPU;
        private System.Diagnostics.PerformanceCounter perfDisk;
        private System.Windows.Forms.Timer timer;
    }
}


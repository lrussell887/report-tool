namespace Report_Tool
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.chkEnableAutoRefresh = new System.Windows.Forms.CheckBox();
            this.nudRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.lblRefreshInterval = new System.Windows.Forms.Label();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.chkEnableNotificationSound = new System.Windows.Forms.CheckBox();
            this.chkEnableNotifications = new System.Windows.Forms.CheckBox();
            this.btnResetDefaults = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshInterval)).BeginInit();
            this.grpReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnableAutoRefresh
            // 
            this.chkEnableAutoRefresh.AutoSize = true;
            this.chkEnableAutoRefresh.Checked = true;
            this.chkEnableAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableAutoRefresh.Location = new System.Drawing.Point(6, 45);
            this.chkEnableAutoRefresh.Name = "chkEnableAutoRefresh";
            this.chkEnableAutoRefresh.Size = new System.Drawing.Size(118, 17);
            this.chkEnableAutoRefresh.TabIndex = 2;
            this.chkEnableAutoRefresh.Text = "Enable auto-refresh";
            this.chkEnableAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // nudRefreshInterval
            // 
            this.nudRefreshInterval.Location = new System.Drawing.Point(144, 19);
            this.nudRefreshInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudRefreshInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRefreshInterval.Name = "nudRefreshInterval";
            this.nudRefreshInterval.Size = new System.Drawing.Size(120, 20);
            this.nudRefreshInterval.TabIndex = 1;
            this.nudRefreshInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblRefreshInterval
            // 
            this.lblRefreshInterval.AutoSize = true;
            this.lblRefreshInterval.Location = new System.Drawing.Point(6, 21);
            this.lblRefreshInterval.Name = "lblRefreshInterval";
            this.lblRefreshInterval.Size = new System.Drawing.Size(130, 13);
            this.lblRefreshInterval.TabIndex = 0;
            this.lblRefreshInterval.Text = "Refresh Interval (minutes):";
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.chkEnableNotificationSound);
            this.grpReports.Controls.Add(this.chkEnableNotifications);
            this.grpReports.Controls.Add(this.chkEnableAutoRefresh);
            this.grpReports.Controls.Add(this.nudRefreshInterval);
            this.grpReports.Controls.Add(this.lblRefreshInterval);
            this.grpReports.Location = new System.Drawing.Point(12, 12);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(270, 114);
            this.grpReports.TabIndex = 0;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // chkEnableNotificationSound
            // 
            this.chkEnableNotificationSound.AutoSize = true;
            this.chkEnableNotificationSound.Checked = true;
            this.chkEnableNotificationSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableNotificationSound.Location = new System.Drawing.Point(6, 91);
            this.chkEnableNotificationSound.Name = "chkEnableNotificationSound";
            this.chkEnableNotificationSound.Size = new System.Drawing.Size(145, 17);
            this.chkEnableNotificationSound.TabIndex = 4;
            this.chkEnableNotificationSound.Text = "Enable notification sound";
            this.chkEnableNotificationSound.UseVisualStyleBackColor = true;
            // 
            // chkEnableNotifications
            // 
            this.chkEnableNotifications.AutoSize = true;
            this.chkEnableNotifications.Checked = true;
            this.chkEnableNotifications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableNotifications.Location = new System.Drawing.Point(6, 68);
            this.chkEnableNotifications.Name = "chkEnableNotifications";
            this.chkEnableNotifications.Size = new System.Drawing.Size(118, 17);
            this.chkEnableNotifications.TabIndex = 3;
            this.chkEnableNotifications.Text = "Enable notifications";
            this.chkEnableNotifications.UseVisualStyleBackColor = true;
            // 
            // btnResetDefaults
            // 
            this.btnResetDefaults.AutoSize = true;
            this.btnResetDefaults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetDefaults.Image = global::Report_Tool.Properties.Resources.reset;
            this.btnResetDefaults.Location = new System.Drawing.Point(12, 132);
            this.btnResetDefaults.Name = "btnResetDefaults";
            this.btnResetDefaults.Size = new System.Drawing.Size(103, 23);
            this.btnResetDefaults.TabIndex = 1;
            this.btnResetDefaults.Text = "Reset Defaults";
            this.btnResetDefaults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetDefaults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetDefaults.UseVisualStyleBackColor = true;
            this.btnResetDefaults.Click += new System.EventHandler(this.btnResetDefaults_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Report_Tool.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(207, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 167);
            this.Controls.Add(this.btnResetDefaults);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshInterval)).EndInit();
            this.grpReports.ResumeLayout(false);
            this.grpReports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnableAutoRefresh;
        private System.Windows.Forms.NumericUpDown nudRefreshInterval;
        private System.Windows.Forms.Label lblRefreshInterval;
        private System.Windows.Forms.GroupBox grpReports;
        private System.Windows.Forms.CheckBox chkEnableNotificationSound;
        private System.Windows.Forms.CheckBox chkEnableNotifications;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResetDefaults;
    }
}
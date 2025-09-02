using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Tool
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            nudRefreshInterval.Value = Properties.Settings.Default.RefreshInterval;
            chkEnableAutoRefresh.Checked = Properties.Settings.Default.EnableAutoRefresh;
            chkEnableNotifications.Checked = Properties.Settings.Default.EnableNotifications;
            chkEnableNotificationSound.Checked = Properties.Settings.Default.EnableNotificationSound;
        }

        private void btnResetDefaults_Click(object sender, EventArgs e)
        {
            nudRefreshInterval.Value = 3;
            chkEnableAutoRefresh.Checked = true;
            chkEnableNotifications.Checked = true;
            chkEnableNotificationSound.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RefreshInterval = (int)nudRefreshInterval.Value;
            Properties.Settings.Default.EnableAutoRefresh = chkEnableAutoRefresh.Checked;
            Properties.Settings.Default.EnableNotifications = chkEnableNotifications.Checked;
            Properties.Settings.Default.EnableNotificationSound = chkEnableNotificationSound.Checked;
            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
        }
    }
}

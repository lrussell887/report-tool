using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using System.Reflection;
using System.Globalization;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualBasic;
using PlayerIOClient;
using Tulpep.NotificationWindow;

namespace Report_Tool
{
    public partial class MainForm : Form
    {
        public Client Client;
        public Connection Connection;

        public string Username, Position;

        public static Report[] Reports = new Report[0], PreviousReports;
        public System.Timers.Timer RefreshTimer;

        public static PopupNotifier reportNotifier = new PopupNotifier();
        public static string notifiedReportId = string.Empty;

        public MainForm()
        {
            InitializeComponent();

            if (Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }

            cmbSearchColumn.SelectedIndex = 0;

            reportNotifier.ShowGrip = false;
            reportNotifier.Image = Properties.Resources.notification;
            reportNotifier.ImagePadding = new Padding(4);
            reportNotifier.Click += ReportNotifier_Click;
        }

        #region Event handlers
        private void MainForm_Shown(object sender, EventArgs e)
        {
            accountToolStripMenuItem.PerformClick();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Connection != null && Connection.Connected)
            {
                Connection.Disconnect();
            }
        }

        private void RefreshTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RefreshReports();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView listView = (ListView)((ContextMenuStrip)(((ToolStripItem)sender).Owner)).SourceControl;
            ListViewHitTestInfo hit = listView.HitTest(listView.PointToClient(cmsCopy.Bounds.Location));

            if (hit.SubItem != null && !string.IsNullOrEmpty(hit.SubItem.Text))
            {
                Clipboard.SetText(hit.SubItem.Text);
            }
        }

        private void ReportNotifier_Click(object sender, EventArgs e)
        {
            reportNotifier.Hide();

            Activate();
            WindowState = FormWindowState.Normal;

            if (!string.IsNullOrEmpty(notifiedReportId))
            {
                DisplayReport(Reports.Single(r => r.ID == notifiedReportId));
            }
        }
        #endregion

        #region Menu buttons
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new SettingsForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (Connection != null && Connection.Connected)
                    {
                        ConfigureRefreshTimer();
                    }
                }
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AccountForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Client = form.Client;

                    Connection = form.Connection;
                    Connection.Send("init");
                    Connection.OnMessage += ToolConnection_OnMessage;
                }
            }
        }

        private void viewReportStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Reports.Length > 0)
            {
                int uncheckedCount = Reports.Count(r => r.Handler == "nobody");
                int openCount = Reports.Count(r => r.Status == "Open");
                int pendingCount = Reports.Count(r => r.Status == "Pending");
                int solvedCount = Reports.Count(r => r.Status == "Solved");
                int spamCount = Reports.Count(r => r.Status == "Spam");
                int duplicateCount = Reports.Count(r => r.Status == "Duplicate");

                Dictionary<string, int> handlerCount = new Dictionary<string, int>();

                foreach (var report in Reports)
                {
                    if (report.Handler != "nobody")
                    {
                        handlerCount.TryGetValue(report.Handler, out int i);
                        handlerCount[report.Handler] = i + 1;
                    }
                }

                StringBuilder stats = new StringBuilder();

                stats.AppendLine($"Out of the last {Reports.Length} reports:");
                stats.AppendLine();
                stats.AppendLine($"{uncheckedCount} ({(uncheckedCount / (double)Reports.Length) * 100}%) reports have not been checked.");
                stats.AppendLine();
                stats.AppendLine($"{openCount} ({(openCount / (double)Reports.Length) * 100}%) reports are open.");
                stats.AppendLine($"{pendingCount} ({(pendingCount / (double)Reports.Length) * 100}%) reports are pending.");
                stats.AppendLine($"{solvedCount} ({(solvedCount / (double)Reports.Length) * 100}%) reports are solved.");
                stats.AppendLine($"{spamCount} ({(spamCount / (double)Reports.Length) * 100}%) reports are spam.");
                stats.AppendLine($"{duplicateCount} ({(duplicateCount / (double)Reports.Length) * 100}%) reports are duplicates.");
                stats.AppendLine();
                
                foreach (var handler in handlerCount.OrderByDescending(h => h.Value))
                {
                    stats.AppendLine($"{handler.Key} has handled {handler.Value} ({(handler.Value / (double)Reports.Length) * 100}%) reports.");
                }

                MessageBox.Show(stats.ToString(), "Report Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime buildDate = new DateTime(2000, 1, 1).Add(new TimeSpan(TimeSpan.TicksPerDay * Assembly.GetEntryAssembly().GetName().Version.Build));

            StringBuilder about = new StringBuilder();
            about.AppendLine("Everybody Edits Report Tool " + Application.ProductVersion);
            about.AppendLine("Build date: " + buildDate.ToLongDateString());
            about.AppendLine();
            about.AppendLine("Created by lrussell");

            MessageBox.Show(about.ToString(), "About Report Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Helper methods
        public void RefreshReports()
        {
            if (Connection != null && Connection.Connected)
            {
                slblStatus.Text = "Requesting reports";
                Connection.Send("getLatestReports");
            }
        }

        public void DisplayReportList(Report[] reports)
        {
            lvwReports.BeginInvoke((MethodInvoker)delegate ()
            {
                lvwReports.BeginUpdate();
                lvwReports.Items.Clear();

                foreach (Report report in reports)
                {
                    List<string> reportData = new List<string>
                    {
                        report.Accuser,
                        report.Accusee,
                        report.Status,
                        report.Handler,
                        report.Reason
                    };

                    ListViewItem reportRow = new ListViewItem(reportData.ToArray())
                    {
                        BackColor = lvwReports.Items.Count % 2 == 0 ? Color.White : Color.FromArgb(245, 245, 245),
                        Name = report.ID
                    };

                    lvwReports.Items.Add(reportRow);
                }

                lvwReports.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwReports.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwReports.EndUpdate();
            });
        }

        public void FilterReportList(string column, string query)
        {
            if (column == "All")
            {
                DisplayReportList(Reports.ToArray());
                return;
            }

            List<Report> filteredReports = new List<Report>();

            foreach (Report report in Reports)
            {
                string value = (string)report.GetType().GetProperty(column).GetValue(report, null);

                if (value.StartsWith(query, StringComparison.InvariantCultureIgnoreCase))
                {
                    filteredReports.Add(report);
                }
            }

            DisplayReportList(filteredReports.ToArray());
        }

        public void DisplayReport(Report report)
        {
            tabMain.SelectedTab = tpReportManager;

            // Report Information
            txtId.Text = report.ID;
            txtDate.Text = report.Date.ToLocalTime().ToString();
            txtAccuser.Text = report.Accuser;
            txtAccusee.Text = report.Accusee;
            txtWorld.Text = $"{report.WorldName} ({report.WorldId})";
            rtbReportReason.Text = report.Reason;

            // Chat Messages
            rtbChatMessages.BeginUpdate();
            rtbChatMessages.Clear();

            for (int i = 0; i < report.ChatLog.Length; i++)
            {
                string[] colonSplit = report.ChatLog[i].Split(new char[] { ':' }, 2);

                if (colonSplit.Length < 2)
                {
                    rtbChatMessages.AppendText(report.ChatLog[i] + (i < report.ChatLog.Length - 1 ? Environment.NewLine : string.Empty));
                    continue;
                }

                string player = colonSplit[0], message = colonSplit[1];

                rtbChatMessages.SelectionColor = player == report.Accuser ? Color.Green : player == report.Accusee ? Color.Red : SystemColors.WindowText;
                rtbChatMessages.SelectionFont = new Font(rtbChatMessages.Font, FontStyle.Bold);
                rtbChatMessages.AppendText(player + ":");

                rtbChatMessages.SelectionFont = new Font(rtbChatMessages.Font, FontStyle.Regular);
                rtbChatMessages.AppendText(message + (i < report.ChatLog.Length - 1 ? Environment.NewLine : string.Empty));
            }
            
            rtbChatMessages.SelectionStart = 0;
            rtbChatMessages.EndUpdate();

            // Report Control
            cmbStatus.Text = report.Status;
            txtActionTaken.Text = report.ActionTaken;
            txtHandler.Text = report.Handler;

            // Ban Control
            txtBanPlayer.Text = report.Accusee;
            txtBanReason.Clear();
            nudDays.Value = 0;
            nudHours.Value = 0;
            nudMinutes.Value = 0;
            nudSeconds.Value = 0;
        }

        public void DisplayPlayerAlts(Alt[] alts)
        {
            lvwAlternateAccounts.BeginInvoke((MethodInvoker)delegate ()
            {
                lvwAlternateAccounts.BeginUpdate();
                lvwAlternateAccounts.Items.Clear();

                foreach (Alt alt in alts)
                {
                    List<string> altData = new List<string>
                    {
                        alt.Username,
                        alt.UserId,
                        (alt.OnlineStatus) ? "Online" : "Offline",
                        alt.WorldID,
                        alt.WorldName
                    };

                    ListViewItem altRow = new ListViewItem(altData.ToArray());
                    altRow.SubItems[2].ForeColor = (alt.OnlineStatus) ? Color.Green : Color.Red;
                    altRow.UseItemStyleForSubItems = false;

                    lvwAlternateAccounts.Items.Add(altRow);
                }

                lvwAlternateAccounts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwAlternateAccounts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwAlternateAccounts.EndUpdate();
            });
        }

        public void DisplayPlayerBans(Ban[] bans)
        {
            lvwRecentBans.BeginInvoke((MethodInvoker)delegate ()
            {
                lvwRecentBans.BeginUpdate();
                lvwRecentBans.Items.Clear();

                if (bans.Length > 0)
                {
                    foreach (Ban ban in bans)
                    {
                        List<string> banData = new List<string>
                        {
                            ban.ID,
                            ban.BanDate.ToLocalTime().ToString(),
                            ban.ExpirationDate.ToLocalTime().ToString(),
                            ban.BannedBy,
                            ban.Reason
                        };

                        ListViewItem banRow = new ListViewItem(banData.ToArray());
                        lvwRecentBans.Items.Add(banRow);
                    }
                }
                else
                {
                    lvwRecentBans.Items.Add("No recent bans found.");
                }

                lvwRecentBans.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwRecentBans.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwRecentBans.EndUpdate();
            });
        }

        public static void NotifyReport()
        {
            if (Properties.Settings.Default.EnableNotifications && PreviousReports.Length > 0)
            {
                Report[] newReports = Reports.Where(n => !PreviousReports.Any(o => n.ID == o.ID) && n.Handler == "nobody").ToArray();

                if (newReports.Length > 0)
                {
                    if (newReports.Length == 1)
                    {
                        Report newReport = newReports.First();
                        reportNotifier.TitleText = $"{newReport.Accuser} reported {newReport.Accusee}";
                        reportNotifier.ContentText = newReport.Reason;
                        notifiedReportId = newReport.ID;
                    }
                    else
                    {
                        reportNotifier.TitleText = $"{newReports.Length} new reports";
                        notifiedReportId = string.Empty;
                    }

                    reportNotifier.Popup();

                    if (Properties.Settings.Default.EnableNotificationSound)
                    {
                        new SoundPlayer(Properties.Resources.notify).Play();
                    }
                }
            }
        }

        public void ConfigureRefreshTimer()
        {
            if (RefreshTimer != null)
            {
                RefreshTimer.Dispose();
            }

            RefreshTimer = new System.Timers.Timer();
            RefreshTimer.Elapsed += RefreshTimer_Elapsed;
            RefreshTimer.Interval = Properties.Settings.Default.RefreshInterval * 60 * 1000;
            RefreshTimer.Enabled = Properties.Settings.Default.EnableAutoRefresh;
        }
        #endregion

        #region Report List
        private void listViewReports_DoubleClick(object sender, EventArgs e)
        {
            if (lvwReports.SelectedItems.Count > 0)
            {
                string reportId = lvwReports.SelectedItems[0].Name;
                DisplayReport(Reports.Single(r => r.ID == reportId));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshReports();
        }

        private void cmbSearchColumn_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbSearchQuery.Text = string.Empty;
            cmbSearchQuery.Items.Clear();

            switch (cmbSearchColumn.Text)
            {
                case "All":
                    {
                        cmbSearchQuery.DropDownStyle = ComboBoxStyle.Simple;
                        cmbSearchQuery.Enabled = false;
                    }
                    break;
                case "Status":
                    {
                        cmbSearchQuery.DropDownStyle = ComboBoxStyle.DropDown;
                        cmbSearchQuery.Items.AddRange(new string[] { "Open", "Pending", "Solved", "Spam", "Duplicate" });
                        cmbSearchQuery.Enabled = true;
                    }
                    break;
                case "ID":
                case "Accuser":
                case "Accusee":
                case "Handler":
                    {
                        cmbSearchQuery.DropDownStyle = ComboBoxStyle.Simple;
                        cmbSearchQuery.Enabled = true;
                    }
                    break;
            }

            cmbSearchQuery.Focus();
        }

        private void cmbSearchQuery_TextChanged(object sender, EventArgs e)
        {
            FilterReportList(cmbSearchColumn.Text, cmbSearchQuery.Text);
        }
        #endregion

        #region Report Manager
        private void picAccuserInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAccuser.Text))
            {
                tabMain.SelectedIndex = 2;
                tabPlayerInfo.SelectedIndex = 0;
                txtSearchPlayer.Text = txtAccuser.Text;
                btnSearchPlayer.PerformClick();
            }
        }

        private void picAccuseeInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAccusee.Text))
            {
                tabMain.SelectedIndex = 2;
                tabPlayerInfo.SelectedIndex = 0;
                txtSearchPlayer.Text = txtAccusee.Text;
                btnSearchPlayer.PerformClick();
            }
        }

        private void picWorldLink_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                string id = Reports.Single(r => r.ID == txtId.Text).WorldId;
                string result = Interaction.InputBox($"Press OK to open this world in your browser.{Environment.NewLine}{Environment.NewLine}To copy only the ID, use CTRL+C then press Cancel to close this dialog.", "Open World", id);

                if (result == id)
                {
                    Process.Start("http://everybodyedits.com/games/" + id.Replace(" ", "-"));
                }
            }
        }

        private void rtbReportReason_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void rtbChatMessages_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                if (!string.IsNullOrEmpty(cmbStatus.Text) && !string.IsNullOrEmpty(txtActionTaken.Text))
                {
                    Connection.Send("saveReport", txtId.Text, txtActionTaken.Text, cmbStatus.Text);
                }
                else
                {
                    MessageBox.Show("Please select a status and describe the action taken for this report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPermaban_Click(object sender, EventArgs e)
        {
            if (Connection != null && Connection.Connected)
            {
                if (!string.IsNullOrEmpty(txtBanPlayer.Text) && !string.IsNullOrEmpty(txtBanReason.Text))
                {
                    var result = MessageBox.Show($"Are you sure you want to permaban \"{txtBanPlayer.Text}\"?", "Permaban Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        RoomConnection.Send("say", string.Format("/ban {0} {1}", txtBanPlayer.Text, txtBanReason.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Please provide the player's name and ban reason.", "Ban Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIpBan_Click(object sender, EventArgs e)
        {
            if (Connection != null && Connection.Connected)
            {
                if (!string.IsNullOrEmpty(txtBanPlayer.Text))
                {
                    var result = MessageBox.Show($"Are you sure you want to IP ban \"{txtBanPlayer.Text}\" for {nudDays.Value} day(s)?", "IP Ban Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        RoomConnection.Send("say", string.Format("/banip {0} {1}", txtBanPlayer.Text, nudDays.Value));
                    }
                }
                else
                {
                    MessageBox.Show("Please provide the player's name and ban duration (days only).", "Ban Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            if (Connection != null && Connection.Connected)
            {
                if (!string.IsNullOrEmpty(txtBanPlayer.Text) && !string.IsNullOrEmpty(txtBanReason.Text))
                {
                    var result = MessageBox.Show($"Are you sure you want to temporarily ban \"{txtBanPlayer.Text}\"?", "Ban Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string banLength = string.Format("{0}d{1}h{2}m{3}s", nudDays.Value, nudHours.Value, nudMinutes.Value, nudSeconds.Value);
                        RoomConnection.Send("say", string.Format("/tempban {0} {1} {2}", txtBanPlayer.Text, banLength, txtBanReason.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Please provide the player's name, ban reason, and ban duration.", "Ban Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNewer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) && lvwReports.Items.Count > 0)
            {
                int curIndex = lvwReports.Items.IndexOfKey(txtId.Text);
                if (curIndex == -1) return;

                int nextIndex = curIndex > 0 ? curIndex - 1 : curIndex;

                if (nextIndex != curIndex)
                {
                    DisplayReport(Reports.Single(r => r.ID == lvwReports.Items[nextIndex].Name));
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                }
            }
        }

        private void btnOlder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) && lvwReports.Items.Count > 0)
            {
                int curIndex = lvwReports.Items.IndexOfKey(txtId.Text);
                if (curIndex == -1) return;

                int prevIndex = curIndex < lvwReports.Items.Count - 1 ? curIndex + 1 : curIndex;

                if (prevIndex != curIndex)
                {
                    DisplayReport(Reports.Single(r => r.ID == lvwReports.Items[prevIndex].Name));
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                }
            }
        }
        #endregion

        #region Player Information
        private void txtSearchPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchPlayer.PerformClick();
            }
        }

        private void btnSearchPlayer_Click(object sender, EventArgs e)
        {
            if (Connection != null && Connection.Connected)
            {
                lvwAlternateAccounts.Items.Clear();
                lvwRecentBans.Items.Clear();

                string player = txtSearchPlayer.Text.ToLower().Trim();
                Connection.Send("getPlayersAlts", player);
                Connection.Send("getPlayersBans", player);
            }
        }
        #endregion

        #region Tool Room
        private void ToolConnection_OnMessage(object sender, PlayerIOClient.Message m)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                switch (m.Type)
                {
                    case "init":
                        {
                            Username = m.GetString(0);
                            Position = m.GetString(1);
                            Text = $"Everybody Edits Report Tool - [{Username} / {Position}]";

                            RefreshReports();
                            ConfigureRefreshTimer();
                        }
                        break;
                    case "getLatestReports":
                        {
                            slblStatus.Text = "Received reports, updating";
                            List<Report> reports = new List<Report>();

                            for (uint i = 0; i < m.Count; i += 12)
                            {
                                Report report = new Report()
                                {
                                    ID = m.GetString(i + 0),
                                    Status = m.GetString(i + 1),
                                    WorldId = m.GetString(i + 3),
                                    WorldName = m.GetString(i + 4),
                                    Accuser = m.GetString(i + 5),
                                    Accusee = m.GetString(i + 6),
                                    Reason = m.GetString(i + 7).TrimEnd(),
                                    ActionTaken = m.GetString(i + 8),
                                    ChatLog = m.GetString(i + 9).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries),
                                    Handler = m.GetString(i + 10).ToLower()
                                };

                                if (DateTime.TryParseExact(m.GetString(i + 2), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out DateTime date))
                                {
                                    report.Date = date;
                                }

                                reports.Add(report);
                            }

                            PreviousReports = Reports.ToArray();
                            Reports = reports.ToArray();

                            FilterReportList(cmbSearchColumn.Text, cmbSearchQuery.Text);
                            NotifyReport();

                            slblStatus.Text = "Reports last updated at " + DateTime.Now.ToLongTimeString();
                        }
                        break;
                    case "getPlayersAlts":
                        {
                            List<Alt> alts = new List<Alt>();

                            for (uint i = 0; i < m.Count; i += 4)
                            {
                                Alt alt = new Alt()
                                {
                                    Username = m.GetString(i),
                                    WorldName = m.GetString(i + 1),
                                    WorldID = m.GetString(i + 2),
                                    UserId = m.GetString(i + 3)
                                };

                                alt.OnlineStatus = !(alt.WorldID == string.Empty);
                                alts.Add(alt);
                            }

                            DisplayPlayerAlts(alts.OrderByDescending(a => a.OnlineStatus).ToArray());
                        }
                        break;
                    case "getPlayersBans":
                        {
                            List<Ban> bans = new List<Ban>();

                            if (m[0].GetType() != typeof(bool))
                            {
                                for (uint i = 2; i < m.Count; i += 5)
                                {
                                    Ban ban = new Ban()
                                    {
                                        ID = m.GetString(i),
                                        BannedBy = m.GetString(i + 3).ToLower(),
                                        Reason = m.GetString(i + 4)
                                    };

                                    if (DateTime.TryParseExact(m.GetString(i + 1), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out DateTime banDate))
                                    {
                                        ban.BanDate = banDate;
                                    }

                                    if (DateTime.TryParseExact(m.GetString(i + 2), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out DateTime expirationDate))
                                    {
                                        ban.ExpirationDate = expirationDate;
                                    }

                                    bans.Add(ban);
                                }
                            }

                            DisplayPlayerBans(bans.ToArray());
                        }
                        break;
                    case "saveReport":
                        {
                            if (m.GetBoolean(0))
                            {
                                int index = Reports.TakeWhile(r => r.ID != txtId.Text).Count();
                                Reports[index].Status = cmbStatus.Text;
                                Reports[index].ActionTaken = txtActionTaken.Text;
                                Reports[index].Handler = Username;

                                FilterReportList(cmbSearchColumn.Text, cmbSearchQuery.Text);
                                txtHandler.Text = Username;

                                slblStatus.Text = "Report saved at " + DateTime.Now.ToLongTimeString();
                            }
                            else
                            {
                                MessageBox.Show(m.GetString(1), "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                }
            });
        }
        #endregion

        #region Moderator Room
        private Connection _roomConnection;
        public Connection RoomConnection
        {
            get
            {
                if (_roomConnection == null || !_roomConnection.Connected)
                {
                    slblStatus.Text = "Connecting to Moderator Room";

                    int version = Client.BigDB.Load("config", "config").GetInt("version");
                    _roomConnection = Client.Multiplayer.CreateJoinRoom("PWl61tgprycEI", "Everybodyedits" + version, false, null, null);
                    _roomConnection.Send("init");

                    AutoResetEvent wait = new AutoResetEvent(false);

                    void OnMessage(object sender, PlayerIOClient.Message e)
                    {
                        switch (e.Type)
                        {
                            case "init":
                                {
                                    slblStatus.Text = "Connected to Moderator Room";
                                    wait.Set();
                                }
                                break;
                            case "write":
                                {
                                    if (e.Count > 1 && e.GetString(1) != "Joined invisible world.")
                                    {
                                        _roomConnection.Disconnect();
                                        slblStatus.Text = "Completed action in Moderator Room at " + DateTime.Now.ToLongTimeString();
                                        MessageBox.Show(e.GetString(1), "Message from Moderator Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                break;
                        }
                    }

                    _roomConnection.OnMessage += OnMessage;
                    wait.WaitOne();
                }

                return _roomConnection;
            }
        }
        #endregion
    }
}
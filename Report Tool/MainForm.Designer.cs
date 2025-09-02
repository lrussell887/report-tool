namespace Report_Tool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpReportList = new System.Windows.Forms.TabPage();
            this.cmbSearchQuery = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbSearchColumn = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvwReports = new System.Windows.Forms.ListView();
            this.chAccuser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAccusee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHandler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpReportManager = new System.Windows.Forms.TabPage();
            this.btnNewer = new System.Windows.Forms.Button();
            this.btnOlder = new System.Windows.Forms.Button();
            this.tlpPrimary = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.grpChatMessages = new System.Windows.Forms.GroupBox();
            this.grpReportInformation = new System.Windows.Forms.GroupBox();
            this.rtbReportReason = new System.Windows.Forms.RichTextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.picWorldLink = new System.Windows.Forms.PictureBox();
            this.picAccuseeInfo = new System.Windows.Forms.PictureBox();
            this.picAccuserInfo = new System.Windows.Forms.PictureBox();
            this.lblWorld = new System.Windows.Forms.Label();
            this.lblAccusee = new System.Windows.Forms.Label();
            this.txtWorld = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAccusee = new System.Windows.Forms.TextBox();
            this.lblAccuser = new System.Windows.Forms.Label();
            this.txtAccuser = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.grpBanControl = new System.Windows.Forms.GroupBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.lblDays = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.btnIpBan = new System.Windows.Forms.Button();
            this.btnPermaban = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblBanReason = new System.Windows.Forms.Label();
            this.txtBanReason = new System.Windows.Forms.TextBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.txtBanPlayer = new System.Windows.Forms.TextBox();
            this.grpReportControl = new System.Windows.Forms.GroupBox();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.txtHandler = new System.Windows.Forms.TextBox();
            this.lblHandledBy = new System.Windows.Forms.Label();
            this.lblActionTaken = new System.Windows.Forms.Label();
            this.txtActionTaken = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.tpPlayerInfo = new System.Windows.Forms.TabPage();
            this.btnSearchPlayer = new System.Windows.Forms.Button();
            this.lblPlayerSearch = new System.Windows.Forms.Label();
            this.tabPlayerInfo = new System.Windows.Forms.TabControl();
            this.tpAlts = new System.Windows.Forms.TabPage();
            this.lvwAlternateAccounts = new System.Windows.Forms.ListView();
            this.chAltName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAltUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAltOnlineStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAltWorldId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAltWorldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpRecentBans = new System.Windows.Forms.TabPage();
            this.lvwRecentBans = new System.Windows.Forms.ListView();
            this.chBanId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBanDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBanExpiration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBannedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBanReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgIcons = new System.Windows.Forms.ImageList(this.components);
            this.txtSearchPlayer = new System.Windows.Forms.TextBox();
            this.ssrMain = new System.Windows.Forms.StatusStrip();
            this.slblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbChatMessages = new ExtendedRichTextBox();
            this.msMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tpReportList.SuspendLayout();
            this.cmsCopy.SuspendLayout();
            this.tpReportManager.SuspendLayout();
            this.tlpPrimary.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.grpChatMessages.SuspendLayout();
            this.grpReportInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorldLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccuseeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccuserInfo)).BeginInit();
            this.tlpRight.SuspendLayout();
            this.grpBanControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.grpReportControl.SuspendLayout();
            this.tpPlayerInfo.SuspendLayout();
            this.tabPlayerInfo.SuspendLayout();
            this.tpAlts.SuspendLayout();
            this.tpRecentBans.SuspendLayout();
            this.ssrMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.accountToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportStatisticsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // viewReportStatisticsToolStripMenuItem
            // 
            this.viewReportStatisticsToolStripMenuItem.Name = "viewReportStatisticsToolStripMenuItem";
            this.viewReportStatisticsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewReportStatisticsToolStripMenuItem.Text = "View Report Statistics";
            this.viewReportStatisticsToolStripMenuItem.Click += new System.EventHandler(this.viewReportStatisticsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tpReportList);
            this.tabMain.Controls.Add(this.tpReportManager);
            this.tabMain.Controls.Add(this.tpPlayerInfo);
            this.tabMain.ImageList = this.imgIcons;
            this.tabMain.Location = new System.Drawing.Point(0, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(784, 509);
            this.tabMain.TabIndex = 1;
            // 
            // tpReportList
            // 
            this.tpReportList.Controls.Add(this.cmbSearchQuery);
            this.tpReportList.Controls.Add(this.lblSearch);
            this.tpReportList.Controls.Add(this.cmbSearchColumn);
            this.tpReportList.Controls.Add(this.btnRefresh);
            this.tpReportList.Controls.Add(this.lvwReports);
            this.tpReportList.ImageKey = "list.png";
            this.tpReportList.Location = new System.Drawing.Point(4, 26);
            this.tpReportList.Name = "tpReportList";
            this.tpReportList.Padding = new System.Windows.Forms.Padding(3);
            this.tpReportList.Size = new System.Drawing.Size(776, 479);
            this.tpReportList.TabIndex = 0;
            this.tpReportList.Text = "Report List";
            this.tpReportList.UseVisualStyleBackColor = true;
            // 
            // cmbSearchQuery
            // 
            this.cmbSearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSearchQuery.FormattingEnabled = true;
            this.cmbSearchQuery.Location = new System.Drawing.Point(185, 455);
            this.cmbSearchQuery.Name = "cmbSearchQuery";
            this.cmbSearchQuery.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchQuery.TabIndex = 3;
            this.cmbSearchQuery.TextChanged += new System.EventHandler(this.cmbSearchQuery_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 458);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search:";
            // 
            // cmbSearchColumn
            // 
            this.cmbSearchColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSearchColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchColumn.FormattingEnabled = true;
            this.cmbSearchColumn.Items.AddRange(new object[] {
            "All",
            "ID",
            "Accuser",
            "Accusee",
            "Status",
            "Handler"});
            this.cmbSearchColumn.Location = new System.Drawing.Point(58, 455);
            this.cmbSearchColumn.Name = "cmbSearchColumn";
            this.cmbSearchColumn.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchColumn.TabIndex = 2;
            this.cmbSearchColumn.SelectedValueChanged += new System.EventHandler(this.cmbSearchColumn_SelectedValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::Report_Tool.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(693, 453);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lvwReports
            // 
            this.lvwReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAccuser,
            this.chAccusee,
            this.chStatus,
            this.chHandler,
            this.chReason});
            this.lvwReports.ContextMenuStrip = this.cmsCopy;
            this.lvwReports.FullRowSelect = true;
            this.lvwReports.GridLines = true;
            this.lvwReports.Location = new System.Drawing.Point(6, 6);
            this.lvwReports.Name = "lvwReports";
            this.lvwReports.Size = new System.Drawing.Size(762, 441);
            this.lvwReports.TabIndex = 0;
            this.lvwReports.UseCompatibleStateImageBehavior = false;
            this.lvwReports.View = System.Windows.Forms.View.Details;
            this.lvwReports.DoubleClick += new System.EventHandler(this.listViewReports_DoubleClick);
            // 
            // chAccuser
            // 
            this.chAccuser.Text = "Accuser";
            this.chAccuser.Width = 51;
            // 
            // chAccusee
            // 
            this.chAccusee.Text = "Accusee";
            this.chAccusee.Width = 54;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 42;
            // 
            // chHandler
            // 
            this.chHandler.Text = "Handler";
            this.chHandler.Width = 49;
            // 
            // chReason
            // 
            this.chReason.Text = "Reason";
            this.chReason.Width = 49;
            // 
            // cmsCopy
            // 
            this.cmsCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.cmsCopy.Name = "cmsPlayerInfo";
            this.cmsCopy.ShowImageMargin = false;
            this.cmsCopy.Size = new System.Drawing.Size(78, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // tpReportManager
            // 
            this.tpReportManager.Controls.Add(this.btnNewer);
            this.tpReportManager.Controls.Add(this.btnOlder);
            this.tpReportManager.Controls.Add(this.tlpPrimary);
            this.tpReportManager.ImageKey = "manager.png";
            this.tpReportManager.Location = new System.Drawing.Point(4, 26);
            this.tpReportManager.Name = "tpReportManager";
            this.tpReportManager.Size = new System.Drawing.Size(776, 479);
            this.tpReportManager.TabIndex = 2;
            this.tpReportManager.Text = "Report Manager";
            this.tpReportManager.UseVisualStyleBackColor = true;
            // 
            // btnNewer
            // 
            this.btnNewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewer.Image = global::Report_Tool.Properties.Resources.newer;
            this.btnNewer.Location = new System.Drawing.Point(612, 453);
            this.btnNewer.Name = "btnNewer";
            this.btnNewer.Size = new System.Drawing.Size(75, 23);
            this.btnNewer.TabIndex = 1;
            this.btnNewer.Text = "Newer";
            this.btnNewer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewer.UseVisualStyleBackColor = true;
            this.btnNewer.Click += new System.EventHandler(this.btnNewer_Click);
            // 
            // btnOlder
            // 
            this.btnOlder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOlder.Image = global::Report_Tool.Properties.Resources.older;
            this.btnOlder.Location = new System.Drawing.Point(693, 453);
            this.btnOlder.Name = "btnOlder";
            this.btnOlder.Size = new System.Drawing.Size(75, 23);
            this.btnOlder.TabIndex = 2;
            this.btnOlder.Text = "Older";
            this.btnOlder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOlder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOlder.UseVisualStyleBackColor = true;
            this.btnOlder.Click += new System.EventHandler(this.btnOlder_Click);
            // 
            // tlpPrimary
            // 
            this.tlpPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPrimary.ColumnCount = 2;
            this.tlpPrimary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrimary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrimary.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpPrimary.Controls.Add(this.tlpRight, 1, 0);
            this.tlpPrimary.Location = new System.Drawing.Point(0, 0);
            this.tlpPrimary.Name = "tlpPrimary";
            this.tlpPrimary.RowCount = 1;
            this.tlpPrimary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrimary.Size = new System.Drawing.Size(776, 447);
            this.tlpPrimary.TabIndex = 0;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 382F));
            this.tlpLeft.Controls.Add(this.grpChatMessages, 0, 1);
            this.tlpLeft.Controls.Add(this.grpReportInformation, 0, 0);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.Size = new System.Drawing.Size(382, 441);
            this.tlpLeft.TabIndex = 0;
            // 
            // grpChatMessages
            // 
            this.grpChatMessages.Controls.Add(this.rtbChatMessages);
            this.grpChatMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChatMessages.Location = new System.Drawing.Point(3, 168);
            this.grpChatMessages.Name = "grpChatMessages";
            this.grpChatMessages.Size = new System.Drawing.Size(376, 274);
            this.grpChatMessages.TabIndex = 1;
            this.grpChatMessages.TabStop = false;
            this.grpChatMessages.Text = "Chat Messages";
            // 
            // grpReportInformation
            // 
            this.grpReportInformation.Controls.Add(this.rtbReportReason);
            this.grpReportInformation.Controls.Add(this.lblReason);
            this.grpReportInformation.Controls.Add(this.picWorldLink);
            this.grpReportInformation.Controls.Add(this.picAccuseeInfo);
            this.grpReportInformation.Controls.Add(this.picAccuserInfo);
            this.grpReportInformation.Controls.Add(this.lblWorld);
            this.grpReportInformation.Controls.Add(this.lblAccusee);
            this.grpReportInformation.Controls.Add(this.txtWorld);
            this.grpReportInformation.Controls.Add(this.txtId);
            this.grpReportInformation.Controls.Add(this.txtAccusee);
            this.grpReportInformation.Controls.Add(this.lblAccuser);
            this.grpReportInformation.Controls.Add(this.txtAccuser);
            this.grpReportInformation.Controls.Add(this.lblDate);
            this.grpReportInformation.Controls.Add(this.lblId);
            this.grpReportInformation.Controls.Add(this.txtDate);
            this.grpReportInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReportInformation.Location = new System.Drawing.Point(3, 3);
            this.grpReportInformation.Name = "grpReportInformation";
            this.grpReportInformation.Size = new System.Drawing.Size(376, 159);
            this.grpReportInformation.TabIndex = 0;
            this.grpReportInformation.TabStop = false;
            this.grpReportInformation.Text = "Report Information";
            // 
            // rtbReportReason
            // 
            this.rtbReportReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbReportReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReportReason.Location = new System.Drawing.Point(70, 114);
            this.rtbReportReason.Name = "rtbReportReason";
            this.rtbReportReason.ReadOnly = true;
            this.rtbReportReason.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbReportReason.Size = new System.Drawing.Size(300, 39);
            this.rtbReportReason.TabIndex = 11;
            this.rtbReportReason.Text = "";
            this.rtbReportReason.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbReportReason_LinkClicked);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(6, 114);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(47, 13);
            this.lblReason.TabIndex = 10;
            this.lblReason.Text = "Reason:";
            // 
            // picWorldLink
            // 
            this.picWorldLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picWorldLink.Image = global::Report_Tool.Properties.Resources.link;
            this.picWorldLink.Location = new System.Drawing.Point(354, 92);
            this.picWorldLink.Name = "picWorldLink";
            this.picWorldLink.Size = new System.Drawing.Size(16, 16);
            this.picWorldLink.TabIndex = 17;
            this.picWorldLink.TabStop = false;
            this.picWorldLink.Click += new System.EventHandler(this.picWorldLink_Click);
            // 
            // picAccuseeInfo
            // 
            this.picAccuseeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAccuseeInfo.Image = ((System.Drawing.Image)(resources.GetObject("picAccuseeInfo.Image")));
            this.picAccuseeInfo.Location = new System.Drawing.Point(354, 73);
            this.picAccuseeInfo.Name = "picAccuseeInfo";
            this.picAccuseeInfo.Size = new System.Drawing.Size(16, 16);
            this.picAccuseeInfo.TabIndex = 16;
            this.picAccuseeInfo.TabStop = false;
            this.picAccuseeInfo.Click += new System.EventHandler(this.picAccuseeInfo_Click);
            // 
            // picAccuserInfo
            // 
            this.picAccuserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAccuserInfo.Image = ((System.Drawing.Image)(resources.GetObject("picAccuserInfo.Image")));
            this.picAccuserInfo.Location = new System.Drawing.Point(354, 54);
            this.picAccuserInfo.Name = "picAccuserInfo";
            this.picAccuserInfo.Size = new System.Drawing.Size(16, 16);
            this.picAccuserInfo.TabIndex = 15;
            this.picAccuserInfo.TabStop = false;
            this.picAccuserInfo.Click += new System.EventHandler(this.picAccuserInfo_Click);
            // 
            // lblWorld
            // 
            this.lblWorld.AutoSize = true;
            this.lblWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorld.Location = new System.Drawing.Point(6, 95);
            this.lblWorld.Name = "lblWorld";
            this.lblWorld.Size = new System.Drawing.Size(38, 13);
            this.lblWorld.TabIndex = 8;
            this.lblWorld.Text = "World:";
            // 
            // lblAccusee
            // 
            this.lblAccusee.AutoSize = true;
            this.lblAccusee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccusee.Location = new System.Drawing.Point(6, 76);
            this.lblAccusee.Name = "lblAccusee";
            this.lblAccusee.Size = new System.Drawing.Size(52, 13);
            this.lblAccusee.TabIndex = 6;
            this.lblAccusee.Text = "Accusee:";
            // 
            // txtWorld
            // 
            this.txtWorld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorld.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorld.Location = new System.Drawing.Point(70, 95);
            this.txtWorld.Name = "txtWorld";
            this.txtWorld.ReadOnly = true;
            this.txtWorld.Size = new System.Drawing.Size(278, 13);
            this.txtWorld.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Location = new System.Drawing.Point(70, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(300, 13);
            this.txtId.TabIndex = 1;
            // 
            // txtAccusee
            // 
            this.txtAccusee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccusee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccusee.Location = new System.Drawing.Point(70, 76);
            this.txtAccusee.Name = "txtAccusee";
            this.txtAccusee.ReadOnly = true;
            this.txtAccusee.Size = new System.Drawing.Size(278, 13);
            this.txtAccusee.TabIndex = 7;
            // 
            // lblAccuser
            // 
            this.lblAccuser.AutoSize = true;
            this.lblAccuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccuser.Location = new System.Drawing.Point(6, 57);
            this.lblAccuser.Name = "lblAccuser";
            this.lblAccuser.Size = new System.Drawing.Size(49, 13);
            this.lblAccuser.TabIndex = 4;
            this.lblAccuser.Text = "Accuser:";
            // 
            // txtAccuser
            // 
            this.txtAccuser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccuser.Location = new System.Drawing.Point(70, 57);
            this.txtAccuser.Name = "txtAccuser";
            this.txtAccuser.ReadOnly = true;
            this.txtAccuser.Size = new System.Drawing.Size(278, 13);
            this.txtAccuser.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(6, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Location = new System.Drawing.Point(70, 38);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(300, 13);
            this.txtDate.TabIndex = 3;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRight.Controls.Add(this.grpBanControl, 0, 1);
            this.tlpRight.Controls.Add(this.grpReportControl, 0, 0);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(391, 3);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 2;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRight.Size = new System.Drawing.Size(382, 441);
            this.tlpRight.TabIndex = 1;
            // 
            // grpBanControl
            // 
            this.grpBanControl.Controls.Add(this.lblMinutes);
            this.grpBanControl.Controls.Add(this.nudMinutes);
            this.grpBanControl.Controls.Add(this.lblSeconds);
            this.grpBanControl.Controls.Add(this.nudSeconds);
            this.grpBanControl.Controls.Add(this.lblHours);
            this.grpBanControl.Controls.Add(this.nudHours);
            this.grpBanControl.Controls.Add(this.lblDays);
            this.grpBanControl.Controls.Add(this.nudDays);
            this.grpBanControl.Controls.Add(this.btnIpBan);
            this.grpBanControl.Controls.Add(this.btnPermaban);
            this.grpBanControl.Controls.Add(this.btnBan);
            this.grpBanControl.Controls.Add(this.lblDuration);
            this.grpBanControl.Controls.Add(this.lblBanReason);
            this.grpBanControl.Controls.Add(this.txtBanReason);
            this.grpBanControl.Controls.Add(this.lblPlayer);
            this.grpBanControl.Controls.Add(this.txtBanPlayer);
            this.grpBanControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBanControl.Location = new System.Drawing.Point(3, 223);
            this.grpBanControl.Name = "grpBanControl";
            this.grpBanControl.Size = new System.Drawing.Size(379, 215);
            this.grpBanControl.TabIndex = 1;
            this.grpBanControl.TabStop = false;
            this.grpBanControl.Text = "Ban Control";
            // 
            // lblMinutes
            // 
            this.lblMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinutes.Location = new System.Drawing.Point(264, 134);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(53, 13);
            this.lblMinutes.TabIndex = 11;
            this.lblMinutes.Text = "minutes";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudMinutes
            // 
            this.nudMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinutes.Location = new System.Drawing.Point(267, 111);
            this.nudMinutes.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(50, 20);
            this.nudMinutes.TabIndex = 7;
            // 
            // lblSeconds
            // 
            this.lblSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeconds.Location = new System.Drawing.Point(320, 134);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(53, 13);
            this.lblSeconds.TabIndex = 12;
            this.lblSeconds.Text = "seconds";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudSeconds
            // 
            this.nudSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSeconds.Location = new System.Drawing.Point(323, 111);
            this.nudSeconds.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(50, 20);
            this.nudSeconds.TabIndex = 8;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHours.Location = new System.Drawing.Point(208, 134);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(53, 13);
            this.lblHours.TabIndex = 10;
            this.lblHours.Text = "hours";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudHours
            // 
            this.nudHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHours.Location = new System.Drawing.Point(211, 111);
            this.nudHours.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(50, 20);
            this.nudHours.TabIndex = 6;
            // 
            // lblDays
            // 
            this.lblDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDays.Location = new System.Drawing.Point(152, 134);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(53, 13);
            this.lblDays.TabIndex = 9;
            this.lblDays.Text = "days";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudDays
            // 
            this.nudDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDays.Location = new System.Drawing.Point(155, 111);
            this.nudDays.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(50, 20);
            this.nudDays.TabIndex = 5;
            // 
            // btnIpBan
            // 
            this.btnIpBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIpBan.AutoSize = true;
            this.btnIpBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIpBan.Image = global::Report_Tool.Properties.Resources.ip_ban;
            this.btnIpBan.Location = new System.Drawing.Point(186, 179);
            this.btnIpBan.Name = "btnIpBan";
            this.btnIpBan.Size = new System.Drawing.Size(97, 23);
            this.btnIpBan.TabIndex = 14;
            this.btnIpBan.Text = "IP Ban Player";
            this.btnIpBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIpBan.UseVisualStyleBackColor = true;
            this.btnIpBan.Click += new System.EventHandler(this.btnIpBan_Click);
            // 
            // btnPermaban
            // 
            this.btnPermaban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPermaban.AutoSize = true;
            this.btnPermaban.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPermaban.Image = global::Report_Tool.Properties.Resources.permaban;
            this.btnPermaban.Location = new System.Drawing.Point(67, 179);
            this.btnPermaban.Name = "btnPermaban";
            this.btnPermaban.Size = new System.Drawing.Size(113, 23);
            this.btnPermaban.TabIndex = 13;
            this.btnPermaban.Text = "Permaban Player";
            this.btnPermaban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPermaban.UseVisualStyleBackColor = true;
            this.btnPermaban.Click += new System.EventHandler(this.btnPermaban_Click);
            // 
            // btnBan
            // 
            this.btnBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBan.AutoSize = true;
            this.btnBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBan.Image = global::Report_Tool.Properties.Resources.ban;
            this.btnBan.Location = new System.Drawing.Point(289, 179);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(84, 23);
            this.btnBan.TabIndex = 15;
            this.btnBan.Text = "Ban Player";
            this.btnBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(6, 113);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 13);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration:\r\n";
            // 
            // lblBanReason
            // 
            this.lblBanReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBanReason.AutoSize = true;
            this.lblBanReason.Location = new System.Drawing.Point(6, 48);
            this.lblBanReason.Name = "lblBanReason";
            this.lblBanReason.Size = new System.Drawing.Size(47, 13);
            this.lblBanReason.TabIndex = 2;
            this.lblBanReason.Text = "Reason:";
            // 
            // txtBanReason
            // 
            this.txtBanReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBanReason.Location = new System.Drawing.Point(123, 45);
            this.txtBanReason.Multiline = true;
            this.txtBanReason.Name = "txtBanReason";
            this.txtBanReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBanReason.Size = new System.Drawing.Size(250, 60);
            this.txtBanReason.TabIndex = 3;
            // 
            // lblPlayer
            // 
            this.lblPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(6, 22);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(39, 13);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player:";
            // 
            // txtBanPlayer
            // 
            this.txtBanPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBanPlayer.Location = new System.Drawing.Point(123, 19);
            this.txtBanPlayer.Name = "txtBanPlayer";
            this.txtBanPlayer.Size = new System.Drawing.Size(250, 20);
            this.txtBanPlayer.TabIndex = 1;
            // 
            // grpReportControl
            // 
            this.grpReportControl.Controls.Add(this.btnSaveReport);
            this.grpReportControl.Controls.Add(this.txtHandler);
            this.grpReportControl.Controls.Add(this.lblHandledBy);
            this.grpReportControl.Controls.Add(this.lblActionTaken);
            this.grpReportControl.Controls.Add(this.txtActionTaken);
            this.grpReportControl.Controls.Add(this.lblStatus);
            this.grpReportControl.Controls.Add(this.cmbStatus);
            this.grpReportControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReportControl.Location = new System.Drawing.Point(3, 3);
            this.grpReportControl.Name = "grpReportControl";
            this.grpReportControl.Size = new System.Drawing.Size(379, 214);
            this.grpReportControl.TabIndex = 0;
            this.grpReportControl.TabStop = false;
            this.grpReportControl.Text = "Report Control";
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveReport.AutoSize = true;
            this.btnSaveReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveReport.Image = global::Report_Tool.Properties.Resources.save;
            this.btnSaveReport.Location = new System.Drawing.Point(280, 131);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(93, 23);
            this.btnSaveReport.TabIndex = 6;
            this.btnSaveReport.Text = "Save Report";
            this.btnSaveReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // txtHandler
            // 
            this.txtHandler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHandler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHandler.Location = new System.Drawing.Point(123, 112);
            this.txtHandler.Name = "txtHandler";
            this.txtHandler.ReadOnly = true;
            this.txtHandler.Size = new System.Drawing.Size(250, 13);
            this.txtHandler.TabIndex = 5;
            // 
            // lblHandledBy
            // 
            this.lblHandledBy.AutoSize = true;
            this.lblHandledBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandledBy.Location = new System.Drawing.Point(6, 112);
            this.lblHandledBy.Name = "lblHandledBy";
            this.lblHandledBy.Size = new System.Drawing.Size(65, 13);
            this.lblHandledBy.TabIndex = 4;
            this.lblHandledBy.Text = "Handled By:";
            // 
            // lblActionTaken
            // 
            this.lblActionTaken.AutoSize = true;
            this.lblActionTaken.Location = new System.Drawing.Point(6, 49);
            this.lblActionTaken.Name = "lblActionTaken";
            this.lblActionTaken.Size = new System.Drawing.Size(74, 13);
            this.lblActionTaken.TabIndex = 2;
            this.lblActionTaken.Text = "Action Taken:";
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActionTaken.Location = new System.Drawing.Point(123, 46);
            this.txtActionTaken.Multiline = true;
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActionTaken.Size = new System.Drawing.Size(250, 60);
            this.txtActionTaken.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(6, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Open",
            "Pending",
            "Solved",
            "Spam",
            "Duplicate"});
            this.cmbStatus.Location = new System.Drawing.Point(123, 19);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(250, 21);
            this.cmbStatus.TabIndex = 1;
            // 
            // tpPlayerInfo
            // 
            this.tpPlayerInfo.Controls.Add(this.btnSearchPlayer);
            this.tpPlayerInfo.Controls.Add(this.lblPlayerSearch);
            this.tpPlayerInfo.Controls.Add(this.tabPlayerInfo);
            this.tpPlayerInfo.Controls.Add(this.txtSearchPlayer);
            this.tpPlayerInfo.ImageKey = "player.png";
            this.tpPlayerInfo.Location = new System.Drawing.Point(4, 26);
            this.tpPlayerInfo.Name = "tpPlayerInfo";
            this.tpPlayerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayerInfo.Size = new System.Drawing.Size(776, 479);
            this.tpPlayerInfo.TabIndex = 1;
            this.tpPlayerInfo.Text = "Player Information";
            this.tpPlayerInfo.UseVisualStyleBackColor = true;
            // 
            // btnSearchPlayer
            // 
            this.btnSearchPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearchPlayer.Image = global::Report_Tool.Properties.Resources.search;
            this.btnSearchPlayer.Location = new System.Drawing.Point(179, 453);
            this.btnSearchPlayer.Name = "btnSearchPlayer";
            this.btnSearchPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPlayer.TabIndex = 3;
            this.btnSearchPlayer.Text = "Search";
            this.btnSearchPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearchPlayer.UseVisualStyleBackColor = true;
            this.btnSearchPlayer.Click += new System.EventHandler(this.btnSearchPlayer_Click);
            // 
            // lblPlayerSearch
            // 
            this.lblPlayerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlayerSearch.AutoSize = true;
            this.lblPlayerSearch.Location = new System.Drawing.Point(8, 458);
            this.lblPlayerSearch.Name = "lblPlayerSearch";
            this.lblPlayerSearch.Size = new System.Drawing.Size(39, 13);
            this.lblPlayerSearch.TabIndex = 1;
            this.lblPlayerSearch.Text = "Player:";
            // 
            // tabPlayerInfo
            // 
            this.tabPlayerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPlayerInfo.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPlayerInfo.Controls.Add(this.tpAlts);
            this.tabPlayerInfo.Controls.Add(this.tpRecentBans);
            this.tabPlayerInfo.ImageList = this.imgIcons;
            this.tabPlayerInfo.Location = new System.Drawing.Point(6, 6);
            this.tabPlayerInfo.Name = "tabPlayerInfo";
            this.tabPlayerInfo.SelectedIndex = 0;
            this.tabPlayerInfo.Size = new System.Drawing.Size(764, 443);
            this.tabPlayerInfo.TabIndex = 0;
            // 
            // tpAlts
            // 
            this.tpAlts.Controls.Add(this.lvwAlternateAccounts);
            this.tpAlts.ImageKey = "alts.png";
            this.tpAlts.Location = new System.Drawing.Point(4, 26);
            this.tpAlts.Name = "tpAlts";
            this.tpAlts.Size = new System.Drawing.Size(756, 413);
            this.tpAlts.TabIndex = 3;
            this.tpAlts.Text = "Alternate Accounts";
            this.tpAlts.UseVisualStyleBackColor = true;
            // 
            // lvwAlternateAccounts
            // 
            this.lvwAlternateAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAltName,
            this.chAltUserId,
            this.chAltOnlineStatus,
            this.chAltWorldId,
            this.chAltWorldName});
            this.lvwAlternateAccounts.ContextMenuStrip = this.cmsCopy;
            this.lvwAlternateAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAlternateAccounts.FullRowSelect = true;
            this.lvwAlternateAccounts.GridLines = true;
            this.lvwAlternateAccounts.Location = new System.Drawing.Point(0, 0);
            this.lvwAlternateAccounts.Name = "lvwAlternateAccounts";
            this.lvwAlternateAccounts.Size = new System.Drawing.Size(756, 413);
            this.lvwAlternateAccounts.TabIndex = 0;
            this.lvwAlternateAccounts.UseCompatibleStateImageBehavior = false;
            this.lvwAlternateAccounts.View = System.Windows.Forms.View.Details;
            // 
            // chAltName
            // 
            this.chAltName.Text = "Name";
            this.chAltName.Width = 40;
            // 
            // chAltUserId
            // 
            this.chAltUserId.Text = "User ID";
            this.chAltUserId.Width = 48;
            // 
            // chAltOnlineStatus
            // 
            this.chAltOnlineStatus.Text = "Online Status";
            this.chAltOnlineStatus.Width = 75;
            // 
            // chAltWorldId
            // 
            this.chAltWorldId.Text = "World ID";
            this.chAltWorldId.Width = 54;
            // 
            // chAltWorldName
            // 
            this.chAltWorldName.Text = "World Name";
            this.chAltWorldName.Width = 71;
            // 
            // tpRecentBans
            // 
            this.tpRecentBans.Controls.Add(this.lvwRecentBans);
            this.tpRecentBans.ImageKey = "bans.png";
            this.tpRecentBans.Location = new System.Drawing.Point(4, 26);
            this.tpRecentBans.Name = "tpRecentBans";
            this.tpRecentBans.Size = new System.Drawing.Size(756, 413);
            this.tpRecentBans.TabIndex = 2;
            this.tpRecentBans.Text = "Recent Bans";
            this.tpRecentBans.UseVisualStyleBackColor = true;
            // 
            // lvwRecentBans
            // 
            this.lvwRecentBans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBanId,
            this.chBanDate,
            this.chBanExpiration,
            this.chBannedBy,
            this.chBanReason});
            this.lvwRecentBans.ContextMenuStrip = this.cmsCopy;
            this.lvwRecentBans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRecentBans.FullRowSelect = true;
            this.lvwRecentBans.GridLines = true;
            this.lvwRecentBans.Location = new System.Drawing.Point(0, 0);
            this.lvwRecentBans.Name = "lvwRecentBans";
            this.lvwRecentBans.Size = new System.Drawing.Size(756, 413);
            this.lvwRecentBans.TabIndex = 0;
            this.lvwRecentBans.UseCompatibleStateImageBehavior = false;
            this.lvwRecentBans.View = System.Windows.Forms.View.Details;
            // 
            // chBanId
            // 
            this.chBanId.Text = "ID";
            this.chBanId.Width = 25;
            // 
            // chBanDate
            // 
            this.chBanDate.Text = "Date";
            this.chBanDate.Width = 35;
            // 
            // chBanExpiration
            // 
            this.chBanExpiration.Text = "Expiration";
            this.chBanExpiration.Width = 58;
            // 
            // chBannedBy
            // 
            this.chBannedBy.Text = "Banned By";
            this.chBannedBy.Width = 64;
            // 
            // chBanReason
            // 
            this.chBanReason.Text = "Reason";
            this.chBanReason.Width = 49;
            // 
            // imgIcons
            // 
            this.imgIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcons.ImageStream")));
            this.imgIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcons.Images.SetKeyName(0, "list.png");
            this.imgIcons.Images.SetKeyName(1, "manager.png");
            this.imgIcons.Images.SetKeyName(2, "player.png");
            this.imgIcons.Images.SetKeyName(3, "alts.png");
            this.imgIcons.Images.SetKeyName(4, "bans.png");
            // 
            // txtSearchPlayer
            // 
            this.txtSearchPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchPlayer.Location = new System.Drawing.Point(53, 455);
            this.txtSearchPlayer.Name = "txtSearchPlayer";
            this.txtSearchPlayer.Size = new System.Drawing.Size(120, 20);
            this.txtSearchPlayer.TabIndex = 2;
            this.txtSearchPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchPlayer_KeyDown);
            // 
            // ssrMain
            // 
            this.ssrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblStatus});
            this.ssrMain.Location = new System.Drawing.Point(0, 539);
            this.ssrMain.Name = "ssrMain";
            this.ssrMain.Size = new System.Drawing.Size(784, 22);
            this.ssrMain.TabIndex = 2;
            // 
            // slblStatus
            // 
            this.slblStatus.Name = "slblStatus";
            this.slblStatus.Size = new System.Drawing.Size(769, 17);
            this.slblStatus.Spring = true;
            this.slblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbChatMessages
            // 
            this.rtbChatMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChatMessages.Location = new System.Drawing.Point(3, 16);
            this.rtbChatMessages.Name = "rtbChatMessages";
            this.rtbChatMessages.ReadOnly = true;
            this.rtbChatMessages.Size = new System.Drawing.Size(370, 255);
            this.rtbChatMessages.TabIndex = 0;
            this.rtbChatMessages.Text = "";
            this.rtbChatMessages.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbChatMessages_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ssrMain);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Everybody Edits Report Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tpReportList.ResumeLayout(false);
            this.tpReportList.PerformLayout();
            this.cmsCopy.ResumeLayout(false);
            this.tpReportManager.ResumeLayout(false);
            this.tlpPrimary.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.grpChatMessages.ResumeLayout(false);
            this.grpReportInformation.ResumeLayout(false);
            this.grpReportInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorldLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccuseeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccuserInfo)).EndInit();
            this.tlpRight.ResumeLayout(false);
            this.grpBanControl.ResumeLayout(false);
            this.grpBanControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.grpReportControl.ResumeLayout(false);
            this.grpReportControl.PerformLayout();
            this.tpPlayerInfo.ResumeLayout(false);
            this.tpPlayerInfo.PerformLayout();
            this.tabPlayerInfo.ResumeLayout(false);
            this.tpAlts.ResumeLayout(false);
            this.tpRecentBans.ResumeLayout(false);
            this.ssrMain.ResumeLayout(false);
            this.ssrMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpReportList;
        private System.Windows.Forms.TabPage tpPlayerInfo;
        private System.Windows.Forms.ListView lvwReports;
        private System.Windows.Forms.ColumnHeader chAccuser;
        private System.Windows.Forms.ColumnHeader chAccusee;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chHandler;
        private System.Windows.Forms.ColumnHeader chReason;
        private System.Windows.Forms.TabPage tpReportManager;
        private System.Windows.Forms.StatusStrip ssrMain;
        private System.Windows.Forms.ToolStripStatusLabel slblStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbSearchColumn;
        private System.Windows.Forms.ComboBox cmbSearchQuery;
        private System.Windows.Forms.TabControl tabPlayerInfo;
        private System.Windows.Forms.TextBox txtSearchPlayer;
        private System.Windows.Forms.TabPage tpAlts;
        private System.Windows.Forms.ListView lvwAlternateAccounts;
        private System.Windows.Forms.ColumnHeader chAltName;
        private System.Windows.Forms.ColumnHeader chAltUserId;
        private System.Windows.Forms.ColumnHeader chAltOnlineStatus;
        private System.Windows.Forms.ColumnHeader chAltWorldId;
        private System.Windows.Forms.ColumnHeader chAltWorldName;
        private System.Windows.Forms.TabPage tpRecentBans;
        private System.Windows.Forms.ListView lvwRecentBans;
        private System.Windows.Forms.ColumnHeader chBanReason;
        private System.Windows.Forms.ColumnHeader chBannedBy;
        private System.Windows.Forms.ColumnHeader chBanDate;
        private System.Windows.Forms.ColumnHeader chBanExpiration;
        private System.Windows.Forms.ColumnHeader chBanId;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Label lblPlayerSearch;
        private System.Windows.Forms.ToolStripMenuItem viewReportStatisticsToolStripMenuItem;
        private System.Windows.Forms.ImageList imgIcons;
        private System.Windows.Forms.Button btnSearchPlayer;
        private System.Windows.Forms.ContextMenuStrip cmsCopy;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpPrimary;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.GroupBox grpChatMessages;
        private ExtendedRichTextBox rtbChatMessages;
        private System.Windows.Forms.GroupBox grpReportInformation;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.PictureBox picWorldLink;
        private System.Windows.Forms.PictureBox picAccuseeInfo;
        private System.Windows.Forms.PictureBox picAccuserInfo;
        private System.Windows.Forms.Label lblWorld;
        private System.Windows.Forms.Label lblAccusee;
        private System.Windows.Forms.TextBox txtWorld;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAccusee;
        private System.Windows.Forms.Label lblAccuser;
        private System.Windows.Forms.TextBox txtAccuser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.GroupBox grpReportControl;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.TextBox txtHandler;
        private System.Windows.Forms.Label lblHandledBy;
        private System.Windows.Forms.Label lblActionTaken;
        private System.Windows.Forms.TextBox txtActionTaken;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox grpBanControl;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Button btnIpBan;
        private System.Windows.Forms.Button btnPermaban;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblBanReason;
        private System.Windows.Forms.TextBox txtBanReason;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TextBox txtBanPlayer;
        private System.Windows.Forms.RichTextBox rtbReportReason;
        private System.Windows.Forms.Button btnOlder;
        private System.Windows.Forms.Button btnNewer;
    }
}


namespace Client
{
    partial class MainWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.injectDataGrid = new System.Windows.Forms.DataGridView();
            this.injectSearchInput = new System.Windows.Forms.TextBox();
            this.injectButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.summonButton = new System.Windows.Forms.Button();
            this.unitSearchInput = new System.Windows.Forms.TextBox();
            this.unitDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.arenaButton = new System.Windows.Forms.Button();
            this.rankUpButton = new System.Windows.Forms.Button();
            this.levelStatus = new System.Windows.Forms.RichTextBox();
            this.levelPartyButton = new System.Windows.Forms.Button();
            this.Missions = new System.Windows.Forms.TabPage();
            this.RepeatMission = new System.Windows.Forms.TextBox();
            this.RepeatLabel = new System.Windows.Forms.Label();
            this.RBAmazon = new System.Windows.Forms.RadioButton();
            this.RBAndroid = new System.Windows.Forms.RadioButton();
            this.RBiOS = new System.Windows.Forms.RadioButton();
            this.LBLevel = new System.Windows.Forms.TextBox();
            this.LBLabel = new System.Windows.Forms.Label();
            this.CBExplore = new System.Windows.Forms.CheckBox();
            this.CBUnits = new System.Windows.Forms.CheckBox();
            this.CBLoot = new System.Windows.Forms.CheckBox();
            this.CBChallenge = new System.Windows.Forms.CheckBox();
            this.CBTrophies = new System.Windows.Forms.CheckBox();
            this.StartMission = new System.Windows.Forms.Button();
            this.CBFriends = new System.Windows.Forms.CheckBox();
            this.MissionIdLabel = new System.Windows.Forms.Label();
            this.MissionSelect = new System.Windows.Forms.ComboBox();
            this.JPSummon = new System.Windows.Forms.TabPage();
            this.JPGachaTicket = new System.Windows.Forms.ComboBox();
            this.JPLogin = new System.Windows.Forms.Button();
            this.GachaSummon = new System.Windows.Forms.Button();
            this.JPGacha = new System.Windows.Forms.ComboBox();
            this.donateButton = new System.Windows.Forms.Button();
            this.consoleLog = new System.Windows.Forms.RichTextBox();
            this.ProxyPort = new System.Windows.Forms.TextBox();
            this.ProxyIP = new System.Windows.Forms.TextBox();
            this.fbtokenInput = new System.Windows.Forms.TextBox();
            this.fbidInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injectDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.Missions.SuspendLayout();
            this.JPSummon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.Missions);
            this.tabControl1.Controls.Add(this.JPSummon);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 231);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.injectDataGrid);
            this.tabPage1.Controls.Add(this.injectSearchInput);
            this.tabPage1.Controls.Add(this.injectButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Injection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // injectDataGrid
            // 
            this.injectDataGrid.AllowUserToAddRows = false;
            this.injectDataGrid.AllowUserToDeleteRows = false;
            this.injectDataGrid.AllowUserToResizeRows = false;
            this.injectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.injectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.injectDataGrid.Location = new System.Drawing.Point(3, 6);
            this.injectDataGrid.Name = "injectDataGrid";
            this.injectDataGrid.RowHeadersVisible = false;
            this.injectDataGrid.Size = new System.Drawing.Size(772, 165);
            this.injectDataGrid.TabIndex = 3;
            // 
            // injectSearchInput
            // 
            this.injectSearchInput.Location = new System.Drawing.Point(6, 178);
            this.injectSearchInput.Name = "injectSearchInput";
            this.injectSearchInput.Size = new System.Drawing.Size(253, 20);
            this.injectSearchInput.TabIndex = 2;
            this.injectSearchInput.Text = "search";
            this.injectSearchInput.TextChanged += new System.EventHandler(this.InjectSearchInput_TextChanged);
            // 
            // injectButton
            // 
            this.injectButton.Location = new System.Drawing.Point(700, 176);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(75, 23);
            this.injectButton.TabIndex = 1;
            this.injectButton.Text = "inject";
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.summonButton);
            this.tabPage2.Controls.Add(this.unitSearchInput);
            this.tabPage2.Controls.Add(this.unitDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unit Hunter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // summonButton
            // 
            this.summonButton.Location = new System.Drawing.Point(648, 176);
            this.summonButton.Name = "summonButton";
            this.summonButton.Size = new System.Drawing.Size(127, 23);
            this.summonButton.TabIndex = 2;
            this.summonButton.Text = "summon highlighted";
            this.summonButton.UseVisualStyleBackColor = true;
            this.summonButton.Click += new System.EventHandler(this.SummonButton_Click);
            // 
            // unitSearchInput
            // 
            this.unitSearchInput.Location = new System.Drawing.Point(7, 179);
            this.unitSearchInput.Name = "unitSearchInput";
            this.unitSearchInput.Size = new System.Drawing.Size(237, 20);
            this.unitSearchInput.TabIndex = 1;
            this.unitSearchInput.Text = "search";
            this.unitSearchInput.TextChanged += new System.EventHandler(this.UnitSearchInput_TextChanged);
            // 
            // unitDataGrid
            // 
            this.unitDataGrid.AllowUserToAddRows = false;
            this.unitDataGrid.AllowUserToDeleteRows = false;
            this.unitDataGrid.AllowUserToResizeRows = false;
            this.unitDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unitDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitDataGrid.Location = new System.Drawing.Point(7, 7);
            this.unitDataGrid.Name = "unitDataGrid";
            this.unitDataGrid.RowHeadersVisible = false;
            this.unitDataGrid.Size = new System.Drawing.Size(768, 166);
            this.unitDataGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.arenaButton);
            this.tabPage3.Controls.Add(this.rankUpButton);
            this.tabPage3.Controls.Add(this.levelStatus);
            this.tabPage3.Controls.Add(this.levelPartyButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(781, 205);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Leveling";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // arenaButton
            // 
            this.arenaButton.Location = new System.Drawing.Point(335, 155);
            this.arenaButton.Name = "arenaButton";
            this.arenaButton.Size = new System.Drawing.Size(75, 23);
            this.arenaButton.TabIndex = 3;
            this.arenaButton.Text = "do arena";
            this.arenaButton.UseVisualStyleBackColor = true;
            this.arenaButton.Click += new System.EventHandler(this.arenaButton_Click);
            // 
            // rankUpButton
            // 
            this.rankUpButton.Location = new System.Drawing.Point(432, 155);
            this.rankUpButton.Name = "rankUpButton";
            this.rankUpButton.Size = new System.Drawing.Size(75, 23);
            this.rankUpButton.TabIndex = 2;
            this.rankUpButton.Text = "rank up";
            this.rankUpButton.UseVisualStyleBackColor = true;
            this.rankUpButton.Click += new System.EventHandler(this.RankUpButton_Click);
            // 
            // levelStatus
            // 
            this.levelStatus.Location = new System.Drawing.Point(4, 4);
            this.levelStatus.Name = "levelStatus";
            this.levelStatus.ReadOnly = true;
            this.levelStatus.Size = new System.Drawing.Size(774, 124);
            this.levelStatus.TabIndex = 1;
            this.levelStatus.Text = "status...";
            // 
            // levelPartyButton
            // 
            this.levelPartyButton.Location = new System.Drawing.Point(238, 155);
            this.levelPartyButton.Name = "levelPartyButton";
            this.levelPartyButton.Size = new System.Drawing.Size(75, 23);
            this.levelPartyButton.TabIndex = 0;
            this.levelPartyButton.Text = "level party";
            this.levelPartyButton.UseVisualStyleBackColor = true;
            this.levelPartyButton.Click += new System.EventHandler(this.LevelPartyButton_Click);
            // 
            // Missions
            // 
            this.Missions.Controls.Add(this.RepeatMission);
            this.Missions.Controls.Add(this.RepeatLabel);
            this.Missions.Controls.Add(this.RBAmazon);
            this.Missions.Controls.Add(this.RBAndroid);
            this.Missions.Controls.Add(this.RBiOS);
            this.Missions.Controls.Add(this.LBLevel);
            this.Missions.Controls.Add(this.LBLabel);
            this.Missions.Controls.Add(this.CBExplore);
            this.Missions.Controls.Add(this.CBUnits);
            this.Missions.Controls.Add(this.CBLoot);
            this.Missions.Controls.Add(this.CBChallenge);
            this.Missions.Controls.Add(this.CBTrophies);
            this.Missions.Controls.Add(this.StartMission);
            this.Missions.Controls.Add(this.CBFriends);
            this.Missions.Controls.Add(this.MissionIdLabel);
            this.Missions.Controls.Add(this.MissionSelect);
            this.Missions.Location = new System.Drawing.Point(4, 22);
            this.Missions.Name = "Missions";
            this.Missions.Size = new System.Drawing.Size(781, 205);
            this.Missions.TabIndex = 4;
            this.Missions.Text = "Missions";
            this.Missions.UseVisualStyleBackColor = true;
            // 
            // RepeatMission
            // 
            this.RepeatMission.Location = new System.Drawing.Point(219, 77);
            this.RepeatMission.Name = "RepeatMission";
            this.RepeatMission.Size = new System.Drawing.Size(100, 20);
            this.RepeatMission.TabIndex = 16;
            // 
            // RepeatLabel
            // 
            this.RepeatLabel.AutoSize = true;
            this.RepeatLabel.Location = new System.Drawing.Point(171, 80);
            this.RepeatLabel.Name = "RepeatLabel";
            this.RepeatLabel.Size = new System.Drawing.Size(42, 13);
            this.RepeatLabel.TabIndex = 15;
            this.RepeatLabel.Text = "Repeat";
            // 
            // RBAmazon
            // 
            this.RBAmazon.AutoSize = true;
            this.RBAmazon.Location = new System.Drawing.Point(177, 103);
            this.RBAmazon.Name = "RBAmazon";
            this.RBAmazon.Size = new System.Drawing.Size(63, 17);
            this.RBAmazon.TabIndex = 14;
            this.RBAmazon.Text = "Amazon";
            this.RBAmazon.UseVisualStyleBackColor = true;
            this.RBAmazon.CheckedChanged += new System.EventHandler(this.RBOS_CheckedChanged);
            // 
            // RBAndroid
            // 
            this.RBAndroid.AutoSize = true;
            this.RBAndroid.Location = new System.Drawing.Point(114, 103);
            this.RBAndroid.Name = "RBAndroid";
            this.RBAndroid.Size = new System.Drawing.Size(61, 17);
            this.RBAndroid.TabIndex = 13;
            this.RBAndroid.Text = "Android";
            this.RBAndroid.UseVisualStyleBackColor = true;
            this.RBAndroid.CheckedChanged += new System.EventHandler(this.RBOS_CheckedChanged);
            // 
            // RBiOS
            // 
            this.RBiOS.AutoSize = true;
            this.RBiOS.Checked = true;
            this.RBiOS.Location = new System.Drawing.Point(65, 103);
            this.RBiOS.Name = "RBiOS";
            this.RBiOS.Size = new System.Drawing.Size(42, 17);
            this.RBiOS.TabIndex = 12;
            this.RBiOS.TabStop = true;
            this.RBiOS.Text = "iOS";
            this.RBiOS.UseVisualStyleBackColor = true;
            this.RBiOS.CheckedChanged += new System.EventHandler(this.RBOS_CheckedChanged);
            // 
            // LBLevel
            // 
            this.LBLevel.Location = new System.Drawing.Point(65, 77);
            this.LBLevel.Name = "LBLevel";
            this.LBLevel.Size = new System.Drawing.Size(100, 20);
            this.LBLevel.TabIndex = 11;
            // 
            // LBLabel
            // 
            this.LBLabel.AutoSize = true;
            this.LBLabel.Location = new System.Drawing.Point(39, 80);
            this.LBLabel.Name = "LBLabel";
            this.LBLabel.Size = new System.Drawing.Size(20, 13);
            this.LBLabel.TabIndex = 10;
            this.LBLabel.Text = "LB";
            // 
            // CBExplore
            // 
            this.CBExplore.AutoSize = true;
            this.CBExplore.Location = new System.Drawing.Point(244, 57);
            this.CBExplore.Name = "CBExplore";
            this.CBExplore.Size = new System.Drawing.Size(128, 17);
            this.CBExplore.TabIndex = 9;
            this.CBExplore.Text = "Exploration Treasures";
            this.CBExplore.UseVisualStyleBackColor = true;
            // 
            // CBUnits
            // 
            this.CBUnits.AutoSize = true;
            this.CBUnits.Location = new System.Drawing.Point(153, 57);
            this.CBUnits.Name = "CBUnits";
            this.CBUnits.Size = new System.Drawing.Size(85, 17);
            this.CBUnits.TabIndex = 8;
            this.CBUnits.Text = "Collect Units";
            this.CBUnits.UseVisualStyleBackColor = true;
            // 
            // CBLoot
            // 
            this.CBLoot.AutoSize = true;
            this.CBLoot.Location = new System.Drawing.Point(65, 57);
            this.CBLoot.Name = "CBLoot";
            this.CBLoot.Size = new System.Drawing.Size(82, 17);
            this.CBLoot.TabIndex = 7;
            this.CBLoot.Text = "Collect Loot";
            this.CBLoot.UseVisualStyleBackColor = true;
            // 
            // CBChallenge
            // 
            this.CBChallenge.AutoSize = true;
            this.CBChallenge.Enabled = false;
            this.CBChallenge.Location = new System.Drawing.Point(273, 34);
            this.CBChallenge.Name = "CBChallenge";
            this.CBChallenge.Size = new System.Drawing.Size(125, 17);
            this.CBChallenge.TabIndex = 6;
            this.CBChallenge.Text = "Complete Challenges";
            this.CBChallenge.UseVisualStyleBackColor = true;
            // 
            // CBTrophies
            // 
            this.CBTrophies.AutoSize = true;
            this.CBTrophies.Location = new System.Drawing.Point(153, 34);
            this.CBTrophies.Name = "CBTrophies";
            this.CBTrophies.Size = new System.Drawing.Size(114, 17);
            this.CBTrophies.TabIndex = 5;
            this.CBTrophies.Text = "Complete Trophies";
            this.CBTrophies.UseVisualStyleBackColor = true;
            this.CBTrophies.CheckedChanged += new System.EventHandler(this.CBTrophies_CheckedChanged);
            // 
            // StartMission
            // 
            this.StartMission.Location = new System.Drawing.Point(703, 170);
            this.StartMission.Name = "StartMission";
            this.StartMission.Size = new System.Drawing.Size(75, 23);
            this.StartMission.TabIndex = 4;
            this.StartMission.Text = "Start";
            this.StartMission.UseVisualStyleBackColor = true;
            this.StartMission.Click += new System.EventHandler(this.StartMission_Click);
            // 
            // CBFriends
            // 
            this.CBFriends.AutoSize = true;
            this.CBFriends.Location = new System.Drawing.Point(65, 34);
            this.CBFriends.Name = "CBFriends";
            this.CBFriends.Size = new System.Drawing.Size(82, 17);
            this.CBFriends.TabIndex = 3;
            this.CBFriends.Text = "Use Friends";
            this.CBFriends.UseVisualStyleBackColor = true;
            // 
            // MissionIdLabel
            // 
            this.MissionIdLabel.AutoSize = true;
            this.MissionIdLabel.Location = new System.Drawing.Point(3, 10);
            this.MissionIdLabel.Name = "MissionIdLabel";
            this.MissionIdLabel.Size = new System.Drawing.Size(56, 13);
            this.MissionIdLabel.TabIndex = 2;
            this.MissionIdLabel.Text = "Mission ID";
            // 
            // MissionSelect
            // 
            this.MissionSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MissionSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MissionSelect.FormattingEnabled = true;
            this.MissionSelect.Location = new System.Drawing.Point(65, 7);
            this.MissionSelect.Name = "MissionSelect";
            this.MissionSelect.Size = new System.Drawing.Size(380, 21);
            this.MissionSelect.TabIndex = 1;
            // 
            // JPSummon
            // 
            this.JPSummon.Controls.Add(this.JPGachaTicket);
            this.JPSummon.Controls.Add(this.JPLogin);
            this.JPSummon.Controls.Add(this.GachaSummon);
            this.JPSummon.Controls.Add(this.JPGacha);
            this.JPSummon.Location = new System.Drawing.Point(4, 22);
            this.JPSummon.Name = "JPSummon";
            this.JPSummon.Size = new System.Drawing.Size(781, 205);
            this.JPSummon.TabIndex = 3;
            this.JPSummon.Text = "JP Summon";
            this.JPSummon.UseVisualStyleBackColor = true;
            // 
            // JPGachaTicket
            // 
            this.JPGachaTicket.FormattingEnabled = true;
            this.JPGachaTicket.Location = new System.Drawing.Point(389, 35);
            this.JPGachaTicket.Name = "JPGachaTicket";
            this.JPGachaTicket.Size = new System.Drawing.Size(88, 21);
            this.JPGachaTicket.TabIndex = 5;
            // 
            // JPLogin
            // 
            this.JPLogin.Location = new System.Drawing.Point(703, 171);
            this.JPLogin.Name = "JPLogin";
            this.JPLogin.Size = new System.Drawing.Size(75, 23);
            this.JPLogin.TabIndex = 4;
            this.JPLogin.Text = "Login";
            this.JPLogin.UseVisualStyleBackColor = true;
            this.JPLogin.Click += new System.EventHandler(this.JPLogin_Click);
            // 
            // GachaSummon
            // 
            this.GachaSummon.Enabled = false;
            this.GachaSummon.Location = new System.Drawing.Point(703, 35);
            this.GachaSummon.Name = "GachaSummon";
            this.GachaSummon.Size = new System.Drawing.Size(75, 23);
            this.GachaSummon.TabIndex = 1;
            this.GachaSummon.Text = "Summon";
            this.GachaSummon.UseVisualStyleBackColor = true;
            this.GachaSummon.Click += new System.EventHandler(this.GachaSummon_Click);
            // 
            // JPGacha
            // 
            this.JPGacha.FormattingEnabled = true;
            this.JPGacha.Location = new System.Drawing.Point(3, 35);
            this.JPGacha.Name = "JPGacha";
            this.JPGacha.Size = new System.Drawing.Size(380, 21);
            this.JPGacha.TabIndex = 0;
            // 
            // donateButton
            // 
            this.donateButton.Location = new System.Drawing.Point(689, 248);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(106, 23);
            this.donateButton.TabIndex = 3;
            this.donateButton.Text = "Donate to Shalzuth";
            this.donateButton.UseVisualStyleBackColor = true;
            this.donateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // consoleLog
            // 
            this.consoleLog.Location = new System.Drawing.Point(13, 341);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ReadOnly = true;
            this.consoleLog.Size = new System.Drawing.Size(785, 212);
            this.consoleLog.TabIndex = 3;
            this.consoleLog.Text = "";
            // 
            // ProxyPort
            // 
            this.ProxyPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Client.Properties.Settings.Default, "ProxyPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProxyPort.Location = new System.Drawing.Point(194, 308);
            this.ProxyPort.Name = "ProxyPort";
            this.ProxyPort.Size = new System.Drawing.Size(203, 20);
            this.ProxyPort.TabIndex = 6;
            this.ProxyPort.Text = global::Client.Properties.Settings.Default.ProxyPort;
            this.ProxyPort.TextChanged += new System.EventHandler(this.ProxyPort_TextChanged);
            // 
            // ProxyIP
            // 
            this.ProxyIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Client.Properties.Settings.Default, "ProxyIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProxyIP.Location = new System.Drawing.Point(13, 308);
            this.ProxyIP.Name = "ProxyIP";
            this.ProxyIP.Size = new System.Drawing.Size(178, 20);
            this.ProxyIP.TabIndex = 5;
            this.ProxyIP.Text = global::Client.Properties.Settings.Default.ProxyIP;
            this.ProxyIP.TextChanged += new System.EventHandler(this.ProxyIP_TextChanged);
            // 
            // fbtokenInput
            // 
            this.fbtokenInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Client.Properties.Settings.Default, "fbtokenInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fbtokenInput.Location = new System.Drawing.Point(194, 269);
            this.fbtokenInput.Name = "fbtokenInput";
            this.fbtokenInput.Size = new System.Drawing.Size(203, 20);
            this.fbtokenInput.TabIndex = 1;
            this.fbtokenInput.Text = global::Client.Properties.Settings.Default.fbtokenInput;
            this.fbtokenInput.TextChanged += new System.EventHandler(this.fbtokenInput_TextChanged);
            // 
            // fbidInput
            // 
            this.fbidInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Client.Properties.Settings.Default, "fbidInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fbidInput.Location = new System.Drawing.Point(13, 269);
            this.fbidInput.Name = "fbidInput";
            this.fbidInput.Size = new System.Drawing.Size(178, 20);
            this.fbidInput.TabIndex = 0;
            this.fbidInput.Text = global::Client.Properties.Settings.Default.fbidInput;
            this.fbidInput.TextChanged += new System.EventHandler(this.FbidInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FB ID/Email or Transfer Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "FB Token/Password or Transfer Pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Proxy IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proxy Port:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 565);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProxyPort);
            this.Controls.Add(this.ProxyIP);
            this.Controls.Add(this.consoleLog);
            this.Controls.Add(this.donateButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fbtokenInput);
            this.Controls.Add(this.fbidInput);
            this.Name = "MainWindow";
            this.Text = "Shalzuth\'s Brave Haxvius";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injectDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.Missions.ResumeLayout(false);
            this.Missions.PerformLayout();
            this.JPSummon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fbidInput;
        private System.Windows.Forms.TextBox fbtokenInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView injectDataGrid;
        private System.Windows.Forms.TextBox injectSearchInput;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button donateButton;
        private System.Windows.Forms.DataGridView unitDataGrid;
        private System.Windows.Forms.Button summonButton;
        private System.Windows.Forms.TextBox unitSearchInput;
        private System.Windows.Forms.RichTextBox consoleLog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button levelPartyButton;
        private System.Windows.Forms.RichTextBox levelStatus;
        private System.Windows.Forms.TabPage JPSummon;
        private System.Windows.Forms.Button GachaSummon;
        private System.Windows.Forms.ComboBox JPGacha;
        private System.Windows.Forms.Button JPLogin;
        private System.Windows.Forms.ComboBox JPGachaTicket;
        private System.Windows.Forms.Button rankUpButton;
        private System.Windows.Forms.TabPage Missions;
        private System.Windows.Forms.ComboBox MissionSelect;
        private System.Windows.Forms.CheckBox CBFriends;
        private System.Windows.Forms.Label MissionIdLabel;
        private System.Windows.Forms.Button StartMission;
        private System.Windows.Forms.CheckBox CBTrophies;
        private System.Windows.Forms.CheckBox CBChallenge;
        private System.Windows.Forms.CheckBox CBLoot;
        private System.Windows.Forms.CheckBox CBUnits;
        private System.Windows.Forms.CheckBox CBExplore;
        private System.Windows.Forms.TextBox LBLevel;
        private System.Windows.Forms.Label LBLabel;
        private System.Windows.Forms.RadioButton RBAndroid;
        private System.Windows.Forms.RadioButton RBiOS;
        private System.Windows.Forms.RadioButton RBAmazon;
        private System.Windows.Forms.TextBox ProxyIP;
        private System.Windows.Forms.TextBox ProxyPort;
        private System.Windows.Forms.TextBox RepeatMission;
        private System.Windows.Forms.Label RepeatLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button arenaButton;
    }
}


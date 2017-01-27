namespace DeckTracker
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.recordMatchTab = new System.Windows.Forms.TabPage();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.btn_defeat = new System.Windows.Forms.Button();
            this.btn_victory = new System.Windows.Forms.Button();
            this.matchVersusLabel = new System.Windows.Forms.Label();
            this.cb_matchArchetype = new System.Windows.Forms.ComboBox();
            this.archetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DeckTracker.Database.DatabaseDataSet();
            this.cb_matchBuild = new System.Windows.Forms.ComboBox();
            this.buildsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.link_recordMatchToEditArchetypes = new System.Windows.Forms.LinkLabel();
            this.link_recordMatchToEditBuilds = new System.Windows.Forms.LinkLabel();
            this.recordMatchLabel = new System.Windows.Forms.Label();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbl_wins = new System.Windows.Forms.Label();
            this.lbl_losses = new System.Windows.Forms.Label();
            this.lbl_winRate = new System.Windows.Forms.Label();
            this.winRateLabel = new System.Windows.Forms.Label();
            this.btn_recordMatch = new System.Windows.Forms.Button();
            this.statisticsVersusLabel = new System.Windows.Forms.Label();
            this.cb_statisticsArchetype = new System.Windows.Forms.ComboBox();
            this.cb_statisticsBuild = new System.Windows.Forms.ComboBox();
            this.link_statisticsToEditArchetypes = new System.Windows.Forms.LinkLabel();
            this.link_statisticsToEditBuilds = new System.Windows.Forms.LinkLabel();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.editBuildsTab = new System.Windows.Forms.TabPage();
            this.btn_addBuild = new System.Windows.Forms.Button();
            this.btn_editBuild = new System.Windows.Forms.Button();
            this.btn_deleteBuild = new System.Windows.Forms.Button();
            this.dgv_builds = new System.Windows.Forms.DataGridView();
            this.editBuildsLabel = new System.Windows.Forms.Label();
            this.editArchetypesTab = new System.Windows.Forms.TabPage();
            this.btn_addArchetype = new System.Windows.Forms.Button();
            this.btn_editArchetype = new System.Windows.Forms.Button();
            this.btn_deleteArchetype = new System.Windows.Forms.Button();
            this.dgv_archetypes = new System.Windows.Forms.DataGridView();
            this.editArchetypesLabel = new System.Windows.Forms.Label();
            this.buildsTableAdapter = new DeckTracker.Database.DatabaseDataSetTableAdapters.BuildsTableAdapter();
            this.archetypesTableAdapter = new DeckTracker.Database.DatabaseDataSetTableAdapters.ArchetypesTableAdapter();
            this.matchesTableAdapter = new DeckTracker.Database.DatabaseDataSetTableAdapters.MatchesTableAdapter();
            this.nameColumnBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archetypeColumnBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteColumnBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumnBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.recordMatchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildsBindingSource)).BeginInit();
            this.statisticsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.editBuildsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_builds)).BeginInit();
            this.editArchetypesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_archetypes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.recordMatchTab);
            this.tabControl.Controls.Add(this.statisticsTab);
            this.tabControl.Controls.Add(this.editBuildsTab);
            this.tabControl.Controls.Add(this.editArchetypesTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(155, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(624, 442);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // recordMatchTab
            // 
            this.recordMatchTab.Controls.Add(this.btn_statistics);
            this.recordMatchTab.Controls.Add(this.btn_defeat);
            this.recordMatchTab.Controls.Add(this.btn_victory);
            this.recordMatchTab.Controls.Add(this.matchVersusLabel);
            this.recordMatchTab.Controls.Add(this.cb_matchArchetype);
            this.recordMatchTab.Controls.Add(this.cb_matchBuild);
            this.recordMatchTab.Controls.Add(this.link_recordMatchToEditArchetypes);
            this.recordMatchTab.Controls.Add(this.link_recordMatchToEditBuilds);
            this.recordMatchTab.Controls.Add(this.recordMatchLabel);
            this.recordMatchTab.Location = new System.Drawing.Point(4, 29);
            this.recordMatchTab.Name = "recordMatchTab";
            this.recordMatchTab.Padding = new System.Windows.Forms.Padding(3);
            this.recordMatchTab.Size = new System.Drawing.Size(616, 409);
            this.recordMatchTab.TabIndex = 0;
            this.recordMatchTab.Text = "Record Match";
            this.recordMatchTab.UseVisualStyleBackColor = true;
            // 
            // btn_statistics
            // 
            this.btn_statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistics.Location = new System.Drawing.Point(218, 350);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(180, 40);
            this.btn_statistics.TabIndex = 4;
            this.btn_statistics.Text = "Statistics";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // btn_defeat
            // 
            this.btn_defeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defeat.Location = new System.Drawing.Point(337, 245);
            this.btn_defeat.Name = "btn_defeat";
            this.btn_defeat.Size = new System.Drawing.Size(240, 50);
            this.btn_defeat.TabIndex = 4;
            this.btn_defeat.Text = "Defeat";
            this.btn_defeat.UseVisualStyleBackColor = true;
            this.btn_defeat.Click += new System.EventHandler(this.btn_defeat_Click);
            // 
            // btn_victory
            // 
            this.btn_victory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_victory.Location = new System.Drawing.Point(40, 245);
            this.btn_victory.Name = "btn_victory";
            this.btn_victory.Size = new System.Drawing.Size(240, 50);
            this.btn_victory.TabIndex = 4;
            this.btn_victory.Text = "Victory";
            this.btn_victory.UseVisualStyleBackColor = true;
            this.btn_victory.Click += new System.EventHandler(this.btn_victory_Click);
            // 
            // matchVersusLabel
            // 
            this.matchVersusLabel.AutoSize = true;
            this.matchVersusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchVersusLabel.Location = new System.Drawing.Point(277, 126);
            this.matchVersusLabel.Name = "matchVersusLabel";
            this.matchVersusLabel.Size = new System.Drawing.Size(65, 39);
            this.matchVersusLabel.TabIndex = 3;
            this.matchVersusLabel.Text = "VS";
            // 
            // cb_matchArchetype
            // 
            this.cb_matchArchetype.DataSource = this.archetypesBindingSource;
            this.cb_matchArchetype.DisplayMember = "name";
            this.cb_matchArchetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_matchArchetype.DropDownWidth = 121;
            this.cb_matchArchetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_matchArchetype.FormattingEnabled = true;
            this.cb_matchArchetype.Location = new System.Drawing.Point(388, 126);
            this.cb_matchArchetype.Name = "cb_matchArchetype";
            this.cb_matchArchetype.Size = new System.Drawing.Size(150, 24);
            this.cb_matchArchetype.TabIndex = 2;
            this.cb_matchArchetype.ValueMember = "archetypeID";
            // 
            // archetypesBindingSource
            // 
            this.archetypesBindingSource.DataMember = "Archetypes";
            this.archetypesBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_matchBuild
            // 
            this.cb_matchBuild.DataSource = this.buildsBindingSource;
            this.cb_matchBuild.DisplayMember = "name";
            this.cb_matchBuild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_matchBuild.DropDownWidth = 121;
            this.cb_matchBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_matchBuild.FormattingEnabled = true;
            this.cb_matchBuild.Location = new System.Drawing.Point(81, 126);
            this.cb_matchBuild.Name = "cb_matchBuild";
            this.cb_matchBuild.Size = new System.Drawing.Size(150, 24);
            this.cb_matchBuild.TabIndex = 2;
            this.cb_matchBuild.ValueMember = "buildID";
            // 
            // buildsBindingSource
            // 
            this.buildsBindingSource.DataMember = "Builds";
            this.buildsBindingSource.DataSource = this.databaseDataSet;
            // 
            // link_recordMatchToEditArchetypes
            // 
            this.link_recordMatchToEditArchetypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.link_recordMatchToEditArchetypes.AutoSize = true;
            this.link_recordMatchToEditArchetypes.Location = new System.Drawing.Point(457, 110);
            this.link_recordMatchToEditArchetypes.Name = "link_recordMatchToEditArchetypes";
            this.link_recordMatchToEditArchetypes.Size = new System.Drawing.Size(81, 13);
            this.link_recordMatchToEditArchetypes.TabIndex = 1;
            this.link_recordMatchToEditArchetypes.TabStop = true;
            this.link_recordMatchToEditArchetypes.Text = "Edit Archetypes";
            this.link_recordMatchToEditArchetypes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_recordMatchToEditArchetypes_LinkClicked);
            // 
            // link_recordMatchToEditBuilds
            // 
            this.link_recordMatchToEditBuilds.AutoSize = true;
            this.link_recordMatchToEditBuilds.Location = new System.Drawing.Point(78, 110);
            this.link_recordMatchToEditBuilds.Name = "link_recordMatchToEditBuilds";
            this.link_recordMatchToEditBuilds.Size = new System.Drawing.Size(73, 13);
            this.link_recordMatchToEditBuilds.TabIndex = 1;
            this.link_recordMatchToEditBuilds.TabStop = true;
            this.link_recordMatchToEditBuilds.Text = "Edit My Builds";
            this.link_recordMatchToEditBuilds.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_recordMatchToEditBuilds_LinkClicked);
            // 
            // recordMatchLabel
            // 
            this.recordMatchLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.recordMatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordMatchLabel.Location = new System.Drawing.Point(3, 3);
            this.recordMatchLabel.Name = "recordMatchLabel";
            this.recordMatchLabel.Size = new System.Drawing.Size(610, 60);
            this.recordMatchLabel.TabIndex = 0;
            this.recordMatchLabel.Text = "Record Match";
            this.recordMatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statisticsTab
            // 
            this.statisticsTab.Controls.Add(this.panel1);
            this.statisticsTab.Controls.Add(this.btn_recordMatch);
            this.statisticsTab.Controls.Add(this.statisticsVersusLabel);
            this.statisticsTab.Controls.Add(this.cb_statisticsArchetype);
            this.statisticsTab.Controls.Add(this.cb_statisticsBuild);
            this.statisticsTab.Controls.Add(this.link_statisticsToEditArchetypes);
            this.statisticsTab.Controls.Add(this.link_statisticsToEditBuilds);
            this.statisticsTab.Controls.Add(this.statisticsLabel);
            this.statisticsTab.Location = new System.Drawing.Point(4, 29);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsTab.Size = new System.Drawing.Size(616, 409);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.lbl_wins);
            this.panel1.Controls.Add(this.lbl_losses);
            this.panel1.Controls.Add(this.lbl_winRate);
            this.panel1.Controls.Add(this.winRateLabel);
            this.panel1.Location = new System.Drawing.Point(103, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 120);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "- Losses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "|";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(23, 62);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 33);
            this.label.TabIndex = 0;
            this.label.Text = "Wins -";
            // 
            // lbl_wins
            // 
            this.lbl_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wins.Location = new System.Drawing.Point(133, 62);
            this.lbl_wins.Name = "lbl_wins";
            this.lbl_wins.Size = new System.Drawing.Size(66, 33);
            this.lbl_wins.TabIndex = 0;
            this.lbl_wins.Text = "123";
            this.lbl_wins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_losses
            // 
            this.lbl_losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_losses.Location = new System.Drawing.Point(206, 62);
            this.lbl_losses.Name = "lbl_losses";
            this.lbl_losses.Size = new System.Drawing.Size(75, 33);
            this.lbl_losses.TabIndex = 0;
            this.lbl_losses.Text = "123";
            this.lbl_losses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_winRate
            // 
            this.lbl_winRate.AutoSize = true;
            this.lbl_winRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winRate.Location = new System.Drawing.Point(251, 11);
            this.lbl_winRate.Name = "lbl_winRate";
            this.lbl_winRate.Size = new System.Drawing.Size(75, 33);
            this.lbl_winRate.TabIndex = 0;
            this.lbl_winRate.Text = "1.23";
            // 
            // winRateLabel
            // 
            this.winRateLabel.AutoSize = true;
            this.winRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winRateLabel.Location = new System.Drawing.Point(94, 11);
            this.winRateLabel.Name = "winRateLabel";
            this.winRateLabel.Size = new System.Drawing.Size(151, 33);
            this.winRateLabel.TabIndex = 0;
            this.winRateLabel.Text = "Win Rate:";
            // 
            // btn_recordMatch
            // 
            this.btn_recordMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recordMatch.Location = new System.Drawing.Point(218, 350);
            this.btn_recordMatch.Name = "btn_recordMatch";
            this.btn_recordMatch.Size = new System.Drawing.Size(180, 40);
            this.btn_recordMatch.TabIndex = 9;
            this.btn_recordMatch.Text = "Record Match Results";
            this.btn_recordMatch.UseVisualStyleBackColor = true;
            this.btn_recordMatch.Click += new System.EventHandler(this.btn_recordMatch_Click);
            // 
            // statisticsVersusLabel
            // 
            this.statisticsVersusLabel.AutoSize = true;
            this.statisticsVersusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsVersusLabel.Location = new System.Drawing.Point(277, 126);
            this.statisticsVersusLabel.Name = "statisticsVersusLabel";
            this.statisticsVersusLabel.Size = new System.Drawing.Size(65, 39);
            this.statisticsVersusLabel.TabIndex = 8;
            this.statisticsVersusLabel.Text = "VS";
            // 
            // cb_statisticsArchetype
            // 
            this.cb_statisticsArchetype.DataSource = this.archetypesBindingSource;
            this.cb_statisticsArchetype.DisplayMember = "name";
            this.cb_statisticsArchetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_statisticsArchetype.DropDownWidth = 121;
            this.cb_statisticsArchetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_statisticsArchetype.FormattingEnabled = true;
            this.cb_statisticsArchetype.Location = new System.Drawing.Point(388, 126);
            this.cb_statisticsArchetype.Name = "cb_statisticsArchetype";
            this.cb_statisticsArchetype.Size = new System.Drawing.Size(150, 24);
            this.cb_statisticsArchetype.TabIndex = 6;
            this.cb_statisticsArchetype.ValueMember = "archetypeID";
            this.cb_statisticsArchetype.SelectedIndexChanged += new System.EventHandler(this.cb_statisticsArchetype_SelectedIndexChanged);
            // 
            // cb_statisticsBuild
            // 
            this.cb_statisticsBuild.DataSource = this.buildsBindingSource;
            this.cb_statisticsBuild.DisplayMember = "name";
            this.cb_statisticsBuild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_statisticsBuild.DropDownWidth = 121;
            this.cb_statisticsBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_statisticsBuild.FormattingEnabled = true;
            this.cb_statisticsBuild.Location = new System.Drawing.Point(81, 126);
            this.cb_statisticsBuild.Name = "cb_statisticsBuild";
            this.cb_statisticsBuild.Size = new System.Drawing.Size(150, 24);
            this.cb_statisticsBuild.TabIndex = 7;
            this.cb_statisticsBuild.ValueMember = "buildID";
            this.cb_statisticsBuild.SelectedIndexChanged += new System.EventHandler(this.cb_statisticsBuild_SelectedIndexChanged);
            // 
            // link_statisticsToEditArchetypes
            // 
            this.link_statisticsToEditArchetypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.link_statisticsToEditArchetypes.AutoSize = true;
            this.link_statisticsToEditArchetypes.Location = new System.Drawing.Point(457, 110);
            this.link_statisticsToEditArchetypes.Name = "link_statisticsToEditArchetypes";
            this.link_statisticsToEditArchetypes.Size = new System.Drawing.Size(81, 13);
            this.link_statisticsToEditArchetypes.TabIndex = 4;
            this.link_statisticsToEditArchetypes.TabStop = true;
            this.link_statisticsToEditArchetypes.Text = "Edit Archetypes";
            this.link_statisticsToEditArchetypes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_statisticsToEditArchetypes_LinkClicked);
            // 
            // link_statisticsToEditBuilds
            // 
            this.link_statisticsToEditBuilds.AutoSize = true;
            this.link_statisticsToEditBuilds.Location = new System.Drawing.Point(78, 110);
            this.link_statisticsToEditBuilds.Name = "link_statisticsToEditBuilds";
            this.link_statisticsToEditBuilds.Size = new System.Drawing.Size(73, 13);
            this.link_statisticsToEditBuilds.TabIndex = 5;
            this.link_statisticsToEditBuilds.TabStop = true;
            this.link_statisticsToEditBuilds.Text = "Edit My Builds";
            this.link_statisticsToEditBuilds.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_statisticsToEditBuilds_LinkClicked);
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsLabel.Location = new System.Drawing.Point(3, 3);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(610, 60);
            this.statisticsLabel.TabIndex = 1;
            this.statisticsLabel.Text = "Statistics";
            this.statisticsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editBuildsTab
            // 
            this.editBuildsTab.AutoScroll = true;
            this.editBuildsTab.Controls.Add(this.btn_addBuild);
            this.editBuildsTab.Controls.Add(this.btn_editBuild);
            this.editBuildsTab.Controls.Add(this.btn_deleteBuild);
            this.editBuildsTab.Controls.Add(this.dgv_builds);
            this.editBuildsTab.Controls.Add(this.editBuildsLabel);
            this.editBuildsTab.Location = new System.Drawing.Point(4, 29);
            this.editBuildsTab.Name = "editBuildsTab";
            this.editBuildsTab.Size = new System.Drawing.Size(616, 409);
            this.editBuildsTab.TabIndex = 2;
            this.editBuildsTab.Text = "Edit My Builds";
            this.editBuildsTab.UseVisualStyleBackColor = true;
            // 
            // btn_addBuild
            // 
            this.btn_addBuild.Location = new System.Drawing.Point(236, 378);
            this.btn_addBuild.Name = "btn_addBuild";
            this.btn_addBuild.Size = new System.Drawing.Size(120, 23);
            this.btn_addBuild.TabIndex = 1;
            this.btn_addBuild.Text = "Add New Build";
            this.btn_addBuild.UseVisualStyleBackColor = true;
            this.btn_addBuild.Click += new System.EventHandler(this.btn_addBuild_Click);
            // 
            // btn_editBuild
            // 
            this.btn_editBuild.Location = new System.Drawing.Point(362, 378);
            this.btn_editBuild.Name = "btn_editBuild";
            this.btn_editBuild.Size = new System.Drawing.Size(120, 23);
            this.btn_editBuild.TabIndex = 2;
            this.btn_editBuild.Text = "Edit Selected";
            this.btn_editBuild.UseVisualStyleBackColor = true;
            this.btn_editBuild.Click += new System.EventHandler(this.btn_editBuild_Click);
            // 
            // btn_deleteBuild
            // 
            this.btn_deleteBuild.Location = new System.Drawing.Point(488, 378);
            this.btn_deleteBuild.Name = "btn_deleteBuild";
            this.btn_deleteBuild.Size = new System.Drawing.Size(120, 23);
            this.btn_deleteBuild.TabIndex = 3;
            this.btn_deleteBuild.Text = "Delete Selected";
            this.btn_deleteBuild.UseVisualStyleBackColor = true;
            this.btn_deleteBuild.Click += new System.EventHandler(this.btn_deleteBuild_Click);
            // 
            // dgv_builds
            // 
            this.dgv_builds.AllowUserToAddRows = false;
            this.dgv_builds.AllowUserToDeleteRows = false;
            this.dgv_builds.AllowUserToResizeColumns = false;
            this.dgv_builds.AllowUserToResizeRows = false;
            this.dgv_builds.AutoGenerateColumns = false;
            this.dgv_builds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_builds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_builds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumnBuild,
            this.archetypeColumnBuild,
            this.noteColumnBuild,
            this.idColumnBuild});
            this.dgv_builds.DataSource = this.buildsBindingSource;
            this.dgv_builds.Location = new System.Drawing.Point(8, 63);
            this.dgv_builds.MultiSelect = false;
            this.dgv_builds.Name = "dgv_builds";
            this.dgv_builds.ReadOnly = true;
            this.dgv_builds.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_builds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_builds.Size = new System.Drawing.Size(600, 309);
            this.dgv_builds.TabIndex = 0;
            // 
            // editBuildsLabel
            // 
            this.editBuildsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editBuildsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBuildsLabel.Location = new System.Drawing.Point(0, 0);
            this.editBuildsLabel.Name = "editBuildsLabel";
            this.editBuildsLabel.Size = new System.Drawing.Size(616, 60);
            this.editBuildsLabel.TabIndex = 1;
            this.editBuildsLabel.Text = "Edit My Builds";
            this.editBuildsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editArchetypesTab
            // 
            this.editArchetypesTab.AutoScroll = true;
            this.editArchetypesTab.Controls.Add(this.btn_addArchetype);
            this.editArchetypesTab.Controls.Add(this.btn_editArchetype);
            this.editArchetypesTab.Controls.Add(this.btn_deleteArchetype);
            this.editArchetypesTab.Controls.Add(this.dgv_archetypes);
            this.editArchetypesTab.Controls.Add(this.editArchetypesLabel);
            this.editArchetypesTab.Location = new System.Drawing.Point(4, 29);
            this.editArchetypesTab.Name = "editArchetypesTab";
            this.editArchetypesTab.Size = new System.Drawing.Size(616, 409);
            this.editArchetypesTab.TabIndex = 3;
            this.editArchetypesTab.Text = "Edit Archetypes";
            this.editArchetypesTab.UseVisualStyleBackColor = true;
            // 
            // btn_addArchetype
            // 
            this.btn_addArchetype.Location = new System.Drawing.Point(236, 378);
            this.btn_addArchetype.Name = "btn_addArchetype";
            this.btn_addArchetype.Size = new System.Drawing.Size(120, 23);
            this.btn_addArchetype.TabIndex = 5;
            this.btn_addArchetype.Text = "Add Archetype";
            this.btn_addArchetype.UseVisualStyleBackColor = true;
            this.btn_addArchetype.Click += new System.EventHandler(this.btn_addArchetype_Click);
            // 
            // btn_editArchetype
            // 
            this.btn_editArchetype.Location = new System.Drawing.Point(362, 378);
            this.btn_editArchetype.Name = "btn_editArchetype";
            this.btn_editArchetype.Size = new System.Drawing.Size(120, 23);
            this.btn_editArchetype.TabIndex = 6;
            this.btn_editArchetype.Text = "Edit Selected";
            this.btn_editArchetype.UseVisualStyleBackColor = true;
            this.btn_editArchetype.Click += new System.EventHandler(this.btn_editArchetype_Click);
            // 
            // btn_deleteArchetype
            // 
            this.btn_deleteArchetype.Location = new System.Drawing.Point(488, 378);
            this.btn_deleteArchetype.Name = "btn_deleteArchetype";
            this.btn_deleteArchetype.Size = new System.Drawing.Size(120, 23);
            this.btn_deleteArchetype.TabIndex = 7;
            this.btn_deleteArchetype.Text = "Delete Selected";
            this.btn_deleteArchetype.UseVisualStyleBackColor = true;
            this.btn_deleteArchetype.Click += new System.EventHandler(this.btn_deleteArchetype_Click);
            // 
            // dgv_archetypes
            // 
            this.dgv_archetypes.AllowUserToAddRows = false;
            this.dgv_archetypes.AllowUserToDeleteRows = false;
            this.dgv_archetypes.AllowUserToResizeColumns = false;
            this.dgv_archetypes.AllowUserToResizeRows = false;
            this.dgv_archetypes.AutoGenerateColumns = false;
            this.dgv_archetypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_archetypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_archetypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumnArchetype,
            this.noteColumnArchetype,
            this.idColumnArchetype});
            this.dgv_archetypes.DataSource = this.archetypesBindingSource;
            this.dgv_archetypes.Location = new System.Drawing.Point(8, 63);
            this.dgv_archetypes.MultiSelect = false;
            this.dgv_archetypes.Name = "dgv_archetypes";
            this.dgv_archetypes.ReadOnly = true;
            this.dgv_archetypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_archetypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_archetypes.Size = new System.Drawing.Size(600, 309);
            this.dgv_archetypes.TabIndex = 4;
            // 
            // editArchetypesLabel
            // 
            this.editArchetypesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editArchetypesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editArchetypesLabel.Location = new System.Drawing.Point(0, 0);
            this.editArchetypesLabel.Name = "editArchetypesLabel";
            this.editArchetypesLabel.Size = new System.Drawing.Size(616, 60);
            this.editArchetypesLabel.TabIndex = 1;
            this.editArchetypesLabel.Text = "Edit Archetypes";
            this.editArchetypesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buildsTableAdapter
            // 
            this.buildsTableAdapter.ClearBeforeFill = true;
            // 
            // archetypesTableAdapter
            // 
            this.archetypesTableAdapter.ClearBeforeFill = true;
            // 
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // nameColumnBuild
            // 
            this.nameColumnBuild.DataPropertyName = "name";
            this.nameColumnBuild.FillWeight = 25F;
            this.nameColumnBuild.HeaderText = "name";
            this.nameColumnBuild.Name = "nameColumnBuild";
            this.nameColumnBuild.ReadOnly = true;
            // 
            // archetypeColumnBuild
            // 
            this.archetypeColumnBuild.DataPropertyName = "archetypeID";
            this.archetypeColumnBuild.FillWeight = 25F;
            this.archetypeColumnBuild.HeaderText = "archetypeID";
            this.archetypeColumnBuild.Name = "archetypeColumnBuild";
            this.archetypeColumnBuild.ReadOnly = true;
            // 
            // noteColumnBuild
            // 
            this.noteColumnBuild.DataPropertyName = "note";
            this.noteColumnBuild.FillWeight = 50F;
            this.noteColumnBuild.HeaderText = "note";
            this.noteColumnBuild.Name = "noteColumnBuild";
            this.noteColumnBuild.ReadOnly = true;
            // 
            // idColumnBuild
            // 
            this.idColumnBuild.DataPropertyName = "buildID";
            this.idColumnBuild.HeaderText = "buildID";
            this.idColumnBuild.Name = "idColumnBuild";
            this.idColumnBuild.ReadOnly = true;
            this.idColumnBuild.Visible = false;
            // 
            // nameColumnArchetype
            // 
            this.nameColumnArchetype.DataPropertyName = "name";
            this.nameColumnArchetype.FillWeight = 25F;
            this.nameColumnArchetype.HeaderText = "name";
            this.nameColumnArchetype.Name = "nameColumnArchetype";
            this.nameColumnArchetype.ReadOnly = true;
            // 
            // noteColumnArchetype
            // 
            this.noteColumnArchetype.DataPropertyName = "note";
            this.noteColumnArchetype.FillWeight = 75F;
            this.noteColumnArchetype.HeaderText = "note";
            this.noteColumnArchetype.Name = "noteColumnArchetype";
            this.noteColumnArchetype.ReadOnly = true;
            // 
            // idColumnArchetype
            // 
            this.idColumnArchetype.DataPropertyName = "archetypeID";
            this.idColumnArchetype.HeaderText = "archetypeID";
            this.idColumnArchetype.Name = "idColumnArchetype";
            this.idColumnArchetype.ReadOnly = true;
            this.idColumnArchetype.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Win Rate Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.recordMatchTab.ResumeLayout(false);
            this.recordMatchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildsBindingSource)).EndInit();
            this.statisticsTab.ResumeLayout(false);
            this.statisticsTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.editBuildsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_builds)).EndInit();
            this.editArchetypesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_archetypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage recordMatchTab;
        private System.Windows.Forms.TabPage statisticsTab;
        private System.Windows.Forms.TabPage editBuildsTab;
        private System.Windows.Forms.TabPage editArchetypesTab;
        private System.Windows.Forms.Label recordMatchLabel;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.Label editBuildsLabel;
        private System.Windows.Forms.Label editArchetypesLabel;
        private System.Windows.Forms.Button btn_defeat;
        private System.Windows.Forms.Button btn_victory;
        private System.Windows.Forms.Label matchVersusLabel;
        private System.Windows.Forms.ComboBox cb_matchArchetype;
        private System.Windows.Forms.ComboBox cb_matchBuild;
        private System.Windows.Forms.LinkLabel link_recordMatchToEditArchetypes;
        private System.Windows.Forms.LinkLabel link_recordMatchToEditBuilds;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.Label statisticsVersusLabel;
        private System.Windows.Forms.ComboBox cb_statisticsArchetype;
        private System.Windows.Forms.ComboBox cb_statisticsBuild;
        private System.Windows.Forms.LinkLabel link_statisticsToEditArchetypes;
        private System.Windows.Forms.LinkLabel link_statisticsToEditBuilds;
        private System.Windows.Forms.Button btn_recordMatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label winRateLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dgv_builds;
        private System.Windows.Forms.Button btn_deleteBuild;
        private System.Windows.Forms.Button btn_addBuild;
        private System.Windows.Forms.Button btn_editBuild;
        private System.Windows.Forms.Button btn_addArchetype;
        private System.Windows.Forms.Button btn_editArchetype;
        private System.Windows.Forms.Button btn_deleteArchetype;
        private System.Windows.Forms.DataGridView dgv_archetypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_wins;
        private System.Windows.Forms.Label lbl_losses;
        private System.Windows.Forms.Label lbl_winRate;
        private Database.DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource buildsBindingSource;
        private Database.DatabaseDataSetTableAdapters.BuildsTableAdapter buildsTableAdapter;
        private System.Windows.Forms.BindingSource archetypesBindingSource;
        private Database.DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter;
        private Database.DatabaseDataSetTableAdapters.MatchesTableAdapter matchesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumnBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn archetypeColumnBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteColumnBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumnBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumnArchetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteColumnArchetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumnArchetype;
    }
}


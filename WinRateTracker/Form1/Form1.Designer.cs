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
            System.Windows.Forms.Label lblVersusTab1;
            System.Windows.Forms.Label lblTitleTab1;
            System.Windows.Forms.Label lblLosses;
            System.Windows.Forms.Label lblSeperator;
            System.Windows.Forms.Label lblWins;
            System.Windows.Forms.Label lblWinRate;
            System.Windows.Forms.Label lblVersusTab2;
            System.Windows.Forms.Label lblTitleTab2;
            System.Windows.Forms.Label lblTitleTab3;
            System.Windows.Forms.Label lblTitleTab4;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.recordMatchTab = new System.Windows.Forms.TabPage();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnDefeat = new System.Windows.Forms.Button();
            this.btnVictory = new System.Windows.Forms.Button();
            this.cboArchetypeTab1 = new System.Windows.Forms.ComboBox();
            this.archetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DeckTracker.Database.DatabaseDataSet();
            this.cboBuildTab1 = new System.Windows.Forms.ComboBox();
            this.buildsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lnkEditArchetypesTab1 = new System.Windows.Forms.LinkLabel();
            this.lnkEditBuildsTab1 = new System.Windows.Forms.LinkLabel();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.chkAllBuilds = new System.Windows.Forms.CheckBox();
            this.chkAllArchetypes = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWinsValue = new System.Windows.Forms.Label();
            this.lblLossesValue = new System.Windows.Forms.Label();
            this.lblWinRateValue = new System.Windows.Forms.Label();
            this.btnRecordMatch = new System.Windows.Forms.Button();
            this.cboArchetypeTab2 = new System.Windows.Forms.ComboBox();
            this.cboBuildTab2 = new System.Windows.Forms.ComboBox();
            this.lnkEditArchetypesTab2 = new System.Windows.Forms.LinkLabel();
            this.lnkEditBuildsTab2 = new System.Windows.Forms.LinkLabel();
            this.editBuildsTab = new System.Windows.Forms.TabPage();
            this.btnAddBuild = new System.Windows.Forms.Button();
            this.btnEditBuild = new System.Windows.Forms.Button();
            this.btnDeleteBuild = new System.Windows.Forms.Button();
            this.dgvBuilds = new System.Windows.Forms.DataGridView();
            this.nameColumnBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archetypeColumnBuild = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.noteColumnBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumnBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editArchetypesTab = new System.Windows.Forms.TabPage();
            this.btnAddArchetype = new System.Windows.Forms.Button();
            this.btnEditArchetype = new System.Windows.Forms.Button();
            this.btnDeleteArchetype = new System.Windows.Forms.Button();
            this.dgvArchetypes = new System.Windows.Forms.DataGridView();
            this.nameColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildsTableAdapter = new DeckTracker.Database.DatabaseDataSetTableAdapters.BuildsTableAdapter();
            this.archetypesTableAdapter = new DeckTracker.Database.DatabaseDataSetTableAdapters.ArchetypesTableAdapter();
            this.matchesTableAdapter = new DeckTracker.Database.DatabaseDataSetTableAdapters.MatchesTableAdapter();
            this.archetypesTableAdapter1 = new DeckTracker.Database.DatabaseDataSetTableAdapters.ArchetypesTableAdapter();
            lblVersusTab1 = new System.Windows.Forms.Label();
            lblTitleTab1 = new System.Windows.Forms.Label();
            lblLosses = new System.Windows.Forms.Label();
            lblSeperator = new System.Windows.Forms.Label();
            lblWins = new System.Windows.Forms.Label();
            lblWinRate = new System.Windows.Forms.Label();
            lblVersusTab2 = new System.Windows.Forms.Label();
            lblTitleTab2 = new System.Windows.Forms.Label();
            lblTitleTab3 = new System.Windows.Forms.Label();
            lblTitleTab4 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.recordMatchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildsBindingSource)).BeginInit();
            this.statisticsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.editBuildsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilds)).BeginInit();
            this.editArchetypesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchetypes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersusTab1
            // 
            lblVersusTab1.AutoSize = true;
            lblVersusTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblVersusTab1.Location = new System.Drawing.Point(277, 126);
            lblVersusTab1.Name = "lblVersusTab1";
            lblVersusTab1.Size = new System.Drawing.Size(65, 39);
            lblVersusTab1.TabIndex = 3;
            lblVersusTab1.Text = "VS";
            // 
            // lblTitleTab1
            // 
            lblTitleTab1.Dock = System.Windows.Forms.DockStyle.Top;
            lblTitleTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitleTab1.Location = new System.Drawing.Point(3, 3);
            lblTitleTab1.Name = "lblTitleTab1";
            lblTitleTab1.Size = new System.Drawing.Size(610, 60);
            lblTitleTab1.TabIndex = 0;
            lblTitleTab1.Text = "Record Match";
            lblTitleTab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLosses
            // 
            lblLosses.AutoSize = true;
            lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLosses.Location = new System.Drawing.Point(278, 62);
            lblLosses.Name = "lblLosses";
            lblLosses.Size = new System.Drawing.Size(134, 33);
            lblLosses.TabIndex = 0;
            lblLosses.Text = "- Losses";
            // 
            // lblSeperator
            // 
            lblSeperator.AutoSize = true;
            lblSeperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSeperator.Location = new System.Drawing.Point(190, 62);
            lblSeperator.Name = "lblSeperator";
            lblSeperator.Size = new System.Drawing.Size(24, 33);
            lblSeperator.TabIndex = 0;
            lblSeperator.Text = "|";
            // 
            // lblWins
            // 
            lblWins.AutoSize = true;
            lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblWins.Location = new System.Drawing.Point(23, 62);
            lblWins.Name = "lblWins";
            lblWins.Size = new System.Drawing.Size(104, 33);
            lblWins.TabIndex = 0;
            lblWins.Text = "Wins -";
            // 
            // lblWinRate
            // 
            lblWinRate.AutoSize = true;
            lblWinRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblWinRate.Location = new System.Drawing.Point(94, 11);
            lblWinRate.Name = "lblWinRate";
            lblWinRate.Size = new System.Drawing.Size(151, 33);
            lblWinRate.TabIndex = 0;
            lblWinRate.Text = "Win Rate:";
            // 
            // lblVersusTab2
            // 
            lblVersusTab2.AutoSize = true;
            lblVersusTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblVersusTab2.Location = new System.Drawing.Point(277, 126);
            lblVersusTab2.Name = "lblVersusTab2";
            lblVersusTab2.Size = new System.Drawing.Size(65, 39);
            lblVersusTab2.TabIndex = 8;
            lblVersusTab2.Text = "VS";
            // 
            // lblTitleTab2
            // 
            lblTitleTab2.Dock = System.Windows.Forms.DockStyle.Top;
            lblTitleTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitleTab2.Location = new System.Drawing.Point(3, 3);
            lblTitleTab2.Name = "lblTitleTab2";
            lblTitleTab2.Size = new System.Drawing.Size(610, 60);
            lblTitleTab2.TabIndex = 1;
            lblTitleTab2.Text = "Statistics";
            lblTitleTab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleTab3
            // 
            lblTitleTab3.Dock = System.Windows.Forms.DockStyle.Top;
            lblTitleTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitleTab3.Location = new System.Drawing.Point(0, 0);
            lblTitleTab3.Name = "lblTitleTab3";
            lblTitleTab3.Size = new System.Drawing.Size(616, 60);
            lblTitleTab3.TabIndex = 1;
            lblTitleTab3.Text = "Edit My Builds";
            lblTitleTab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleTab4
            // 
            lblTitleTab4.Dock = System.Windows.Forms.DockStyle.Top;
            lblTitleTab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitleTab4.Location = new System.Drawing.Point(0, 0);
            lblTitleTab4.Name = "lblTitleTab4";
            lblTitleTab4.Size = new System.Drawing.Size(616, 60);
            lblTitleTab4.TabIndex = 1;
            lblTitleTab4.Text = "Edit Archetypes";
            lblTitleTab4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.recordMatchTab.Controls.Add(this.btnStatistics);
            this.recordMatchTab.Controls.Add(this.btnDefeat);
            this.recordMatchTab.Controls.Add(this.btnVictory);
            this.recordMatchTab.Controls.Add(lblVersusTab1);
            this.recordMatchTab.Controls.Add(this.cboArchetypeTab1);
            this.recordMatchTab.Controls.Add(this.cboBuildTab1);
            this.recordMatchTab.Controls.Add(this.lnkEditArchetypesTab1);
            this.recordMatchTab.Controls.Add(this.lnkEditBuildsTab1);
            this.recordMatchTab.Controls.Add(lblTitleTab1);
            this.recordMatchTab.Location = new System.Drawing.Point(4, 29);
            this.recordMatchTab.Name = "recordMatchTab";
            this.recordMatchTab.Padding = new System.Windows.Forms.Padding(3);
            this.recordMatchTab.Size = new System.Drawing.Size(616, 409);
            this.recordMatchTab.TabIndex = 0;
            this.recordMatchTab.Text = "Record Match";
            this.recordMatchTab.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Location = new System.Drawing.Point(218, 350);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(180, 40);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.SelectStatisticsTab);
            // 
            // btnDefeat
            // 
            this.btnDefeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefeat.Location = new System.Drawing.Point(337, 245);
            this.btnDefeat.Name = "btnDefeat";
            this.btnDefeat.Size = new System.Drawing.Size(240, 50);
            this.btnDefeat.TabIndex = 4;
            this.btnDefeat.Text = "Defeat";
            this.btnDefeat.UseVisualStyleBackColor = true;
            this.btnDefeat.Click += new System.EventHandler(this.btnDefeat_Click);
            // 
            // btnVictory
            // 
            this.btnVictory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVictory.Location = new System.Drawing.Point(40, 245);
            this.btnVictory.Name = "btnVictory";
            this.btnVictory.Size = new System.Drawing.Size(240, 50);
            this.btnVictory.TabIndex = 4;
            this.btnVictory.Text = "Victory";
            this.btnVictory.UseVisualStyleBackColor = true;
            this.btnVictory.Click += new System.EventHandler(this.btnVictory_Click);
            // 
            // cboArchetypeTab1
            // 
            this.cboArchetypeTab1.DataSource = this.archetypesBindingSource;
            this.cboArchetypeTab1.DisplayMember = "name";
            this.cboArchetypeTab1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArchetypeTab1.DropDownWidth = 121;
            this.cboArchetypeTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArchetypeTab1.FormattingEnabled = true;
            this.cboArchetypeTab1.Location = new System.Drawing.Point(388, 126);
            this.cboArchetypeTab1.Name = "cboArchetypeTab1";
            this.cboArchetypeTab1.Size = new System.Drawing.Size(150, 24);
            this.cboArchetypeTab1.TabIndex = 2;
            this.cboArchetypeTab1.ValueMember = "archetypeID";
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
            // cboBuildTab1
            // 
            this.cboBuildTab1.DataSource = this.buildsBindingSource;
            this.cboBuildTab1.DisplayMember = "name";
            this.cboBuildTab1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuildTab1.DropDownWidth = 121;
            this.cboBuildTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuildTab1.FormattingEnabled = true;
            this.cboBuildTab1.Location = new System.Drawing.Point(81, 126);
            this.cboBuildTab1.Name = "cboBuildTab1";
            this.cboBuildTab1.Size = new System.Drawing.Size(150, 24);
            this.cboBuildTab1.TabIndex = 2;
            this.cboBuildTab1.ValueMember = "buildID";
            // 
            // buildsBindingSource
            // 
            this.buildsBindingSource.DataMember = "Builds";
            this.buildsBindingSource.DataSource = this.databaseDataSet;
            // 
            // lnkEditArchetypesTab1
            // 
            this.lnkEditArchetypesTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkEditArchetypesTab1.AutoSize = true;
            this.lnkEditArchetypesTab1.Location = new System.Drawing.Point(457, 110);
            this.lnkEditArchetypesTab1.Name = "lnkEditArchetypesTab1";
            this.lnkEditArchetypesTab1.Size = new System.Drawing.Size(81, 13);
            this.lnkEditArchetypesTab1.TabIndex = 1;
            this.lnkEditArchetypesTab1.TabStop = true;
            this.lnkEditArchetypesTab1.Text = "Edit Archetypes";
            this.lnkEditArchetypesTab1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectEditArchetypesTab);
            // 
            // lnkEditBuildsTab1
            // 
            this.lnkEditBuildsTab1.AutoSize = true;
            this.lnkEditBuildsTab1.Location = new System.Drawing.Point(78, 110);
            this.lnkEditBuildsTab1.Name = "lnkEditBuildsTab1";
            this.lnkEditBuildsTab1.Size = new System.Drawing.Size(73, 13);
            this.lnkEditBuildsTab1.TabIndex = 1;
            this.lnkEditBuildsTab1.TabStop = true;
            this.lnkEditBuildsTab1.Text = "Edit My Builds";
            this.lnkEditBuildsTab1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectEditBuildsTab);
            // 
            // statisticsTab
            // 
            this.statisticsTab.Controls.Add(this.chkAllBuilds);
            this.statisticsTab.Controls.Add(this.chkAllArchetypes);
            this.statisticsTab.Controls.Add(this.panel1);
            this.statisticsTab.Controls.Add(this.btnRecordMatch);
            this.statisticsTab.Controls.Add(lblVersusTab2);
            this.statisticsTab.Controls.Add(this.cboArchetypeTab2);
            this.statisticsTab.Controls.Add(this.cboBuildTab2);
            this.statisticsTab.Controls.Add(this.lnkEditArchetypesTab2);
            this.statisticsTab.Controls.Add(this.lnkEditBuildsTab2);
            this.statisticsTab.Controls.Add(lblTitleTab2);
            this.statisticsTab.Location = new System.Drawing.Point(4, 29);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsTab.Size = new System.Drawing.Size(616, 409);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
            // 
            // chkAllBuilds
            // 
            this.chkAllBuilds.AutoSize = true;
            this.chkAllBuilds.Location = new System.Drawing.Point(103, 156);
            this.chkAllBuilds.Name = "chkAllBuilds";
            this.chkAllBuilds.Size = new System.Drawing.Size(68, 17);
            this.chkAllBuilds.TabIndex = 11;
            this.chkAllBuilds.Text = "All Builds";
            this.chkAllBuilds.UseVisualStyleBackColor = true;
            this.chkAllBuilds.CheckedChanged += new System.EventHandler(this.chkAllBuilds_CheckedChanged);
            // 
            // chkAllArchetypes
            // 
            this.chkAllArchetypes.AutoSize = true;
            this.chkAllArchetypes.Location = new System.Drawing.Point(423, 156);
            this.chkAllArchetypes.Name = "chkAllArchetypes";
            this.chkAllArchetypes.Size = new System.Drawing.Size(93, 17);
            this.chkAllArchetypes.TabIndex = 11;
            this.chkAllArchetypes.Text = "All Archetypes";
            this.chkAllArchetypes.UseVisualStyleBackColor = true;
            this.chkAllArchetypes.CheckedChanged += new System.EventHandler(this.chkAllArchetypes_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(lblLosses);
            this.panel1.Controls.Add(lblSeperator);
            this.panel1.Controls.Add(lblWins);
            this.panel1.Controls.Add(this.lblWinsValue);
            this.panel1.Controls.Add(this.lblLossesValue);
            this.panel1.Controls.Add(this.lblWinRateValue);
            this.panel1.Controls.Add(lblWinRate);
            this.panel1.Location = new System.Drawing.Point(103, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 120);
            this.panel1.TabIndex = 10;
            // 
            // lblWinsValue
            // 
            this.lblWinsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinsValue.Location = new System.Drawing.Point(133, 62);
            this.lblWinsValue.Name = "lblWinsValue";
            this.lblWinsValue.Size = new System.Drawing.Size(66, 33);
            this.lblWinsValue.TabIndex = 0;
            this.lblWinsValue.Text = "123";
            this.lblWinsValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLossesValue
            // 
            this.lblLossesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossesValue.Location = new System.Drawing.Point(206, 62);
            this.lblLossesValue.Name = "lblLossesValue";
            this.lblLossesValue.Size = new System.Drawing.Size(75, 33);
            this.lblLossesValue.TabIndex = 0;
            this.lblLossesValue.Text = "123";
            this.lblLossesValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWinRateValue
            // 
            this.lblWinRateValue.AutoSize = true;
            this.lblWinRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinRateValue.Location = new System.Drawing.Point(251, 11);
            this.lblWinRateValue.Name = "lblWinRateValue";
            this.lblWinRateValue.Size = new System.Drawing.Size(75, 33);
            this.lblWinRateValue.TabIndex = 0;
            this.lblWinRateValue.Text = "1.23";
            // 
            // btnRecordMatch
            // 
            this.btnRecordMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordMatch.Location = new System.Drawing.Point(218, 350);
            this.btnRecordMatch.Name = "btnRecordMatch";
            this.btnRecordMatch.Size = new System.Drawing.Size(180, 40);
            this.btnRecordMatch.TabIndex = 9;
            this.btnRecordMatch.Text = "Record Match Results";
            this.btnRecordMatch.UseVisualStyleBackColor = true;
            this.btnRecordMatch.Click += new System.EventHandler(this.SelectRecordMatchTab);
            // 
            // cboArchetypeTab2
            // 
            this.cboArchetypeTab2.DataSource = this.archetypesBindingSource;
            this.cboArchetypeTab2.DisplayMember = "name";
            this.cboArchetypeTab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArchetypeTab2.DropDownWidth = 121;
            this.cboArchetypeTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArchetypeTab2.FormattingEnabled = true;
            this.cboArchetypeTab2.Location = new System.Drawing.Point(388, 126);
            this.cboArchetypeTab2.Name = "cboArchetypeTab2";
            this.cboArchetypeTab2.Size = new System.Drawing.Size(150, 24);
            this.cboArchetypeTab2.TabIndex = 6;
            this.cboArchetypeTab2.ValueMember = "archetypeID";
            this.cboArchetypeTab2.SelectedIndexChanged += new System.EventHandler(this.cboArchetypeTab2_SelectedIndexChanged);
            // 
            // cboBuildTab2
            // 
            this.cboBuildTab2.DataSource = this.buildsBindingSource;
            this.cboBuildTab2.DisplayMember = "name";
            this.cboBuildTab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuildTab2.DropDownWidth = 121;
            this.cboBuildTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuildTab2.FormattingEnabled = true;
            this.cboBuildTab2.Location = new System.Drawing.Point(81, 126);
            this.cboBuildTab2.Name = "cboBuildTab2";
            this.cboBuildTab2.Size = new System.Drawing.Size(150, 24);
            this.cboBuildTab2.TabIndex = 7;
            this.cboBuildTab2.ValueMember = "buildID";
            this.cboBuildTab2.SelectedIndexChanged += new System.EventHandler(this.cboBuildTab2_SelectedIndexChanged);
            // 
            // lnkEditArchetypesTab2
            // 
            this.lnkEditArchetypesTab2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkEditArchetypesTab2.AutoSize = true;
            this.lnkEditArchetypesTab2.Location = new System.Drawing.Point(457, 110);
            this.lnkEditArchetypesTab2.Name = "lnkEditArchetypesTab2";
            this.lnkEditArchetypesTab2.Size = new System.Drawing.Size(81, 13);
            this.lnkEditArchetypesTab2.TabIndex = 4;
            this.lnkEditArchetypesTab2.TabStop = true;
            this.lnkEditArchetypesTab2.Text = "Edit Archetypes";
            this.lnkEditArchetypesTab2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectEditArchetypesTab);
            // 
            // lnkEditBuildsTab2
            // 
            this.lnkEditBuildsTab2.AutoSize = true;
            this.lnkEditBuildsTab2.Location = new System.Drawing.Point(78, 110);
            this.lnkEditBuildsTab2.Name = "lnkEditBuildsTab2";
            this.lnkEditBuildsTab2.Size = new System.Drawing.Size(73, 13);
            this.lnkEditBuildsTab2.TabIndex = 5;
            this.lnkEditBuildsTab2.TabStop = true;
            this.lnkEditBuildsTab2.Text = "Edit My Builds";
            this.lnkEditBuildsTab2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectEditBuildsTab);
            // 
            // editBuildsTab
            // 
            this.editBuildsTab.AutoScroll = true;
            this.editBuildsTab.Controls.Add(this.btnAddBuild);
            this.editBuildsTab.Controls.Add(this.btnEditBuild);
            this.editBuildsTab.Controls.Add(this.btnDeleteBuild);
            this.editBuildsTab.Controls.Add(this.dgvBuilds);
            this.editBuildsTab.Controls.Add(lblTitleTab3);
            this.editBuildsTab.Location = new System.Drawing.Point(4, 29);
            this.editBuildsTab.Name = "editBuildsTab";
            this.editBuildsTab.Size = new System.Drawing.Size(616, 409);
            this.editBuildsTab.TabIndex = 2;
            this.editBuildsTab.Text = "Edit My Builds";
            this.editBuildsTab.UseVisualStyleBackColor = true;
            // 
            // btnAddBuild
            // 
            this.btnAddBuild.Location = new System.Drawing.Point(236, 378);
            this.btnAddBuild.Name = "btnAddBuild";
            this.btnAddBuild.Size = new System.Drawing.Size(120, 23);
            this.btnAddBuild.TabIndex = 1;
            this.btnAddBuild.Text = "Add New Build";
            this.btnAddBuild.UseVisualStyleBackColor = true;
            this.btnAddBuild.Click += new System.EventHandler(this.btnAddBuild_Click);
            // 
            // btnEditBuild
            // 
            this.btnEditBuild.Location = new System.Drawing.Point(362, 378);
            this.btnEditBuild.Name = "btnEditBuild";
            this.btnEditBuild.Size = new System.Drawing.Size(120, 23);
            this.btnEditBuild.TabIndex = 2;
            this.btnEditBuild.Text = "Edit Selected";
            this.btnEditBuild.UseVisualStyleBackColor = true;
            this.btnEditBuild.Click += new System.EventHandler(this.btnEditBuild_Click);
            // 
            // btnDeleteBuild
            // 
            this.btnDeleteBuild.Location = new System.Drawing.Point(488, 378);
            this.btnDeleteBuild.Name = "btnDeleteBuild";
            this.btnDeleteBuild.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteBuild.TabIndex = 3;
            this.btnDeleteBuild.Text = "Delete Selected";
            this.btnDeleteBuild.UseVisualStyleBackColor = true;
            this.btnDeleteBuild.Click += new System.EventHandler(this.btnDeleteBuild_Click);
            // 
            // dgvBuilds
            // 
            this.dgvBuilds.AllowUserToAddRows = false;
            this.dgvBuilds.AllowUserToDeleteRows = false;
            this.dgvBuilds.AllowUserToResizeColumns = false;
            this.dgvBuilds.AllowUserToResizeRows = false;
            this.dgvBuilds.AutoGenerateColumns = false;
            this.dgvBuilds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuilds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuilds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumnBuild,
            this.archetypeColumnBuild,
            this.noteColumnBuild,
            this.idColumnBuild});
            this.dgvBuilds.DataSource = this.buildsBindingSource;
            this.dgvBuilds.Location = new System.Drawing.Point(8, 63);
            this.dgvBuilds.MultiSelect = false;
            this.dgvBuilds.Name = "dgvBuilds";
            this.dgvBuilds.ReadOnly = true;
            this.dgvBuilds.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBuilds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuilds.Size = new System.Drawing.Size(600, 309);
            this.dgvBuilds.TabIndex = 0;
            // 
            // nameColumnBuild
            // 
            this.nameColumnBuild.DataPropertyName = "name";
            this.nameColumnBuild.FillWeight = 25F;
            this.nameColumnBuild.HeaderText = "name";
            this.nameColumnBuild.Name = "nameColumnBuild";
            this.nameColumnBuild.ReadOnly = true;
            this.nameColumnBuild.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // archetypeColumnBuild
            // 
            this.archetypeColumnBuild.DataPropertyName = "archetypeID";
            this.archetypeColumnBuild.DataSource = this.archetypesBindingSource;
            this.archetypeColumnBuild.DisplayMember = "name";
            this.archetypeColumnBuild.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.archetypeColumnBuild.FillWeight = 25F;
            this.archetypeColumnBuild.HeaderText = "archetype";
            this.archetypeColumnBuild.Name = "archetypeColumnBuild";
            this.archetypeColumnBuild.ReadOnly = true;
            this.archetypeColumnBuild.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.archetypeColumnBuild.ValueMember = "archetypeID";
            // 
            // noteColumnBuild
            // 
            this.noteColumnBuild.DataPropertyName = "note";
            this.noteColumnBuild.FillWeight = 50F;
            this.noteColumnBuild.HeaderText = "note";
            this.noteColumnBuild.Name = "noteColumnBuild";
            this.noteColumnBuild.ReadOnly = true;
            this.noteColumnBuild.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idColumnBuild
            // 
            this.idColumnBuild.DataPropertyName = "buildID";
            this.idColumnBuild.HeaderText = "buildID";
            this.idColumnBuild.Name = "idColumnBuild";
            this.idColumnBuild.ReadOnly = true;
            this.idColumnBuild.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idColumnBuild.Visible = false;
            // 
            // editArchetypesTab
            // 
            this.editArchetypesTab.AutoScroll = true;
            this.editArchetypesTab.Controls.Add(this.btnAddArchetype);
            this.editArchetypesTab.Controls.Add(this.btnEditArchetype);
            this.editArchetypesTab.Controls.Add(this.btnDeleteArchetype);
            this.editArchetypesTab.Controls.Add(this.dgvArchetypes);
            this.editArchetypesTab.Controls.Add(lblTitleTab4);
            this.editArchetypesTab.Location = new System.Drawing.Point(4, 29);
            this.editArchetypesTab.Name = "editArchetypesTab";
            this.editArchetypesTab.Size = new System.Drawing.Size(616, 409);
            this.editArchetypesTab.TabIndex = 3;
            this.editArchetypesTab.Text = "Edit Archetypes";
            this.editArchetypesTab.UseVisualStyleBackColor = true;
            // 
            // btnAddArchetype
            // 
            this.btnAddArchetype.Location = new System.Drawing.Point(236, 378);
            this.btnAddArchetype.Name = "btnAddArchetype";
            this.btnAddArchetype.Size = new System.Drawing.Size(120, 23);
            this.btnAddArchetype.TabIndex = 5;
            this.btnAddArchetype.Text = "Add Archetype";
            this.btnAddArchetype.UseVisualStyleBackColor = true;
            this.btnAddArchetype.Click += new System.EventHandler(this.btnAddArchetype_Click);
            // 
            // btnEditArchetype
            // 
            this.btnEditArchetype.Location = new System.Drawing.Point(362, 378);
            this.btnEditArchetype.Name = "btnEditArchetype";
            this.btnEditArchetype.Size = new System.Drawing.Size(120, 23);
            this.btnEditArchetype.TabIndex = 6;
            this.btnEditArchetype.Text = "Edit Selected";
            this.btnEditArchetype.UseVisualStyleBackColor = true;
            this.btnEditArchetype.Click += new System.EventHandler(this.btnEditArchetype_Click);
            // 
            // btnDeleteArchetype
            // 
            this.btnDeleteArchetype.Location = new System.Drawing.Point(488, 378);
            this.btnDeleteArchetype.Name = "btnDeleteArchetype";
            this.btnDeleteArchetype.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteArchetype.TabIndex = 7;
            this.btnDeleteArchetype.Text = "Delete Selected";
            this.btnDeleteArchetype.UseVisualStyleBackColor = true;
            this.btnDeleteArchetype.Click += new System.EventHandler(this.btnDeleteArchetype_Click);
            // 
            // dgvArchetypes
            // 
            this.dgvArchetypes.AllowUserToAddRows = false;
            this.dgvArchetypes.AllowUserToDeleteRows = false;
            this.dgvArchetypes.AllowUserToResizeColumns = false;
            this.dgvArchetypes.AllowUserToResizeRows = false;
            this.dgvArchetypes.AutoGenerateColumns = false;
            this.dgvArchetypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArchetypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArchetypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumnArchetype,
            this.noteColumnArchetype,
            this.idColumnArchetype});
            this.dgvArchetypes.DataSource = this.archetypesBindingSource;
            this.dgvArchetypes.Location = new System.Drawing.Point(8, 63);
            this.dgvArchetypes.MultiSelect = false;
            this.dgvArchetypes.Name = "dgvArchetypes";
            this.dgvArchetypes.ReadOnly = true;
            this.dgvArchetypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArchetypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchetypes.Size = new System.Drawing.Size(600, 309);
            this.dgvArchetypes.TabIndex = 4;
            // 
            // nameColumnArchetype
            // 
            this.nameColumnArchetype.DataPropertyName = "name";
            this.nameColumnArchetype.FillWeight = 25F;
            this.nameColumnArchetype.HeaderText = "name";
            this.nameColumnArchetype.Name = "nameColumnArchetype";
            this.nameColumnArchetype.ReadOnly = true;
            this.nameColumnArchetype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // noteColumnArchetype
            // 
            this.noteColumnArchetype.DataPropertyName = "note";
            this.noteColumnArchetype.FillWeight = 75F;
            this.noteColumnArchetype.HeaderText = "note";
            this.noteColumnArchetype.Name = "noteColumnArchetype";
            this.noteColumnArchetype.ReadOnly = true;
            this.noteColumnArchetype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idColumnArchetype
            // 
            this.idColumnArchetype.DataPropertyName = "archetypeID";
            this.idColumnArchetype.HeaderText = "archetypeID";
            this.idColumnArchetype.Name = "idColumnArchetype";
            this.idColumnArchetype.ReadOnly = true;
            this.idColumnArchetype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idColumnArchetype.Visible = false;
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
            // archetypesTableAdapter1
            // 
            this.archetypesTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilds)).EndInit();
            this.editArchetypesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchetypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage recordMatchTab;
        private System.Windows.Forms.TabPage statisticsTab;
        private System.Windows.Forms.TabPage editBuildsTab;
        private System.Windows.Forms.TabPage editArchetypesTab;
        private System.Windows.Forms.Button btnDefeat;
        private System.Windows.Forms.Button btnVictory;
        private System.Windows.Forms.ComboBox cboArchetypeTab1;
        private System.Windows.Forms.ComboBox cboBuildTab1;
        private System.Windows.Forms.LinkLabel lnkEditArchetypesTab1;
        private System.Windows.Forms.LinkLabel lnkEditBuildsTab1;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.ComboBox cboArchetypeTab2;
        private System.Windows.Forms.ComboBox cboBuildTab2;
        private System.Windows.Forms.LinkLabel lnkEditArchetypesTab2;
        private System.Windows.Forms.LinkLabel lnkEditBuildsTab2;
        private System.Windows.Forms.Button btnRecordMatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBuilds;
        private System.Windows.Forms.Button btnDeleteBuild;
        private System.Windows.Forms.Button btnAddBuild;
        private System.Windows.Forms.Button btnEditBuild;
        private System.Windows.Forms.Button btnAddArchetype;
        private System.Windows.Forms.Button btnEditArchetype;
        private System.Windows.Forms.Button btnDeleteArchetype;
        private System.Windows.Forms.DataGridView dgvArchetypes;
        private System.Windows.Forms.Label lblWinsValue;
        private System.Windows.Forms.Label lblLossesValue;
        private System.Windows.Forms.Label lblWinRateValue;
        private Database.DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource buildsBindingSource;
        private Database.DatabaseDataSetTableAdapters.BuildsTableAdapter buildsTableAdapter;
        private System.Windows.Forms.BindingSource archetypesBindingSource;
        private Database.DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter;
        private Database.DatabaseDataSetTableAdapters.MatchesTableAdapter matchesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumnBuild;
        private System.Windows.Forms.DataGridViewComboBoxColumn archetypeColumnBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteColumnBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumnBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumnArchetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteColumnArchetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumnArchetype;
        private System.Windows.Forms.CheckBox chkAllBuilds;
        private System.Windows.Forms.CheckBox chkAllArchetypes;
        private Database.DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter1;
    }
}


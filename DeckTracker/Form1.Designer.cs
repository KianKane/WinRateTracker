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
            this.defeatButton = new System.Windows.Forms.Button();
            this.victoryButton = new System.Windows.Forms.Button();
            this.matchVersusLabel = new System.Windows.Forms.Label();
            this.matchArchetypeComboBox = new System.Windows.Forms.ComboBox();
            this.archetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DeckTracker.DatabaseDataSet();
            this.matchDeckListComboBox = new System.Windows.Forms.ComboBox();
            this.deckListsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.link_recordMatchToEditDeckArchetypes = new System.Windows.Forms.LinkLabel();
            this.link_recordMatchToEditDeckLists = new System.Windows.Forms.LinkLabel();
            this.recordMatchLabel = new System.Windows.Forms.Label();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.winRateLabel = new System.Windows.Forms.Label();
            this.btn_recordMatch = new System.Windows.Forms.Button();
            this.statisticsVersusLabel = new System.Windows.Forms.Label();
            this.cb_statisticsArchetype = new System.Windows.Forms.ComboBox();
            this.cb_statisticsDeckList = new System.Windows.Forms.ComboBox();
            this.link_statisticsToEditDeckArchetypes = new System.Windows.Forms.LinkLabel();
            this.link_statisticsToEditDeckLists = new System.Windows.Forms.LinkLabel();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.editDeckListsTab = new System.Windows.Forms.TabPage();
            this.btn_addDeckList = new System.Windows.Forms.Button();
            this.btn_editDeckList = new System.Windows.Forms.Button();
            this.btn_deleteDeckList = new System.Windows.Forms.Button();
            this.dgv_deckLists = new System.Windows.Forms.DataGridView();
            this.nameColumnDeckList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteColumnDeckList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classColumnDeckList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumnDeckList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editDeckListsLabel = new System.Windows.Forms.Label();
            this.editArchetypesTab = new System.Windows.Forms.TabPage();
            this.btn_addArchetype = new System.Windows.Forms.Button();
            this.btn_editArchetype = new System.Windows.Forms.Button();
            this.btn_deleteArchetype = new System.Windows.Forms.Button();
            this.dgv_archetypes = new System.Windows.Forms.DataGridView();
            this.nameColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumnArchetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editArchetypesLabel = new System.Windows.Forms.Label();
            this.deckListsTableAdapter = new DeckTracker.DatabaseDataSetTableAdapters.DeckListsTableAdapter();
            this.tableAdapterManager = new DeckTracker.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.archetypesTableAdapter = new DeckTracker.DatabaseDataSetTableAdapters.ArchetypesTableAdapter();
            this.lbl_winRate = new System.Windows.Forms.Label();
            this.lbl_losses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_wins = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matchesTableAdapter = new DeckTracker.DatabaseDataSetTableAdapters.MatchesTableAdapter();
            this.tabControl.SuspendLayout();
            this.recordMatchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckListsBindingSource)).BeginInit();
            this.statisticsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.editDeckListsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deckLists)).BeginInit();
            this.editArchetypesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_archetypes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.recordMatchTab);
            this.tabControl.Controls.Add(this.statisticsTab);
            this.tabControl.Controls.Add(this.editDeckListsTab);
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
            this.recordMatchTab.Controls.Add(this.defeatButton);
            this.recordMatchTab.Controls.Add(this.victoryButton);
            this.recordMatchTab.Controls.Add(this.matchVersusLabel);
            this.recordMatchTab.Controls.Add(this.matchArchetypeComboBox);
            this.recordMatchTab.Controls.Add(this.matchDeckListComboBox);
            this.recordMatchTab.Controls.Add(this.link_recordMatchToEditDeckArchetypes);
            this.recordMatchTab.Controls.Add(this.link_recordMatchToEditDeckLists);
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
            // defeatButton
            // 
            this.defeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defeatButton.Location = new System.Drawing.Point(337, 245);
            this.defeatButton.Name = "defeatButton";
            this.defeatButton.Size = new System.Drawing.Size(240, 50);
            this.defeatButton.TabIndex = 4;
            this.defeatButton.Text = "Defeat";
            this.defeatButton.UseVisualStyleBackColor = true;
            // 
            // victoryButton
            // 
            this.victoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryButton.Location = new System.Drawing.Point(40, 245);
            this.victoryButton.Name = "victoryButton";
            this.victoryButton.Size = new System.Drawing.Size(240, 50);
            this.victoryButton.TabIndex = 4;
            this.victoryButton.Text = "Victory";
            this.victoryButton.UseVisualStyleBackColor = true;
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
            // matchArchetypeComboBox
            // 
            this.matchArchetypeComboBox.DataSource = this.archetypesBindingSource;
            this.matchArchetypeComboBox.DisplayMember = "name";
            this.matchArchetypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchArchetypeComboBox.DropDownWidth = 121;
            this.matchArchetypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchArchetypeComboBox.FormattingEnabled = true;
            this.matchArchetypeComboBox.Location = new System.Drawing.Point(388, 126);
            this.matchArchetypeComboBox.Name = "matchArchetypeComboBox";
            this.matchArchetypeComboBox.Size = new System.Drawing.Size(150, 24);
            this.matchArchetypeComboBox.TabIndex = 2;
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
            // matchDeckListComboBox
            // 
            this.matchDeckListComboBox.DataSource = this.deckListsBindingSource;
            this.matchDeckListComboBox.DisplayMember = "name";
            this.matchDeckListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchDeckListComboBox.DropDownWidth = 121;
            this.matchDeckListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchDeckListComboBox.FormattingEnabled = true;
            this.matchDeckListComboBox.Location = new System.Drawing.Point(81, 126);
            this.matchDeckListComboBox.Name = "matchDeckListComboBox";
            this.matchDeckListComboBox.Size = new System.Drawing.Size(150, 24);
            this.matchDeckListComboBox.TabIndex = 2;
            // 
            // deckListsBindingSource
            // 
            this.deckListsBindingSource.DataMember = "DeckLists";
            this.deckListsBindingSource.DataSource = this.databaseDataSet;
            // 
            // link_recordMatchToEditDeckArchetypes
            // 
            this.link_recordMatchToEditDeckArchetypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.link_recordMatchToEditDeckArchetypes.AutoSize = true;
            this.link_recordMatchToEditDeckArchetypes.Location = new System.Drawing.Point(428, 110);
            this.link_recordMatchToEditDeckArchetypes.Name = "link_recordMatchToEditDeckArchetypes";
            this.link_recordMatchToEditDeckArchetypes.Size = new System.Drawing.Size(110, 13);
            this.link_recordMatchToEditDeckArchetypes.TabIndex = 1;
            this.link_recordMatchToEditDeckArchetypes.TabStop = true;
            this.link_recordMatchToEditDeckArchetypes.Text = "Edit Deck Archetypes";
            this.link_recordMatchToEditDeckArchetypes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_recordMatchToEditDeckArchetypes_LinkClicked);
            // 
            // link_recordMatchToEditDeckLists
            // 
            this.link_recordMatchToEditDeckLists.AutoSize = true;
            this.link_recordMatchToEditDeckLists.Location = new System.Drawing.Point(78, 110);
            this.link_recordMatchToEditDeckLists.Name = "link_recordMatchToEditDeckLists";
            this.link_recordMatchToEditDeckLists.Size = new System.Drawing.Size(78, 13);
            this.link_recordMatchToEditDeckLists.TabIndex = 1;
            this.link_recordMatchToEditDeckLists.TabStop = true;
            this.link_recordMatchToEditDeckLists.Text = "Edit Deck Lists";
            this.link_recordMatchToEditDeckLists.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_recordMatchToEditDeckLists_LinkClicked);
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
            this.statisticsTab.Controls.Add(this.cb_statisticsDeckList);
            this.statisticsTab.Controls.Add(this.link_statisticsToEditDeckArchetypes);
            this.statisticsTab.Controls.Add(this.link_statisticsToEditDeckLists);
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
            this.cb_statisticsArchetype.SelectedIndexChanged += new System.EventHandler(this.cb_statisticsArchetype_SelectedIndexChanged);
            // 
            // cb_statisticsDeckList
            // 
            this.cb_statisticsDeckList.DataSource = this.deckListsBindingSource;
            this.cb_statisticsDeckList.DisplayMember = "name";
            this.cb_statisticsDeckList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_statisticsDeckList.DropDownWidth = 121;
            this.cb_statisticsDeckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_statisticsDeckList.FormattingEnabled = true;
            this.cb_statisticsDeckList.Location = new System.Drawing.Point(81, 126);
            this.cb_statisticsDeckList.Name = "cb_statisticsDeckList";
            this.cb_statisticsDeckList.Size = new System.Drawing.Size(150, 24);
            this.cb_statisticsDeckList.TabIndex = 7;
            this.cb_statisticsDeckList.SelectedIndexChanged += new System.EventHandler(this.cb_statisticsDeckList_SelectedIndexChanged);
            // 
            // link_statisticsToEditDeckArchetypes
            // 
            this.link_statisticsToEditDeckArchetypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.link_statisticsToEditDeckArchetypes.AutoSize = true;
            this.link_statisticsToEditDeckArchetypes.Location = new System.Drawing.Point(428, 110);
            this.link_statisticsToEditDeckArchetypes.Name = "link_statisticsToEditDeckArchetypes";
            this.link_statisticsToEditDeckArchetypes.Size = new System.Drawing.Size(110, 13);
            this.link_statisticsToEditDeckArchetypes.TabIndex = 4;
            this.link_statisticsToEditDeckArchetypes.TabStop = true;
            this.link_statisticsToEditDeckArchetypes.Text = "Edit Deck Archetypes";
            this.link_statisticsToEditDeckArchetypes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_statisticsToEditDeckArchetypes_LinkClicked);
            // 
            // link_statisticsToEditDeckLists
            // 
            this.link_statisticsToEditDeckLists.AutoSize = true;
            this.link_statisticsToEditDeckLists.Location = new System.Drawing.Point(78, 110);
            this.link_statisticsToEditDeckLists.Name = "link_statisticsToEditDeckLists";
            this.link_statisticsToEditDeckLists.Size = new System.Drawing.Size(78, 13);
            this.link_statisticsToEditDeckLists.TabIndex = 5;
            this.link_statisticsToEditDeckLists.TabStop = true;
            this.link_statisticsToEditDeckLists.Text = "Edit Deck Lists";
            this.link_statisticsToEditDeckLists.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_statisticsToEditDeckLists_LinkClicked);
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
            // editDeckListsTab
            // 
            this.editDeckListsTab.AutoScroll = true;
            this.editDeckListsTab.Controls.Add(this.btn_addDeckList);
            this.editDeckListsTab.Controls.Add(this.btn_editDeckList);
            this.editDeckListsTab.Controls.Add(this.btn_deleteDeckList);
            this.editDeckListsTab.Controls.Add(this.dgv_deckLists);
            this.editDeckListsTab.Controls.Add(this.editDeckListsLabel);
            this.editDeckListsTab.Location = new System.Drawing.Point(4, 29);
            this.editDeckListsTab.Name = "editDeckListsTab";
            this.editDeckListsTab.Size = new System.Drawing.Size(616, 409);
            this.editDeckListsTab.TabIndex = 2;
            this.editDeckListsTab.Text = "Edit Deck Lists";
            this.editDeckListsTab.UseVisualStyleBackColor = true;
            // 
            // btn_addDeckList
            // 
            this.btn_addDeckList.Location = new System.Drawing.Point(236, 378);
            this.btn_addDeckList.Name = "btn_addDeckList";
            this.btn_addDeckList.Size = new System.Drawing.Size(120, 23);
            this.btn_addDeckList.TabIndex = 1;
            this.btn_addDeckList.Text = "Add Deck List";
            this.btn_addDeckList.UseVisualStyleBackColor = true;
            this.btn_addDeckList.Click += new System.EventHandler(this.btn_addDeckList_Click);
            // 
            // btn_editDeckList
            // 
            this.btn_editDeckList.Location = new System.Drawing.Point(362, 378);
            this.btn_editDeckList.Name = "btn_editDeckList";
            this.btn_editDeckList.Size = new System.Drawing.Size(120, 23);
            this.btn_editDeckList.TabIndex = 2;
            this.btn_editDeckList.Text = "Edit Selected";
            this.btn_editDeckList.UseVisualStyleBackColor = true;
            this.btn_editDeckList.Click += new System.EventHandler(this.btn_editDeckList_Click);
            // 
            // btn_deleteDeckList
            // 
            this.btn_deleteDeckList.Location = new System.Drawing.Point(488, 378);
            this.btn_deleteDeckList.Name = "btn_deleteDeckList";
            this.btn_deleteDeckList.Size = new System.Drawing.Size(120, 23);
            this.btn_deleteDeckList.TabIndex = 3;
            this.btn_deleteDeckList.Text = "Delete Selected";
            this.btn_deleteDeckList.UseVisualStyleBackColor = true;
            this.btn_deleteDeckList.Click += new System.EventHandler(this.btn_deleteDeckList_Click);
            // 
            // dgv_deckLists
            // 
            this.dgv_deckLists.AllowUserToAddRows = false;
            this.dgv_deckLists.AllowUserToDeleteRows = false;
            this.dgv_deckLists.AllowUserToResizeColumns = false;
            this.dgv_deckLists.AllowUserToResizeRows = false;
            this.dgv_deckLists.AutoGenerateColumns = false;
            this.dgv_deckLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_deckLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_deckLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumnDeckList,
            this.noteColumnDeckList,
            this.classColumnDeckList,
            this.idColumnDeckList});
            this.dgv_deckLists.DataSource = this.deckListsBindingSource;
            this.dgv_deckLists.Location = new System.Drawing.Point(8, 63);
            this.dgv_deckLists.MultiSelect = false;
            this.dgv_deckLists.Name = "dgv_deckLists";
            this.dgv_deckLists.ReadOnly = true;
            this.dgv_deckLists.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_deckLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_deckLists.Size = new System.Drawing.Size(600, 309);
            this.dgv_deckLists.TabIndex = 0;
            // 
            // nameColumnDeckList
            // 
            this.nameColumnDeckList.DataPropertyName = "name";
            this.nameColumnDeckList.HeaderText = "name";
            this.nameColumnDeckList.Name = "nameColumnDeckList";
            this.nameColumnDeckList.ReadOnly = true;
            // 
            // noteColumnDeckList
            // 
            this.noteColumnDeckList.DataPropertyName = "note";
            this.noteColumnDeckList.HeaderText = "note";
            this.noteColumnDeckList.Name = "noteColumnDeckList";
            this.noteColumnDeckList.ReadOnly = true;
            // 
            // classColumnDeckList
            // 
            this.classColumnDeckList.DataPropertyName = "class";
            this.classColumnDeckList.HeaderText = "class";
            this.classColumnDeckList.Name = "classColumnDeckList";
            this.classColumnDeckList.ReadOnly = true;
            // 
            // idColumnDeckList
            // 
            this.idColumnDeckList.DataPropertyName = "deckListID";
            this.idColumnDeckList.HeaderText = "id";
            this.idColumnDeckList.Name = "idColumnDeckList";
            this.idColumnDeckList.ReadOnly = true;
            this.idColumnDeckList.Visible = false;
            // 
            // editDeckListsLabel
            // 
            this.editDeckListsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editDeckListsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDeckListsLabel.Location = new System.Drawing.Point(0, 0);
            this.editDeckListsLabel.Name = "editDeckListsLabel";
            this.editDeckListsLabel.Size = new System.Drawing.Size(616, 60);
            this.editDeckListsLabel.TabIndex = 1;
            this.editDeckListsLabel.Text = "Edit Deck Lists";
            this.editDeckListsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.classColumnArchetype,
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
            // nameColumnArchetype
            // 
            this.nameColumnArchetype.DataPropertyName = "name";
            this.nameColumnArchetype.HeaderText = "name";
            this.nameColumnArchetype.Name = "nameColumnArchetype";
            this.nameColumnArchetype.ReadOnly = true;
            // 
            // noteColumnArchetype
            // 
            this.noteColumnArchetype.DataPropertyName = "note";
            this.noteColumnArchetype.HeaderText = "note";
            this.noteColumnArchetype.Name = "noteColumnArchetype";
            this.noteColumnArchetype.ReadOnly = true;
            // 
            // classColumnArchetype
            // 
            this.classColumnArchetype.DataPropertyName = "class";
            this.classColumnArchetype.HeaderText = "class";
            this.classColumnArchetype.Name = "classColumnArchetype";
            this.classColumnArchetype.ReadOnly = true;
            // 
            // idColumnArchetype
            // 
            this.idColumnArchetype.DataPropertyName = "archetypeID";
            this.idColumnArchetype.HeaderText = "id";
            this.idColumnArchetype.Name = "idColumnArchetype";
            this.idColumnArchetype.ReadOnly = true;
            this.idColumnArchetype.Visible = false;
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
            // deckListsTableAdapter
            // 
            this.deckListsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchetypesTableAdapter = this.archetypesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeckListsTableAdapter = this.deckListsTableAdapter;
            this.tableAdapterManager.MatchesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DeckTracker.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // archetypesTableAdapter
            // 
            this.archetypesTableAdapter.ClearBeforeFill = true;
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
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Deck Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.recordMatchTab.ResumeLayout(false);
            this.recordMatchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckListsBindingSource)).EndInit();
            this.statisticsTab.ResumeLayout(false);
            this.statisticsTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.editDeckListsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deckLists)).EndInit();
            this.editArchetypesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_archetypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage recordMatchTab;
        private System.Windows.Forms.TabPage statisticsTab;
        private System.Windows.Forms.TabPage editDeckListsTab;
        private System.Windows.Forms.TabPage editArchetypesTab;
        private System.Windows.Forms.Label recordMatchLabel;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.Label editDeckListsLabel;
        private System.Windows.Forms.Label editArchetypesLabel;
        private System.Windows.Forms.Button defeatButton;
        private System.Windows.Forms.Button victoryButton;
        private System.Windows.Forms.Label matchVersusLabel;
        private System.Windows.Forms.ComboBox matchArchetypeComboBox;
        private System.Windows.Forms.ComboBox matchDeckListComboBox;
        private System.Windows.Forms.LinkLabel link_recordMatchToEditDeckArchetypes;
        private System.Windows.Forms.LinkLabel link_recordMatchToEditDeckLists;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.Label statisticsVersusLabel;
        private System.Windows.Forms.ComboBox cb_statisticsArchetype;
        private System.Windows.Forms.ComboBox cb_statisticsDeckList;
        private System.Windows.Forms.LinkLabel link_statisticsToEditDeckArchetypes;
        private System.Windows.Forms.LinkLabel link_statisticsToEditDeckLists;
        private System.Windows.Forms.Button btn_recordMatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label winRateLabel;
        private System.Windows.Forms.Label label;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource deckListsBindingSource;
        private DatabaseDataSetTableAdapters.DeckListsTableAdapter deckListsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv_deckLists;
        private System.Windows.Forms.Button btn_deleteDeckList;
        private DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter;
        private System.Windows.Forms.BindingSource archetypesBindingSource;
        private System.Windows.Forms.Button btn_addDeckList;
        private System.Windows.Forms.Button btn_editDeckList;
        private System.Windows.Forms.Button btn_addArchetype;
        private System.Windows.Forms.Button btn_editArchetype;
        private System.Windows.Forms.Button btn_deleteArchetype;
        private System.Windows.Forms.DataGridView dgv_archetypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumnArchetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteColumnArchetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn classColumnArchetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumnArchetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumnDeckList;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteColumnDeckList;
        private System.Windows.Forms.DataGridViewTextBoxColumn classColumnDeckList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumnDeckList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_wins;
        private System.Windows.Forms.Label lbl_losses;
        private System.Windows.Forms.Label lbl_winRate;
        private DatabaseDataSetTableAdapters.MatchesTableAdapter matchesTableAdapter;
    }
}


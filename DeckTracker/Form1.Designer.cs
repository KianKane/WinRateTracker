﻿namespace DeckTracker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.recordMatchTab = new System.Windows.Forms.TabPage();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.defeatButton = new System.Windows.Forms.Button();
            this.victoryButton = new System.Windows.Forms.Button();
            this.matchVersusLabel = new System.Windows.Forms.Label();
            this.matchArchetypeComboBox = new System.Windows.Forms.ComboBox();
            this.archetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DeckTracker.DatabaseDataSet();
            this.matchDeckListComboBox = new System.Windows.Forms.ComboBox();
            this.deckListsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchEditArchetypesLink = new System.Windows.Forms.LinkLabel();
            this.matchEditDeckListsLink = new System.Windows.Forms.LinkLabel();
            this.recordMatchLabel = new System.Windows.Forms.Label();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.winsAndLossesLabel = new System.Windows.Forms.Label();
            this.winRateLabel = new System.Windows.Forms.Label();
            this.recordMatchResultsButton = new System.Windows.Forms.Button();
            this.statisticsVersusLabel = new System.Windows.Forms.Label();
            this.statisticsArchetypeComboBox = new System.Windows.Forms.ComboBox();
            this.statisticsDeckListComboBox = new System.Windows.Forms.ComboBox();
            this.statisticsEditDeckArchetypesLink = new System.Windows.Forms.LinkLabel();
            this.statisticsEditDeckListsLink = new System.Windows.Forms.LinkLabel();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.editDeckListsTab = new System.Windows.Forms.TabPage();
            this.btn_addDeckList = new System.Windows.Forms.Button();
            this.btn_editDeckList = new System.Windows.Forms.Button();
            this.btn_deleteDeckList = new System.Windows.Forms.Button();
            this.dgv_deckLists = new System.Windows.Forms.DataGridView();
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
            this.nameColumnDeckList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteColumnDeckList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classColumnDeckList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumnDeckList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.recordMatchTab);
            this.tabControl1.Controls.Add(this.statisticsTab);
            this.tabControl1.Controls.Add(this.editDeckListsTab);
            this.tabControl1.Controls.Add(this.editArchetypesTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(155, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 442);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // recordMatchTab
            // 
            this.recordMatchTab.Controls.Add(this.statisticsButton);
            this.recordMatchTab.Controls.Add(this.defeatButton);
            this.recordMatchTab.Controls.Add(this.victoryButton);
            this.recordMatchTab.Controls.Add(this.matchVersusLabel);
            this.recordMatchTab.Controls.Add(this.matchArchetypeComboBox);
            this.recordMatchTab.Controls.Add(this.matchDeckListComboBox);
            this.recordMatchTab.Controls.Add(this.matchEditArchetypesLink);
            this.recordMatchTab.Controls.Add(this.matchEditDeckListsLink);
            this.recordMatchTab.Controls.Add(this.recordMatchLabel);
            this.recordMatchTab.Location = new System.Drawing.Point(4, 29);
            this.recordMatchTab.Name = "recordMatchTab";
            this.recordMatchTab.Padding = new System.Windows.Forms.Padding(3);
            this.recordMatchTab.Size = new System.Drawing.Size(616, 409);
            this.recordMatchTab.TabIndex = 0;
            this.recordMatchTab.Text = "Record Match";
            this.recordMatchTab.UseVisualStyleBackColor = true;
            // 
            // statisticsButton
            // 
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.Location = new System.Drawing.Point(218, 350);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(180, 40);
            this.statisticsButton.TabIndex = 4;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = true;
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
            // matchEditArchetypesLink
            // 
            this.matchEditArchetypesLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matchEditArchetypesLink.AutoSize = true;
            this.matchEditArchetypesLink.Location = new System.Drawing.Point(428, 110);
            this.matchEditArchetypesLink.Name = "matchEditArchetypesLink";
            this.matchEditArchetypesLink.Size = new System.Drawing.Size(110, 13);
            this.matchEditArchetypesLink.TabIndex = 1;
            this.matchEditArchetypesLink.TabStop = true;
            this.matchEditArchetypesLink.Text = "Edit Deck Archetypes";
            // 
            // matchEditDeckListsLink
            // 
            this.matchEditDeckListsLink.AutoSize = true;
            this.matchEditDeckListsLink.Location = new System.Drawing.Point(78, 110);
            this.matchEditDeckListsLink.Name = "matchEditDeckListsLink";
            this.matchEditDeckListsLink.Size = new System.Drawing.Size(78, 13);
            this.matchEditDeckListsLink.TabIndex = 1;
            this.matchEditDeckListsLink.TabStop = true;
            this.matchEditDeckListsLink.Text = "Edit Deck Lists";
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
            this.statisticsTab.Controls.Add(this.recordMatchResultsButton);
            this.statisticsTab.Controls.Add(this.statisticsVersusLabel);
            this.statisticsTab.Controls.Add(this.statisticsArchetypeComboBox);
            this.statisticsTab.Controls.Add(this.statisticsDeckListComboBox);
            this.statisticsTab.Controls.Add(this.statisticsEditDeckArchetypesLink);
            this.statisticsTab.Controls.Add(this.statisticsEditDeckListsLink);
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
            this.panel1.Controls.Add(this.winsAndLossesLabel);
            this.panel1.Controls.Add(this.winRateLabel);
            this.panel1.Location = new System.Drawing.Point(103, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 120);
            this.panel1.TabIndex = 10;
            // 
            // winsAndLossesLabel
            // 
            this.winsAndLossesLabel.AutoSize = true;
            this.winsAndLossesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsAndLossesLabel.Location = new System.Drawing.Point(36, 62);
            this.winsAndLossesLabel.Name = "winsAndLossesLabel";
            this.winsAndLossesLabel.Size = new System.Drawing.Size(353, 33);
            this.winsAndLossesLabel.TabIndex = 0;
            this.winsAndLossesLabel.Text = "Wins - 112 | 96 - Losses";
            // 
            // winRateLabel
            // 
            this.winRateLabel.AutoSize = true;
            this.winRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winRateLabel.Location = new System.Drawing.Point(94, 11);
            this.winRateLabel.Name = "winRateLabel";
            this.winRateLabel.Size = new System.Drawing.Size(220, 33);
            this.winRateLabel.TabIndex = 0;
            this.winRateLabel.Text = "Win Rate: 1.17";
            // 
            // recordMatchResultsButton
            // 
            this.recordMatchResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordMatchResultsButton.Location = new System.Drawing.Point(218, 350);
            this.recordMatchResultsButton.Name = "recordMatchResultsButton";
            this.recordMatchResultsButton.Size = new System.Drawing.Size(180, 40);
            this.recordMatchResultsButton.TabIndex = 9;
            this.recordMatchResultsButton.Text = "Record Match Results";
            this.recordMatchResultsButton.UseVisualStyleBackColor = true;
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
            // statisticsArchetypeComboBox
            // 
            this.statisticsArchetypeComboBox.DataSource = this.archetypesBindingSource;
            this.statisticsArchetypeComboBox.DisplayMember = "name";
            this.statisticsArchetypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statisticsArchetypeComboBox.DropDownWidth = 121;
            this.statisticsArchetypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsArchetypeComboBox.FormattingEnabled = true;
            this.statisticsArchetypeComboBox.Location = new System.Drawing.Point(388, 126);
            this.statisticsArchetypeComboBox.Name = "statisticsArchetypeComboBox";
            this.statisticsArchetypeComboBox.Size = new System.Drawing.Size(150, 24);
            this.statisticsArchetypeComboBox.TabIndex = 6;
            // 
            // statisticsDeckListComboBox
            // 
            this.statisticsDeckListComboBox.DataSource = this.deckListsBindingSource;
            this.statisticsDeckListComboBox.DisplayMember = "name";
            this.statisticsDeckListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statisticsDeckListComboBox.DropDownWidth = 121;
            this.statisticsDeckListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsDeckListComboBox.FormattingEnabled = true;
            this.statisticsDeckListComboBox.Location = new System.Drawing.Point(81, 126);
            this.statisticsDeckListComboBox.Name = "statisticsDeckListComboBox";
            this.statisticsDeckListComboBox.Size = new System.Drawing.Size(150, 24);
            this.statisticsDeckListComboBox.TabIndex = 7;
            // 
            // statisticsEditDeckArchetypesLink
            // 
            this.statisticsEditDeckArchetypesLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsEditDeckArchetypesLink.AutoSize = true;
            this.statisticsEditDeckArchetypesLink.Location = new System.Drawing.Point(428, 110);
            this.statisticsEditDeckArchetypesLink.Name = "statisticsEditDeckArchetypesLink";
            this.statisticsEditDeckArchetypesLink.Size = new System.Drawing.Size(110, 13);
            this.statisticsEditDeckArchetypesLink.TabIndex = 4;
            this.statisticsEditDeckArchetypesLink.TabStop = true;
            this.statisticsEditDeckArchetypesLink.Text = "Edit Deck Archetypes";
            // 
            // statisticsEditDeckListsLink
            // 
            this.statisticsEditDeckListsLink.AutoSize = true;
            this.statisticsEditDeckListsLink.Location = new System.Drawing.Point(78, 110);
            this.statisticsEditDeckListsLink.Name = "statisticsEditDeckListsLink";
            this.statisticsEditDeckListsLink.Size = new System.Drawing.Size(78, 13);
            this.statisticsEditDeckListsLink.TabIndex = 5;
            this.statisticsEditDeckListsLink.TabStop = true;
            this.statisticsEditDeckListsLink.Text = "Edit Deck Lists";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Deck Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
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

        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.LinkLabel matchEditArchetypesLink;
        private System.Windows.Forms.LinkLabel matchEditDeckListsLink;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Label statisticsVersusLabel;
        private System.Windows.Forms.ComboBox statisticsArchetypeComboBox;
        private System.Windows.Forms.ComboBox statisticsDeckListComboBox;
        private System.Windows.Forms.LinkLabel statisticsEditDeckArchetypesLink;
        private System.Windows.Forms.LinkLabel statisticsEditDeckListsLink;
        private System.Windows.Forms.Button recordMatchResultsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label winRateLabel;
        private System.Windows.Forms.Label winsAndLossesLabel;
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
    }
}


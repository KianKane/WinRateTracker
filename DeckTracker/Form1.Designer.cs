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
            this.deckListsSave = new System.Windows.Forms.Button();
            this.deckListsDataGridView = new System.Windows.Forms.DataGridView();
            this.editDeckListsLabel = new System.Windows.Forms.Label();
            this.editArchetypesTab = new System.Windows.Forms.TabPage();
            this.archetypesSave = new System.Windows.Forms.Button();
            this.archetypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editArchetypesLabel = new System.Windows.Forms.Label();
            this.deckListsTableAdapter = new DeckTracker.DatabaseDataSetTableAdapters.DeckListsTableAdapter();
            this.tableAdapterManager = new DeckTracker.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.archetypesTableAdapter = new DeckTracker.DatabaseDataSetTableAdapters.ArchetypesTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.recordMatchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckListsBindingSource)).BeginInit();
            this.statisticsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.editDeckListsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckListsDataGridView)).BeginInit();
            this.editArchetypesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypesDataGridView)).BeginInit();
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
            this.editDeckListsTab.Controls.Add(this.deckListsSave);
            this.editDeckListsTab.Controls.Add(this.deckListsDataGridView);
            this.editDeckListsTab.Controls.Add(this.editDeckListsLabel);
            this.editDeckListsTab.Location = new System.Drawing.Point(4, 29);
            this.editDeckListsTab.Name = "editDeckListsTab";
            this.editDeckListsTab.Size = new System.Drawing.Size(616, 409);
            this.editDeckListsTab.TabIndex = 2;
            this.editDeckListsTab.Text = "Edit Deck Lists";
            this.editDeckListsTab.UseVisualStyleBackColor = true;
            // 
            // deckListsSave
            // 
            this.deckListsSave.Location = new System.Drawing.Point(488, 378);
            this.deckListsSave.Name = "deckListsSave";
            this.deckListsSave.Size = new System.Drawing.Size(120, 23);
            this.deckListsSave.TabIndex = 2;
            this.deckListsSave.Text = "Save Changes";
            this.deckListsSave.UseVisualStyleBackColor = true;
            this.deckListsSave.Click += new System.EventHandler(this.UpdateDatabase);
            // 
            // deckListsDataGridView
            // 
            this.deckListsDataGridView.AllowUserToAddRows = false;
            this.deckListsDataGridView.AllowUserToDeleteRows = false;
            this.deckListsDataGridView.AllowUserToResizeColumns = false;
            this.deckListsDataGridView.AllowUserToResizeRows = false;
            this.deckListsDataGridView.AutoGenerateColumns = false;
            this.deckListsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deckListsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.deckListsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1});
            this.deckListsDataGridView.DataSource = this.deckListsBindingSource;
            this.deckListsDataGridView.Location = new System.Drawing.Point(8, 63);
            this.deckListsDataGridView.MultiSelect = false;
            this.deckListsDataGridView.Name = "deckListsDataGridView";
            this.deckListsDataGridView.ReadOnly = true;
            this.deckListsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.deckListsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deckListsDataGridView.Size = new System.Drawing.Size(600, 309);
            this.deckListsDataGridView.TabIndex = 1;
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
            this.editArchetypesTab.Controls.Add(this.archetypesSave);
            this.editArchetypesTab.Controls.Add(this.archetypesDataGridView);
            this.editArchetypesTab.Controls.Add(this.editArchetypesLabel);
            this.editArchetypesTab.Location = new System.Drawing.Point(4, 29);
            this.editArchetypesTab.Name = "editArchetypesTab";
            this.editArchetypesTab.Size = new System.Drawing.Size(616, 409);
            this.editArchetypesTab.TabIndex = 3;
            this.editArchetypesTab.Text = "Edit Archetypes";
            this.editArchetypesTab.UseVisualStyleBackColor = true;
            // 
            // archetypesSave
            // 
            this.archetypesSave.Location = new System.Drawing.Point(488, 378);
            this.archetypesSave.Name = "archetypesSave";
            this.archetypesSave.Size = new System.Drawing.Size(120, 23);
            this.archetypesSave.TabIndex = 3;
            this.archetypesSave.Text = "Save Changes";
            this.archetypesSave.UseVisualStyleBackColor = true;
            this.archetypesSave.Click += new System.EventHandler(this.UpdateDatabase);
            // 
            // archetypesDataGridView
            // 
            this.archetypesDataGridView.AutoGenerateColumns = false;
            this.archetypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.archetypesDataGridView.DataSource = this.archetypesBindingSource;
            this.archetypesDataGridView.Location = new System.Drawing.Point(8, 63);
            this.archetypesDataGridView.Name = "archetypesDataGridView";
            this.archetypesDataGridView.Size = new System.Drawing.Size(600, 309);
            this.archetypesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "archetypeID";
            this.dataGridViewTextBoxColumn5.HeaderText = "archetypeID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn7.HeaderText = "note";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "class";
            this.dataGridViewTextBoxColumn8.HeaderText = "class";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn3.HeaderText = "note";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "class";
            this.dataGridViewTextBoxColumn4.HeaderText = "class";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "deckListID";
            this.dataGridViewTextBoxColumn1.HeaderText = "deckListID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.deckListsDataGridView)).EndInit();
            this.editArchetypesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.archetypesDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView deckListsDataGridView;
        private System.Windows.Forms.Button deckListsSave;
        private DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter;
        private System.Windows.Forms.BindingSource archetypesBindingSource;
        private System.Windows.Forms.DataGridView archetypesDataGridView;
        private System.Windows.Forms.Button archetypesSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}


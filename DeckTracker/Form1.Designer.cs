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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.recordMatchTab = new System.Windows.Forms.TabPage();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.defeatButton = new System.Windows.Forms.Button();
            this.victoryButton = new System.Windows.Forms.Button();
            this.versusLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deckListComboBox = new System.Windows.Forms.ComboBox();
            this.editArchetypesLink = new System.Windows.Forms.LinkLabel();
            this.editDeckListsLink = new System.Windows.Forms.LinkLabel();
            this.recordMatchLabel = new System.Windows.Forms.Label();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.editDeckListsTab = new System.Windows.Forms.TabPage();
            this.editDeckListsLabel = new System.Windows.Forms.Label();
            this.editArchetypesTab = new System.Windows.Forms.TabPage();
            this.editArchetypesLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.recordMatchTab.SuspendLayout();
            this.statisticsTab.SuspendLayout();
            this.editDeckListsTab.SuspendLayout();
            this.editArchetypesTab.SuspendLayout();
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
            this.recordMatchTab.Controls.Add(this.versusLabel);
            this.recordMatchTab.Controls.Add(this.comboBox1);
            this.recordMatchTab.Controls.Add(this.deckListComboBox);
            this.recordMatchTab.Controls.Add(this.editArchetypesLink);
            this.recordMatchTab.Controls.Add(this.editDeckListsLink);
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
            this.defeatButton.Location = new System.Drawing.Point(336, 245);
            this.defeatButton.Name = "defeatButton";
            this.defeatButton.Size = new System.Drawing.Size(240, 50);
            this.defeatButton.TabIndex = 4;
            this.defeatButton.Text = "Defeat";
            this.defeatButton.UseVisualStyleBackColor = true;
            // 
            // victoryButton
            // 
            this.victoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryButton.Location = new System.Drawing.Point(39, 245);
            this.victoryButton.Name = "victoryButton";
            this.victoryButton.Size = new System.Drawing.Size(240, 50);
            this.victoryButton.TabIndex = 4;
            this.victoryButton.Text = "Victory";
            this.victoryButton.UseVisualStyleBackColor = true;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.Location = new System.Drawing.Point(276, 126);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(65, 39);
            this.versusLabel.TabIndex = 3;
            this.versusLabel.Text = "VS";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 121;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(387, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // deckListComboBox
            // 
            this.deckListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deckListComboBox.DropDownWidth = 121;
            this.deckListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckListComboBox.FormattingEnabled = true;
            this.deckListComboBox.Location = new System.Drawing.Point(80, 126);
            this.deckListComboBox.Name = "deckListComboBox";
            this.deckListComboBox.Size = new System.Drawing.Size(150, 32);
            this.deckListComboBox.TabIndex = 2;
            // 
            // editArchetypesLink
            // 
            this.editArchetypesLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editArchetypesLink.AutoSize = true;
            this.editArchetypesLink.Location = new System.Drawing.Point(427, 110);
            this.editArchetypesLink.Name = "editArchetypesLink";
            this.editArchetypesLink.Size = new System.Drawing.Size(110, 13);
            this.editArchetypesLink.TabIndex = 1;
            this.editArchetypesLink.TabStop = true;
            this.editArchetypesLink.Text = "Edit Deck Archetypes";
            // 
            // editDeckListsLink
            // 
            this.editDeckListsLink.AutoSize = true;
            this.editDeckListsLink.Location = new System.Drawing.Point(77, 110);
            this.editDeckListsLink.Name = "editDeckListsLink";
            this.editDeckListsLink.Size = new System.Drawing.Size(78, 13);
            this.editDeckListsLink.TabIndex = 1;
            this.editDeckListsLink.TabStop = true;
            this.editDeckListsLink.Text = "Edit Deck Lists";
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
            this.statisticsTab.Controls.Add(this.statisticsLabel);
            this.statisticsTab.Location = new System.Drawing.Point(4, 29);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsTab.Size = new System.Drawing.Size(616, 409);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
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
            this.editDeckListsTab.Controls.Add(this.editDeckListsLabel);
            this.editDeckListsTab.Location = new System.Drawing.Point(4, 29);
            this.editDeckListsTab.Name = "editDeckListsTab";
            this.editDeckListsTab.Size = new System.Drawing.Size(616, 409);
            this.editDeckListsTab.TabIndex = 2;
            this.editDeckListsTab.Text = "Edit Deck Lists";
            this.editDeckListsTab.UseVisualStyleBackColor = true;
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
            this.editArchetypesTab.Controls.Add(this.editArchetypesLabel);
            this.editArchetypesTab.Location = new System.Drawing.Point(4, 29);
            this.editArchetypesTab.Name = "editArchetypesTab";
            this.editArchetypesTab.Size = new System.Drawing.Size(616, 409);
            this.editArchetypesTab.TabIndex = 3;
            this.editArchetypesTab.Text = "Edit Archetypes";
            this.editArchetypesTab.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Deck Tracker";
            this.tabControl1.ResumeLayout(false);
            this.recordMatchTab.ResumeLayout(false);
            this.recordMatchTab.PerformLayout();
            this.statisticsTab.ResumeLayout(false);
            this.editDeckListsTab.ResumeLayout(false);
            this.editArchetypesTab.ResumeLayout(false);
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
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox deckListComboBox;
        private System.Windows.Forms.LinkLabel editArchetypesLink;
        private System.Windows.Forms.LinkLabel editDeckListsLink;
        private System.Windows.Forms.Button statisticsButton;
    }
}


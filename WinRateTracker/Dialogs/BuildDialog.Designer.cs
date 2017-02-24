namespace DeckTracker
{
    partial class BuildDialog
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
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblArchetype;
            System.Windows.Forms.Label lblNote;
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboArchetype = new System.Windows.Forms.ComboBox();
            this.archetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DeckTracker.Model.DatabaseDataSet();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.archetypesTableAdapter = new DeckTracker.Model.DatabaseDataSetTableAdapters.ArchetypesTableAdapter();
            lblName = new System.Windows.Forms.Label();
            lblArchetype = new System.Windows.Forms.Label();
            lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.archetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(38, 13);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 15);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(56, 68);
            this.txtNote.MaxLength = 200;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(216, 47);
            this.txtNote.TabIndex = 2;
            // 
            // cboArchetype
            // 
            this.cboArchetype.DataSource = this.archetypesBindingSource;
            this.cboArchetype.DisplayMember = "name";
            this.cboArchetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArchetype.FormattingEnabled = true;
            this.cboArchetype.Location = new System.Drawing.Point(56, 41);
            this.cboArchetype.Name = "cboArchetype";
            this.cboArchetype.Size = new System.Drawing.Size(135, 21);
            this.cboArchetype.TabIndex = 1;
            this.cboArchetype.ValueMember = "archetypeID";
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
            // lblArchetype
            // 
            lblArchetype.AutoSize = true;
            lblArchetype.Location = new System.Drawing.Point(15, 44);
            lblArchetype.Name = "lblArchetype";
            lblArchetype.Size = new System.Drawing.Size(35, 13);
            lblArchetype.TabIndex = 0;
            lblArchetype.Text = "Class:";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new System.Drawing.Point(17, 71);
            lblNote.Name = "lblNote";
            lblNote.Size = new System.Drawing.Size(33, 13);
            lblNote.TabIndex = 0;
            lblNote.Text = "Note:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(56, 121);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // archetypesTableAdapter
            // 
            this.archetypesTableAdapter.ClearBeforeFill = true;
            // 
            // BuildDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cboArchetype);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtName);
            this.Controls.Add(lblNote);
            this.Controls.Add(lblArchetype);
            this.Controls.Add(lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BuildDialog";
            this.Text = "Build Dialog";
            this.Load += new System.EventHandler(this.BuildDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.archetypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtNote;
        public System.Windows.Forms.ComboBox cboArchetype;
        private Model.DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource archetypesBindingSource;
        private Model.DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter;
    }
}
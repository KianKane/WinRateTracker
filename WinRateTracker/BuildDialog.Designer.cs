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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.cb_archetype = new System.Windows.Forms.ComboBox();
            this.archetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DeckTracker.DatabaseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.archetypesTableAdapter = new DeckTracker.DatabaseDataSetTableAdapters.ArchetypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.archetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(56, 15);
            this.tb_name.MaxLength = 50;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(216, 20);
            this.tb_name.TabIndex = 0;
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(56, 68);
            this.tb_note.MaxLength = 200;
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(216, 47);
            this.tb_note.TabIndex = 2;
            // 
            // cb_archetype
            // 
            this.cb_archetype.DataSource = this.archetypesBindingSource;
            this.cb_archetype.DisplayMember = "name";
            this.cb_archetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_archetype.FormattingEnabled = true;
            this.cb_archetype.Location = new System.Drawing.Point(56, 41);
            this.cb_archetype.Name = "cb_archetype";
            this.cb_archetype.Size = new System.Drawing.Size(135, 21);
            this.cb_archetype.TabIndex = 1;
            this.cb_archetype.ValueMember = "archetypeID";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Note:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(56, 121);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(137, 121);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cb_archetype);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.TextBox tb_note;
        public System.Windows.Forms.ComboBox cb_archetype;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource archetypesBindingSource;
        private DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter;
    }
}
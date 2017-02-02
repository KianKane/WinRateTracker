namespace DeckTracker.Dialogs
{
    partial class ArchetypeSetupDialog
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_game = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(207, 84);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(196, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "No, let me set up archetypes manually";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSize = true;
            this.btn_confirm.Location = new System.Drawing.Point(11, 84);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(189, 23);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "Yes, set up archetypes automatically";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Would you like to automatically setup archetypes from one of the following games?" +
    "";
            // 
            // cb_game
            // 
            this.cb_game.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_game.FormattingEnabled = true;
            this.cb_game.Items.AddRange(new object[] {
            "Hearthstone",
            "Duelyst",
            "Gwent",
            "Shadowverse"});
            this.cb_game.Location = new System.Drawing.Point(137, 40);
            this.cb_game.Name = "cb_game";
            this.cb_game.Size = new System.Drawing.Size(196, 21);
            this.cb_game.TabIndex = 2;
            // 
            // ArchetypeSetupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 117);
            this.Controls.Add(this.cb_game);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Name = "ArchetypeSetupDialog";
            this.Text = "First Time Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cb_game;
    }
}
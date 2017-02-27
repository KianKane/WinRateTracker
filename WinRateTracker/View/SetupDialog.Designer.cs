namespace WinRateTracker.View.Dialogs
{
    partial class SetupDialog
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
            System.Windows.Forms.Label lblGame;
            System.Windows.Forms.Label lblMessage;
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cboGame = new System.Windows.Forms.ComboBox();
            lblGame = new System.Windows.Forms.Label();
            lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Location = new System.Drawing.Point(93, 43);
            lblGame.Name = "lblGame";
            lblGame.Size = new System.Drawing.Size(38, 13);
            lblGame.TabIndex = 7;
            lblGame.Text = "Game:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new System.Drawing.Point(8, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(395, 13);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "Would you like to automatically setup archetypes from one of the following games?" +
    "";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(207, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(196, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "No, let me set up archetypes manually";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Location = new System.Drawing.Point(11, 84);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(189, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Yes, set up archetypes automatically";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cboGame
            // 
            this.cboGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGame.FormattingEnabled = true;
            this.cboGame.Location = new System.Drawing.Point(137, 40);
            this.cboGame.Name = "cboGame";
            this.cboGame.Size = new System.Drawing.Size(196, 21);
            this.cboGame.TabIndex = 2;
            // 
            // SetupDialogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 117);
            this.Controls.Add(this.cboGame);
            this.Controls.Add(lblMessage);
            this.Controls.Add(lblGame);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "SetupDialogView";
            this.Text = "First Time Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        public System.Windows.Forms.ComboBox cboGame;
    }
}
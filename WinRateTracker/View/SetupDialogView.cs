﻿using System;
using System.Windows.Forms;

namespace WinRateTracker.View.Dialogs
{
    /// <summary>
    /// A dialog form that allows the user to select a game to initialize archetypes for.
    /// </summary>
    public partial class SetupDialogView : Form
    {
        public SetupDialogView()
        {
            InitializeComponent();
            cboGame.SelectedIndex = 0; // Ensure that an index is selected.
        }

        /// <summary>
        /// Sets the DialogResult to OK.
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Sets the DialogResult to Cancel.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

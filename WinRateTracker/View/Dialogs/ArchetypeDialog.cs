using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinRateTracker.View.Dialogs
{
    /// <summary>
    /// A dialog form used for the creation/modification of archetypes.
    /// </summary>
    public partial class ArchetypeDialog : Form
    {
        public ArchetypeDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the DialogResult to OK if the input is valid.  Otherwise informs the user that the input is invalid.
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Trim excess whitespace.
            txtName.Text = txtName.Text.Trim();
            txtNote.Text = txtNote.Text.Trim();

            // Validate name.
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("You must enter a name for the Archetype", "Invalid Name");
                txtName.Focus();
                return; // Exits the function, preventing the OK dialog result.
            }

            // Finished.
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Sets the DialogResult to Cancel
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

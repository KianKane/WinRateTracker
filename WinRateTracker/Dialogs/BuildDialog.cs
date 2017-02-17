using System;
using System.Windows.Forms;

namespace DeckTracker
{
    /// <summary>
    /// A dialog form used for the creation/modification of builds.
    /// </summary>
    public partial class BuildDialog : Form
    {
        public BuildDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calls fill on the archetypes table adapter to ensure that the archetypes are loaded into the data bound combobox.
        /// </summary>
        private void BuildDialog_Load(object sender, EventArgs e)
        {
            this.archetypesTableAdapter.Fill(this.databaseDataSet.Archetypes);
        }

        /// <summary>
        /// Sets the DialogResult to OK if the Input is valid.  Otherwise informs the user that the input is invalid.
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Trim excess whitespace.
            txtName.Text = txtName.Text.Trim();
            txtNote.Text = txtNote.Text.Trim();

            // Validate name and archetype.
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("You must enter a name for the build", "Invalid Name");
                txtName.Focus();
                return; // Exits the function, preventing the OK dialog result.
            }
            if (cboArchetype.SelectedIndex < 0)
            {
                MessageBox.Show("You must select an archetype for the build", "Invalid Archetype");
                cboArchetype.Focus();
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

using System;
using System.Windows.Forms;
using WinRateTracker.View.Dialogs;

namespace WinRateTracker.View
{
    /// <summary>
    /// This partial class provides functionality to the elements in the edit archetypes tab.
    /// </summary>
    public partial class Home
    {
        /// <summary>
        /// Adds a new archetype.
        /// </summary>
        private void btnAddArchetype_Click(object sender, EventArgs e)
        {
            ArchetypeDialog dialog = new ArchetypeDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                model.InsertArchetype(dialog.txtName.Text, dialog.txtNote.Text);
            }
        }

        /// <summary>
        /// Edits an existing archetype if an archetype is selected.
        /// 
        /// NOTE: Could there be a better way to retrieve the current data?
        /// </summary>
        private void btnEditArchetype_Click(object sender, EventArgs e)
        {
            if (dgvArchetypes.CurrentRow == null)
                return;

            int id = (int)dgvArchetypes.CurrentRow.Cells["idColumnArchetype"].Value;

            ArchetypeDialog dialog = new ArchetypeDialog();
            dialog.txtName.Text = (string)dgvArchetypes.CurrentRow.Cells["nameColumnArchetype"].Value;
            if (!Convert.IsDBNull(dgvArchetypes.CurrentRow.Cells["noteColumnArchetype"].Value))
                dialog.txtNote.Text = (string)dgvArchetypes.CurrentRow.Cells["noteColumnArchetype"].Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                model.UpdateArchetype(id, dialog.txtName.Text, dialog.txtNote.Text);
            }
        }

        /// <summary>
        /// Deletes an existing archetype if an archetype is selected.  Always prompts the user informing them that associated matches and builds will also be deleted.
        /// </summary>
        private void btnDeleteArchetype_Click(object sender, EventArgs e)
        {
            if (dgvArchetypes.CurrentRow == null)
                return;

            if (MessageBox.Show("Deleting this archetype will also delete all associated builds and match information.  Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgvArchetypes.CurrentRow.Cells["idColumnArchetype"].Value;

                model.DeleteArchetype(id);
            }
        }
    }
}

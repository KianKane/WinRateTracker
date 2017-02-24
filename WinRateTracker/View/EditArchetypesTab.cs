using System;
using System.Windows.Forms;
using DeckTracker.View.Dialogs;

namespace DeckTracker.View
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
                archetypesTableAdapter.InsertQuery(dialog.txtName.Text, dialog.txtNote.Text);
                archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                databaseDataSet.AcceptChanges();
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
                archetypesTableAdapter.UpdateQuery(dialog.txtName.Text, dialog.txtNote.Text, id);
                archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                databaseDataSet.AcceptChanges();
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

                archetypesTableAdapter.DeleteQuery(id);
                archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                matchesTableAdapter.Fill(databaseDataSet.Matches);
                databaseDataSet.AcceptChanges();
            }
        }
    }
}

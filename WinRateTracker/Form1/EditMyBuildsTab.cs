using System;
using System.Windows.Forms;

namespace DeckTracker
{
    /// <summary>
    /// This partial class provides functionality to the elements in the edit my builds tab.
    /// </summary>
    public partial class Form1
    {
        /// <summary>
        /// Adds a new build.  If no archetypes exist this will show a message telling the user that they cannot create a build until archetypes exist.
        /// 
        /// NOTE: Could move the user into the edit archetypes tab if no archetypes exist?
        /// </summary>
        private void btnAddBuild_Click(object sender, EventArgs e)
        {
            if (archetypesBindingSource.Count == 0)
            {
                MessageBox.Show("You need to add at least one archetype before you can create a build.");
                return;
            }

            BuildDialog dialog = new BuildDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buildsTableAdapter.InsertQuery(dialog.txtName.Text, dialog.txtNote.Text, (int)dialog.cboArchetype.SelectedValue);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                databaseDataSet.AcceptChanges();
            }
        }

        /// <summary>
        /// Edits an existing build if a build is selected.
        /// 
        /// NOTE: Could there be a better way to retrieve the current data?
        /// </summary>
        private void btnEditBuild_Click(object sender, EventArgs e)
        {
            if (dgvBuilds.CurrentRow == null)
                return;

            int id = (int)dgvBuilds.CurrentRow.Cells["idColumnBuild"].Value;

            BuildDialog dialog = new BuildDialog();
            dialog.txtName.Text = (string)dgvBuilds.CurrentRow.Cells["nameColumnBuild"].Value;
            dialog.cboArchetype.Text = (string)dgvBuilds.CurrentRow.Cells["classColumnBuild"].Value;
            if (!Convert.IsDBNull(dgvBuilds.CurrentRow.Cells["noteColumnBuild"].Value))
                dialog.txtNote.Text = (string)dgvBuilds.CurrentRow.Cells["noteColumnBuild"].Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buildsTableAdapter.UpdateQuery(dialog.txtName.Text, dialog.txtNote.Text, (int)dialog.cboArchetype.SelectedValue, id);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                databaseDataSet.AcceptChanges();
            }
        }

        /// <summary>
        /// Deletes an existing build if a build is selected.  Always prompts the user informing them that associated matches will also be deleted.
        /// </summary>
        private void btnDeleteBuild_Click(object sender, EventArgs e)
        {
            if (dgvBuilds.CurrentRow == null)
                return;

            if (MessageBox.Show("Deleting this build list will also delete all associated match information.  Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgvBuilds.CurrentRow.Cells["idColumnBuild"].Value;

                buildsTableAdapter.DeleteQuery(id);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                matchesTableAdapter.Fill(databaseDataSet.Matches);
                databaseDataSet.AcceptChanges();
            }
        }
    }
}

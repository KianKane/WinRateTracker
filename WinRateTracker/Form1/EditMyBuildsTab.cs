using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckTracker
{
    public partial class Form1
    {
        // Add
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

        // Edit
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

        // Delete
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

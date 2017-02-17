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

        // Edit
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

        // Delete
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

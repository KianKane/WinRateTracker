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
        private void btn_addArchetype_Click(object sender, EventArgs e)
        {
            ArchetypeDialog dialog = new ArchetypeDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                archetypesTableAdapter.InsertQuery(dialog.tb_name.Text, dialog.tb_note.Text);
                archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                databaseDataSet.AcceptChanges();
            }
        }

        // Edit
        private void btn_editArchetype_Click(object sender, EventArgs e)
        {
            if (dgv_archetypes.CurrentRow == null)
                return;

            int id = (int)dgv_archetypes.CurrentRow.Cells["idColumnArchetype"].Value;

            ArchetypeDialog dialog = new ArchetypeDialog();
            dialog.tb_name.Text = (string)dgv_archetypes.CurrentRow.Cells["nameColumnArchetype"].Value;
            if (!Convert.IsDBNull(dgv_archetypes.CurrentRow.Cells["noteColumnArchetype"].Value))
                dialog.tb_note.Text = (string)dgv_archetypes.CurrentRow.Cells["noteColumnArchetype"].Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                archetypesTableAdapter.UpdateQuery(dialog.tb_name.Text, dialog.tb_note.Text, id);
                archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                databaseDataSet.AcceptChanges();
            }
        }

        // Delete
        private void btn_deleteArchetype_Click(object sender, EventArgs e)
        {
            if (dgv_archetypes.CurrentRow == null)
                return;

            if (MessageBox.Show("Deleting this archetype will also delete all associated builds and match information.  Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgv_archetypes.CurrentRow.Cells["idColumnArchetype"].Value;

                archetypesTableAdapter.DeleteQuery(id);
                archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                matchesTableAdapter.Fill(databaseDataSet.Matches);
                databaseDataSet.AcceptChanges();
            }
        }
    }
}

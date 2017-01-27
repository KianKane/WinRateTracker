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
        private void btn_addBuild_Click(object sender, EventArgs e)
        {
            if (archetypesBindingSource.Count == 0)
            {
                MessageBox.Show("You need to add at least one archetype before you can create a build.");
                return;
            }

            BuildDialog dialog = new BuildDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buildsTableAdapter.InsertQuery(dialog.tb_name.Text, dialog.tb_note.Text, (int)dialog.cb_archetype.SelectedValue);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                databaseDataSet.AcceptChanges();
            }
        }

        // Edit
        private void btn_editBuild_Click(object sender, EventArgs e)
        {
            if (dgv_builds.CurrentRow == null)
                return;

            int id = (int)dgv_builds.CurrentRow.Cells["idColumnBuild"].Value;

            BuildDialog dialog = new BuildDialog();
            dialog.tb_name.Text = (string)dgv_builds.CurrentRow.Cells["nameColumnBuild"].Value;
            dialog.cb_archetype.Text = (string)dgv_builds.CurrentRow.Cells["classColumnBuild"].Value;
            if (!Convert.IsDBNull(dgv_builds.CurrentRow.Cells["noteColumnBuild"].Value))
                dialog.tb_note.Text = (string)dgv_builds.CurrentRow.Cells["noteColumnBuild"].Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buildsTableAdapter.UpdateQuery(dialog.tb_name.Text, dialog.tb_note.Text, (int)dialog.cb_archetype.SelectedValue, id);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                databaseDataSet.AcceptChanges();
            }
        }

        // Delete
        private void btn_deleteBuild_Click(object sender, EventArgs e)
        {
            if (dgv_builds.CurrentRow == null)
                return;

            if (MessageBox.Show("Deleting this build list will also delete all associated match information.  Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgv_builds.CurrentRow.Cells["idColumnBuild"].Value;

                buildsTableAdapter.DeleteQuery(id);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                matchesTableAdapter.Fill(databaseDataSet.Matches);
                databaseDataSet.AcceptChanges();
            }
        }
    }
}

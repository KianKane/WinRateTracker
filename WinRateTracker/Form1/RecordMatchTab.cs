using System;
using System.Windows.Forms;

namespace DeckTracker
{
    public partial class Form1
    {
        private void btnVictory_Click(object sender, EventArgs e)
        {
            RecordMatch(true);
        }

        private void btnDefeat_Click(object sender, EventArgs e)
        {
            RecordMatch(false);
        }

        private void RecordMatch(bool victory)
        {
            if (cboBuildTab1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a build", "No Build Selected");
                return;
            }

            if (cboArchetypeTab1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an Archetype", "No Archetype Selected");
                return;
            }

            int build = (int)cboBuildTab1.SelectedValue;
            int archetype = (int)cboArchetypeTab1.SelectedValue;

            if (MessageBox.Show("Are you sure you want to record this result?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                matchesTableAdapter.RecordMatchQuery(build, archetype, victory);
                matchesTableAdapter.Fill(databaseDataSet.Matches);
                databaseDataSet.AcceptChanges();

                UpdateStatistics();
            }
        }
    }
}

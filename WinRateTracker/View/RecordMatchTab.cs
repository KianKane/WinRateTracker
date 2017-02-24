using System;
using System.Windows.Forms;

namespace DeckTracker.View
{
    /// <summary>
    /// This partial class provides functionality to the elements in the record match tab.
    /// </summary>
    public partial class Home
    {
        /// <summary>
        /// Records a victory.
        /// </summary>
        private void btnVictory_Click(object sender, EventArgs e)
        {
            RecordMatch(true);
        }

        /// <summary>
        /// Records a defeat.
        /// </summary>
        private void btnDefeat_Click(object sender, EventArgs e)
        {
            RecordMatch(false);
        }


        /// <summary>
        /// Record the results of a match if valid input is given.  Otherwise informs the user that the provided input is invalid.
        /// 
        /// NOTE: Statistics may not need to be updated until the user navigates to the statistics tab?
        /// NOTE: Confirmation message box could provide the user with the details of the match about to be recorded.
        /// </summary>
        /// <param name="victory">Indicates whether the match to be recorded was a victory or a defeat.</param>
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

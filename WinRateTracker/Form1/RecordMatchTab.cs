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
        private void lnkEditBuildsTab1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(EDIT_MY_BUILDS_TAB_INDEX);
        }

        private void lnkEditArchetypesTab1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(EDIT_ARCHETYPES_TAB_INDEX);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(STATISTICS_TAB_INDEX);
        }

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

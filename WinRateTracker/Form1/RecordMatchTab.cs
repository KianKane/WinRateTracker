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
        private void link_recordMatchToEditBuilds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(EDIT_MY_BUILDS_TAB_INDEX);
        }

        private void link_recordMatchToEditArchetypes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(EDIT_ARCHETYPES_TAB_INDEX);
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(STATISTICS_TAB_INDEX);
        }

        private void btn_victory_Click(object sender, EventArgs e)
        {
            RecordMatch(true);
        }

        private void btn_defeat_Click(object sender, EventArgs e)
        {
            RecordMatch(false);
        }

        private void RecordMatch(bool victory)
        {
            if (cb_matchBuild.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a build", "No Build Selected");
                return;
            }

            if (cb_matchArchetype.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an Archetype", "No Archetype Selected");
                return;
            }

            int build = (int)cb_matchBuild.SelectedValue;
            int archetype = (int)cb_matchArchetype.SelectedValue;

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

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
        private void lnkEditBuildsTab2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(EDIT_MY_BUILDS_TAB_INDEX);
        }

        private void lnkEditArchetypesTab2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(EDIT_ARCHETYPES_TAB_INDEX);
        }

        private void btnRecordMatch_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(RECORD_MATCH_TAB_INDEX);
        }

        private void cboArchetypeTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void cboBuildTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void chkAllBuilds_CheckedChanged(object sender, EventArgs e)
        {
            cboBuildTab2.Enabled = !((CheckBox)sender).Checked;
            UpdateStatistics();
        }

        private void chkAllArchetypes_CheckedChanged(object sender, EventArgs e)
        {
            cboArchetypeTab2.Enabled = !((CheckBox)sender).Checked;
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            if (cboBuildTab2.SelectedIndex < 0 || cboArchetypeTab2.SelectedIndex < 0)
            {
                lblWinsValue.Text = "0";
                lblLossesValue.Text = "0";
                lblWinRateValue.Text = "0.00";
                return;
            }

            int build = (int)cboBuildTab2.SelectedValue;
            int archetype = (int)cboArchetypeTab2.SelectedValue;

            int wins;
            int losses;

            if (chkAllBuilds.Checked && chkAllArchetypes.Checked)
            {
                wins = (int)matchesTableAdapter.CountMatchesAllQuery(true);
                losses = (int)matchesTableAdapter.CountMatchesAllQuery(false);
            }
            else if (chkAllBuilds.Checked && !chkAllArchetypes.Checked)
            {
                wins = (int)matchesTableAdapter.CountMatchesAllBuildsQuery(archetype, true);
                losses = (int)matchesTableAdapter.CountMatchesAllBuildsQuery(archetype, false);
            }
            else if (!chkAllBuilds.Checked && chkAllArchetypes.Checked)
            {
                wins = (int)matchesTableAdapter.CountMatchesAllArchetypesQuery(build, true);
                losses = (int)matchesTableAdapter.CountMatchesAllArchetypesQuery(build, false);
            }
            else
            {
                wins = (int)matchesTableAdapter.CountMatchesQuery(build, archetype, true);
                losses = (int)matchesTableAdapter.CountMatchesQuery(build, archetype, false);
            }

            lblWinsValue.Text = wins.ToString();
            lblLossesValue.Text = losses.ToString();

            lblWinRateValue.Text = ((double)wins / (losses > 0 ? losses : 1)).ToString("F2");
        }
    }
}

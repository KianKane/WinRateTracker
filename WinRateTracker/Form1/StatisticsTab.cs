﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckTracker
{
    public partial class Form1
    {
        private void link_statisticsToEditBuilds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(EDIT_MY_BUILDS_TAB_INDEX);
        }

        private void link_statisticsToEditArchetypes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(EDIT_ARCHETYPES_TAB_INDEX);
        }

        private void btn_recordMatch_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(RECORD_MATCH_TAB_INDEX);
        }

        private void cb_statisticsArchetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void cb_statisticsBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            if (cb_statisticsBuild.SelectedIndex < 0 || cb_statisticsArchetype.SelectedIndex < 0)
            {
                lbl_wins.Text = "0";
                lbl_losses.Text = "0";
                lbl_winRate.Text = "0.00";
                return;
            }

            int build = (int)cb_statisticsBuild.SelectedValue;
            int archetype = (int)cb_statisticsArchetype.SelectedValue;

            int wins = (int)matchesTableAdapter.CountWinsQuery(build, archetype);
            int losses = (int)matchesTableAdapter.CountLossesQuery(build, archetype);

            lbl_wins.Text = wins.ToString();
            lbl_losses.Text = losses.ToString();

            lbl_winRate.Text = ((double)wins / (losses > 0 ? losses : 1)).ToString("F2");
        }
    }
}

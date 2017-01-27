using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.archetypesTableAdapter.Fill(this.databaseDataSet.Archetypes);
            this.buildsTableAdapter.Fill(this.databaseDataSet.Builds);
            this.archetypesTableAdapter.Fill(this.databaseDataSet.Archetypes);
            this.buildsTableAdapter.Fill(this.databaseDataSet.Builds);
            UpdateStatistics();
        }

        // Record Match Results tab -------------------------------------------------------------------------------------------

        private void link_recordMatchToEditBuilds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void link_recordMatchToEditArchetypes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(3);
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
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

        // Statistics tab ----------------------------------------------------------------------------------------------------

        private void link_statisticsToEditBuilds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void link_statisticsToEditArchetypes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(3);
        }

        private void btn_recordMatch_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
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

        // Edit My Builds tab -------------------------------------------------------------------------------------------

        private void btn_addBuild_Click(object sender, EventArgs e)
        {
            BuildDialog dialog = new BuildDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buildsTableAdapter.InsertQuery(dialog.tb_name.Text, dialog.tb_note.Text, (int)dialog.cb_archetype.SelectedValue);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                databaseDataSet.AcceptChanges();
            }
        }

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

        private void btn_deleteBuild_Click(object sender, EventArgs e)
        {
            if (dgv_builds.CurrentRow == null)
                return;

            if (MessageBox.Show("Deleting this build list will also delete all associated match information.  Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgv_builds.CurrentRow.Cells["idColumnBuild"].Value;

                buildsTableAdapter.DeleteQuery(id);
                buildsTableAdapter.Fill(databaseDataSet.Builds);
                databaseDataSet.AcceptChanges();
            }
        }

        // Edit Archetypes tab -------------------------------------------------------------------------------------------

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

        // Update
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
                databaseDataSet.AcceptChanges();
            }
        }
    }
}

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
            this.deckListsTableAdapter.Fill(this.databaseDataSet.DeckLists);
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
            DataRowView deckList = (DataRowView)cb_matchBuild.SelectedItem;
            DataRowView archetype = (DataRowView)cb_matchArchetype.SelectedItem;

            if (deckList == null)
            {
                MessageBox.Show("Please select a Deck List", "No Deck List Selected");
                return;
            }
            if (archetype == null)
            {
                MessageBox.Show("Please select an Archetype", "No Archetype Selected");
                return;
            }

            if (MessageBox.Show("Are you sure you want to record this result?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                matchesTableAdapter.RecordMatchQuery((int)deckList["deckListID"], (int)archetype["archetypeID"], victory);
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
            DataRowView deckList = (DataRowView)cb_statisticsBuild.SelectedItem;
            DataRowView archetype = (DataRowView)cb_statisticsArchetype.SelectedItem;

            if (deckList == null || archetype == null)
            {
                lbl_wins.Text = "0";
                lbl_losses.Text = "0";
                lbl_winRate.Text = "0.00";
                return;
            }

            int wins = (int)matchesTableAdapter.CountWinsQuery((int)deckList["deckListID"], (int)archetype["archetypeID"]);
            int losses = (int)matchesTableAdapter.CountLossesQuery((int)deckList["deckListID"], (int)archetype["archetypeID"]);

            lbl_wins.Text = wins.ToString();
            lbl_losses.Text = losses.ToString();

            lbl_winRate.Text = ((double)wins / (losses > 0 ? losses : 1)).ToString("F2");
        }

        // Edit Deck Lists tab -------------------------------------------------------------------------------------------

        private void btn_addBuild_Click(object sender, EventArgs e)
        {
            DeckListDialog dialog = new DeckListDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                deckListsTableAdapter.InsertQuery(dialog.tb_name.Text, dialog.cb_class.Text, dialog.tb_note.Text);
                deckListsTableAdapter.Fill(databaseDataSet.DeckLists);
                databaseDataSet.AcceptChanges();
            }
        }

        private void btn_editBuild_Click(object sender, EventArgs e)
        {
            if (dgv_builds.CurrentRow == null)
                return;

            int id = (int)dgv_builds.CurrentRow.Cells["idColumnDeckList"].Value;

            DeckListDialog dialog = new DeckListDialog();
            dialog.tb_name.Text = (string)dgv_builds.CurrentRow.Cells["nameColumnDeckList"].Value;
            dialog.cb_class.Text = (string)dgv_builds.CurrentRow.Cells["classColumnDeckList"].Value;
            if (!Convert.IsDBNull(dgv_builds.CurrentRow.Cells["noteColumnDeckList"].Value))
                dialog.tb_note.Text = (string)dgv_builds.CurrentRow.Cells["noteColumnDeckList"].Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                deckListsTableAdapter.UpdateQuery(dialog.tb_name.Text, dialog.cb_class.Text, dialog.tb_note.Text, id);
                deckListsTableAdapter.Fill(databaseDataSet.DeckLists);
                databaseDataSet.AcceptChanges();
            }
        }

        private void btn_deleteBuild_Click(object sender, EventArgs e)
        {
            if (dgv_builds.CurrentRow == null)
                return;

            if (MessageBox.Show("Deleting this deck list will also delete all associated match information.  Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgv_builds.CurrentRow.Cells["idColumnDeckList"].Value;

                deckListsTableAdapter.DeleteQuery(id);
                deckListsTableAdapter.Fill(databaseDataSet.DeckLists);
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
                archetypesTableAdapter.InsertQuery(dialog.tb_name.Text, dialog.cb_class.Text, dialog.tb_note.Text);
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
            dialog.cb_class.Text = (string)dgv_archetypes.CurrentRow.Cells["classColumnArchetype"].Value;
            if (!Convert.IsDBNull(dgv_archetypes.CurrentRow.Cells["noteColumnArchetype"].Value))
                dialog.tb_note.Text = (string)dgv_archetypes.CurrentRow.Cells["noteColumnArchetype"].Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                archetypesTableAdapter.UpdateQuery(dialog.tb_name.Text, dialog.cb_class.Text, dialog.tb_note.Text, id);
                archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                databaseDataSet.AcceptChanges();
            }
        }

        // Delete
        private void btn_deleteArchetype_Click(object sender, EventArgs e)
        {
            if (dgv_archetypes.CurrentRow == null)
                return;

            if (MessageBox.Show("Deleting this archetype will also delete all associated match information.  Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgv_archetypes.CurrentRow.Cells["idColumnArchetype"].Value;

                archetypesTableAdapter.DeleteQuery(id);
                archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                databaseDataSet.AcceptChanges();
            }
        }
    }
}

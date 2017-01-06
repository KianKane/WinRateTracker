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
        }

        // Edit Deck Lists tab -------------------------------------------------------------------------------------------

        private void btn_addDeckList_Click(object sender, EventArgs e)
        {
            DeckListDialog dialog = new DeckListDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                deckListsTableAdapter.InsertQuery(dialog.tb_name.Text, dialog.cb_class.Text, dialog.tb_note.Text);
                deckListsTableAdapter.Fill(databaseDataSet.DeckLists);
                databaseDataSet.AcceptChanges();
            }
        }

        private void btn_editDeckList_Click(object sender, EventArgs e)
        {
            if (dgv_deckLists.CurrentRow == null)
                return;

            int id = (int)dgv_deckLists.CurrentRow.Cells["idColumnDeckList"].Value;

            DeckListDialog dialog = new DeckListDialog();
            dialog.tb_name.Text = (string)dgv_deckLists.CurrentRow.Cells["nameColumnDeckList"].Value;
            dialog.cb_class.Text = (string)dgv_deckLists.CurrentRow.Cells["classColumnDeckList"].Value;
            if (!Convert.IsDBNull(dgv_deckLists.CurrentRow.Cells["noteColumnDeckList"].Value))
                dialog.tb_note.Text = (string)dgv_deckLists.CurrentRow.Cells["noteColumnDeckList"].Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                deckListsTableAdapter.UpdateQuery(dialog.tb_name.Text, dialog.cb_class.Text, dialog.tb_note.Text, id);
                deckListsTableAdapter.Fill(databaseDataSet.DeckLists);
                databaseDataSet.AcceptChanges();
            }
        }

        private void btn_deleteDeckList_Click(object sender, EventArgs e)
        {
            if (dgv_deckLists.CurrentRow == null)
                return;

            int id = (int)dgv_deckLists.CurrentRow.Cells["idColumnDeckList"].Value;

            deckListsTableAdapter.DeleteQuery(id);
            deckListsTableAdapter.Fill(databaseDataSet.DeckLists);
            databaseDataSet.AcceptChanges();
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

            int id = (int)dgv_archetypes.CurrentRow.Cells["idColumnArchetype"].Value;

            archetypesTableAdapter.DeleteQuery(id);
            archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
            databaseDataSet.AcceptChanges();
        }
    }
}

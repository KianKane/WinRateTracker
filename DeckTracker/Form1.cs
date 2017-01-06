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

        private void UpdateDatabase(object sender, EventArgs e)
        {
            this.Validate();
            this.deckListsBindingSource.EndEdit();
            this.archetypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.archetypesTableAdapter.Fill(this.databaseDataSet.Archetypes);
            this.deckListsTableAdapter.Fill(this.databaseDataSet.DeckLists);
        }

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

            int id = (int)dgv_deckLists.CurrentRow.Cells["idColumn"].Value;

            DeckListDialog dialog = new DeckListDialog();
            dialog.tb_name.Text = (string)dgv_deckLists.CurrentRow.Cells["nameColumn"].Value;
            dialog.cb_class.Text = (string)dgv_deckLists.CurrentRow.Cells["classColumn"].Value;
            if (!Convert.IsDBNull(dgv_deckLists.CurrentRow.Cells["noteColumn"].Value))
                dialog.tb_note.Text = (string)dgv_deckLists.CurrentRow.Cells["noteColumn"].Value;

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

            int id = (int)dgv_deckLists.CurrentRow.Cells["idColumn"].Value;

            deckListsTableAdapter.DeleteQuery(id);
            deckListsTableAdapter.Fill(databaseDataSet.DeckLists);
            databaseDataSet.AcceptChanges();
        }
    }
}

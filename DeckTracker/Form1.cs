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
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Archetypes' table. You can move, or remove it, as needed.
            this.archetypesTableAdapter.Fill(this.databaseDataSet.Archetypes);
            // TODO: This line of code loads data into the 'databaseDataSet.DeckLists' table. You can move, or remove it, as needed.
            this.deckListsTableAdapter.Fill(this.databaseDataSet.DeckLists);

        }
    }
}

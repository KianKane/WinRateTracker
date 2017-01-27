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
        private const int RECORD_MATCH_TAB_INDEX = 0;
        private const int STATISTICS_TAB_INDEX = 1;
        private const int EDIT_MY_BUILDS_TAB_INDEX = 2;
        private const int EDIT_ARCHETYPES_TAB_INDEX = 3;

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

            if (archetypesBindingSource.Count == 0)
            {
                if (MessageBox.Show("Would you like to set up classes for Hearthstone?", "Setup Archetypes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    archetypesTableAdapter.InsertQuery("Mage", null);
                    archetypesTableAdapter.InsertQuery("Hunter", null);
                    archetypesTableAdapter.InsertQuery("Paladin", null);
                    archetypesTableAdapter.InsertQuery("Warrior", null);
                    archetypesTableAdapter.InsertQuery("Druid", null);
                    archetypesTableAdapter.InsertQuery("Warlock", null);
                    archetypesTableAdapter.InsertQuery("Shaman", null);
                    archetypesTableAdapter.InsertQuery("Priest", null);
                    archetypesTableAdapter.InsertQuery("Rogue", null);
                    archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                    databaseDataSet.AcceptChanges();
                }
            }

            UpdateStatistics();
        }
    }
}

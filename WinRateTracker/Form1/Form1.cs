using System;
using System.Windows.Forms;
using DeckTracker.Dialogs;
using DeckTracker.GameArchetypes;

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
                ArchetypeSetupDialog dialog = new ArchetypeSetupDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    IArchetypeInitializer archetypeInitializer = null;

                    if (dialog.cboGame.Text.Equals("Hearthstone"))
                        archetypeInitializer = new HearthstoneArchetypeInitializer();
                    else if (dialog.cboGame.Text.Equals("Duelyst"))
                        archetypeInitializer = new DuelystArchetypeInitializer();
                    else if (dialog.cboGame.Text.Equals("Gwent"))
                        archetypeInitializer = new GwentArchetypeInitializer();
                    else if (dialog.cboGame.Text.Equals("Shadowverse"))
                        archetypeInitializer = new ShadowverseArchetypeInitializer();

                    if (archetypeInitializer != null)
                    {
                        archetypeInitializer.InitializeArchetypes(archetypesTableAdapter);
                        archetypesTableAdapter.Fill(databaseDataSet.Archetypes);
                        databaseDataSet.AcceptChanges();
                    }
                }
            }

            UpdateStatistics();
        }
    }
}

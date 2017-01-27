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
            UpdateStatistics();
        }
    }
}

using System;
using System.Windows.Forms;
using WinRateTracker.View.Dialogs;
using WinRateTracker.Presenter;
using System.Data;

namespace WinRateTracker.View
{
    /// <summary>
    /// The primary window for the application.
    /// </summary>
    public partial class Home : Form, IHomeView
    {
        // Events
        public event Action RecordVictory;
        public event Action RecordDefeat;
        public event Action UpdateStatistics;
        public event Action NewBuild;
        public event Action UpdateBuild;
        public event Action DeleteBuild;
        public event Action NewArchetype;
        public event Action UpdateArchetype;
        public event Action DeleteArchetype;

        // Tab indexes
        private const int RECORD_MATCH_TAB = 0;
        private const int STATISTICS_TAB = 1;
        private const int EDIT_BUILDS_TAB = 2;
        private const int EDIT_ARCHETYPES_TAB = 3;

        /// <summary> Constructor. </summary>
        public Home()
        {
            InitializeComponent();
            new HomePresenter(this); // Create controlling presenter
            // Set up data bindings (This is the only time where it is okay for this class to access the model directly)
            buildsBindingSource.DataMember = "Builds";
            buildsBindingSource.DataSource = Model.Model.Instance.GetDataSet().Builds;
            buildsBindingSource.ResetBindings(false);
            archetypesBindingSource.DataMember = "Archetypes";
            archetypesBindingSource.DataSource = Model.Model.Instance.GetDataSet().Archetypes;
            archetypesBindingSource.ResetBindings(false);
            // Set up data grid view column bikndings
            dgvBuilds.Columns[0].Name = "Builds";                   // Build name column
            dgvBuilds.Columns[0].DataPropertyName = "name";
            dgvBuilds.Columns[1].Name = "Builds";                   // Build note column
            dgvBuilds.Columns[1].DataPropertyName = "note";
            dgvBuilds.Columns[2].Name = "Archetypes";               // Build archetype name column (Uses archetypeID as a foreign key to find the name of the archetype)
            ((DataGridViewComboBoxColumn)dgvBuilds.Columns[2]).DataSource = archetypesBindingSource;
            ((DataGridViewComboBoxColumn)dgvBuilds.Columns[2]).DataPropertyName = "archetypeID";
            ((DataGridViewComboBoxColumn)dgvBuilds.Columns[2]).DisplayMember = "name";
            ((DataGridViewComboBoxColumn)dgvBuilds.Columns[2]).ValueMember = "archetypeID";
            dgvArchetypes.Columns[0].Name = "Archetypes";           // Archetype name column
            dgvArchetypes.Columns[0].DataPropertyName = "name";
            dgvArchetypes.Columns[1].Name = "Archetypes";           // Archetype note column
            dgvArchetypes.Columns[1].DataPropertyName = "note";
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string WinRate
        {
            set { lblWinRateValue.Text = value; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string Wins
        {
            set { lblWinsValue.Text = value; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string Losses
        {
            set { lblLossesValue.Text = value; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int? SelectedBuildID
        {
            get
            {
                if (buildsBindingSource.Current == null)
                    return null;
                else
                    return (int)((DataRowView)buildsBindingSource.Current).Row["buildID"];
            }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int? SelectedArchetypeID
        {
            get
            {
                if (archetypesBindingSource.Current == null)
                    return null;
                else
                    return (int)((DataRowView)archetypesBindingSource.Current).Row["archetypeID"];
            }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public bool AllBuilds
        {
            get { return chkAllBuilds.Checked; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public bool AllArchetypes
        {
            get { return chkAllArchetypes.Checked;  }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowSetupDialog()
        {
            SetupDialog dialog = new SetupDialog();
            dialog.ShowDialog();
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowNewBuildDialog()
        {
            BuildDialog dialog = new BuildDialog(false);
            dialog.ShowDialog();
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowUpdateBuildDialog()
        {
            BuildDialog dialog = new BuildDialog(true, (int)SelectedBuildID);
            dialog.ShowDialog();
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowNewArchetypeDialog()
        {
            ArchetypeDialog dialog = new ArchetypeDialog(false);
            dialog.ShowDialog();
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowUpdateArchetypeDialog()
        {
            ArchetypeDialog dialog = new ArchetypeDialog(true, (int)SelectedArchetypeID);
            dialog.ShowDialog();
        }

        /// <summary> Navigates to the record match tab. </summary>
        private void SelectRecordMatchTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(RECORD_MATCH_TAB);
        }

        /// <summary> Navigates to the statistics tab. </summary>
        private void SelectStatisticsTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(STATISTICS_TAB);
        }

        /// <summary> Navigates to the edit builds tab. </summary>
        private void SelectEditBuildsTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(EDIT_BUILDS_TAB);
        }

        /// <summary> Navigates to the edit archetypes tab. </summary>
        private void SelectEditArchetypesTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(EDIT_ARCHETYPES_TAB);
        }

        /// <summary> Request a statistics update when the user navigates to the statistics tab. </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == STATISTICS_TAB)
                UpdateStatistics?.Invoke();
        }

        /// <summary> Executes when the record victory button is clicked. </summary>
        private void btnVictory_Click(object sender, EventArgs e)
        {
            RecordVictory?.Invoke();
        }

        /// <summary> Executes when the record defeat button is clicked. </summary>
        private void btnDefeat_Click(object sender, EventArgs e)
        {
            RecordDefeat?.Invoke();
        }

        /// <summary> Executes when the selected build on the statistic page changes. </summary>
        private void cboBuildTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics?.Invoke();
        }

        /// <summary> Executes when the selected archetype on the statistic page changes. </summary>
        private void cboArchetypeTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics?.Invoke();
        }

        /// <summary> Disables/Enables the build combobox and requests a statistics update. </summary>
        private void chkAllBuilds_CheckedChanged(object sender, EventArgs e)
        {
            cboBuildTab2.Enabled = !((CheckBox)sender).Checked;
            UpdateStatistics?.Invoke();
        }

        /// <summary> Disables/Enables the archetype combobox and requests a statistics update. </summary>
        private void chkAllArchetypes_CheckedChanged(object sender, EventArgs e)
        {
            cboArchetypeTab2.Enabled = !((CheckBox)sender).Checked;
            UpdateStatistics?.Invoke();
        }

        /// <summary> Executes when the add build button is clicked. </summary>
        private void btnAddBuild_Click(object sender, EventArgs e)
        {
            NewBuild?.Invoke();
        }

        /// <summary> Executes when the edit build button is clicked. </summary>
        private void btnEditBuild_Click(object sender, EventArgs e)
        {
            UpdateBuild?.Invoke();
        }

        /// <summary> Executes when the delete build button is clicked. </summary>
        private void btnDeleteBuild_Click(object sender, EventArgs e)
        {
            DeleteBuild?.Invoke();
        }

        /// <summary> Executes when the add archetype button is clicked. </summary>
        private void btnAddArchetype_Click(object sender, EventArgs e)
        {
            NewArchetype?.Invoke();
        }

        /// <summary> Executes when the edit archetype button is clicked. </summary>
        private void btnEditArchetype_Click(object sender, EventArgs e)
        {
            UpdateArchetype?.Invoke();
        }

        /// <summary> Executes when the delete archetype button is clicked. </summary>
        private void btnDeleteArchetype_Click(object sender, EventArgs e)
        {
            DeleteArchetype?.Invoke();
        }
    }
}

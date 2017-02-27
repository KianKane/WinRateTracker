using System;
using System.Windows.Forms;
using WinRateTracker.View.Dialogs;
using WinRateTracker.Model;
using WinRateTracker.Presenter;
using System.Data;

namespace WinRateTracker.View
{
    /// <summary>
    /// The primary window for the application.
    /// This window is split into partial classes for each tab, See "RecordMatchTab.cs", "StatisticsTab.cs", "EditMyBuildsTab.cs", and "EditArchetypesTab.cs".
    /// Shared functionality is stored in this file.
    /// </summary>
    public partial class Home : Form, IHomeView
    {
        private const int RECORD_MATCH_TAB_INDEX = 0;
        private const int STATISTICS_TAB_INDEX = 1;
        private const int EDIT_BUILDS_TAB_INDEX = 2;
        private const int EDIT_ARCHETYPES_TAB_INDEX = 3;

        public event Action RecordVictory;
        public event Action RecordDefeat;
        public event Action UpdateStatistics;
        public event Action NewBuild;
        public event Action UpdateBuild;
        public event Action DeleteBuild;
        public event Action NewArchetype;
        public event Action UpdateArchetype;
        public event Action DeleteArchetype;

        public string WinRate
        {
            set { lblWinRateValue.Text = value; }
        }

        public string Wins
        {
            set { lblWinsValue.Text = value; }
        }

        public string Losses
        {
            set { lblLossesValue.Text = value; }
        }

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

        public bool AllBuilds
        {
            get { return chkAllBuilds.Checked; }
        }

        public bool AllArchetypes
        {
            get { return chkAllArchetypes.Checked;  }
        }

        public void ShowSetupDialog()
        {
            SetupDialogView dialog = new SetupDialogView();
            dialog.ShowDialog();
        }

        public void ShowNewBuildDialog()
        {
            BuildDialog dialog = new BuildDialog(false);
            dialog.ShowDialog();
        }

        public void ShowUpdateBuildDialog()
        {
            BuildDialog dialog = new BuildDialog(true, (int)SelectedBuildID);
            dialog.ShowDialog();
        }

        public void ShowNewArchetypeDialog()
        {
            ArchetypeDialog dialog = new ArchetypeDialog(false);
            dialog.ShowDialog();
        }

        public void ShowUpdateArchetypeDialog()
        {
            ArchetypeDialog dialog = new ArchetypeDialog(true, (int)SelectedArchetypeID);
            dialog.ShowDialog();
        }


        public void Message(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public bool Prompt(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public Home()
        {
            InitializeComponent();

            new HomePresenter(this);

            buildsBindingSource.DataMember = "Builds";
            buildsBindingSource.DataSource = Model.Model.Instance.GetDataSet().Builds;
            buildsBindingSource.ResetBindings(false);
            archetypesBindingSource.DataMember = "Archetypes";
            archetypesBindingSource.DataSource = Model.Model.Instance.GetDataSet().Archetypes;
            archetypesBindingSource.ResetBindings(false);
            dgvBuilds.AutoGenerateColumns = true;
            dgvArchetypes.AutoGenerateColumns = true;
        }

        /// <summary> Navigates to the record match tab. </summary>
        private void SelectRecordMatchTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(RECORD_MATCH_TAB_INDEX);
        }

        /// <summary> Navigates to the statistics tab. </summary>
        private void SelectStatisticsTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(STATISTICS_TAB_INDEX);
        }

        /// <summary> Navigates to the edit builds tab. </summary>
        private void SelectEditBuildsTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(EDIT_BUILDS_TAB_INDEX);
        }

        /// <summary> Navigates to the edit archetypes tab. </summary>
        private void SelectEditArchetypesTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(EDIT_ARCHETYPES_TAB_INDEX);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == STATISTICS_TAB_INDEX)
                UpdateStatistics?.Invoke();
        }

        /// <summary>
        /// Records a victory.
        /// </summary>
        private void btnVictory_Click(object sender, EventArgs e)
        {
            RecordVictory?.Invoke();
        }

        /// <summary>
        /// Records a defeat.
        /// </summary>
        private void btnDefeat_Click(object sender, EventArgs e)
        {
            RecordDefeat?.Invoke();
        }

        private void cboBuildTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics?.Invoke();
        }

        private void cboArchetypeTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics?.Invoke();
        }

        /// <summary>
        /// Disables/Enables the build combobox and updates statistics
        /// </summary>
        private void chkAllBuilds_CheckedChanged(object sender, EventArgs e)
        {
            cboBuildTab2.Enabled = !((CheckBox)sender).Checked;
            UpdateStatistics?.Invoke();
        }

        /// <summary>
        /// Disables/Enables the archetype combobox and updates statistics
        /// </summary>
        private void chkAllArchetypes_CheckedChanged(object sender, EventArgs e)
        {
            cboArchetypeTab2.Enabled = !((CheckBox)sender).Checked;
            UpdateStatistics?.Invoke();
        }

        /// <summary>
        /// Adds a new build.  If no archetypes exist this will show a message telling the user that they cannot create a build until archetypes exist.
        /// 
        /// NOTE: Could move the user into the edit archetypes tab if no archetypes exist?
        /// </summary>
        private void btnAddBuild_Click(object sender, EventArgs e)
        {
            NewBuild?.Invoke();
        }

        /// <summary>
        /// Edits an existing build if a build is selected.
        /// 
        /// NOTE: Could there be a better way to retrieve the current data?
        /// </summary>
        private void btnEditBuild_Click(object sender, EventArgs e)
        {
            UpdateBuild?.Invoke();
        }

        /// <summary>
        /// Deletes an existing build if a build is selected.  Always prompts the user informing them that associated matches will also be deleted.
        /// </summary>
        private void btnDeleteBuild_Click(object sender, EventArgs e)
        {
            DeleteBuild?.Invoke();
        }

        /// <summary>
        /// Adds a new archetype.
        /// </summary>
        private void btnAddArchetype_Click(object sender, EventArgs e)
        {
            NewArchetype?.Invoke();
        }

        /// <summary>
        /// Edits an existing archetype if an archetype is selected.
        /// 
        /// NOTE: Could there be a better way to retrieve the current data?
        /// </summary>
        private void btnEditArchetype_Click(object sender, EventArgs e)
        {
            UpdateArchetype?.Invoke();
        }

        /// <summary>
        /// Deletes an existing archetype if an archetype is selected.  Always prompts the user informing them that associated matches and builds will also be deleted.
        /// </summary>
        private void btnDeleteArchetype_Click(object sender, EventArgs e)
        {
            DeleteArchetype?.Invoke();
        }
    }
}

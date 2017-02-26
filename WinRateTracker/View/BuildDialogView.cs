using System;
using System.Windows.Forms;
using WinRateTracker.Model;
using WinRateTracker.Presenter;

namespace WinRateTracker.View.Dialogs
{
    /// <summary>
    /// A dialog form used for the creation/modification of builds.
    /// </summary>
    public partial class BuildDialogView : Form, INewBuildView, IUpdateBuildView
    {
        public event Action InsertBuild;
        public event Action UpdateBuild;

        public void CloseDialog()
        {
            this.DialogResult = DialogResult.OK;
        }

        public int BuildID
        {
            get { return buildID; }
        }

        public string BuildName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string BuildNote
        {
            get { return txtNote.Text; }
            set { txtNote.Text = value; }
        }

        public string ArchetypeName
        {
            set { cboArchetype.Text = value; }
        }

        public int ArchetypeID
        {
            get { return (int)cboArchetype.SelectedValue; }
        }

        public void Message(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public bool Prompt(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private bool editing;
        private int buildID;

        public BuildDialogView(bool editing, int buildID = -1)
        {
            InitializeComponent();
            this.editing = editing;
            this.buildID = buildID;
            archetypesBindingSource.DataMember = "Archetypes";
            archetypesBindingSource.DataSource = Model.Model.Instance.GetDataSet().Archetypes;
            archetypesBindingSource.ResetBindings(false);
            if (editing)
            {
                cboArchetype.Enabled = false;
                new UpdateBuildPresenter(this);
            }
            else
            {
                new NewBuildPresenter(this);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (editing)
                UpdateBuild?.Invoke();
            else
                InsertBuild?.Invoke();
        }

        /// <summary>
        /// Sets the DialogResult to Cancel
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

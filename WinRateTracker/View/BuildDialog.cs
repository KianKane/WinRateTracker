using System;
using System.Windows.Forms;
using WinRateTracker.Presenter;

namespace WinRateTracker.View.Dialogs
{
    /// <summary>
    /// A dialog form used for the creation/modification of builds.
    /// This dialog can act as both a new build view and an update build view.
    /// </summary>
    public partial class BuildDialog : Form, INewBuildView, IUpdateBuildView
    {
        public event Action Confirm;
        public event Action Cancel;

        private bool editing; // If this variable is TRUE then this is an update build dialog, otherwise it is a new build dialog.
        private int buildID; // The ID of the build being modified by this dialog. (Unused if this dialog is in new build mode)

        /// <summary> Constructor. </summary>
        /// <param name="editing"> If this variable is TRUE then this is an update build dialog, otherwise it is a new build dialog. </param>
        /// <param name="buildID"> The ID of the build being modified by this dialog. (Unused if this dialog is in new build mode) </param>
        public BuildDialog(bool editing, int buildID = -1)
        {
            InitializeComponent();
            this.editing = editing;
            this.buildID = buildID;
            if (editing)
            {
                cboArchetype.Enabled = false; // Disable the archetype selection combobox in edit mode as it cannot be modified
                new UpdateBuildPresenter(this); // Create controlling presenter
            }
            else
            {
                // Set up data bindings (This is the only time where it is okay for this class to access the model directly)
                archetypesBindingSource.DataMember = "Archetypes";
                archetypesBindingSource.DataSource = Model.Model.Instance.GetDataSet().Archetypes;
                cboArchetype.DataSource = archetypesBindingSource;
                cboArchetype.DisplayMember = "name";
                archetypesBindingSource.ResetBindings(false);
                new NewBuildPresenter(this); // Create controlling presenter
            }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int BuildID
        {
            get { return buildID; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string BuildName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string BuildNote
        {
            get { return txtNote.Text; }
            set { txtNote.Text = value; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string ArchetypeName
        {
            set
            {
                cboArchetype.Items.Add(value);
                cboArchetype.Text = value;
            }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int ArchetypeID
        {
            get { return (int)cboArchetype.SelectedValue; }
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void CloseDialog()
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary> Executes when the confirm button is clicked. </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Confirm?.Invoke();
        }

        /// <summary> Executes when the cancel button is clicked. </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }
    }
}

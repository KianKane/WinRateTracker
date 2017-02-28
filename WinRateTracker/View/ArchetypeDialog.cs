using System;
using System.Windows.Forms;
using WinRateTracker.Presenter;

namespace WinRateTracker.View.Dialogs
{
    /// <summary>
    /// A dialog form used for the creation/modification of archetypes.
    /// This dialog can act as both a new archetype view and an update archetype view.
    /// </summary>
    public partial class ArchetypeDialog : Form, INewArchetypeView, IUpdateArchetypeView
    {
        public event Action Confirm;
        public event Action Cancel;

        private bool editing; // If this variable is TRUE then this is an update archetype dialog, otherwise it is a new archetype dialog.
        private int archetypeID; // The ID of the archetype being modified by this dialog. (Unused if this dialog is in new archetype mode)

        /// <summary> Constructor. </summary>
        /// <param name="editing"> If this variable is TRUE then this is an update archetype dialog, otherwise it is a new archetype dialog. </param>
        /// <param name="archetypeID"> The ID of the archetype being modified by this dialog. (Unused if this dialog is in new archetype mode) </param>
        public ArchetypeDialog(bool editing, int archetypeID = -1)
        {
            InitializeComponent();
            this.editing = editing;
            this.archetypeID = archetypeID;
            if (editing)
                new UpdateArchetypePresenter(this); // Create controlling presenter
            else
                new NewArchetypePresenter(this); // Create controlling presenter
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int ArchetypeID
        {
            get { return archetypeID; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string ArchetypeName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string ArchetypeNote
        {
            get { return txtNote.Text; }
            set { txtNote.Text = value; }
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void CloseDialog()
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void Message(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public bool Prompt(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo) == DialogResult.Yes;
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

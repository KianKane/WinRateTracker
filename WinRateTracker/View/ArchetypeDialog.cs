using System;
using System.Windows.Forms;
using WinRateTracker.Model;
using WinRateTracker.Presenter;

namespace WinRateTracker.View.Dialogs
{
    /// <summary>
    /// A dialog form used for the creation/modification of archetypes.
    /// </summary>
    public partial class ArchetypeDialog : Form, INewArchetypeView, IUpdateArchetypeView
    {
        public event Action InsertArchetype;
        public event Action UpdateArchetype;

        public void CloseDialog()
        {
            this.DialogResult = DialogResult.OK;
        }

        public int ArchetypeID
        {
            get { return archetypeID; }
        }

        public string ArchetypeName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string ArchetypeNote
        {
            get { return txtNote.Text; }
            set { txtNote.Text = value; }
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
        private int archetypeID;

        public ArchetypeDialog(bool editing, int archetypeID = -1)
        {
            InitializeComponent();
            this.editing = editing;
            this.archetypeID = archetypeID;
            if (editing)
                new UpdateArchetypePresenter(this);
            else
                new NewArchetypePresenter(this);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (editing)
                UpdateArchetype?.Invoke();
            else
                InsertArchetype?.Invoke();
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

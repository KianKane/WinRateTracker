using System;
using System.Windows.Forms;
using WinRateTracker.Presenter;

namespace WinRateTracker.View.Dialogs
{
    /// <summary>
    /// A dialog form that allows the user to select a game to initialize archetypes for.
    /// </summary>
    public partial class SetupDialogView : Form, ISetupDialogView
    {
        public event Action SetupArchetypes;
        
        public string[] GameOptions
        {
            set
            {
                foreach (string game in value)
                {
                    cboGame.Items.Add(game);
                    cboGame.SelectedIndex = 0;
                }
            }
        }
        
        public int SelectedGame
        {
            get { return cboGame.SelectedIndex; }
        }

        public void CloseDialog()
        {
            this.DialogResult = DialogResult.OK;
        }

        public void Message(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public bool Prompt(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public SetupDialogView()
        {
            InitializeComponent();
            new SetupPresenter(this);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SetupArchetypes?.Invoke();
        }

        /// <summary>
        /// Sets the DialogResult to Cancel.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

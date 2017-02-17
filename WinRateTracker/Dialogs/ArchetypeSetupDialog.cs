using System;
using System.Windows.Forms;

namespace DeckTracker.Dialogs
{
    public partial class ArchetypeSetupDialog : Form
    {
        public ArchetypeSetupDialog()
        {
            InitializeComponent();
            cboGame.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

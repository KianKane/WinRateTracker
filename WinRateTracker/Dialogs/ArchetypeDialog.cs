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
    public partial class ArchetypeDialog : Form
    {
        public ArchetypeDialog()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Trim
            txtName.Text = txtName.Text.Trim();
            txtNote.Text = txtNote.Text.Trim();

            // Validate
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("You must enter a name for the Archetype", "Invalid Name");
                txtName.Focus();
                return; // Exits the function, preventing the OK dialog result
            }

            // OK
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

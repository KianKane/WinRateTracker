﻿using System;
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
    public partial class BuildDialog : Form
    {
        public BuildDialog()
        {
            InitializeComponent();
        }

        private void BuildDialog_Load(object sender, EventArgs e)
        {
            this.archetypesTableAdapter.Fill(this.databaseDataSet.Archetypes);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            // Trim
            tb_name.Text = tb_name.Text.Trim();
            tb_note.Text = tb_note.Text.Trim();

            // Validate
            if (tb_name.Text.Equals(""))
            {
                MessageBox.Show("You must enter a name for the build", "Invalid Name");
                tb_name.Focus();
                return; // Exits the function, preventing the OK dialog result
            }
            if (cb_archetype.SelectedIndex < 0)
            {
                MessageBox.Show("You must select an archetype for the build", "Invalid Archetype");
                cb_archetype.Focus();
                return; // Exits the function, preventing the OK dialog result
            }

            // OK
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

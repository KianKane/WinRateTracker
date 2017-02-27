﻿using System;
using System.Windows.Forms;
using WinRateTracker.Presenter;

namespace WinRateTracker.View.Dialogs
{
    /// <summary>
    /// A dialog form that allows the user to select a game to initialize archetypes for.
    /// </summary>
    public partial class SetupDialog : Form, ISetupDialogView
    {
        public event Action SetupArchetypes;

        /// <summary> Constructor. </summary>
        public SetupDialog()
        {
            InitializeComponent();
            new SetupPresenter(this); // Create controlling presenter
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string[] GameOptions
        {
            set
            {
                foreach (string game in value)
                {
                    cboGame.Items.Add(game);
                    cboGame.SelectedIndex = 0; // By default select the first game in the array
                }
            }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int SelectedGame
        {
            get { return cboGame.SelectedIndex; }
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
            SetupArchetypes?.Invoke();
        }

        /// <summary> Executes when the cancel button is clicked. </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

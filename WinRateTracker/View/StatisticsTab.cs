using System;
using System.Windows.Forms;

namespace WinRateTracker.View
{
    /// <summary>
    /// This partial class provides functionality to the elements in the statistics tab.
    /// </summary>
    public partial class Home
    {
        /// <summary>
        /// Updates statistics whenever the selected archetype changes.
        /// 
        /// NOTE: Could combine with the build updated method.
        /// </summary>
        private void cboArchetypeTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        /// <summary>
        /// Updates statistics whenever the selected build changes.
        /// 
        /// NOTE: Could combine with the archetype updated method.
        /// </summary>
        private void cboBuildTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        /// <summary>
        /// Disables/Enables the build combobox and updates statistics
        /// </summary>
        private void chkAllBuilds_CheckedChanged(object sender, EventArgs e)
        {
            cboBuildTab2.Enabled = !((CheckBox)sender).Checked;
            UpdateStatistics();
        }

        /// <summary>
        /// Disables/Enables the archetype combobox and updates statistics
        /// </summary>
        private void chkAllArchetypes_CheckedChanged(object sender, EventArgs e)
        {
            cboArchetypeTab2.Enabled = !((CheckBox)sender).Checked;
            UpdateStatistics();
        }

        /// <summary>
        /// Updates statistics based on the selected build and archetype.
        /// 
        /// NOTE: Could show a message when one of the comboboxes has no value selected?
        /// NOTE: Could be a better way to call different queries when one or both of the "All____" checkboxes are selected?  Switch block maybe?
        /// </summary>
        private void UpdateStatistics()
        {
            if (cboBuildTab2.SelectedIndex < 0 || cboArchetypeTab2.SelectedIndex < 0)
            {
                lblWinsValue.Text = "0";
                lblLossesValue.Text = "0";
                lblWinRateValue.Text = "0.00";
                return;
            }

            int? build = (int)cboBuildTab2.SelectedValue;
            int? archetype = (int)cboArchetypeTab2.SelectedValue;

            int wins;
            int losses;

            if (!chkAllBuilds.Checked)
                build = null;
            if (!chkAllArchetypes.Checked)
                archetype = null;

            wins = model.CountMatches(build, archetype, true);
            losses = model.CountMatches(build, archetype, false);

            lblWinsValue.Text = wins.ToString();
            lblLossesValue.Text = losses.ToString();

            lblWinRateValue.Text = ((double)wins / (losses > 0 ? losses : 1)).ToString("F2");
        }
    }
}

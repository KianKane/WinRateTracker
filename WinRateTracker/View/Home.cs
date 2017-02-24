﻿using System;
using System.Windows.Forms;
using WinRateTracker.View.Dialogs;
using WinRateTracker.Presenter.GameArchetypes;
using WinRateTracker.Model;

namespace WinRateTracker.View
{
    /// <summary>
    /// The primary window for the application.
    /// This window is split into partial classes for each tab, See "RecordMatchTab.cs", "StatisticsTab.cs", "EditMyBuildsTab.cs", and "EditArchetypesTab.cs".
    /// Shared functionality is stored in this file.
    /// </summary>
    public partial class Home : Form
    {
        private IModel model;
        private const int RECORD_MATCH_TAB_INDEX = 0;
        private const int STATISTICS_TAB_INDEX = 1;
        private const int EDIT_BUILDS_TAB_INDEX = 2;
        private const int EDIT_ARCHETYPES_TAB_INDEX = 3;

        public Home(IModel model)
        {
            this.model = model;

            InitializeComponent();

            buildsBindingSource.DataMember = "Builds";
            buildsBindingSource.DataSource = model.GetDataSet();
            buildsBindingSource.ResetBindings(false);

            archetypesBindingSource.DataMember = "Archetypes";
            archetypesBindingSource.DataSource = model.GetDataSet();
            archetypesBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Application initialization goes in here.
        /// This method fills the table adapters.
        /// When there is no existing archetypes this method promps the user with the ArchetypeSetupDialog to allow them to auto-initialize archetypes for a certain game.
        /// Statistics are updated in this method.
        /// 
        /// TODO: Figure out why this method fills the archetypesTableAdapter and the buildsTableAdapter twice.
        /// NOTE: Could move update statistics out of this method and only call it when the statistics tab is navigated to?
        /// NOTE: Could find another way to identify the archetype initializer?  Archetype initializer dialog could rpovide an initializer?  String comparason here seems wrong.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        /// <summary>
        /// Navigates to the record match tab.
        /// </summary>
        private void SelectRecordMatchTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(RECORD_MATCH_TAB_INDEX);
        }

        /// <summary>
        /// Navigates to the statistics tab.
        /// 
        /// NOTE: Could update statistics here instead of on form load?
        /// </summary>
        private void SelectStatisticsTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(STATISTICS_TAB_INDEX);
        }

        /// <summary>
        /// Navigates to the edit builds tab.
        /// </summary>
        private void SelectEditBuildsTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(EDIT_BUILDS_TAB_INDEX);
        }

        /// <summary>
        /// Navigates to the edit archetypes tab.
        /// </summary>
        private void SelectEditArchetypesTab(object sender, EventArgs e)
        {
            tabControl.SelectTab(EDIT_ARCHETYPES_TAB_INDEX);
        }
    }
}

using System;
using WinRateTracker.View;

namespace WinRateTrackerTests.TestDoubles
{
    /// <summary>
    /// This class acts as a mock for the Home form.
    /// </summary>
    class HomeMock : IHomeView
    {
        // Events
        public event Action RecordVictory;
        public event Action RecordDefeat;
        public event Action UpdateStatistics;
        public event Action NewBuild;
        public event Action UpdateBuild;
        public event Action DeleteBuild;
        public event Action NewArchetype;
        public event Action UpdateArchetype;
        public event Action DeleteArchetype;

        private string winRate;
        private string wins;
        private string losses;
        private int? selectedBuildID;
        private int? selectedArchetypeID;
        private bool allBuilds;
        private bool allArchetypes;
        private bool setupDialogShown;
        private bool newBuildDialogShown;
        private bool updateBuildDialogShown;
        private bool newArchetypeDialogShown; 
        private bool updateArchetypeDialogShown;

        /// <summary> Constructor. </summary>
        public HomeMock()
        {
            // Set up initial values
            winRate = string.Empty;
            wins = string.Empty;
            losses = string.Empty;
            selectedBuildID = null;
            selectedArchetypeID = null;
            allBuilds = false;
            allArchetypes = false;
            setupDialogShown = false;
            newBuildDialogShown = false;
            updateBuildDialogShown = false;
            newArchetypeDialogShown = false;
            updateArchetypeDialogShown = false;
    }

        /// <summary> Used by testing classes to check if the setup dialog would have been shown by the view. </summary>
        public bool SetupDialogShown
        {
            get { return setupDialogShown; }
        }

        /// <summary> Used by testing classes to check if the new build dialog would have been shown by the view. </summary>
        public bool NewBuildDialogShown
        {
            get { return newBuildDialogShown; }
        }

        /// <summary> Used by testing classes to check if the update build dialog would have been shown by the view. </summary>
        public bool UpdateBuildDialogShown
        {
            get { return updateBuildDialogShown; }
        }

        /// <summary> Used by testing classes to check if the new archetype dialog would have been shown by the view. </summary>
        public bool NewArchetypeDialogShown
        {
            get { return newArchetypeDialogShown; }
        }

        /// <summary> Used by testing classes to check if the update archetype dialog would have been shown by the view. </summary>
        public bool UpdateArchetypeDialogShown
        {
            get { return updateArchetypeDialogShown; }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string WinRate
        {
            set { winRate = value; }
            get { return winRate; } // Getter used for testing purposes, it is not required by the interface and only exists in this mock.
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string Wins
        {
            set { wins = value; }
            get { return wins; } // Getter used for testing purposes, it is not required by the interface and only exists in this mock.
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string Losses
        {
            set { losses = value; }
            get { return losses; } // Getter used for testing purposes, it is not required by the interface and only exists in this mock.
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int? SelectedBuildID
        {
            get { return selectedBuildID; }
            set { selectedBuildID = value; } // Setter used for testing purposes, it is not required by the interface and only exists in this mock.
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int? SelectedArchetypeID
        {
            get { return selectedArchetypeID; }
            set { selectedArchetypeID = value; } // Setter used for testing purposes, it is not required by the interface and only exists in this mock.
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public bool AllBuilds
        {
            get { return allBuilds; }
            set { allBuilds = value; } // Setter used for testing purposes, it is not required by the interface and only exists in this mock.
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public bool AllArchetypes
        {
            get { return allArchetypes; }
            set { allArchetypes = value; } // Setter used for testing purposes, it is not required by the interface and only exists in this mock.
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowSetupDialog()
        {
            setupDialogShown = true;
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowNewBuildDialog()
        {
            newBuildDialogShown = true;
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowUpdateBuildDialog()
        {
            updateBuildDialogShown = true;
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowNewArchetypeDialog()
        {
            newArchetypeDialogShown = true;
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowUpdateArchetypeDialog()
        {
            updateArchetypeDialogShown = true;
        }

        /// <summary> Used by testing classes to invoke the RecordVictory event. </summary>
        public void RecordVictory_Invoke()
        {
            RecordVictory?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the RecordDefeat event. </summary>
        public void RecordDefeat_Invoke()
        {
            RecordDefeat?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the UpdateStatistics event. </summary>
        public void UpdateStatistics_Invoke()
        {
            UpdateStatistics?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the NewBuild event. </summary>
        public void NewBuild_Invoke()
        {
            NewBuild?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the UpdateBuild event. </summary>
        public void UpdateBuild_Invoke()
        {
            UpdateBuild?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the DeleteBuild event. </summary>
        public void DeleteBuild_Invoke()
        {
            DeleteBuild?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the NewArchetype event. </summary>
        public void NewArchetype_Invoke()
        {
            NewArchetype?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the UpdateArchetype event. </summary>
        public void UpdateArchetype_Invoke()
        {
            UpdateArchetype?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the DeleteArchetype event. </summary>
        public void DeleteArchetype_Invoke()
        {
            DeleteArchetype?.Invoke();
        }
    }
}

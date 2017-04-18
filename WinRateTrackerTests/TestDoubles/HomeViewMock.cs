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

        /// <summary> Constructor. </summary>
        public HomeMock()
        {
            // Set up initial values
            WinRate = string.Empty;
            Wins = string.Empty;
            Losses = string.Empty;
            SelectedBuildID = null;
            SelectedArchetypeID = null;
            AllBuilds = false;
            AllArchetypes = false;
            SetupDialogShown = false;
            NewBuildDialogShown = false;
            UpdateBuildDialogShown = false;
            NewArchetypeDialogShown = false;
            UpdateArchetypeDialogShown = false;
        }

        /// <summary> Used by testing classes to check if the setup dialog would have been shown by the view. </summary>
        public bool SetupDialogShown { get; private set; }

        /// <summary> Used by testing classes to check if the new build dialog would have been shown by the view. </summary>
        public bool NewBuildDialogShown { get; private set; }

        /// <summary> Used by testing classes to check if the update build dialog would have been shown by the view. </summary>
        public bool UpdateBuildDialogShown { get; private set; }

        /// <summary> Used by testing classes to check if the new archetype dialog would have been shown by the view. </summary>
        public bool NewArchetypeDialogShown { get; private set; }

        /// <summary> Used by testing classes to check if the update archetype dialog would have been shown by the view. </summary>
        public bool UpdateArchetypeDialogShown { get; private set; }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string WinRate { get; set; } // Getter used for testing purposes, it is not required by the interface and only exists in this mock.

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string Wins { get; set; } // Getter used for testing purposes, it is not required by the interface and only exists in this mock.

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string Losses { get; set; } // Getter used for testing purposes, it is not required by the interface and only exists in this mock.

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int? SelectedBuildID { get; set; } // Setter used for testing purposes, it is not required by the interface and only exists in this mock.

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int? SelectedArchetypeID { get; set; } // Setter used for testing purposes, it is not required by the interface and only exists in this mock.

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public bool AllBuilds { get; set; } // Setter used for testing purposes, it is not required by the interface and only exists in this mock.

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public bool AllArchetypes { get; set; } // Setter used for testing purposes, it is not required by the interface and only exists in this mock.

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowSetupDialog()
        {
            SetupDialogShown = true;
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowNewBuildDialog()
        {
            NewBuildDialogShown = true;
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowUpdateBuildDialog()
        {
            UpdateBuildDialogShown = true;
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowNewArchetypeDialog()
        {
            NewArchetypeDialogShown = true;
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public void ShowUpdateArchetypeDialog()
        {
            UpdateArchetypeDialogShown = true;
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
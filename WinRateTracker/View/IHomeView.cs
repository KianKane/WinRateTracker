using System;

namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines the outward facing interaction contract for the application home page.
    /// </summary>
    interface IHomeView : IView
    {
        /// <summary> This event fires when the user wants to record a victory. </summary>
        event Action RecordVictory;

        /// <summary> This event fires when the user wants to record a defeat. </summary>
        event Action RecordDefeat;

        /// <summary> This event fires when the statistics should be recalculated. </summary>
        event Action UpdateStatistics;

        /// <summary> This event fires when the user wants to create a new build. </summary>
        event Action NewBuild;

        /// <summary> This event fires when the user wants to modify a build. </summary>
        event Action UpdateBuild;

        /// <summary> This event fires when the user wants to delete a build. </summary>
        event Action DeleteBuild;

        /// <summary> This event fires when the user wants to create a new archetype. </summary>
        event Action NewArchetype;

        /// <summary> This event fires when the user wants to modify an archetype. </summary>
        event Action UpdateArchetype;

        /// <summary> This event fires when the user wants to delete an archetype. </summary>
        event Action DeleteArchetype;

        /// <summary> Used to set the win rate display text. </summary>
        string WinRate { set; }

        /// <summary> Used to set the win count display text. </summary>
        string Wins { set; }

        /// <summary> Used to set the loss count display text. </summary>
        string Losses { set; }

        /// <summary> The ID of the selected build. (NULL = No build currently selected) </summary>
        int? SelectedBuildID { get; }

        /// <summary> The ID of the selected archetype. (NULL = No archetype currently selected) </summary>
        int? SelectedArchetypeID { get; }

        /// <summary> The checked state of the all builds checkbox. </summary>
        bool AllBuilds { get; }

        /// <summary> The checked state of the all archetypes checkbox. </summary>
        bool AllArchetypes { get; }

        /// <summary> This method should create and show the archetype setup dialog. </summary>
        void ShowSetupDialog();

        /// <summary> This method should create and show the new build dialog. </summary>
        void ShowNewBuildDialog();

        /// <summary> This method should create and show the update build dialog. </summary>
        void ShowUpdateBuildDialog();

        /// <summary> This method should create and show the new archetype dialog. </summary>
        void ShowNewArchetypeDialog();

        /// <summary> This method should create and show the update archetype dialog. </summary>
        void ShowUpdateArchetypeDialog();

    }
}

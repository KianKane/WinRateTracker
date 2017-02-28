using System;

namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines the outward facing interaction contract for the update build dialog view.
    /// </summary>
    public interface IUpdateBuildView : IDialogView
    {
        /// <summary> This event fires when the user wants to update the build. </summary>
        event Action UpdateBuild;

        /// <summary> Used to get the modified build name and set the build name display text to the initial value. </summary>
        string BuildName { get; set; }

        /// <summary> Used to get the modified build note and set the build note display text to the initial value. </summary>
        string BuildNote { get; set; }

        /// <summary> Used to set the name of the attached archetype display text to the initial value. </summary>
        string ArchetypeName { set; }

        /// <summary> Used to get the ID of the build to be modified. </summary>
        int BuildID { get; }
    }
}

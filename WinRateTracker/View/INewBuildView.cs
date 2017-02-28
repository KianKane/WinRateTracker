using System;

namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines the outward facing interaction contract for the new build dialog view.
    /// </summary>
    public interface INewBuildView : IDialogView
    {
        /// <summary> Used to get the new build name. </summary>
        string BuildName { get; }

        /// <summary> Used to get the new build name. </summary>
        string BuildNote { get; }

        /// <summary> Used to get the ID of the archetype attatched to the new build. </summary>
        int ArchetypeID { get; }
    }
}

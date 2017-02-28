using System;

namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines the outward facing interaction contract for the new archetype dialog view.
    /// </summary>
    public interface INewArchetypeView : IDialogView
    {
        /// <summary> Used to get the new archetype name. </summary>
        string ArchetypeName { get; }

        /// <summary> Used to get the new archetype note </summary>
        string ArchetypeNote { get; }
    }
}

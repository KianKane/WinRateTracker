using System;

namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines the outward facing interaction contract for the new archetype dialog view.
    /// </summary>
    interface INewArchetypeView : IDialogView
    {
        /// <summary> This event fires when the user wants to insert the archetype. </summary>
        event Action InsertArchetype;

        /// <summary> Used to get the new archetype name. </summary>
        string ArchetypeName { get; }

        /// <summary> Used to get the new archetype note </summary>
        string ArchetypeNote { get; }
    }
}

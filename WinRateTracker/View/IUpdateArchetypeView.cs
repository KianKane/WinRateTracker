using System;

namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines the outward facing interaction contract for the update archetype dialog view.
    /// </summary>
    public interface IUpdateArchetypeView : IDialogView
    {
        /// <summary> This event fires when the user wants to update the archetype. </summary>
        event Action UpdateArchetype;

        /// <summary> Used to get the ID of the archetype to be modified. </summary>
        int ArchetypeID { get; }

        /// <summary> Used to get the modified archetype name and set the archetype name display text to the initial value. </summary>
        string ArchetypeName { get; set; }

        /// <summary> Used to get the modified archetype note and set the archetype note display text to the initial value. </summary>
        string ArchetypeNote { get; set; }
    }
}

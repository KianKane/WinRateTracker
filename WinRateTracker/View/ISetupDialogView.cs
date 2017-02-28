using System;

namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines the outward facing interaction contract for the initial archetype setup dialog view.
    /// </summary>
    public interface ISetupDialogView : IDialogView
    {
        /// <summary> This event fires when the user wants to set up archetypes. </summary>
        event Action SetupArchetypes;

        /// <summary> Used to set the avaliable game options for the user to choose from. </summary>
        string[] GameOptions { set; }

        /// <summary> Used to get the selected game index. </summary>
        int SelectedGame { get; }
    }
}

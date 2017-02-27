using System;

namespace WinRateTracker.View
{
    interface ISetupDialogView : IDialogView
    {
        event Action SetupArchetypes;
        string[] GameOptions { set; }
        int SelectedGame { get; }
    }
}

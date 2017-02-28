using System;

namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines a close dialog function that all dialog views must implement.
    /// </summary>
    public interface IDialogView : IView
    {
        /// <summary> This event fires when the user clicks the confirm button on the dialog. </summary>
        event Action Confirm;

        /// <summary> This event fires when the user clicks the cancel button on the dialog. </summary>
        event Action Cancel;

        /// <summary> Close the dialog with an OK result. </summary>
        void CloseDialog();
    }
}

namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines a close dialog function that all dialog views must implement.
    /// </summary>
    public interface IDialogView : IView
    {
        /// <summary> Close the dialog with an OK result. </summary>
        void CloseDialog();
    }
}

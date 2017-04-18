using System;
using WinRateTracker.View;

namespace WinRateTrackerTests.TestDoubles
{
    /// <summary>
    /// This class acts as a mock for the SetupDialog form.
    /// </summary>
    class SetupDialogMock : ISetupDialogView
    {
        public event Action Confirm;
        public event Action Cancel;

        /// <summary> Constructor. </summary>
        public SetupDialogMock()
        {
            SelectedGame = 0;
            GameOptions = null;
            Closed = false;
        }

        /// <summary> Auto-generated property used to indicate whether the mock form is closed or not. </summary>
        public bool Closed { get; private set; }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string[] GameOptions { get; set; } // Getter used for testing purposes, it is not requred by the interface and only exists in this mock.

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int SelectedGame { get; set; } // Setter used for testing purposes, it is not required by the interface and only exists in this mock.

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void CloseDialog()
        {
            Closed = true;
        }

        /// <summary> Used by testing classes to invoke the Confirm event. </summary>
        public void Confirm_Invoke()
        {
            Confirm?.Invoke();
        }

        /// <summary> Used by testing classes to invoke the Cancel event. </summary>
        public void Cancel_Invoke()
        {
            Cancel?.Invoke();
        }
    }
}

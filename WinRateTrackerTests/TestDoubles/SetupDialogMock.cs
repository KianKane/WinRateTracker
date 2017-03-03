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

        private int selectedGame;
        private string[] gameOptions;

        /// <summary> Constructor. </summary>
        public SetupDialogMock()
        {
            selectedGame = 0;
            gameOptions = null;
            Closed = false;
        }

        /// <summary> Auto-generated property used to indicate whether the mock form is closed or not. </summary>
        public bool Closed { get; private set; }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public string[] GameOptions
        {
            set
            {
                gameOptions = value;
            }
            get // Getter used for testing purposes, it is not requred by the interface and only exists in this mock.
            {
                return gameOptions;
            }
        }

        /// <summary> Interface realization property.  See interface for documentation. </summary>
        public int SelectedGame
        {
            get
            {
                return selectedGame;
            }
            set // Setter used for testing purposes, it is not required by the interface and only exists in this mock.
            {
                selectedGame = value;
            }
        }

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

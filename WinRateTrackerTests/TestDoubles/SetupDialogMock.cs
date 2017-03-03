using System;
using WinRateTracker.View;

namespace WinRateTrackerTests.TestDoubles
{
    class SetupDialogMock : ISetupDialogView
    {
        public event Action Confirm;
        public event Action Cancel;

        private int selectedGame;
        private string[] gameOptions;

        public SetupDialogMock()
        {
            selectedGame = 0;
            gameOptions = null;
            Closed = false;
        }

        public bool Closed { get; private set; }

        public string[] GameOptions
        {
            set
            {
                gameOptions = value;
            }
            get
            {
                return gameOptions;
            }
        }

        public int SelectedGame
        {
            get
            {
                return selectedGame;
            }
            set
            {
                selectedGame = value;
            }
        }

        public void CloseDialog()
        {
            Closed = true;
        }

        public void Confirm_Invoke()
        {
            Confirm?.Invoke();
        }

        public void Cancel_Invoke()
        {
            Cancel?.Invoke();
        }
    }
}

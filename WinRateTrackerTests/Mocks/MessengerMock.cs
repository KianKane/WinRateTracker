﻿using WinRateTracker.View;

namespace WinRateTrackerTests.Mocks
{
    class MessengerMock : IMessenger
    {
        public void Message(string title, string message){}
        public bool Prompt(string title, string message){ return false; }
    }
}

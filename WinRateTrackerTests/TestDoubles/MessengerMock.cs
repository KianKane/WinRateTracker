using WinRateTracker.View;

namespace WinRateTrackerTests.TestDoubles
{
    class MessengerStub : IMessenger
    {
        public void Message(string title, string message){}
        public bool Prompt(string title, string message){ return false; }
    }
}

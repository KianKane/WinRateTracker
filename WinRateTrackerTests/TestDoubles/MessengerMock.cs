using WinRateTracker.View;

namespace WinRateTrackerTests.TestDoubles
{
    /// <summary>
    /// An empty stub implementation of IMessenger to be used for test purposes.
    /// </summary>
    class MessengerStub : IMessenger
    {
        /// <summary> Empty stub implementation. </summary>
        public void Message(string title, string message){}

        /// <summary> Empty stub implementation.  Always returns true. </summary>
        /// <returns> Always returns true. </returns>
        public bool Prompt(string title, string message){ return true; }
    }
}

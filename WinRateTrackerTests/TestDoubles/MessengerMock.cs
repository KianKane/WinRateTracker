using System.Collections.Generic;
using WinRateTracker.View;

namespace WinRateTrackerTests.TestDoubles
{
    /// <summary>
    /// This class acts as a mock messenger.  Instead of displaying messages to the user it simply stores a list of messages sent.
    /// </summary>
    class MessengerMock : IMessenger
    {
        /// <summary> Stores a record of a single message. </summary>
        public struct MessageRecord
        {
            public string title;
            public string message;
            public bool isPrompt;

            public MessageRecord(string title, string message, bool isPrompt)
            {
                this.title = title;
                this.message = message;
                this.isPrompt = isPrompt;
            }
        }

        private Stack<MessageRecord> messages; // Stores the messages sent from this messenger.
        private bool accept; // When this is true the messenger will assume the user accepts all prompts.  When this is false the messenger will assume the user declines all prompts.

        /// <summary> Constructor. </summary>
        public MessengerMock()
        {
            messages = new Stack<MessageRecord>();
            accept = true;
        }

        /// <summary> This property allows testing classes to view the messages shown by this class. </summary>
        public Stack<MessageRecord> Messages
        {
            get { return messages; }
        }

        /// <summary> When this is true the messenger will assume the user accepts all prompts.  When this is false the messenger will assume the user declines all prompts. </summary>
        public bool Accept
        {
            get { return accept; }
            set { accept = value; }
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void Message(string title, string message)
        {
            messages.Push(new MessageRecord(title, message, false));
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        /// <returns> Returns value of Accept property to fake user interaction. </returns>
        public bool Prompt(string title, string message)
        {
            messages.Push(new MessageRecord(title, message, true));
            return Accept;
        }
    }
}

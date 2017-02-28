using System.Windows.Forms;

namespace WinRateTracker.View
{
    /// <summary>
    /// This class is a concrete singleton implementation of the IMessenger interface.
    /// This class allows other classes to show messages to the user as well as prompt the user with yes/no questions.
    /// </summary>
    public class Messenger : IMessenger
    {
        private static Messenger _instance; // Private singleton instance variable, this should not be used anywhere except inside the Instance property getter.

        private Messenger() { } // The constructor is private.

        /// <summary> Singleton instance property. </summary>
        public static Messenger Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Messenger();
                return _instance;
            }
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void Message(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public bool Prompt(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}

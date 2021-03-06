﻿namespace WinRateTracker.View
{
    /// <summary>
    /// This interface defines messaging capabilities to be implemented by a messenger class.
    /// </summary>
    public interface IMessenger
    {
        /// <summary> Display a message to the user. </summary>
        /// <param name="title"> The title of the message. </param>
        /// <param name="message"> The content of the message. </param>
        void Message(string title, string message);

        /// <summary> Prompt the user with a yes/no dialog. </summary>
        /// <param name="title"> The title of the prompt. </param>
        /// <param name="message"> The content of the prompt. </param>
        /// <returns> TRUE if the user answers yes, FALSE if the user answers no. </returns>
        bool Prompt(string title, string message);
    }
}

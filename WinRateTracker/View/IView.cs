using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRateTracker.View
{
    interface IView
    {
        void Message(string title, string message);
        bool Prompt(string title, string message);
    }
}

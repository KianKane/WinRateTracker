using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRateTracker.View
{
    interface INewArchetypeView : IDialogView
    {
        event Action InsertArchetype;
        string ArchetypeName { get; }
        string ArchetypeNote { get; }
    }
}

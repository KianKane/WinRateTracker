using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRateTracker.View
{
    interface IUpdateArchetypeView : IDialogView
    {
        event Action UpdateArchetype;
        int ArchetypeID { get; }
        string ArchetypeName { get; set; }
        string ArchetypeNote { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRateTracker.View
{
    interface INewBuildView : IDialogView
    {
        event Action InsertBuild;
        string BuildName { get; }
        string BuildNote { get; }
        int ArchetypeID { get; }
    }
}

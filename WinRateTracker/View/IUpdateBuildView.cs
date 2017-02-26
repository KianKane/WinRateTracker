using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRateTracker.View
{
    interface IUpdateBuildView : IDialogView
    {
        event Action UpdateBuild;
        string BuildName { get; set; }
        string BuildNote { get; set; }
        string ArchetypeName { set; }
        int ArchetypeID { get; }
        int BuildID { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRateTracker.View
{
    interface IHomeView : IView
    {
        event Action RecordVictory;
        event Action RecordDefeat;
        event Action UpdateStatistics;
        event Action NewBuild;
        event Action UpdateBuild;
        event Action DeleteBuild;
        event Action NewArchetype;
        event Action UpdateArchetype;
        event Action DeleteArchetype;
        string WinRate { set; }
        string Wins { set; }
        string Losses { set; }
        int? SelectedBuildID { get; }
        int? SelectedArchetypeID { get; }
        bool AllBuilds { get; }
        bool AllArchetypes { get; }
        void ShowNewBuildDialog();
        void ShowUpdateBuildDialog();
        void ShowNewArchetypeDialog();
        void ShowUpdateArchetypeDialog();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckTracker.Database.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
    interface IArchetypeInitializer
    {
        void InitializeArchetypes(ArchetypesTableAdapter adapter);
    }
}

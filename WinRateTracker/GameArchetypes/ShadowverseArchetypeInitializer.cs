using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckTracker.Database.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
    class ShadowverseArchetypeInitializer : IArchetypeInitializer
    {
        public void InitializeArchetypes(ArchetypesTableAdapter adapter)
        {
            adapter.InsertQuery("Arisa (Forestcraft)", null);
            adapter.InsertQuery("Erika (Swordcraft)", null);
            adapter.InsertQuery("Isabelle (Runecraft)", null);
            adapter.InsertQuery("Rowan (Dragoncraft)", null);
            adapter.InsertQuery("Luna (Shadowcraft)", null);
            adapter.InsertQuery("Urias (Bloodcraft)", null);
            adapter.InsertQuery("Eris (Havencraft)", null);
        }
    }
}

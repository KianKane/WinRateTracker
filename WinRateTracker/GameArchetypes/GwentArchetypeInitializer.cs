using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckTracker.Database.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
    class GwentArchetypeInitializer : IArchetypeInitializer
    {
        public void InitializeArchetypes(ArchetypesTableAdapter adapter)
        {
            adapter.InsertQuery("Nilfgaard", null);
            adapter.InsertQuery("Monsters", null);
            adapter.InsertQuery("Skellige", null);
            adapter.InsertQuery("Northern Realms", null);
            adapter.InsertQuery("Scoia'tael", null);
        }
    }
}
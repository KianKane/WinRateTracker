using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckTracker.Database.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
    class HearthstoneArchetypeInitializer : IArchetypeInitializer
    {
        public void InitializeArchetypes(ArchetypesTableAdapter adapter)
        {
            adapter.InsertQuery("Mage", null);
            adapter.InsertQuery("Hunter", null);
            adapter.InsertQuery("Paladin", null);
            adapter.InsertQuery("Warrior", null);
            adapter.InsertQuery("Druid", null);
            adapter.InsertQuery("Warlock", null);
            adapter.InsertQuery("Shaman", null);
            adapter.InsertQuery("Priest", null);
            adapter.InsertQuery("Rogue", null);
        }
    }
}

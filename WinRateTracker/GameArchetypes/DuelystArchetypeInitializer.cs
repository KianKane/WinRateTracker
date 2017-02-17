﻿using DeckTracker.Database.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
    class DuelystArchetypeInitializer : IArchetypeInitializer
    {
        public void InitializeArchetypes(ArchetypesTableAdapter adapter)
        {
            adapter.InsertQuery("Lyonar", null);
            adapter.InsertQuery("Songhai", null);
            adapter.InsertQuery("Vetruvian", null);
            adapter.InsertQuery("Abyssian", null);
            adapter.InsertQuery("Magmar", null);
            adapter.InsertQuery("Vanar", null);
        }
    }
}

using DeckTracker.Database.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
    class ShadowverseArchetypeInitializer : IArchetypeInitializer
    {
        public void InitializeArchetypes(ArchetypesTableAdapter adapter)
        {
            adapter.InsertQuery("Forestcraft", "Arisa");
            adapter.InsertQuery("Swordcraft", "Erika");
            adapter.InsertQuery("Runecraft", "Isabelle");
            adapter.InsertQuery("Dragoncraft", "Rowan");
            adapter.InsertQuery("Shadowcraft", "Luna");
            adapter.InsertQuery("Bloodcraft", "Urias");
            adapter.InsertQuery("Havencraft", "Eris");
        }
    }
}

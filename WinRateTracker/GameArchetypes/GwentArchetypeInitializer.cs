using DeckTracker.Model.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
    /// <summary>
    /// Initializes archetypes for the game Gwent.
    /// Uses the name field to store the faction name.
    /// 
    /// TODO: Find or write default descriptions for the various factions.
    /// </summary>
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
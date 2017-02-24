using DeckTracker.Model.DatabaseDataSetTableAdapters;

namespace DeckTracker.Presenter.GameArchetypes
{
    /// <summary>
    /// Initializes archetypes for the game Duelyst.
    /// Uses the name field to store the faction name.
    /// 
    /// TODO: Find or write default descriptions for the various factions.
    /// NOTE: Can possibly use defualt hero names as descriptions?
    /// </summary>
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

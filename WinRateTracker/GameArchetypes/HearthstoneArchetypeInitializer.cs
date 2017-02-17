using DeckTracker.Database.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
    /// <summary>
    /// Initializes archetypes for the game Hearthstone.
    /// Uses the name field to store the class.
    /// Uses the note field to store the default hero associated with the class.
    /// 
    /// NOTE: Could possibly move hero name into name and class name into note.
    /// </summary>
    class HearthstoneArchetypeInitializer : IArchetypeInitializer
    {
        public void InitializeArchetypes(ArchetypesTableAdapter adapter)
        {
            adapter.InsertQuery("Mage", "Jaina Proudmoore");
            adapter.InsertQuery("Hunter", "Rexxar");
            adapter.InsertQuery("Paladin", "Uther Lightbringer");
            adapter.InsertQuery("Warrior", "Garrosh Hellscream");
            adapter.InsertQuery("Druid", "Malfurion Stormrage");
            adapter.InsertQuery("Warlock", "Gul'dan");
            adapter.InsertQuery("Shaman", "Thrall");
            adapter.InsertQuery("Priest", "Anduin Wrynn");
            adapter.InsertQuery("Rogue", "Valeera Sanguinar");
        }
    }
}

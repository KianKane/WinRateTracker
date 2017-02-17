using DeckTracker.Database.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
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

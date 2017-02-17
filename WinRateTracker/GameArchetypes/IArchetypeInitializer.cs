using DeckTracker.Database.DatabaseDataSetTableAdapters;

namespace DeckTracker.GameArchetypes
{
    interface IArchetypeInitializer
    {
        void InitializeArchetypes(ArchetypesTableAdapter adapter);
    }
}

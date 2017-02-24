using WinRateTracker.Model.DatabaseDataSetTableAdapters;

namespace WinRateTracker.Presenter.GameArchetypes
{
    /// <summary>
    /// Defines how an archetype initializer is to be interacted with.
    /// </summary>
    interface IArchetypeInitializer
    {
        /// <summary>
        /// When called the archetype initializer should fill the archetypes table using the provided ArchetypesTableAdapter.
        /// </summary>
        /// <param name="adapter">The archetype table adapter to use to insert archetypes.</param>
        void InitializeArchetypes(ArchetypesTableAdapter adapter);
    }
}

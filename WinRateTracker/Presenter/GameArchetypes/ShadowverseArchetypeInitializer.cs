using WinRateTracker.Model.DatabaseDataSetTableAdapters;

namespace WinRateTracker.Presenter.GameArchetypes
{
    /// <summary>
    /// Initializes archetypes for the game Shadowverse.
    /// Uses the name field to store the class name.
    /// Uses the note field to store the name of the classes hero.
    /// 
    /// NOTE: Could find more descriptive notes.
    /// NOTE: Could possibly swap hero and class names.
    /// </summary>
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

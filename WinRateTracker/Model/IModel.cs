namespace WinRateTracker.Model
{
    public interface IModel
    {
        DatabaseDataSet GetDataSet();
        void InsertBuild(string name, string note, int archetypeID);
        void UpdateBuild(int buildID, string name, string note, int archetypeID);
        void DeleteBuild(int buildID);
        void InsertArchetype(string name, string note);
        void UpdateArchetype(int archetypeID, string name, string note);
        void DeleteArchetype(int archetypeID);
        void RecordMatch(int buildID, int archetypeID, bool victory);
        int CountMatches(int? buildID, int? archetypeID, bool victory);
        string GetArchetypeName(int archetypeID);
        string GetArchetypeNote(int archetypeID);
        string GetBuildName(int buildID);
        string GetBuildNote(int buildID);
        int GetBuildArchetypeID(int buildID);
        int GetArchetypeCount();
    }
}

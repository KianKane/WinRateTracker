namespace WinRateTracker.Model
{
    interface IModel
    {
        void InsertBuild(string name, string note, int archetypeID);
        void UpdateBuild(int buildID, string name, string note, int archetypeID));
        void DeleteBuild(int buildID);
        void InsertArchetype(string name, string note);
        void UpdateArchetype(int archetypeID, string name, string note);
        void DeleteArchetype(int archetypeID);
        void RecordMatch(int buildID, int archetypeID, bool victory);
        int CountMatches(int? buildID, int? archetypeID, bool victory);
    }
}

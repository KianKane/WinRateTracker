namespace WinRateTracker.Model
{
    /// <summary>
    /// This interface defines the outward facing interaction contract of the project model.
    /// </summary>
    public interface IModel
    {
        /// <summary> Get the DatabaseDataSet instance used by this model.  Views use this for data binding, presenters should not use this method. </summary>
        /// <returns> The DatabaseDataSet instance used by this model. </returns>
        DatabaseDataSet GetDataSet();

        /// <summary> Adds a new build and inserts it into the database. </summary>
        /// <param name="name"> The name of the new build. </param>
        /// <param name="note"> The note attatched to the new build. </param>
        /// <param name="archetypeID"> The archetypeID of the archetype attatched to the new build. </param>
        void InsertBuild(string name, string note, int archetypeID);

        /// <summary> Modifies a specified build.  This cannot be used to change the archetype attatched to the build. </summary>
        /// <param name="buildID"> The ID of the build to be modified. </param>
        /// <param name="name"> The new name to be assigned to the build. </param>
        /// <param name="note"> The new note to be attatched to the build. </param>
        void UpdateBuild(int buildID, string name, string note);

        /// <summary> Deletes a specified build, removing it from the database. </summary>
        /// <param name="buildID"> The ID of the build to be deleted. </param>
        void DeleteBuild(int buildID);

        /// <summary> Adds a new archetype and inserts it into the database. </summary>
        /// <param name="name"> The name of the new archetype. </param>
        /// <param name="note"> The note attatched to the new archetype. </param>
        void InsertArchetype(string name, string note);

        /// <summary> Modifies a specified archetype. </summary>
        /// <param name="archetypeID"> The ID of the archetype to be modified. </param>
        /// <param name="name"> The new name to be assigned to the archetype. </param>
        /// <param name="note"> The new note to be attatched to the archetype. </param>
        void UpdateArchetype(int archetypeID, string name, string note);

        /// <summary> Deletes a specified archetype, removing it from the database. </summary>
        /// <param name="archetypeID"> The ID of the archetype to be deleted. </param>
        void DeleteArchetype(int archetypeID);

        /// <summary> Records a match and inserts it into the database. </summary>
        /// <param name="buildID"> The ID of the build used in the match. </param>
        /// <param name="archetypeID"> The ID of the archetype played against. </param>
        /// <param name="victory"> The result of the game. (TRUE = Victory, FALSE = Defeat) </param>
        void RecordMatch(int buildID, int archetypeID, bool victory);

        /// <summary> Counts and returns the number of matches played meeting the requirements indicated by the parameters. </summary>
        /// <param name="buildID"> The ID of the build used in the matches to be counted. (NULL = All Builds) </param>
        /// <param name="archetypeID"> The ID of the archetype used in the matches to be counted. (NULL = All Archetypes) </param>
        /// <param name="victory"> The result of the games to be counted. (TRUE = Victory, FALSE = Defeat) </param>
        /// <returns> The number of matches played meeting the requirements indicated by the parameters. </returns>
        int CountMatches(int? buildID, int? archetypeID, bool victory);

        /// <summary> Gets and returns the name of the archetype with the passed ID. </summary>
        /// <param name="archetypeID"> The ID of the archetype to find. </param>
        /// <returns> The name of the archetype with the passed ID. </returns>
        string GetArchetypeName(int archetypeID);

        /// <summary> Gets and returns the note attatched to the archetype with the passed ID. </summary>
        /// <param name="archetypeID"> The ID of the archetype to find. </param>
        /// <returns> The note attatched to the archetype with the passed ID. </returns>
        string GetArchetypeNote(int archetypeID);

        /// <summary> Gets and returns the name of the build with the passed ID. </summary>
        /// <param name="buildID"> The ID of the build to find. </param>
        /// <returns> The name of the build with the passed ID. </returns>
        string GetBuildName(int buildID);

        /// <summary> Gets and returns the note attatched to the build with the passed ID. </summary>
        /// <param name="buildID"> The ID of the build to find. </param>
        /// <returns> The note attatched to the build with the passed ID. </returns>
        string GetBuildNote(int buildID);

        /// <summary> Gets and returns the archetypeID of the archetype connected to the build with the passed ID. </summary>
        /// <param name="buildID"> The ID of the build to find. </param>
        /// <returns> The archetypeID of the archetype connected to the build with the passed ID. </returns>
        int GetBuildArchetypeID(int buildID);

        /// <summary> Gets and returns the total number of archetypes. 
        /// NOTE: Could replace with NoArchetypes with a boolean return type as this method is currently only used to check if there are no archetypes </summary>
        /// <returns> The total number of archetypes. </returns>
        int GetArchetypeCount();
    }
}

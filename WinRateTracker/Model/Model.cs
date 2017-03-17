using System;
using System.Data;
using System.Windows.Forms;

namespace WinRateTracker.Model
{
    /// <summary>
    /// This class is a concrete singleton implementation of the IModel interface.
    /// This class allows other classes to access the database through it without exposing the details of the database connection.
    /// </summary>
    class Model : IModel
    {
        private static Model _instance; // Private singleton instance variable, this should not be used anywhere except inside the Instance property getter.
        private DatabaseDataSet dataSet;
        private DatabaseDataSetTableAdapters.BuildsTableAdapter buildsTableAdapter;
        private DatabaseDataSetTableAdapters.MatchesTableAdapter matchesTableAdapter;
        private DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter;

        /// <summary>
        /// Constructor.
        /// Sets up dataset and table adapters.
        /// </summary>
        private Model()
        {
            // Set up data set
            dataSet = new DatabaseDataSet();
            dataSet.BeginInit();
            dataSet.DataSetName = "DatabaseDataSet";
            dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            dataSet.EndInit();
            // Set up table adapters
            buildsTableAdapter = new DatabaseDataSetTableAdapters.BuildsTableAdapter();
            buildsTableAdapter.ClearBeforeFill = true;
            matchesTableAdapter = new DatabaseDataSetTableAdapters.MatchesTableAdapter();
            matchesTableAdapter.ClearBeforeFill = true;
            archetypesTableAdapter = new DatabaseDataSetTableAdapters.ArchetypesTableAdapter();
            archetypesTableAdapter.ClearBeforeFill = true;
            // Fill table adapters
            buildsTableAdapter.Fill(dataSet.Builds);
            matchesTableAdapter.Fill(dataSet.Matches);
            archetypesTableAdapter.Fill(dataSet.Archetypes);
        }

        /// <summary> Singleton instance property. </summary>
        public static Model Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Model();
                return _instance;
            }
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public DatabaseDataSet GetDataSet()
        {
            return dataSet;
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void InsertBuild(string name, string note, int archetypeID)
        {
            buildsTableAdapter.InsertQuery(name, note, archetypeID);
            buildsTableAdapter.Fill(dataSet.Builds);
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void UpdateBuild(int buildID, string name, string note)
        {
            buildsTableAdapter.UpdateQuery(name, note, buildID);
            buildsTableAdapter.Fill(dataSet.Builds);
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void DeleteBuild(int buildID)
        {
            buildsTableAdapter.DeleteQuery(buildID);
            buildsTableAdapter.Fill(dataSet.Builds);
            matchesTableAdapter.Fill(dataSet.Matches);
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void InsertArchetype(string name, string note)
        {
            archetypesTableAdapter.InsertQuery(name, note);
            archetypesTableAdapter.Fill(dataSet.Archetypes);
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void UpdateArchetype(int archetypeID, string name, string note)
        {
            archetypesTableAdapter.UpdateQuery(name, note, archetypeID);
            archetypesTableAdapter.Fill(dataSet.Archetypes);
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void DeleteArchetype(int archetypeID)
        {
            archetypesTableAdapter.DeleteQuery(archetypeID);
            buildsTableAdapter.Fill(dataSet.Builds);
            matchesTableAdapter.Fill(dataSet.Matches);
            archetypesTableAdapter.Fill(dataSet.Archetypes);
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void RecordMatch(int buildID, int archetypeID, bool victory)
        {
            matchesTableAdapter.RecordMatchQuery(buildID, archetypeID, victory);
            matchesTableAdapter.Fill(dataSet.Matches);
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public int CountMatches(int? buildID, int? archetypeID, bool victory)
        {
            int matches = 0;
            if (buildID == null && archetypeID == null)
                matches = (int)matchesTableAdapter.CountMatchesAllQuery(victory); // All builds and all archetypes
            else if (buildID == null)
                matches = (int)matchesTableAdapter.CountMatchesAllBuildsQuery((int)archetypeID, victory); // All builds but specific archetype
            else if (archetypeID == null)
                matches = (int)matchesTableAdapter.CountMatchesAllArchetypesQuery((int)buildID, victory); // All archetypes but specific build
            else
                matches = (int)matchesTableAdapter.CountMatchesQuery((int)buildID, (int)archetypeID, victory); // Specific build and archetype
            return matches;
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public bool ArchetypeExists(int archetypeID)
        {
            DataRow[] rows = dataSet.Archetypes.Select("archetypeID = " + archetypeID);
            return rows.Length > 0;
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public bool BuildExists(int buildID)
        {
            DataRow[] rows = dataSet.Builds.Select("buildID = " + buildID);
            return rows.Length > 0;
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public string GetArchetypeName(int archetypeID)
        {
            DataRow[] rows = dataSet.Archetypes.Select("archetypeID = " + archetypeID);
            if (rows.Length == 0)
                return "";
            DataRow row = rows[0];
            return row["name"].ToString();
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public string GetArchetypeNote(int archetypeID)
        {
            DataRow[] rows = dataSet.Archetypes.Select("archetypeID = " + archetypeID);
            if (rows.Length == 0)
                return "";
            DataRow row = rows[0];
            return row["note"].ToString() ?? "";
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public string GetBuildName(int buildID)
        {
            DataRow[] rows = dataSet.Builds.Select("buildID = " + buildID);
            if (rows.Length == 0)
                return "";
            DataRow row = rows[0];
            return row["name"].ToString();
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public string GetBuildNote(int buildID)
        {
            DataRow[] rows = dataSet.Builds.Select("buildID = " + buildID);
            if (rows.Length == 0)
                return "";
            DataRow row = rows[0];
            return row["note"].ToString() ?? "";
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public int GetBuildArchetypeID(int buildID)
        {
            DataRow[] rows = dataSet.Builds.Select("buildID = " + buildID);
            if (rows.Length == 0)
                return -1;
            DataRow row = rows[0];
            return (int)row["archetypeID"];
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public int GetArchetypeCount()
        {
            return dataSet.Archetypes.Count;
        }
    }
}

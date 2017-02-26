using System;
using System.Data;
using System.Windows.Forms;

namespace WinRateTracker.Model
{
    class Model : IModel
    {
        private static Model _instance;
        public static Model Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Model();
                return _instance;
            }
        }

        DatabaseDataSet dataSet;
        DatabaseDataSetTableAdapters.BuildsTableAdapter buildsTableAdapter;
        DatabaseDataSetTableAdapters.MatchesTableAdapter matchesTableAdapter;
        DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter;

        private Model()
        {
            dataSet = new DatabaseDataSet();
            dataSet.BeginInit();
            dataSet.DataSetName = "DatabaseDataSet";
            dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            dataSet.EndInit();

            buildsTableAdapter = new DatabaseDataSetTableAdapters.BuildsTableAdapter();
            buildsTableAdapter.ClearBeforeFill = true;

            matchesTableAdapter = new DatabaseDataSetTableAdapters.MatchesTableAdapter();
            matchesTableAdapter.ClearBeforeFill = true;

            archetypesTableAdapter = new DatabaseDataSetTableAdapters.ArchetypesTableAdapter();
            archetypesTableAdapter.ClearBeforeFill = true;

            buildsTableAdapter.Fill(dataSet.Builds);
            matchesTableAdapter.Fill(dataSet.Matches);
            archetypesTableAdapter.Fill(dataSet.Archetypes);
        }

        public DatabaseDataSet GetDataSet()
        {
            return dataSet;
        }

        public void InsertBuild(string name, string note, int archetypeID)
        {
            buildsTableAdapter.InsertQuery(name, note, archetypeID);
            buildsTableAdapter.Fill(dataSet.Builds);
        }

        public void UpdateBuild(int buildID, string name, string note, int archetypeID)
        {
            buildsTableAdapter.UpdateQuery(name, note, archetypeID, buildID);
            buildsTableAdapter.Fill(dataSet.Builds);
        }

        public void DeleteBuild(int buildID)
        {
            buildsTableAdapter.DeleteQuery(buildID);
            buildsTableAdapter.Fill(dataSet.Builds);
            matchesTableAdapter.Fill(dataSet.Matches);
        }

        public void InsertArchetype(string name, string note)
        {
            archetypesTableAdapter.InsertQuery(name, note);
            archetypesTableAdapter.Fill(dataSet.Archetypes);
        }

        public void UpdateArchetype(int archetypeID, string name, string note)
        {
            archetypesTableAdapter.UpdateQuery(name, note, archetypeID);
            archetypesTableAdapter.Fill(dataSet.Archetypes);
        }

        public void DeleteArchetype(int archetypeID)
        {
            archetypesTableAdapter.DeleteQuery(archetypeID);
            buildsTableAdapter.Fill(dataSet.Builds);
            matchesTableAdapter.Fill(dataSet.Matches);
            archetypesTableAdapter.Fill(dataSet.Archetypes);
        }

        public void RecordMatch(int buildID, int archetypeID, bool victory)
        {
            matchesTableAdapter.RecordMatchQuery(buildID, archetypeID, victory);
            matchesTableAdapter.Fill(dataSet.Matches);
        }

        public int CountMatches(int? buildID, int? archetypeID, bool victory)
        {
            int matches = 0;

            if (buildID != null && archetypeID != null)
                matches = (int)matchesTableAdapter.CountMatchesQuery((int)buildID, (int)archetypeID, victory);
            else if (archetypeID != null)
                matchesTableAdapter.CountMatchesAllBuildsQuery((int)archetypeID, victory);
            else if (buildID != null)
                matchesTableAdapter.CountMatchesAllArchetypesQuery((int)buildID, victory);
            else
                matchesTableAdapter.CountMatchesAllQuery(victory);
            return matches;
        }

        public string GetArchetypeName(int archetypeID)
        {
            DataRow[] rows = dataSet.Archetypes.Select("archetypeID = " + archetypeID);
            if (rows.Length == 0)
                return "";
            DataRow row = rows[0];
            return row["name"].ToString();
        }

        public string GetArchetypeNote(int archetypeID)
        {
            DataRow[] rows = dataSet.Archetypes.Select("archetypeID = " + archetypeID);
            if (rows.Length == 0)
                return "";
            DataRow row = rows[0];
            return row["note"].ToString() ?? "";
        }

        public string GetBuildName(int buildID)
        {
            DataRow[] rows = dataSet.Builds.Select("buildID = " + buildID);
            if (rows.Length == 0)
                return "";
            DataRow row = rows[0];
            return row["name"].ToString();
        }

        public string GetBuildNote(int buildID)
        {
            DataRow[] rows = dataSet.Builds.Select("buildID = " + buildID);
            if (rows.Length == 0)
                return "";
            DataRow row = rows[0];
            return row["note"].ToString() ?? "";
        }

        public int GetBuildArchetypeID(int buildID)
        {
            DataRow[] rows = dataSet.Builds.Select("buildID = " + buildID);
            if (rows.Length == 0)
                return -1;
            DataRow row = rows[0];
            return (int)row["archetypeID"];
        }

        public int GetArchetypeCount()
        {
            return dataSet.Archetypes.Count;
        }
    }
}

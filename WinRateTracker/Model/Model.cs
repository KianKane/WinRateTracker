using System;

namespace WinRateTracker.Model
{
    class Model : IModel
    {
        DatabaseDataSet dataSet;
        DatabaseDataSetTableAdapters.BuildsTableAdapter buildsTableAdapter;
        DatabaseDataSetTableAdapters.MatchesTableAdapter matchesTableAdapter;
        DatabaseDataSetTableAdapters.ArchetypesTableAdapter archetypesTableAdapter;

        public Model()
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
        }

        public void InsertBuild(string name, string note, int archetypeID)
        {
            buildsTableAdapter.InsertQuery(name, note, archetypeID);
            FillDataSet();
        }

        public void UpdateBuild(int buildID, string name, string note, int archetypeID)
        {
            buildsTableAdapter.UpdateQuery(name, note, archetypeID, buildID);
            FillDataSet();
        }

        public void DeleteBuild(int buildID)
        {
            buildsTableAdapter.DeleteQuery(buildID);
            FillDataSet();
        }

        public void InsertArchetype(string name, string note)
        {
            archetypesTableAdapter.InsertQuery(name, note);
            FillDataSet();
        }

        public void UpdateArchetype(int archetypeID, string name, string note)
        {
            archetypesTableAdapter.UpdateQuery(name, note, archetypeID);
            FillDataSet();
        }

        public void DeleteArchetype(int archetypeID)
        {
            archetypesTableAdapter.DeleteQuery(archetypeID);
            FillDataSet();
        }

        public void RecordMatch(int buildID, int archetypeID, bool victory)
        {
            matchesTableAdapter.RecordMatchQuery(buildID, archetypeID, victory);
            FillDataSet();
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

        private void FillDataSet()
        {
            buildsTableAdapter.Fill(dataSet.Builds);
            matchesTableAdapter.Fill(dataSet.Matches);
            archetypesTableAdapter.Fill(dataSet.Archetypes);
        }
    }
}

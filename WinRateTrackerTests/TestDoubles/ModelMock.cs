using System.Collections.Generic;
using WinRateTracker.Model;

namespace WinRateTrackerTests.TestDoubles
{
    class ModelMock : IModel
    {
        public struct Build
        {
            public int id;
            public string name;
            public string note;
            public int archetypeID;

            public Build(int id, string name, string note, int archetypeID)
            {
                this.id = id;
                this.name = name;
                this.note = note;
                this.archetypeID = archetypeID;
            }
        }

        public struct Match
        {
            public int id;
            public int buildID;
            public int archetypeID;
            public bool victory;

            public Match(int id, int buildID, int archetypeID, bool victory)
            {
                this.id = id;
                this.buildID = buildID;
                this.archetypeID = archetypeID;
                this.victory = victory;
            }
        }

        public struct Archetype
        {
            public int id;
            public string name;
            public string note;

            public Archetype(int id, string name, string note)
            {
                this.id = id;
                this.name = name;
                this.note = note;
            }
        }

        public List<Build> builds;
        public List<Match> matches;
        public List<Archetype> archetypes;

        private int nextBuildID;
        private int nextMatchID;
        private int nextArchetypeID;

        /// <summary> Constructor. </summary>
        public ModelMock()
        {
            builds = new List<Build>();
            matches = new List<Match>();
            archetypes = new List<Archetype>();

            nextBuildID = 1;
            nextMatchID = 1;
            nextArchetypeID = 1;
        }


        /// <summary> GetDataSet should not be used in testing.  Presenters should not use this method. </summary>
        public DatabaseDataSet GetDataSet()
        {
            return null;
        }

        public void InsertBuild(string name, string note, int archetypeID)
        {
            builds.Add(new Build(nextBuildID++, name, note, archetypeID));
        }

        public void UpdateBuild(int buildID, string name, string note)
        {
            for (int i = 0; i < builds.Count; i++)
            {
                if (builds[i].id == buildID)
                {
                    builds[i] = new Build(builds[i].id, name, note, builds[i].archetypeID);
                    break;
                }
            }
        }

        public void DeleteBuild(int buildID)
        {
            for (int i = 0; i < builds.Count; i++)
            {
                if (builds[i].id == buildID)
                {
                    builds.RemoveAt(i);
                    break;
                }
            }
        }

        public void InsertArchetype(string name, string note)
        {
            archetypes.Add(new Archetype(nextArchetypeID++, name, note));
        }

        public void UpdateArchetype(int archetypeID, string name, string note)
        {
            for (int i = 0; i < archetypes.Count; i++)
            {
                if (archetypes[i].id == archetypeID)
                {
                    archetypes[i] = new Archetype(archetypes[i].id, name, note);
                    break;
                }
            }
        }

        public void DeleteArchetype(int archetypeID)
        {
            for (int i = 0; i < archetypes.Count; i++)
            {
                if (archetypes[i].id == archetypeID)
                {
                    archetypes.RemoveAt(i) ;
                    break;
                }
            }
        }

        public void RecordMatch(int buildID, int archetypeID, bool victory)
        {
            matches.Add(new Match(nextMatchID++, buildID, archetypeID, victory));
        }

        public int CountMatches(int? buildID, int? archetypeID, bool victory)
        {
            int count = 0;
            foreach (Match match in matches)
            {
                if ((buildID == null || match.buildID == buildID) && (archetypeID == null || match.archetypeID == archetypeID) && (match.victory == victory))
                {
                    count++;
                }
            }
            return count;
        }

        public string GetArchetypeName(int archetypeID)
        {
            for (int i = 0; i < archetypes.Count; i++)
            {
                if (archetypes[i].id == archetypeID)
                {
                    return archetypes[i].name;
                }
            }
            return null;
        }

        public string GetArchetypeNote(int archetypeID)
        {
            for (int i = 0; i < archetypes.Count; i++)
            {
                if (archetypes[i].id == archetypeID)
                {
                    return archetypes[i].note;
                }
            }
            return null;
        }

        public string GetBuildName(int buildID)
        {
            for (int i = 0; i < builds.Count; i++)
            {
                if (builds[i].id == buildID)
                {
                    return builds[i].name;
                }
            }
            return null;
        }

        public string GetBuildNote(int buildID)
        {
            for (int i = 0; i < builds.Count; i++)
            {
                if (builds[i].id == buildID)
                {
                    return builds[i].note;
                }
            }
            return null;
        }

        public int GetBuildArchetypeID(int buildID)
        {
            for (int i = 0; i < builds.Count; i++)
            {
                if (builds[i].id == buildID)
                {
                    return builds[i].archetypeID;
                }
            }
            return -1;
        }

        public int GetArchetypeCount()
        {
            return archetypes.Count;
        }
    }
}

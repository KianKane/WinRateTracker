using System;
using System.Collections.Generic;
using WinRateTracker.Model;

namespace WinRateTrackerTests.TestDoubles
{
    /// <summary>
    /// This class acts as a mock model.  Instead of connecting to a database it simply stores lists of Builds, Matches and Archetypes.
    /// </summary>
    class ModelMock : IModel
    {
        /// <summary> Stores the information for a single build. </summary>
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

        /// <summary> Stores the information for a single match. </summary>
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

        /// <summary> Stores the information for a single archetype. </summary>
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

        // Lists are public so they can be checked at any point by test classes.
        public List<Build> builds;
        public List<Match> matches;
        public List<Archetype> archetypes;

        // ID counters are used to create unique IDS.  these must be incremented every time they are used.
        // NOTE: Could replace these with properties that incrememnt themselves automatically.
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void InsertBuild(string name, string note, int archetypeID)
        {
            builds.Add(new Build(nextBuildID++, name, note, archetypeID));
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void InsertArchetype(string name, string note)
        {
            archetypes.Add(new Archetype(nextArchetypeID++, name, note));
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void DeleteArchetype(int archetypeID)
        {
            for (int i = 0; i < archetypes.Count; i++)
            {
                if (archetypes[i].id == archetypeID)
                {
                    archetypes.RemoveAt(i);
                    break;
                }
            }
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public void RecordMatch(int buildID, int archetypeID, bool victory)
        {
            matches.Add(new Match(nextMatchID++, buildID, archetypeID, victory));
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
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

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public int GetArchetypeCount()
        {
            return archetypes.Count;
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public bool ArchetypeExists(int archetypeID)
        {
            for (int i = 0; i < archetypes.Count; i++)
            {
                if (archetypes[i].id == archetypeID)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary> Interface realization method.  See interface for documentation. </summary>
        public bool BuildExists(int buildID)
        {
            for (int i = 0; i < builds.Count; i++)
            {
                if (builds[i].id == buildID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackNTraceDojo
{
    public class DojoHandler
    {
        private int RotationTime { get; set; }
        private int CommitTime { get; set; }
        private List<string> Names { get; set; }

        public List<string> GetNames() => Names;

        public void SetRotationTime(int minutes)
        {
            RotationTime = minutes;
        }
        public void SetCommitTime(int minutes)
        {
            CommitTime = minutes;
        }

        public int GetRotationTime()
        {
            return RotationTime;
        }
        
        public int GetCommitTime()
        {
            return CommitTime;
        }

        public void SetRotationNames(List<string> names)
        {
            Names = names;
        }
    }

    public class RandomNames
    {
        public Guid Id;
        public string Name;
    }

    public static class Sort
    {
        public static List<string> Randomize(List<string> namesList)
        {
            List<string> listNamesOrdered;
            do
            {
                var names = new List<RandomNames>();
                listNamesOrdered = namesList.OrderBy(i => Guid.NewGuid()).Select(x => x).ToList();
            } while (listNamesOrdered.Equals(namesList));
            
            return listNamesOrdered;
        }
    }
    
    
}
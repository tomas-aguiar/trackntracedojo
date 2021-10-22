using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackNTraceDojo
{
    public class DojoHandler
    {
        private int Minutes { get; set; }
        private List<string> Names { get; set; }

        public List<string> GetNames() => Names;

        public void SetRotationTime(int minutes)
        {
            Minutes = minutes;
        }
<<<<<<< HEAD
=======

>>>>>>> 54d64ff6808a822034ac3cdafd1b7bea8bc7c0ac
        public int GetRotationTime()
        {
            return Minutes;
        }
<<<<<<< HEAD
        
=======

        public void SetRotationNames(List<string> names)
        {
            Names = names;
        }
>>>>>>> 54d64ff6808a822034ac3cdafd1b7bea8bc7c0ac
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
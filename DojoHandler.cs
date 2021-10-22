using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackNTraceDojo
{
    public class DojoHandler
    {
        public static List<string> GetNames() => new List<string>
            {"Tomás", "Lucas", "Samuel", "Henrique", "Saulo", "Caio"};
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
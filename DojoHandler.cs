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
            List<string> list;
            do
            {
                var names = new List<RandomNames>();
                namesList.ForEach(x => names.Add(new RandomNames {Id = Guid.NewGuid(), Name = x}));
                list = names.OrderBy(i => i.Id).Select(x => x.Name).ToList();
            } while (!list.Equals(namesList));
            
            return list;
        }
    }
}
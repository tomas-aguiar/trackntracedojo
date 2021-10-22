using System.Collections.Generic;
using TrackNTraceDojo;
using Xunit;

namespace TrackNTraceDojoTests
{
    public class DojoHandlerTest
    {
        [Fact]
        public void GetsTheListOfNames()
        {
            var result = DojoHandler.GetNames();

            Assert.Equal(6, result.Count);
        }

        [Fact]
        public void GetListOfRandomNames()
        {
            var names = new List<string>
            {
                "name1",
                "name2",
                "name3"
            };
            var namesList = Sort.Randomize(names);

            Assert.NotEqual(names, namesList);
        }

        [Fact]
        public void GetRotationTime()
        {
            var time = DojoHandler.GetRotationTime();
            Assert
        }
    }
}
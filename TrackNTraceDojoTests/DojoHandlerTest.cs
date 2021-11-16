using System.Collections.Generic;
using TrackNTraceDojo;
using Xunit;

namespace TrackNTraceDojoTests
{

    public class DojoHandlerTest
    {
        private readonly DojoHandler _dojoHandlerInstance;

        public DojoHandlerTest()
        {
            _dojoHandlerInstance = new DojoHandler();
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
            var dojoHandlerInstance = new DojoHandler();
            dojoHandlerInstance.SetRotationTime(5);
            var time = dojoHandlerInstance.GetRotationTime();
            Assert.True(time >= 0);
        }

        [Fact]
        public void SetNamesForRotation()
        {
            var names = new List<string>
            {
                "name1",
                "name2",
                "name3"
            };
            
            _dojoHandlerInstance.SetRotationNames(names);
            var rotationList = _dojoHandlerInstance.GetNames();
            
            Assert.Equal(names, rotationList);
            Assert.Equal(names.Count, rotationList.Count);
        }
    }
}
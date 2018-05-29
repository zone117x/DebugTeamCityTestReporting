using System;
using Xunit;

namespace DebugTeamCityTestReporting
{
    public class ExampleUnitTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true, "example passing test");
        }

        [Fact]
        public void AnotherPassingTest()
        {
            Assert.False(false, "another passing test");
        }

        /*
        [Fact]
        public void FailingTest()
        {
            Assert.True(false, "example failing test");
        }
        */
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DebugTeamCityTestReporting
{
    [TestClass]
    public class ExampleUnitTest
    {
        [TestMethod]
        public void PassingTest()
        {
            Assert.IsTrue(true, "example passing test");
        }

        [TestMethod]
        public void AnotherPassingTest()
        {
            Assert.IsFalse(false, "another passing test");
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

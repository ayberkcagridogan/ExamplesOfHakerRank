using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class ViralAdvertising
    {
        [TestMethod]
        public void ViralAdvertisingTest_Case1()
        {
            int day = 5;

            var actual = new ExamplesOfHackerRank.Examples.ViralAdvertising().GetReceiveAdvertisement(day);

            var expected = 24;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ViralAdvertisingTest_Case2()
        {
            int day = 3;

            var actual = new ExamplesOfHackerRank.Examples.ViralAdvertising().GetReceiveAdvertisement(day);

            var expected = 9;

            Assert.AreEqual(expected, actual);
        }
    }
}

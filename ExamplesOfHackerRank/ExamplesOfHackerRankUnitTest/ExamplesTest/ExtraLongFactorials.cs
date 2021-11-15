using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class ExtraLongFactorials
    {
        [TestMethod]
        public void ExtraLongFactorialsTest_Case1()
        {
            int n = 3;

            var actual = new ExamplesOfHackerRank.Examples.ExtraLongFactorials();

            actual.CalculateFactorials(n);

            var expected = "6";

            Assert.AreEqual(expected, actual.Result);

        }

        [TestMethod]
        public void ExtraLongFactorialsTest_Case2()
        {
            int n = 25;

            var actual = new ExamplesOfHackerRank.Examples.ExtraLongFactorials();

            actual.CalculateFactorials(n);

            var expected = "15511210043330985984000000";

            Assert.AreEqual(expected, actual.Result);

        }
    }
}

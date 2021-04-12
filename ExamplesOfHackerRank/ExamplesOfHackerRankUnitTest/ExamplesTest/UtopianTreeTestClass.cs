using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class UtopianTreeTestClass
    {
        [TestMethod]
        public void UtopianTreeTest_Case1()
        {
            int cycle = 0;

            var actual = new UtopianTree().GetTreeHeight(cycle);

            var expected = 1;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void UtopianTreeTest_Case2()
        {
            int cycle = 1;

            var actual = new UtopianTree().GetTreeHeight(cycle);

            var expected = 2;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void UtopianTreeTest_Case3()
        {
            int cycle = 4;

            var actual = new UtopianTree().GetTreeHeight(cycle);

            var expected = 7;

            Assert.AreEqual(expected, actual);

        }
    }
}

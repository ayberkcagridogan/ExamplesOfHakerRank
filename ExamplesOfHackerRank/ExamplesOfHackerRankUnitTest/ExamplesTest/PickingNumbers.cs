using System;
using System.Collections.Generic;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class PickingNumbers
    {
        [TestMethod]
        public void PickingNumberTest_Case1()
        {
            var a = new List<int>() { 4,6,5,3,3,1};
 

            int actula = new ExamplesOfHackerRank.Examples.PickingNumbers().FindMaxSubArray(a);
 
            int expected = 3;

            Assert.AreEqual(expected, actula);

        }

        [TestMethod]
        public void PickingNumberTest_Case2()
        {
            var a = new List<int>() { 1, 2,2,3,1,2};

            int actual = new ExamplesOfHackerRank.Examples.PickingNumbers().FindMaxSubArray(a);

            int expected = 5;
            Assert.AreEqual(expected, actual);

        }
    }
}

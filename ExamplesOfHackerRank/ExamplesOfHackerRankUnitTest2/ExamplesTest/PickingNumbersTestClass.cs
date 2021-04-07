using System;
using System.Collections.Generic;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class PickingNumbersTestClass
    {
        [TestMethod]
        public void PickingNumberTest_Case1()
        {
            var a = new List<int>() { 4,6,5,3,3,1};
            int expect = 3;

            var picknumbers = new PickingNumbers();

           int result = picknumbers.pickingNumbers(a);

            Assert.AreEqual(expect, result);

        }

        [TestMethod]
        public void PickingNumberTest_Case2()
        {
            var a = new List<int>() { 1, 2,2,3,1,2};
            int expect = 5;

            var picknumbers = new PickingNumbers();

            int result = picknumbers.pickingNumbers(a);

            Assert.AreEqual(expect, result);

        }
    }
}

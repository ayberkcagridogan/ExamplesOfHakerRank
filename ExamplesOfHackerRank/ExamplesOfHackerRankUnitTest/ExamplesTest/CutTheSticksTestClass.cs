using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class CutTheSticksTestClass
    {
        [TestMethod]
        public void CutTheSticksTest_Case1()
        {

            List<int> arr = new List<int> { 5, 4, 4, 2, 2, 8 };

            var actual = new CutTheSticks().FindCutOperation(arr);

            List<int> expected = new List<int> { 6, 4, 2, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CutTheSticksTest_Case2()
        {

            List<int> arr = new List<int> { 1, 2, 3 ,4 ,3 ,3 ,2 ,1 };

            var actual = new CutTheSticks().FindCutOperation(arr);

            List<int> expected = new List<int> { 8, 6, 4, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CutTheSticksTest_Case3()
        {

            List<int> arr = new List<int> { 8 ,8 ,14, 10 ,3 ,5 ,14, 12 };

            var actual = new CutTheSticks().FindCutOperation(arr);

            List<int> expected = new List<int> { 8, 7, 6, 4, 3, 2 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

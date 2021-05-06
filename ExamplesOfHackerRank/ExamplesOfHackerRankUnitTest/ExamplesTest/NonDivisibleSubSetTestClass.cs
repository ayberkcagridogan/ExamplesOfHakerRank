using System;
using System.Collections.Generic;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class NonDivisibleSubSetTestClass
    {
        [TestMethod]
        public void NonDivisibleSubsetTest_Case1()
        {
            int divisor = 3;
            List<int> set = new List<int> { 1, 7,2,4 };

            var actual = new NonDivisibleSubSet().FindMaxSubsetCount(divisor, set);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NonDivisibleSubSetTest_Case2()
        {
            int divisor = 7;
            List<int> set = new List<int> { 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 };

            var actual = new NonDivisibleSubSet().FindMaxSubsetCount(divisor, set);

            var expected = 11;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NonDivisibleSubSetTest_Case3()
        {
            int divisor = 1;
            List<int> set = new List<int> { 1 ,2, 3, 4, 5};

            var actual = new NonDivisibleSubSet().FindMaxSubsetCount(divisor, set);

            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NonDivisibleSubSetTest_Case4()
        {
            int divisor = 4;
            List<int> set = new List<int> { 1, 2, 3, 4, 5 ,6 ,7 ,8 ,9 ,10};

            var actual = new NonDivisibleSubSet().FindMaxSubsetCount(divisor, set);

            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}

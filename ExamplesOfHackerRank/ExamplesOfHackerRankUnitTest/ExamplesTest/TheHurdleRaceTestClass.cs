using System;
using System.Collections.Generic;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class TheHurdleRaceTestClass
    {
        [TestMethod]
        public void PickingNumberTest_Case1()
        {

            var k = 4;
            var height = new int[] { 1 ,6 , 3 ,5 , 2};


            var actual = new TheHurdleRace().FindMaxSupport(k, height);

            var expected = 2;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PickingNumberTest_Case2()
        {

            var k = 7;
            var height = new int[] { 2 , 5, 4, 5, 2};


            var actual = new TheHurdleRace().FindMaxSupport(k, height);

            var expected = 0;

            Assert.AreEqual(expected, actual);

        }
    }
}

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


            var result = new TheHurdleRace().FindMaxSupport(k, height);

            var expect = 2;

            Assert.AreEqual(expect, result);

        }

        [TestMethod]
        public void PickingNumberTest_Case2()
        {

            var k = 7;
            var height = new int[] { 2 , 5, 4, 5, 2};


            var result = new TheHurdleRace().FindMaxSupport(k, height);

            var expect = 0;

            Assert.AreEqual(expect, result);

        }
    }
}

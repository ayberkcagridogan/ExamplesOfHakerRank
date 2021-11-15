using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class JumpingOnClouds
    {
        [TestMethod]
        public void JumpingOnCloudsTest_Case1()
        {
            int[] p = { 0, 0, 1, 0, 0, 1, 1, 0 };
            int k = 2;

            var actual = new ExamplesOfHackerRank.Examples.JumpingOnClouds().CalculateEnergy(p, k);

            var expected = 92;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JumpingOnCloudsTest_Case2()
        {
            int[] p = { 1 ,1 ,1 ,0 ,1 ,1 ,0 ,0 ,0 ,0 };
            int k = 3;

            var actual = new ExamplesOfHackerRank.Examples.JumpingOnClouds().CalculateEnergy(p, k);

            var expected = 80;

            Assert.AreEqual(expected, actual);
        }
    }
}

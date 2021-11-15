using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class JumpingOnClouds2{

        [TestMethod]
        public void JumpingOnClouds2Test_Case1(){

            List<int> clouds = new List<int> { 0, 0, 0, 0, 1, 0 };

            var actual = new ExamplesOfHackerRank.Examples.JumpingOnClouds2().FindTheLeastJump(clouds);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JumpingOnClouds2Test_Case2()
        {

            List<int> clouds = new List<int> { 0 ,0 ,1 ,0 ,0 ,1 ,0 };

            var actual = new ExamplesOfHackerRank.Examples.JumpingOnClouds2().FindTheLeastJump(clouds);

            var expected = 4;

            Assert.AreEqual(expected, actual);
        }
    }
}

using System.Collections.Generic;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest{

    [TestClass]
    public class MinimumDistanceTestClass {

        [TestMethod]
        public void MinimumDistanceTest_Case1(){

            var a = new List<int>{7, 1, 3, 4, 1, 7};

            var actual =  new MinimumDistance().minimumDistances(a);

            var expected = 3;

            Assert.AreEqual(expected , actual);

        }
        [TestMethod]
        public void MinimumDistanceTest_Case2(){

            var a = new List<int>{3,2,1,2,3};

            var actual =  new MinimumDistance().minimumDistances(a);

            var expected = 2;

            Assert.AreEqual(expected , actual);
            
        }
    }
}
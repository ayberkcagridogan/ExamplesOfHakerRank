using System.Collections.Generic;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class BeatifulTripletsTestClass
    {
        [TestMethod]
        public void BeatifulTriplets_Case1(){

            var arr = new List<int>{1, 2, 4, 5, 7, 8, 10 };
            var d = 3;

            var actual = new BeatifulTriplets().beautifulTriplets(d , arr);

            var expected = 3;

            Assert.AreEqual(expected , actual);
        }
        [TestMethod]
        public void BeatifulTriplets_Case2(){

            var arr = new List<int>{1, 2, 3, 4, 5};
            var d = 1;

            var actual = new BeatifulTriplets().beautifulTriplets(d , arr);

            var expected = 3;

            Assert.AreEqual(expected , actual);
        }

                [TestMethod]
        public void BeatifulTriplets_Case3(){

            var arr = new List<int>{1, 2, 3, 4, 5, 7, 7, 7, 8,9,11 };
            var d = 4;

            var actual = new BeatifulTriplets().beautifulTriplets(d , arr);

            var expected = 2;

            Assert.AreEqual(expected , actual);
        }
        
    }
}
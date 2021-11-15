using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest{

    [TestClass]
    public class HalloweenSellTestClass{
        
        [TestMethod]
        public void HalloweenSellTest_Case1(){

            var actual =  new HalloweenSell().howManyGames(20 , 3 , 6, 70);

            var expected = 5;

            Assert.AreEqual(expected , actual);
        }

        [TestMethod]
        public void HalloweenSellTest_Case2(){

            var actual =  new HalloweenSell().howManyGames(16,2,1,9981);

            var expected = 9917;

            Assert.AreEqual(expected , actual);
        }
    }
}
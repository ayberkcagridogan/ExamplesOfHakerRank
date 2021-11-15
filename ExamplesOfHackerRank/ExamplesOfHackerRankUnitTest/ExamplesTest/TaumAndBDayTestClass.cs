using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class TaumAndBDayTestClass
    {
        [TestMethod]
        public void TaumAndBDayTestClass_Case1(){
            var actual =  new TaumAndBDay().taumBday(7,7,4,2,1);

            var expected = 35;

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void TaumAndBDayTestClass_Case2(){
            var actual =  new TaumAndBDay().taumBday(3,5,3,4,1);

            var expected = 29;

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TaumAndBDayTestClass_Case3(){
            var actual =  new TaumAndBDay().taumBday(27984,1402,619246,615589,247954);

            var expected = 18192035842;

            Assert.AreEqual(expected,actual);
        }
    }
}
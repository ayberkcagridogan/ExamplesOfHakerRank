using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{

    [TestClass]
    public class ChocolateFeastTestClass
    {
        [TestMethod]
        public void ChocolateFeastTest_TestCasa1()
        {
            int n = 15;
            int c = 3;
            int m = 2;

            var actual = new ChocolateFeast().chocolateFeast(n, c, m);

            var expected = 9;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ChocolateFeastTest_TestCasa2()
        {
            int n = 10;
            int c = 2;
            int m = 5;

            var actual = new ChocolateFeast().chocolateFeast(n, c, m);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ChocolateFeastTest_TestCasa3()
        {
            int n = 12;
            int c = 4;
            int m = 4;

            var actual = new ChocolateFeast().chocolateFeast(n, c, m);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ChocolateFeastTest_TestCasa4()
        {
            int n = 6;
            int c = 2;
            int m = 2;

            var actual = new ChocolateFeast().chocolateFeast(n, c, m);

            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}
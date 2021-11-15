using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class BiggerIsGreater
    {
        [TestMethod]
        public void BiggerIsGreaterTest_Case1()
        {
            string word = "hefg";

            var actual = new ExamplesOfHackerRank.Examples.BiggerIsGreater().FindBigger(word);

            var expected = "hegf";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BiggerIsGreaterTest_Case2()
        {
            string word = "bb";

            var actual = new ExamplesOfHackerRank.Examples.BiggerIsGreater().FindBigger(word);

            var expected = "no answer";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BiggerIsGreaterTest_Case3()
        {
            string word = "lmno";

            var actual = new ExamplesOfHackerRank.Examples.BiggerIsGreater().FindBigger(word);

            var expected = "lmon";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BiggerIsGreaterTest_Case4()
        {
            string word = "dcba";

            var actual = new ExamplesOfHackerRank.Examples.BiggerIsGreater().FindBigger(word);

            var expected = "no answer";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BiggerIsGreaterTest_Case5()
        {
            string word = "dcbb";

            var actual = new ExamplesOfHackerRank.Examples.BiggerIsGreater().FindBigger(word);

            var expected = "no answer";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BiggerIsGreaterTest_Case6()
        {
            string word = "abdc";

            var actual = new ExamplesOfHackerRank.Examples.BiggerIsGreater().FindBigger(word);

            var expected = "acbd";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BiggerIsGreaterTest_Case7()
        {
            string word = "abcd";

            var actual = new ExamplesOfHackerRank.Examples.BiggerIsGreater().FindBigger(word);

            var expected = "abdc";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BiggerIsGreaterTest_Case8()
        {
            string word = "dkhc";

            var actual = new ExamplesOfHackerRank.Examples.BiggerIsGreater().FindBigger(word);

            var expected = "hcdk";

            Assert.AreEqual(expected, actual);

        }
    }
}

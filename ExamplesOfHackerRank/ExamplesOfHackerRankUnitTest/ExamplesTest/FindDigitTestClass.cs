using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class FindDigitTestClass
    {
        [TestMethod]
        public void FindDigitTest_Case1() {

            int n = 124;

            var actual = new FindDigit().FindDigits(n);

            var expected = 3;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindDigitTest_Case2()
        {

            int n = 12;

            var actual = new FindDigit().FindDigits(n);

            var expected = 2;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindDigitTest_Case3()
        {

            int n = 1012;

            var actual = new FindDigit().FindDigits(n);

            var expected = 3;

            Assert.AreEqual(expected, actual);

        }
    }
}

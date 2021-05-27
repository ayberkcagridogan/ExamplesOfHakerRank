using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class LibraryFineTestClass {

        [TestMethod]
        public void LibraryFineTest_Case1() {

            int d1 = 9, m1 = 6, y1 = 2015, d2 = 6, m2 = 6, y2 = 2015;

            var actual = new LibraryFine().CalculateFine(d1, m1, y1, d2, m2, y2);

            var expected = 45;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void LibraryFineTest_Case2()
        {

            int d1 = 6, m1 = 6, y1 = 2015, d2 = 6, m2 = 6, y2 = 2015;

            var actual = new LibraryFine().CalculateFine(d1, m1, y1, d2, m2, y2);

            var expected = 0;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void LibraryFineTest_Case3()
        {

            int d1 = 1, m1 = 1, y1 = 2016, d2 = 31, m2 = 12, y2 = 2015;

            var actual = new LibraryFine().CalculateFine(d1, m1, y1, d2, m2, y2);

            var expected = 10000;

            Assert.AreEqual(expected, actual);

        }
    }
}

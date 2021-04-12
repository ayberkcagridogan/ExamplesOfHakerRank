﻿using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class BeautifulDaysAtTheMoviesTestClass
    {
        [TestMethod]
        public void BeautifulDaysAtTheMoviesTest_Case1()
        {
            int startDay = 20;
            int endDay = 23;
            int divisor = 6;

            var actual = new BeautifulDaysAtTheMovies().BeatifulDaysCount(startDay, endDay, divisor);

            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}

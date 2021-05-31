using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class SherlockAndSquares
    {
        [TestMethod]
        public void SherlockAndSquaresTest_Case1() {

            int a = 3;
            int b = 9;

            var actual = new ExamplesOfHackerRank.Examples.SherlockAndSquares().CountSquares(a, b);

            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}

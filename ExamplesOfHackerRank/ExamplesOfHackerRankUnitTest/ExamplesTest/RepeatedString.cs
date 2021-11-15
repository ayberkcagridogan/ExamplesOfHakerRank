using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class RepeatedString{

        [TestMethod]
        public void RepeatedStringTest_Case1(){

            string s = "aba";
            long n = 10;

            var actual = new ExamplesOfHackerRank.Examples.RepeatedString().CountRepeatedString(s, n);

            var expected = 7;

            Assert.AreEqual(expected, actual);

        }
    }
}

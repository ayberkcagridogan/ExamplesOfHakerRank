using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class Task1TestClass
    {
        [TestMethod]
        public void SequenceEquationTest_Case1()
        {

            string[] args = { "--help", "--name", "aaa", "--count", "10" };

            var expected = 1;

            var actual = new Task1().Validate(args);

            Assert.AreEqual(expected, actual);

        }
    }
}

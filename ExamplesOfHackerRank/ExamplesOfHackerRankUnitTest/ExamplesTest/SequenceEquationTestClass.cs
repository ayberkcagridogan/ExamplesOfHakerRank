using System;
using System.Collections.Generic;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class SequenceEquationTestClass
    {
        [TestMethod]
        public void SequenceEquationTest_Case1()
        {
            List<int> p = new List<int> { 4, 3, 5, 1, 2 };

            var actual = new SequenceEquation().permutationEquation(p);

            List<int> expected = new List<int> { 1, 3, 5, 4, 2 };

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}

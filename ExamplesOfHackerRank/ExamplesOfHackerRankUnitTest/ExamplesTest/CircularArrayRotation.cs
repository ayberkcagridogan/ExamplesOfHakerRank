using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class CircularArrayRotation
    {
        [TestMethod]
        public void CircularArrayRotationTest_Case1()
        {
            int[] array = { 1, 2, 3 };
            int rotationCount = 2;
            int[] queries = { 0, 1, 2 };

            var actual = new ExamplesOfHackerRank.Examples.CircularArrayRotation().GetRotationArray(array, rotationCount, queries);

            int[] expected = { 2, 3, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

    }
}

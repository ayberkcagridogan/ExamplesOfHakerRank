using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class SaveThePrisonerTestClass
    {
        [TestMethod]
        public void SaveThePrisonerTest_Case1()
        {
            int prisoners = 7;
            int pieceOfCandy = 19;
            int start = 2;

            var actual = new SaveThePrisoner().GetPersonToBeWarned(prisoners, pieceOfCandy, start);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SaveThePrisonerTest_Case2()
        {
            int prisoners = 5;
            int pieceOfCandy = 2;
            int start = 1;

            var actual = new SaveThePrisoner().GetPersonToBeWarned(prisoners, pieceOfCandy, start);

            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

    }
}

  

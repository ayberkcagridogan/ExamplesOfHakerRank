using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class AngryProfessorTestClass
    {
        [TestMethod]
        public void AngryProfessorTest_Case1()
        {
            int minParticipantStudent = 3;
            int[] studentsArrivalTime = {-1, -3 , 4, 2};

            var actual = new AngryProfessor().IsClassCancel(minParticipantStudent, studentsArrivalTime);

            var expected = "YES";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AngryProfessorTest_Case2()
        {
            int minParticipantStudent = 2;
            int[] studentsArrivalTime = { 0, - 1, 2 ,1 };

            var actual = new AngryProfessor().IsClassCancel(minParticipantStudent, studentsArrivalTime);

            var expected = "NO";

            Assert.AreEqual(expected, actual);
        }
    }
}

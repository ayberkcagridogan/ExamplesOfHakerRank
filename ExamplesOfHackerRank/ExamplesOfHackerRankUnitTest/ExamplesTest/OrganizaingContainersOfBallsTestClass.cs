using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class OrganizaingContainersOfBallsTestClass
    {
        [TestMethod]
        public void OrganizaingContainersOfBallsTest_Case1()
        {
            int[][] obstacles = new int[][]
                {
                    new int[] {1, 3, 1} ,
                    new int[] {2 ,1, 2} ,
                    new int[] {3 ,3 ,3}
                };

            var actual = new OrganizingContainersOfBalls().IsPossible(obstacles);

            var expected = "Impossible";


            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void OrganizaingContainersOfBallsTest_Case2()
        {
            int[][] obstacles = new int[][]
                {
                    new int[] {0, 2, 1} ,
                    new int[] {1 ,1, 1} ,
                    new int[] {2 ,0 ,0}
                };

            var actual = new OrganizingContainersOfBalls().IsPossible(obstacles);

            var expected = "Possible";


            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void OrganizaingContainersOfBallsTest_Case3()
        {
            int[][] obstacles = new int[][]
                {
                    new int[] {1, 4} ,
                    new int[] {2 ,3} 
                };

            var actual = new OrganizingContainersOfBalls().IsPossible(obstacles);

            var expected = "Impossible";


            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void OrganizaingContainersOfBallsTest_Case4()
        {
            int[][] obstacles = new int[][]
                {
                    new int[] {1, 1} ,
                    new int[] {1 ,1}
                };

            var actual = new OrganizingContainersOfBalls().IsPossible(obstacles);

            var expected = "Possible";


            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void OrganizaingContainersOfBallsTest_Case5()
        {
            int[][] obstacles = new int[][]
                {
                   new int[] {993263231 ,806455183, 972467746 ,761846174 ,226680660 ,667393859 ,815298761 ,790313908 ,997845516},
                   new int[] {873142072 ,579210472, 996344520 ,999601755 ,904458846 ,663577990 ,980240637 ,713052540 ,963408591},
                   new int[] {551159221 ,873763794, 752756532 ,798803609 ,670921889 ,995259612 ,981339960 ,763904498 ,499472207},
                   new int[] {975980611 ,999974039, 729219884 ,834636710 ,973988213 ,969888254 ,846967495 ,687204298 ,511348404},
                   new int[] {993232608 ,998103218, 857820670 ,995587240 ,817798750 ,773950980 ,824882180 ,797565274 ,887424441},
                   new int[] {847857578 ,768853671, 916073200 ,982234748 ,986511977 ,733420232 ,997714976 ,819799716 ,891570083},
                   new int[] {733197334 ,985682497, 612123868 ,971798655 ,999905357 ,710092446 ,997494889 ,683312998 ,850074746},
                   new int[] {799093993 ,543648222, 944524289 ,814951921 ,981087922 ,997222915 ,506561779 ,997697933 ,652807674},
                   new int[] {989362549 ,973516812, 891706714 ,786904549 ,982329176 ,376575034 ,993535504 ,984745483 ,777613376}
                };

            var actual = new OrganizingContainersOfBalls().IsPossible(obstacles);

            var expected = "Possible";


            Assert.AreEqual(expected, actual);

        }
    }
}

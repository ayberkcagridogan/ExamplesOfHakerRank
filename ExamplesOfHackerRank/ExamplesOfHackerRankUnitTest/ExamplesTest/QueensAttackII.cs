using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class QueensAttackII
    {
        [TestMethod]
        public void QueensAttackIITest_Case1()
        {
            int n = 4;
            int obstacleCount = 0;
            int rowQueen = 4;
            int columnQueen = 4;
            int[][] obstacles = null;


            var actual = new ExamplesOfHackerRank.Examples.QueensAttackII().FindQueenAttackCount(n, obstacleCount, rowQueen, columnQueen, obstacles);

            var expected = 9;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QueensAttackIITest_Case2()
        {
            int n = 5;
            int obstacleCount = 3;
            int rowQueen = 4;
            int columnQueen = 3;
            int[][] obstacles = new int[][]
            {
                new int[] {5 ,5} ,
                new int[] {4 ,2} ,
                new int[] {2 ,3} 
            };


            var actual = new ExamplesOfHackerRank.Examples.QueensAttackII().FindQueenAttackCount(n, obstacleCount, rowQueen, columnQueen, obstacles);

            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QueensAttackIITest_Case3()
        {
            int n = 1;
            int obstacleCount = 0;
            int rowQueen = 1;
            int columnQueen = 1;
            int[][] obstacles = null;


            var actual = new ExamplesOfHackerRank.Examples.QueensAttackII().FindQueenAttackCount(n, obstacleCount, rowQueen, columnQueen, obstacles);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QueensAttackIITest_Case4()
        {
            int n = 100000;
            int obstacleCount = 0;
            int rowQueen = 4187;
            int columnQueen = 5068;
            int[][] obstacles = null;


            var actual = new ExamplesOfHackerRank.Examples.QueensAttackII().FindQueenAttackCount(n, obstacleCount, rowQueen, columnQueen, obstacles);

            var expected = 308369;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QueensAttackIITest_Case5()
        {
            int n = 100;
            int obstacleCount = 100;
            int rowQueen = 48;
            int columnQueen = 81;
            int[][] obstacles =
            {
                new int [] {54, 87},
new int [] {64, 97},
new int [] {42, 75},
new int [] {32, 65},
new int [] {42, 87},
new int [] {32, 97},
new int [] {54, 75},
new int [] {64, 65},
new int [] {48, 87},
new int [] {48, 75},
new int [] {54, 81},
new int [] {42, 81},
new int [] {45, 17},
new int [] {14, 24},
new int [] {35, 15},
new int [] {95, 64},
new int [] {63, 87},
new int [] {25, 72},
new int [] {71, 38},
new int [] {96, 97},
new int [] {16, 30},
new int [] {60, 34},
new int [] {31, 67},
new int [] {26, 82},
new int [] {20, 93},
new int [] {81, 38},
new int [] {51, 94},
new int [] {75, 41},
new int [] {79, 84},
new int [] {79, 65},
new int [] {76, 80},
new int [] {52, 87},
new int [] {81, 54},
new int [] {89, 52},
new int [] {20, 31},
new int [] {10, 41},
new int [] {32, 73},
new int [] {83, 98},
new int [] {87, 61},
new int [] {82, 52},
new int [] {80, 64},
new int [] {82, 46},
new int [] {49, 21},
new int [] {73, 86},
new int [] {37, 70},
new int [] {43, 12},
new int [] {94, 28},
new int [] {10, 93},
new int [] {52, 25},
new int [] {50, 61},
new int [] {52, 68},
new int [] {52, 23},
new int [] {60, 91},
new int [] {79, 17},
new int [] {93, 82},
new int [] {12, 18},
new int [] {75, 64},
new int [] {69, 69},
new int [] {94, 74},
new int [] {61, 61},
new int [] {46, 57},
new int [] {67, 45},
new int [] {96, 64},
new int [] {83, 89},
new int [] {58, 87},
new int [] {76, 53},
new int [] {79, 21},
new int [] {94, 70},
new int [] {16, 10},
new int [] {50, 82},
new int [] {92, 20},
new int [] {40, 51},
new int [] {49, 28},
new int [] {51, 82},
new int [] {35, 16},
new int [] {15, 86},
new int [] {78, 89},
new int [] {41, 98},
new int [] {70, 46},
new int [] {79, 79},
new int [] {24, 40},
new int [] {91, 13},
new int [] {59, 73},
new int [] {35, 32},
new int [] {40, 31},
new int [] {14, 31},
new int [] {71, 35},
new int [] {96, 18},
new int [] {27, 39},
new int [] {28, 38},
new int [] {41, 36},
new int [] {31, 63},
new int [] {52, 48},
new int [] {81, 25},
new int [] {49, 90},
new int [] {32, 65},
new int [] {25, 45},
new int [] {63, 94},
new int [] {89, 50},
new int [] {43, 41}
            };


            var actual = new ExamplesOfHackerRank.Examples.QueensAttackII().FindQueenAttackCount(n, obstacleCount, rowQueen, columnQueen, obstacles);

            var expected = 40;

            Assert.AreEqual(expected, actual);
        }
    }
}

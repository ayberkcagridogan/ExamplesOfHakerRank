using System;
using System.Collections.Generic;
using Xunit;
using ExamplesOfHackerRank.Examples;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    public class PickingNumbersTestClass
    {
        [Fact]
        public void PickingNumberTest_Case1()
        {
            var a = new List<int>() { 1, 2, 4, 6, 6, 7 };

            var picknumbers = new PickingNumbers();

            picknumbers.pickingNumbers(a);


        }
    }
}

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest{

    [TestClass]
    public class LisaWorkbook{

        [TestMethod]
        public void GetPageCountTest_Case1(){

            List<int> arr = new List<int>{4 , 2 , 6 , 1, 10};
            int n = 5;
            int k = 3;

            var actual = new ExamplesOfHackerRank.Examples.LisaWorkbook().getPageCount(n,k,arr);

            var expected = 4;

            Assert.AreEqual(expected , actual);


        }
    }
}
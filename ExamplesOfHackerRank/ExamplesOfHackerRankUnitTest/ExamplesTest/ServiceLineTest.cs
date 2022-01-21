using System.Collections.Generic;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest{

    [TestClass]
    public class ServiceLineTest{

        [TestMethod]
        public void ServiceLineTest_Case1(){

            var n = 8;
            var cases = new List<List<int>> 
                                                {
                                                    new List<int>  {0, 3} ,
                                                    new List<int>  {4, 6} ,
                                                    new List<int>  {6, 7} ,
                                                    new List<int>  {3, 5} ,
                                                    new List<int>  {0, 7} ,
                                                };
            var width = new List<int>  {2 ,3 ,1 ,2 ,3 ,2 ,3 ,3};
            var actual = new ServiceLine().serviceLane(n , cases , width);

            var expect = new List<int>{1,2,3,2,1};

            CollectionAssert.AreEqual(expect , actual);
        }
    }
}

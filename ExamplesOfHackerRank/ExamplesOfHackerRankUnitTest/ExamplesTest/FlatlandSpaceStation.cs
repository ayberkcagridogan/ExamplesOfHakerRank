using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest{

    [TestClass]
    public class FlatlandSpaceStation{

        [TestMethod]
        public void FlatlandSpaceStation_Case1(){

            int n = 5;
            int[] c = {0,4};

            var actual = new ExamplesOfHackerRank.Examples.FlatlandSpaceStation().findMaxDistance(n , c);

            var expected = 2;

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void FlatlandSpaceStation_Case2(){

            int n = 100;
            int[] c = {93 ,41, 91, 61, 30, 6 ,25, 90, 97};
        
            var actual = new ExamplesOfHackerRank.Examples.FlatlandSpaceStation().findMaxDistance(n , c);

            var expected = 14;

            Assert.AreEqual(expected,actual);
        }
    }
}
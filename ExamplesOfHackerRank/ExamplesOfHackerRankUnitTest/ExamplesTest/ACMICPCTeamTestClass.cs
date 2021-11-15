using System.Collections.Generic;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest{

    [TestClass]
    public class ACMICPCTeamTestClass{

        [TestMethod]
        public void ACMICPCTeamTestClass_TestCase1(){

            List<string> topic = new List<string>{
"10101",
"11100",
"11010",
"00101"};
            var actual =  new ACMICPCTeam().acmTeam(topic);

            var expected =  new List<int>{5 ,2};

            CollectionAssert.AreEqual(expected , actual);

        }
                [TestMethod]
        public void ACMICPCTeamTestClass_TestCase2(){

            List<string> topic = new List<string>{
"10101",
"11110",
"00010"};
            var actual =  new ACMICPCTeam().acmTeam(topic);

            var expected =  new List<int>{5 ,1};

            CollectionAssert.AreEqual(expected , actual);

        }
    } 
}

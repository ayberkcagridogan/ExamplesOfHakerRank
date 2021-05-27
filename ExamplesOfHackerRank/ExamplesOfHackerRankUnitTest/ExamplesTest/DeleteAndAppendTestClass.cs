using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class DeleteAndAppendTestClass
    {
        [TestMethod]
        public void DeleteAndAppendTest_Case1(){

            string mainWord = "hackerhappy";
            string createdWord = "hackerrank";
            int k = 9;

            var actual = new DeleteAndAppend().IsItPossible(mainWord, createdWord, k);

            var expected = "Yes";

            Assert.AreEqual(expected , actual);
        }
       
       [TestMethod]
        public void DeleteAndAppendTest_Case2()
        {

            string mainWord = "aba";
            string createdWord = "aba";
            int k = 7;

            var actual = new DeleteAndAppend().IsItPossible(mainWord, createdWord, k);

            var expected = "Yes";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAndAppendTest_Case3()
        {

            string mainWord = "ashley";
            string createdWord = "ash";
            int k = 2;

            var actual = new DeleteAndAppend().IsItPossible(mainWord, createdWord, k);

            var expected = "No";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAndAppendTest_Case4()
        {

            string mainWord = "uoiauwrebgiwrhgiuawheirhwebvjforidkslweufgrhvjqasw";
            string createdWord = "vgftrheydkoslwezxcvdsqjkfhrydjwvogfheksockelsnbkeq";
            int k = 2;

            var actual = new DeleteAndAppend().IsItPossible(mainWord, createdWord, k);

            var expected = "No";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAndAppendTest_Case5()
        {

            string mainWord = "abcd";
            string createdWord = "abcdert";
            int k = 10;

            var actual = new DeleteAndAppend().IsItPossible(mainWord, createdWord, k);

            var expected = "No";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAndAppendTest_Case6()
        {

            string mainWord = "zzzzz";
            string createdWord = "zzzzzzz";
            int k = 4;

            var actual = new DeleteAndAppend().IsItPossible(mainWord, createdWord, k);

            var expected = "Yes";

            Assert.AreEqual(expected, actual);
        }
    }
}

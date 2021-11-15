using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class Encryption
    {
        [TestMethod]
        public void EncryptionTest_Case1()
        {
            string word = "have a nice day";

            var actual = new ExamplesOfHackerRank.Examples.Encryption().GetEncryptionWord(word);

            var expect = "hae and via ecy";

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void EncryptionTest_Case2()
        {
            string word = "chillout";

            var actual = new ExamplesOfHackerRank.Examples.Encryption().GetEncryptionWord(word);

            var expect = "clu hlt io";

            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void EncryptionTest_Case3()
        {
            string word = "feedthedog";

            var actual = new ExamplesOfHackerRank.Examples.Encryption().GetEncryptionWord(word);

            var expect = "fto ehg ee dd";

            Assert.AreEqual(expect, actual);
        }
    }
}

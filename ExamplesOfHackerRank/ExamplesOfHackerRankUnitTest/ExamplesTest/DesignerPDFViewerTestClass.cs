using System;
using ExamplesOfHackerRank.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class DesignerPDFViewerTestClass
    {
        [TestMethod]
        public void DesignerPDFViewerTest_Case1()
        {
            int[] heghlighted = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            string word = "abc";

            var actual = new DesignerPDFViewer().FindHighlightedText(heghlighted, word);

            var expected = 9;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DesignerPDFViewerTest_Case2()
        {
            int[] heghlighted = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            string word = "zaba";

            var actual = new DesignerPDFViewer().FindHighlightedText(heghlighted, word);

            var expected = 28;

            Assert.AreEqual(expected, actual);
        }
    }
}

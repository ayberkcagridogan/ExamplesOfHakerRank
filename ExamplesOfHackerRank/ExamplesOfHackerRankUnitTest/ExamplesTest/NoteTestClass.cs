using System;
using ExamplesOfHackerRank.CodeWars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesOfHackerRankUnitTest.ExamplesTest
{
    [TestClass]
    public class NoteTestClass
    {
        [TestMethod]
        public void NoteTest_Case1()
        {
            // Test tree:
            // 
            // 1
            // +-2
            //   +-3
            //   +-4
            // +-5
            //   +-6
            //   +-7
            //
            var lastNode = new Node(7);
            var tree = new Node(
                1,
                new Node(
                    2,
                    new Node(3),
                    new Node(4)),
                new Node(
                    5,
                    new Node(6),
                    lastNode));

            // Expected output:
            //
            // 7
            // 6
            // 5
            // 4
            // 3
            // 2
            // 1
            //
            var n = lastNode;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Previous();
            }

            // Test
            //
            n = lastNode;
            Assert.AreEqual(7, n.Data);
            n = n.Previous();
            Assert.AreEqual(6, n.Data);
            n = n.Previous();
            Assert.AreEqual(5, n.Data);
            n = n.Previous();
            Assert.AreEqual(4, n.Data);
            n = n.Previous();
            Assert.AreEqual(3, n.Data);
            n = n.Previous();
            Assert.AreEqual(2, n.Data);
            n = n.Previous();
            Assert.AreEqual(1, n.Data);
            n = n.Previous();
            Assert.IsNull(n);
        }

        [TestMethod]
        public void NoteTest_Case2()
        {
            // Test tree:
            // 
            // 1
            // +-2
            //   +-5
            // +-3
            //   +-6
            //      +-11
            //   +-7
            // +-4
            //    +-8
            //      +-12
            //      +-13
            //         +-15
            //    +-9
            //    +-10
            //      +-14

            var lastNode = new Node(14);
            var tree = new Node(
                1,
                new Node(
                    2,
                    new Node(5)),
                new Node(
                    3,
                    new Node(
                        6,
                        new Node(11)),
                    new Node(7)),
                new Node(
                    4,
                    new Node(
                        8,
                        new Node(12),
                        new Node(
                            13,
                            new Node(15))),
                    new Node(9),
                    new Node(
                        10,
                        lastNode)));

            // Expected output:
            //
            // 14
            // 10
            // 9
            // 15
            // 13
            // 12
            // 8
            // 4
            // 7
            // 11
            // 6
            // 3
            // 5
            // 2
            // 1
            var n = lastNode;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Previous();
            }

            // Test       
            n = lastNode;
            Assert.AreEqual(14, n.Data);
            n = n.Previous();
            Assert.AreEqual(10, n.Data);
            n = n.Previous();
            Assert.AreEqual(9, n.Data);
            n = n.Previous();
            Assert.AreEqual(15, n.Data);
            n = n.Previous();
            Assert.AreEqual(13, n.Data);
            n = n.Previous();
            Assert.AreEqual(12, n.Data);
            n = n.Previous();
            Assert.AreEqual(8, n.Data);
            n = n.Previous();
            Assert.AreEqual(4, n.Data);
            n = n.Previous();
            Assert.AreEqual(7, n.Data);
            n = n.Previous();
            Assert.AreEqual(11, n.Data);
            n = n.Previous();
            Assert.AreEqual(6, n.Data);
            n = n.Previous();
            Assert.AreEqual(3, n.Data);
            n = n.Previous();
            Assert.AreEqual(5, n.Data);
            n = n.Previous();
            Assert.AreEqual(2, n.Data);
            n = n.Previous();
            Assert.AreEqual(1, n.Data);
            n = n.Previous();
            Assert.IsNull(n);
        }

        [TestMethod]
        public void NoteTest_Case3()
        {
            // Test tree:
            // 
            // 1
            //  +-2
            //     +-3

            var lastNode = new Node(3);
            var tree = new Node(
                1,
                new Node(
                    2,
                  lastNode));

            // Expected output:
            //
            // 3
            // 2
            // 1
            //
            var n = lastNode;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Previous();
            }

            // Test       
            n = lastNode;
            Assert.AreEqual(3, n.Data);
            n = n.Previous();
            Assert.AreEqual(2, n.Data);
            n = n.Previous();
            Assert.AreEqual(1, n.Data);
            n = n.Previous();
            Assert.IsNull(n);
        }

        [TestMethod]
        public void NoteTest_Case4()
        {
            // Test tree:
            // 
            // Null

            Node node = null;

            // Test       
            node = node.Previous();
            Assert.IsNull(node);
        }
    }
}

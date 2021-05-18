using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ExamplesOfHackerRank.CodeWars
{
    public static class NodeExtensions
    {
        public static Node Previous(this Node node)
        {
            if (node == null) return null;

            var nodeParent = node.Parent;

            if (nodeParent == null) return null;


            var nodeIndex = nodeParent.Children.ToList().IndexOf(node);

            if (nodeIndex == 0)
            {
                return nodeParent;
            }

            var nodeSibling = nodeParent.Children.ToList()[nodeIndex - 1];

            if (nodeSibling.Children.Any())
            {
                return nodeSibling;
            }

            return  FindSiblingChildren(nodeSibling);
        }


        private static Node FindSiblingChildren(Node node)
        {
            if (node.Children.Any()) return node;

            return FindSiblingChildren(node.Children.ToList()[node.Children.Count() - 1]);
        }
    }
}

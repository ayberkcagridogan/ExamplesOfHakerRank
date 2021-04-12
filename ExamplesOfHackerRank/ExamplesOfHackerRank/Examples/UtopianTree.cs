using System;
namespace ExamplesOfHackerRank.Examples
{
    public class UtopianTree
    {

        public int GetTreeHeight(int cycle)
        {
            int treeHeight = 1;

            for (int i = 1; i <= cycle ; i++)
            {
                if (i % 2 == 1)
                {
                    treeHeight = treeHeight * 2; 
                }
                if (i % 2 == 0)
                {
                    treeHeight = treeHeight + 1;
                }
            }

            return treeHeight;
        }
    }
}

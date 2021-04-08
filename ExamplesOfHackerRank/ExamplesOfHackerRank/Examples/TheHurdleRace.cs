using System;
using ExamplesOfHackerRank.BusinessHelp;

namespace ExamplesOfHackerRank.Examples
{
    public class TheHurdleRace
    {

        public int FindMaxSupport(int k, int[] height)
        {

            int[] sortHeight = new HeapSort().Sort(height);

            if (sortHeight[sortHeight.Length - 1] - k <= 0 )
            {
                return 0;
            }

            if(sortHeight[sortHeight.Length - 1] - k > 0)
            {
                return sortHeight[sortHeight.Length - 1] - k;
            }

            return -1;

        }


    }
}

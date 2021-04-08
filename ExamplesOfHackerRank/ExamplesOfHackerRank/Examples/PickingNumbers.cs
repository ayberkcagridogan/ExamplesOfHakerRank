using System;
using System.Collections.Generic;

namespace ExamplesOfHackerRank.Examples
{
    public class PickingNumbers
    {

        public int FindMaxSubArray(List<int> a)
        {
            int result = 0;

            for (int i = 0; i < a.Count; i++)
            {
                int count = a.FindAll(x => x == a[i]).Count + a.FindAll(x => x == a[i] + 1).Count;

                if (count > result)
                {
                    result = count;
                }

            }
            return result;
        }
    }
}

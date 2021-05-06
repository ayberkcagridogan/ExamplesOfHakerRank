using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRank.Examples
{
    public class NonDivisibleSubSet
    {
        public int FindMaxSubsetCount(int divisor, List<int> set)
        {
            int result = 0;
            int[] mod = new int[divisor];

            for (int i = 0; i < set.Count; i++)
            {
                mod[set[i] % divisor]++;
            }

            if (mod.Length == 1)
            {
                return 1;
            }

            for (int i = 1; i <= mod.Length / 2; i++)
            {
                if (i == mod.Length - i)
                {
                    result++;
                }
                else
                {
                    result += mod[i] >= mod[mod.Length - i] ? mod[i] : mod[mod.Length - i];
                }
                
            }

            if(mod[0] > 0)
            {
                result++;
            }
            return result;
        }

    }
}

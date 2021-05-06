using System;
using System.Collections.Generic;

namespace ExamplesOfHackerRank.Examples
{
    public class OrganizingContainersOfBalls
    {
        public string IsPossible(int[][] container)
        {
            int n = container.Length;
            int[] sum1 = new int[n];
            int[] sum2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int temp = 0, temp2 = 0;
                for (int j = 0; j < n; j++)
                {
                    temp += container[i][j];
                    temp2 += container[j][i];
                }
                sum1[i] = temp;
                sum2[i] = temp2;
            }
            Array.Sort(sum1);
            Array.Sort(sum2);

            for (int i = 0; i < n; i++)
            {
                if (sum1[i] != sum2[i])
                {
                    return "Impossible";
                }
            }

            return "Possible";
            
        }
    }
}

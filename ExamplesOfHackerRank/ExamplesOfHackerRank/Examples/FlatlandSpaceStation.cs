using System;

namespace ExamplesOfHackerRank.Examples{

    public class FlatlandSpaceStation{

        public int findMaxDistance(int n, int[] c){

            if(n == c.Length) return 0;
            if(c.Length == 0) return n -1;

            int md = 0;
            Array.Sort(c);

            for (int i = 0; i < c.Length -1; i++)
            {
                if((c[i +1] - c[i]) / 2 > md) md = (c[i +1] - c[i]) / 2;
            }

            if(c[0] > md) md = c[0];

            if((n - c[c.Length - 1]) > md ) md = (n - c[c.Length - 1]) - 1;

            return md;
        }
    }
}
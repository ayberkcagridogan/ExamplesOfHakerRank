using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRank.Examples
{
    public class JumpingOnClouds {
       
        public int CalculateEnergy(int[] c, int k)
        {
            int energy = 100;
            int count = 0;

            do
            {
                count += k;

                energy -= 1;

                if (c[count % c.Length] == 1)
                {
                    energy -= 2;
                }

            } while (count % c.Length != 0);


            return energy;
        }
    } 
}

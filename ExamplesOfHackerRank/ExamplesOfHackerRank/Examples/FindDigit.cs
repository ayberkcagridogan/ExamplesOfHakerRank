using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRank.Examples
{
    public class FindDigit
    {
        public int FindDigits(int n)
        {
            int divisor = 10;
            List<int> digits = new List<int>();

            int calculateNumber = n;

            while (divisor / n < 10)
            {
             
                digits.Add((calculateNumber % divisor)/ (divisor/10));

                calculateNumber -= calculateNumber % divisor;
                divisor *= 10;
            }


            int countDigit = 0;

            foreach (var item in digits)
            {
                if (item != 0 && n % item == 0)
                {
                    countDigit++;
                }
            }

            return countDigit;
        }
    }
}

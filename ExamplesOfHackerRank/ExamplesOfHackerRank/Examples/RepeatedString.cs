using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRank.Examples
{
    public class RepeatedString{

        public long CountRepeatedString(string s , long n) {

            long repeatedStringCountInS = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
              if (s.Substring(i, 1) == "a")
                {
                    repeatedStringCountInS++;
                }
            }

            long countRepeatedString = (n / s.Length) * repeatedStringCountInS;

            for (int i = 0; i < (n % s.Length); i++)
            {
                if (s.Substring(i, 1) == "a")
                {
                    countRepeatedString++;
                }
            }

            return countRepeatedString;

        } 
    }
}

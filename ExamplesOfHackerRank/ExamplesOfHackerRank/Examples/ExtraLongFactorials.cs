using System;
using System.Numerics;

namespace ExamplesOfHackerRank.Examples
{
    public class ExtraLongFactorials
    {
        public string Result {
            get { return _calculateFactorials.ToString() ; }
        }

        BigInteger _calculateFactorials = 1;

        public void CalculateFactorials(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                _calculateFactorials *= i;

            }
        }

    }
}

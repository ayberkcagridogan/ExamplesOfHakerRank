using System;
namespace ExamplesOfHackerRank.Examples
{
    public class BeautifulDaysAtTheMovies
    {
        public int BeatifulDaysCount(int startDay, int endDay, int divisor)
        {
            int beatifulDaysCount = 0;

            for (int i = startDay; i <= endDay; i++)
            {
                if ((Math.Abs(i - Reserve(i)) % divisor) == 0)
                {
                    beatifulDaysCount++;
                }
            }

            return beatifulDaysCount;
        }

        private int Reserve(int value)
        {

            int reserveValue = 0;

            while (value > 0)
            {
                reserveValue = reserveValue * 10 + value % 10;
                value /= 10;
            }

            return reserveValue;
        }
    }
}


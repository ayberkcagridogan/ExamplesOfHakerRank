using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRank.Examples
{
    public class LibraryFine {


        public int CalculateFine(int d1, int m1, int y1, int d2, int m2, int y2) {

            if (y2 > y1) return 0;
            if (y2 == y1 && m2 > m1) return 0;
            if (y2 == y1 && m2 == m1 && d2 >= d1) return 0;

            int fine = 0;

            if (d1 > d2)
            {
                fine = 15 * (d1 - d2);
            }

            if (m1 > m2)
            {
                fine = 500 * (m1 - m2);
            }

            if (y1 > y2)
            {
                fine = 10000;
            }
            
            return fine;
        }

    }
}

using System;
namespace ExamplesOfHackerRank.Examples
{
    public class SaveThePrisoner
    {
        public int GetPersonToBeWarned(int prisoners , int pieceOfCandy , int start)
        {
<<<<<<< HEAD

            var result = (((start - 1) + pieceOfCandy -1) % prisoners) + 1;
=======
           // int personToBeWarned = (pieceOfCandy % prisoners) - 1 + start;
            var result = ((((start - 1) + pieceOfCandy - 1) % prisoners) + 1);
>>>>>>> 3623f9c8e2928d5352b8b6175db82fda19eafe7c

            return result;
        }
    }
}

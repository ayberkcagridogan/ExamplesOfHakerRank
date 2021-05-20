using System;
namespace ExamplesOfHackerRank.Examples
{
    public class SaveThePrisoner
    {
        public int GetPersonToBeWarned(int prisoners , int pieceOfCandy , int start)
        {
           // int personToBeWarned = (pieceOfCandy % prisoners) - 1 + start;
            var result = ((((start - 1) + pieceOfCandy - 1) % prisoners) + 1);

            return result;
        }
    }
}

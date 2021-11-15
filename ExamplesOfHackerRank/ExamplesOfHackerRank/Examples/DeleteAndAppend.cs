using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRank.Examples
{
    public  class DeleteAndAppend
    {
        public string IsItPossible(string mainWord , string createdWord , int k)
        {

            if (k >= (mainWord.Length + createdWord.Length)) return "Yes";

            if (mainWord.Substring(0, 1) != createdWord.Substring(0, 1)) return "No";

            int counter = 0;

            while (mainWord.Substring(counter, 1) == createdWord.Substring(counter, 1))
            {
                counter++;
                if (counter == createdWord.Length || counter == mainWord.Length) break;

            }

            int balance = mainWord.Length - counter;
            balance += createdWord.Length - counter;

            if (k >= balance && (k - balance) % 2 == 0) return "Yes";

            return "No";
            
        }
    }
}


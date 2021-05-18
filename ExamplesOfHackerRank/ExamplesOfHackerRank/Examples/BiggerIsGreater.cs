using System;
using System.Collections.Generic;
using ExamplesOfHackerRank.BusinessHelp;

namespace ExamplesOfHackerRank.Examples
{
    public class BiggerIsGreater
    {

        public string FindBigger(string word)
        {

            for (int pointLetter = word.Length - 1; 0 <= pointLetter; pointLetter--)
            {
                for (int checkLetter = pointLetter - 1; 0 <= checkLetter; checkLetter--)
                {
                    if (Compare(word.Substring(checkLetter, 1), word.Substring(pointLetter, 1)))
                    {
                        return Sort(word, pointLetter, checkLetter);

                    }
                }
            }

            return "no answer";

        }

        private bool Compare<T>(T letter1, T letter2) where T : IComparable<T>
        {

            if (letter2.CompareTo(letter1) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private string Sort(string word, int pointLetter, int checkLetter)
        {
            string[] wordArray = new string[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                wordArray[i] = word.Substring(i, 1);
            }

            Swap(wordArray, pointLetter, checkLetter);

      
            QuickSort(wordArray, checkLetter + 1 , wordArray.Length - 1);

            string returnVal = "";

            for (int i = 0; i < wordArray.Length; i++)
            {
                returnVal += wordArray[i];
            }

            return returnVal;
        }


        private string[] Swap(string[] wordArray, int pos0, int pos1)
        {
            string tempVal = wordArray[pos0];
            wordArray[pos0] = wordArray[pos1];
            wordArray[pos1] = tempVal;

            return wordArray;
        }

        private void QuickSort(string[] arr, int low, int high)
        {
            if (low < high)
            {
                // pi is partitioning index, arr[p]
                // is now at right place
                int pi = Partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(string[] arr , int low , int high)
        {
            string pivot = arr[high];

            // Index of smaller element and
            // indicates the right position
            // of pivot found so far
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                if (Compare(pivot ,arr[j]))
                {
                    i++;
                    Swap(arr, i + 1, j);
                }
            }

            Swap(arr, i + 1, high);

            return i + 1;
        }
    }
}

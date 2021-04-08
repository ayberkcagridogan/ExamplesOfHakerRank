using System;
using System.Collections.Generic;

namespace ExamplesOfHackerRank.BusinessHelp
{
    public class BinarySearch
    {
        public int Search(int searchValue, List<int> array)
        {

            if (searchValue < array[array.Count - 1])
            {
                return array.Count + 1;
            }

            if (searchValue > array[0])
            {
                return 1;
            }

            int left = 0;
            int right = array.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == searchValue)
                {
                    return mid + 1;
                }

                if (array[mid] > searchValue)
                {
                    if (array[mid + 1] < searchValue)
                    {
                        return mid + 2;
                    }

                    left = mid + 1;

                }

                if (array[mid] < searchValue)
                {
                    if (array[mid - 1] > searchValue)
                    {
                        return mid + 1;
                    }
                    right = mid - 1;
                }

            }
            return -1;
        }
    }
}

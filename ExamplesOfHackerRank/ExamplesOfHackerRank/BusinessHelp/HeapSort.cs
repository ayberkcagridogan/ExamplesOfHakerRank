using System;
namespace ExamplesOfHackerRank.BusinessHelp
{
    public class HeapSort
    {
        public T[] Sort<T>(T[] array) where T : IComparable<T>
        {

            // Heap meaining is right = left - 1 ; cursor = left - 1
            // for example if cursor = 1 , left = 3 . right = 4
            // then cursor = 0 . left = 1 , right = 2

            int heapSize = array.Length;

            T[] sortArray = buildMaxHeap(array);


            for (int i = heapSize - 1; i >= 1; i--)
            {
                sortArray = swap(array, i, 0);
                heapSize--;
                sortArray = searchCursor(array, heapSize, 0);
            }
            return sortArray;
        }

        private T[] buildMaxHeap<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;
            T[] sortArray = array;

            for (int i = (heapSize / 2) - 1; i >= 0; i--)
            {
                sortArray = searchCursor(array, heapSize, i);
            }
            return sortArray;
        }

        private T[] searchCursor<T>(T[] array, int heapSize, int toSearchCursorPos) where T : IComparable<T>
        {
            T[] sortArray = array;

            if (getLeftKidPos(toSearchCursorPos) >= heapSize)
            {
                //No left kid => no kid at all
                return sortArray;
            }

            int largestKidPos;
            bool leftIsLargest;

            if (getRightKidPos(toSearchCursorPos) >= heapSize || array[getRightKidPos(toSearchCursorPos)].CompareTo(array[getLeftKidPos(toSearchCursorPos)]) < 0)
            {
                largestKidPos = getLeftKidPos(toSearchCursorPos);
                leftIsLargest = true;
            }
            else
            {
                largestKidPos = getRightKidPos(toSearchCursorPos);
                leftIsLargest = false;
            }


            if (array[largestKidPos].CompareTo(array[toSearchCursorPos]) > 0)
            {
                sortArray = swap(array, toSearchCursorPos, largestKidPos);

                if (leftIsLargest)
                {
                    searchCursor(array, heapSize, getLeftKidPos(toSearchCursorPos));
                }
                else
                {
                    searchCursor(array, heapSize, getRightKidPos(toSearchCursorPos));
                }
            }

            return sortArray;

        }

        private T[] swap<T>(T[] array, int pos0, int pos1) where T : IComparable<T>
        {
            T tmpVal = array[pos0];
            array[pos0] = array[pos1];
            array[pos1] = tmpVal;

            return array;
        }

        private int getRightKidPos(int parentPos)
        {
            return 2 * (parentPos + 1);
        }

        private int getLeftKidPos(int parentPos)
        {
            return (2 * (parentPos + 1)) - 1;
        }
    }
}

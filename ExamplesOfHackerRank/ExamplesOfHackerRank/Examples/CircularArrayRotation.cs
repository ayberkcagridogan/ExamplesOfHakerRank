using System;
namespace ExamplesOfHackerRank.Examples
{
    public class CircularArrayRotation
    {
        public int[] GetRotationArray(int[] array , int rotationCount , int[] queries)
        {
            int[] rotationArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                rotationArray[(i + rotationCount) % array.Length] = array[i];
            }

            int[] result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                result[i] = rotationArray[queries[i]];
            }

            return result;
        }
    }
}

using System.Collections.Generic;

namespace ExamplesOfHackerRank.Examples
{
    public class BeatifulTriplets
    {
        public int beautifulTriplets(int d, List<int> arr)
        {
            int cArr = arr.Count;
            int cBeTri = 0;
            for (int i = 0; i < cArr; i++)
            {
                bool second = false;
                for(int j = i +1; j < cArr; j++){
                    
                    if(arr[i] + d == arr[j]){
                        second = true;
                    }

                    if(arr[i] + (2 *d) == arr[j] && second){
                        cBeTri++;
                    }
                    
                }    
            }
            return cBeTri;
        }
    }
}
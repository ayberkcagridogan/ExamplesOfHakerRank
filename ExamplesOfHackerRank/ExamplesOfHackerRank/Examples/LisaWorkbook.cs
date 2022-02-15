using System.Collections.Generic;

namespace ExamplesOfHackerRank.Examples{

    public class LisaWorkbook {

        public int getPageCount(int n, int k, List<int> arr){

            int spCnt = 0;
            int page = 0;

            for(int i = 0 ; i < n ;i++){

                int start = 1;            
                int chapPage = arr[i] % k == 0 ? arr[i] / k : (arr[i] / k) + 1;
                for(int j = 0 ; j < chapPage ; j++){
                    page++;
                    int end = start + k - 1 > arr[i] ? arr[i] : start + k - 1;
                    if(page >= start && page <= end){
                        spCnt++;
                    }
                    start = end + 1;
                }                       
            }
            return spCnt;
        }
    }
}
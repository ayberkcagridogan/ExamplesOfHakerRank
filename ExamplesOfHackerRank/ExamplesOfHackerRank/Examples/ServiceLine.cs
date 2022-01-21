using System.Collections.Generic;

namespace ExamplesOfHackerRank.Examples{

    public class ServiceLine {
        public List<int> serviceLane(int n, List<List<int>> cases, List<int> width)
        {
            List<int> result = new List<int>();

            for(int i = 0; i < cases.Count ; i++){

                int start = cases[i][0];
                int end =  cases[i][1];
                int min = 100000 ;

                for(int j = start ; j <= end ; j++){
                    
                    if(min > width[j]){
                        min = width[j];
                    }
                }
                result.Add(min);
            }
        
            return result;
        }
    }
}
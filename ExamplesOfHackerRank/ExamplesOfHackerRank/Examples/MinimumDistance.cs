using System.Collections.Generic;
using System.Linq;

namespace ExamplesOfHackerRank.Examples
{
    public class MinimumDistance
    {
        public int minimumDistances(List<int> a)
        {
            Dictionary<int , List<int>> values = new Dictionary<int, List<int>>();

            int ctr = a.Count;
            
            for (int i = 0; i < ctr; i++)
            {   
                List<int> indices;
                values.TryGetValue(a[i] , out indices);

                if(indices != null){
                    indices.Add(i);
                }
                else{
                    indices = new List<int>();
                    indices.Add(i);
                    values.Add(a[i] ,indices);
                }   
            }

            int minDis = int.MaxValue; 

            foreach(var key in values.Keys){
                
                List<int> indices = new List<int>();
                values.TryGetValue(key , out indices);

                int curtDist = int.MaxValue;
                if(indices.Count == 2){
                    curtDist = indices[1] - indices[0];
                }

                if(curtDist < minDis){
                    minDis = curtDist;
                }
            }

            return minDis == int.MaxValue ? -1 : minDis; 
        }
    }
}
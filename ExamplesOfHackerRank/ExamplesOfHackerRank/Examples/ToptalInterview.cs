namespace ExamplesOfHackerRank.Examples
{
    public class ToptalInterview
    {
        public int storeEmptyAt(int[][] customers){

                int totalMinutes= 0;
                for (int i = 0; i < customers.Length; i++)
                {

                    int currentMinutes = customers[i][1] + customers [i][2];

                    if(currentMinutes > totalMinutes){    
                        totalMinutes = currentMinutes;                        
                    }

                    if(i % 3 == 0){

                    }



                }
            return 0;
        }
    }
}
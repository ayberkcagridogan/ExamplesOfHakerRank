using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExamplesOfHackerRank.Examples{

    public class ACMICPCTeam{

        public List<int> acmTeam(List<string> topic)
        {
            int maxCountOnes = 0;
            int howManyMaxCountOnes= 0;
            int teamCount = topic.Count();
            int subjectCount =  topic[0].Length;
            Dictionary<int , char[]> values =  new Dictionary<int, char[]>();

            for (int i = 0; i < teamCount; i++)
            {
               values.Add(i , topic[i].ToCharArray());
            }

            for (int i = 0; i < teamCount; i++)
            {
                for (int j = i +1; j < teamCount; j++)
                {
                    int countOnes = 0;
                    char[] firstTeam = values[i];
                    char[] secondTeam = values[j];
                        
                    for (int k = 0; k < subjectCount; k++)
                    {
                        
                        if (firstTeam[k] == '1' || secondTeam[k] == '1')
                        {
                            countOnes++;
                        }
                    }
                    if(countOnes > maxCountOnes){
                        maxCountOnes = countOnes;
                        howManyMaxCountOnes = 1;
                    }
                    else if(countOnes == maxCountOnes){
                        howManyMaxCountOnes++;
                     }
                }
            }
            return new List<int> {maxCountOnes , howManyMaxCountOnes};
        }
        
    }
}

// public class Test
// {
// 	public static void Main()
// 	{
// 		// your code goes here
// 		int[] num = Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
// 		int N = num[0]; int M = num[1];
// 		int maxTopics = -1;
// 		int maxTopicsGang = 0;
// 		string[] sel = new string[N];
// 		for(int i = 0 ; i < N ; i++)
// 		     sel[i] = Console.ReadLine().Trim();
        
// 		for(int i = 0 ; i < N ; i++){
			
// 			for(int j = 0 ; j < N ; j++){
// 				int count = 0;
// 				if(i == j)
// 				   continue;
// 			 for(int k = 0 ; k < M ; k++){
// 			 	if(sel[i][k] == '1' || sel[j][k] == '1')
// 			 	      count++;
// 			 }
// 		     if(count > maxTopics){
// 		            maxTopics = count;
// 		            maxTopicsGang = 1;
// 			}else if (count == maxTopics){
// 				maxTopicsGang++;
// 			}
// 		}
		
// 	}
        
//         Console.WriteLine(maxTopics);
// 		Console.WriteLine(maxTopicsGang/2);
// }
// }

// class Solution {

//     public static bool[] GetBytes(string bitString) 
//     {
//         bool [] a = new bool[bitString.Length];
        
//         for (int i = 0;i<bitString.Length;i++)
//            if (bitString[i] == '1' ) 
//                a[i] = true;
//             return a;
//     }
    
//     static void Main(String[] args) {
//         string [] tokens = Console.ReadLine().Split();
//         int N = Convert.ToInt32(tokens[0]);
//         int M = Convert.ToInt32(tokens[1]);
        
//         BitArray [] people = new BitArray[N];
        
//         for (int i =0;i<N;i++)
//             {
//             people[i] =  new BitArray(GetBytes(Console.ReadLine()));
//         }
        
       
        
        
//         int highKnown = 0;
//         int peopleCount = 0;
//         for (int x = 0;x< N;x++)
//         {
//             for (int y = x;y<N;y++)
//             {
//                 if (x==y) continue;
                
//                 BitArray tmp = new BitArray(people[x]);
//                 tmp.Or(people[y]);
                
//                 int knownTogether = 0;
                
//                 foreach ( bool bit in tmp)
//                     {
//                     if (bit)
//                         knownTogether++;
//                 }
                    
                    
                
                
//                 if (knownTogether == highKnown)
//                     {
//                   //  Console.WriteLine("team " +x + " "+ y+":"+knownTogether);
//                    peopleCount++;
//                 }
//                 if (knownTogether>highKnown)
//                 {
//                     peopleCount = 1;
//                     highKnown = knownTogether;
//                 }
                
//             }
//         }
     
//         Console.WriteLine(highKnown);
//         Console.WriteLine(peopleCount);
//     }
// }   
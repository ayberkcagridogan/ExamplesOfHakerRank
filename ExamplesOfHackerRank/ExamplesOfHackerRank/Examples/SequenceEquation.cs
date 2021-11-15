using System;
using System.Collections.Generic;

namespace ExamplesOfHackerRank.Examples
{
    public class SequenceEquation
    {
        public List<int> permutationEquation(List<int> p)
        {

            List<int> result = new List<int>();

<<<<<<< HEAD
            //for (int i = 1; i <= p.; i++)
            //{
            //   result.Add(p.IndexOf(p.IndexOf(i)+ 1) + 1); 
            //}
=======
            for (int i = 1; i <= p.Count; i++)
            {
               result.Add(p.IndexOf(p.IndexOf(i)+ 1) + 1); 
            }
>>>>>>> 3623f9c8e2928d5352b8b6175db82fda19eafe7c

            return result;

        }
    }
}

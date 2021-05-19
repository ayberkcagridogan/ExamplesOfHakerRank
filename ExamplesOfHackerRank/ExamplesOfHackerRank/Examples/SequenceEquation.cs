﻿using System;
using System.Collections.Generic;

namespace ExamplesOfHackerRank.Examples
{
    public class SequenceEquation
    {
        public List<int> permutationEquation(IEnumerable<int> p)
        {

            List<int> result = new List<int>();

            for (int i = 1; i <= p.Count(); i++)
            {
               result.Add(p.IndexOf(p.IndexOf(i)+ 1) + 1); 
            }

            return result;

        }
    }
}

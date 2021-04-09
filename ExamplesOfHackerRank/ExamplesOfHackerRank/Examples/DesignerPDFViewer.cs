using System;
using System.Collections.Generic;

namespace ExamplesOfHackerRank.Examples
{
    public class DesignerPDFViewer
    {
        public int FindHighlightedText(int[] heghlighted , string word)
        {
            List<string> letterIndex = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w" ,"x", "y", "z" };

            int maxheightedLetter = 0;
            
            for (int i = 0; i < word.Length; i++)
            {
                int letterHeighted = heghlighted[letterIndex.LastIndexOf(word.Substring(i, 1))];
                if (letterHeighted > maxheightedLetter)
                {
                    maxheightedLetter = letterHeighted;
                }
            }

            return word.Length * maxheightedLetter;
        }
    }
}

using System;

namespace ExamplesOfHackerRank.Examples{

    public class ModifiedKaprekarNumbers{

        public void kaprekarNumbers(int p, int q)
        {
            string output = "";
            for (int i = p; i <= q; i++)
            {
                string number = Convert.ToString((ulong)i * (ulong)i);
                int d = number.Length;
                string r = number.Substring( d / 2);
                string l = number.Substring(0, d / 2);
                l = (l.Length == 0) ? "0" : l;
                if (Convert.ToUInt32(r) + Convert.ToUInt32(l) == i) 
                    output += i + " ";
            }
            if(output.Length == 0)
                output = "INVALID RANGE";
            Console.WriteLine(output);
        
        }
    }
}
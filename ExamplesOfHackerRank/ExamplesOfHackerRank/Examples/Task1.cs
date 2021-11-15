using System;
using System.Collections.Generic;

namespace ExamplesOfHackerRank.Examples
{
    public class Task1
    {
        public int Validate(string[] args)
        {
            if(args == null || args.Length == 0 || args.Length > 5)
            {
                return -1;
            }

            bool helpAsked = false;

            try
            {
                for (int i = 0; i < args.Length; i++)
                {

                        if (args[i].ToLower().Equals("--name"))
                        {

                            if (args[i + 1].Length < 3 || args[i + 1].Length > 10)
                                return -1;
                        i++;
                        }
                        else if (args[i].ToLower().Equals("--count"))
                        {
                            int value = Int16.Parse(args[i + 1]);

                            if (value < 10 || value > 100)
                                return -1;
                        i++;
                        }
                        else if (args[i].ToLower().Equals("--help"))
                        {
                            helpAsked = true;
                        }
                        else
                        {
                            return -1;
                        }
                    
                }
            }
            catch (Exception)
            {
                return -1;
            }


            if (helpAsked) return 1;

            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExamplesOfHackerRank.Examples
{
    public class ToptalTest
    {
        public int Solution1(string S)
        {
           string[] sentences = S.Split('.', '?', '!');

            int wordsCount = 0;
            foreach (var sentence in sentences)
            {
                string[] words = Regex.Replace(sentence, @"\s+", " ").Trim().Split(' ');

                wordsCount = Math.Max(wordsCount, words.Length); 
            }

            return wordsCount;

        }

        public int solution2(int[] A, string[] D)
        {
            Dictionary<int, List<int>> trans = new Dictionary<int, List<int>>();

            int total = 0;
            int feeExculudeMonthCount = 0;
            for (int i = 0; i < D.Length; i++)
            {
                total += A[i];

                DateTime date = Convert.ToDateTime(D[i]);

                if (A[i] < 0)
                {
                    if (!trans.ContainsKey(date.Month))
                    {
                        List<int> listValue = new List<int> {A[i]};

                        trans.Add(date.Month, listValue);
                       
                    }
                    else
                    {
                        List<int> listValue = new List<int> {};
                        trans.TryGetValue(date.Month, out listValue);
                        listValue.Add(A[i]);
                    }
                }
            }

            for (int i = 1; i < 13; i++)
            {
                if (trans.ContainsKey(i))
                {
                    List<int> expenses = new List<int>();
                    trans.TryGetValue(i , out expenses);
                    if(expenses.Count >= 3)
                    {
                        int totalExpenses = 0;
                        foreach (var expense in expenses)
                        {
                            totalExpenses += expense;
                        }

                        if (totalExpenses <= -100)
                        {
                            feeExculudeMonthCount++;
                        }
                    }
                }
             }

            return total - (5 * (12 - feeExculudeMonthCount));
        }

        public string solution3(string S)
        {
            string[] lines = S.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.None);

            Dictionary<string, List<DateTime>> cities = new Dictionary<string, List<DateTime>>();

            foreach (var line in lines)
            {
                string[] values = line.Split(',');

                if (cities.ContainsKey(values[1]))
                {
                    List<DateTime> listValue = new List<DateTime> {};
                    cities.TryGetValue(values[1], out listValue);
                    listValue.Add(Convert.ToDateTime(values[2]));
                }
                else
                {
                    List<DateTime> listValue = new List<DateTime> { Convert.ToDateTime(values[2])};
                    cities.Add(values[1], listValue);
                }
            }

            Dictionary<string, DateTime[]> sortedDatedCities = new Dictionary<string, DateTime[]>();

            foreach (var key in cities.Keys)
            {
                List<DateTime> listValue = new List<DateTime> { };
                cities.TryGetValue(key, out listValue);

                listValue.Sort();

                sortedDatedCities.Add(key, listValue.ToArray());
            }
            string result = "";
            foreach (var line in lines)
            {
                string[] values = line.Split(',');

                string ext = values[0].Split('.')[1];

                DateTime[] dateTimes;
                sortedDatedCities.TryGetValue(values[1], out dateTimes);

                int order = 0;


                for (int i = 0; i < dateTimes.Length; i++)
                {
                    if(dateTimes[i] == Convert.ToDateTime(values[2]))
                    {
                        order = i + 1;
                        break;
                    }
                }

                result = values[1] + "" + order + "." + ext;

            }

            return result;
        }
    }
}
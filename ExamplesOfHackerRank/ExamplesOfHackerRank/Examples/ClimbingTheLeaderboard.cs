using System;
using System.Collections.Generic;
using System.Linq;
using ExamplesOfHackerRank.BusinessHelp;

namespace ExamplesOfHackerRank.Examples
{
    public class ClimbingTheLeaderboard
    {

        public List<int> GetPlayersRank(List<int> ranked, List<int> players)
        {
            var result = new List<int>();
            var distinctRanked = ranked.Distinct().ToList();

            var binarySearch = new BinarySearch();

            foreach (var player in players)
            {
               result.Add(binarySearch.Search(player, distinctRanked));
            }

            return result;
        }

    }
}


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

            for (int i = 0; i < players.Count(); i++)
            {
                int currentRank = 1;
                for (int j = 0; j < ranked.Count(); j++)
                {
                    if(players[i] >= ranked[j]){
                        result.Add(currentRank);
                        break;
                    }
                    if(j != ranked.Count()-1 && ranked[j] != ranked[j+1]){
                        currentRank++;
                    }
                    if(j == ranked.Count()-1){
                         result.Add(currentRank + 1); 
                    }
                }
            }

            return result;

            // var result = new List<int>();
            // var distinctRanked = ranked.Distinct().ToList();

            // var binarySearch = new BinarySearch();

            // foreach (var player in players)
            // {
            //    result.Add(binarySearch.Search(player, distinctRanked));
            // }

            // return result;
        }

    }
}


namespace ExamplesOfHackerRank.Examples{

    public class HalloweenSell{

        public int howManyGames(int p, int d, int m, int s)
        {
            int totalCost = 0;
            int lastGamePrice = p;
            int ctrBuyGame = 0;

            while (s >= totalCost + lastGamePrice)
            {
                totalCost += lastGamePrice;
                ctrBuyGame++;
                lastGamePrice = lastGamePrice - d > m ? lastGamePrice - d : m;         
            }

            return ctrBuyGame;
        }
    }
}
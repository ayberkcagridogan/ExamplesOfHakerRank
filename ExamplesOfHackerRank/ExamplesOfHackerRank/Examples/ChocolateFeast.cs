namespace ExamplesOfHackerRank.Examples
{
    public class ChocolateFeast
    {
        public int chocolateFeast(int n, int c, int m)
        {
            int chocolate = n / c;
            int result = chocolate;        
            int wrappers = chocolate;
            
            while (wrappers >= m)
            {
                int newChocolate = wrappers / m;
                result += newChocolate;
                wrappers = wrappers - (newChocolate * m) + newChocolate;
            }

            return result;
        }
    }
}
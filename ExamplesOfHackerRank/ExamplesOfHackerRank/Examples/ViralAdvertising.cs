using System;
namespace ExamplesOfHackerRank.Examples
{
    public class ViralAdvertising
    {
        public int GetReceiveAdvertisement(int day)
        {
            int shareAdvertisement = 5;
            int recieveAdvertisement = 0;
            for (int i = 1; i <= day; i++)
            {
                recieveAdvertisement = (shareAdvertisement / 2) + recieveAdvertisement;
                shareAdvertisement = (shareAdvertisement / 2) * 3;
            }

            return recieveAdvertisement;
        }
    }
}

using System;
using System.Numerics;

namespace ExamplesOfHackerRank.Examples
{
    public class QueensAttackII
    {
         public int FindQueenAttackCount(int n , int obstacleCount , int rowQueen , int columnQueen , int[][] obstacles)
        {

                if (n == 1)
                {
                    return 0;
                }

                int count = 0;

                int countRight = -1;
                int countLeft = -1;
                int countDown = -1;
                int countUp = -1;
                int countCrossRightUp = -1;
                int countCrossLeftUp = -1;
                int countCrossRighDown = -1;
                int countCrossLeftDown = -1;

                for (int j = 0; j < obstacleCount; j++)
                {
                    //Horizontal
                    if (obstacles[j][0] == rowQueen)
                    {
                        if (columnQueen > obstacles[j][1])
                        {
                            countLeft = countLeft == -1 ? columnQueen - obstacles[j][1] - 1 : Math.Min(countLeft, columnQueen - obstacles[j][1] - 1);

                        }
                        else if(columnQueen < obstacles[j][1])
                        {
                            countRight = countRight == -1 ? obstacles[j][1] - columnQueen - 1 : Math.Min(countRight, obstacles[j][1] - columnQueen - 1); 
                           
                        }                       
                    }

                    //Vertical
                    if (obstacles[j][1] == columnQueen)
                    {
                        if (rowQueen > obstacles[j][0])
                        {
                            countDown = countDown == -1 ? rowQueen - obstacles[j][0] - 1 : Math.Min(countDown, rowQueen - obstacles[j][0] - 1);
   
                        }
                        else if (rowQueen < obstacles[j][0])
                        {
                            countUp = countUp == -1 ? obstacles[j][0] - rowQueen - 1 : Math.Min(countUp, obstacles[j][0] - rowQueen - 1);
                        }
                    }

                    //Cross
                    if (Math.Abs(obstacles[j][0] - rowQueen) == Math.Abs(obstacles[j][1] - columnQueen))
                    {
                        if (obstacles[j][0] - rowQueen > 0 && obstacles[j][1] - columnQueen > 0)
                        {
                            countCrossRightUp = countCrossRightUp == -1 ? obstacles[j][0] - rowQueen - 1 : Math.Min(countCrossRightUp, obstacles[j][0] - rowQueen - 1);
                        }
                        else if (obstacles[j][0] - rowQueen > 0 && obstacles[j][1] - columnQueen < 0)
                        {
                            countCrossLeftUp = countCrossLeftUp == -1 ? obstacles[j][0] - rowQueen - 1 : Math.Min(countCrossLeftUp, obstacles[j][0] - rowQueen - 1);
                        }
                        else if (obstacles[j][0] - rowQueen < 0 && obstacles[j][1] - columnQueen > 0)
                        {
                            countCrossRighDown = countCrossRighDown == -1 ? rowQueen - obstacles[j][0] - 1 : Math.Min(countCrossRighDown, rowQueen - obstacles[j][0] - 1);

                        }
                        else if (obstacles[j][0] - rowQueen < 0 && obstacles[j][1] - columnQueen < 0)
                        {
                            countCrossLeftDown = countCrossLeftDown == -1 ? rowQueen - obstacles[j][0] - 1 : Math.Min(countCrossLeftDown, rowQueen - obstacles[j][0] - 1);
                        }
                    }
                }

                count += countLeft == -1 ? columnQueen - 1 : countLeft;
                count += countRight == -1 ? n - columnQueen : countRight;
                count += countDown == -1 ? rowQueen - 1 : countDown;
                count += countUp == -1 ? n - rowQueen : countUp;
                count += countCrossRightUp == -1 ? Math.Min(n - columnQueen, n - rowQueen) : countCrossRightUp;
                count += countCrossLeftUp == -1 ? Math.Min(columnQueen - 1, n - rowQueen) : countCrossLeftUp;
                count += countCrossRighDown == -1 ? Math.Min(n - columnQueen, rowQueen - 1) : countCrossRighDown;
                count += countCrossLeftDown == -1 ? Math.Min(columnQueen - 1, rowQueen - 1) : countCrossLeftDown;

                return count;
          
        }
    }
}



using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRank.Examples
{
    public class SherlockAndSquares{

        public int CountSquares(int a , int b){

            int number = 1;
            int countSquares = 0;

            while(b >= number * number){

                if(number * number >= a){

                    countSquares++;
                }

                number++;
            }

            return countSquares;
        }
    }
}

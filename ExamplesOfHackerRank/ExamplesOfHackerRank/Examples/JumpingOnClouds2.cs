using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRank.Examples
{
    public class JumpingOnClouds2 {

        public int FindTheLeastJump(List<int> clouds){

            int index = 0;
            int jumpCount = 0;
            while (clouds.Count - 1 > index) {

                if (clouds.Count > index + 2 && clouds[index + 2] == 0) {

                    index += 2;
                    jumpCount++;
                }
                else {

                    index++;
                    jumpCount++;
                }
            }

            return jumpCount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesOfHackerRank.Examples
{
    public class CutTheSticks {

        public List<int> FindCutOperation(List<int> arr)
        {
            int smallPiece = arr[0];
            int maxPieceIndex = 0;

            for (int i = 0; i < arr.Count; i++) {
                if (smallPiece > arr[i]) {
                    smallPiece = arr[i];
                }

                if (arr[i] > arr[maxPieceIndex])
                {
                    maxPieceIndex = i;
                }
            }

            int nextSmallPiece = arr[maxPieceIndex];
            List<int> cutOperations = new List<int>();
            int count = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] - smallPiece >= 0)
                    {
                        count++;
                        arr[j] = arr[j] - smallPiece;
                    }

                    if (nextSmallPiece > arr[j] && arr[j] > 0)
                    {
                        nextSmallPiece = arr[j];
                    }
                }
                if (count == 0) break;
                cutOperations.Add(count);
                count = 0;
                smallPiece = nextSmallPiece;
                nextSmallPiece = arr[maxPieceIndex];
            }

            return cutOperations;
        }

    }
}

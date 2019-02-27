using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class MathHelpers2
    {
        public static int[,] BuildMultiplicationTable(int maxFactor)
        {
            int arraySize = maxFactor + 1;
            int[,] array = new int[arraySize, arraySize];

            for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < array.GetLength(1); colIndex++)
                {
                    array[rowIndex, colIndex] = rowIndex * colIndex;
                }
            }
            return array;
        }
    }
}

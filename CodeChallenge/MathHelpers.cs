using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public static class MathHelpers
    {
        public static int[][] BuildMultiplicationTable(int maxFactor)
        {
            int arraySize = maxFactor + 1;
            int[][] sheet = new int[arraySize][];

            for (int i = 0; i < sheet.Length; i++)
            {
                sheet[i] = new int[arraySize];

                for (int j = 0; j < sheet[i].Length; j++)
                {
                    sheet[i][j] = i * j;
                }
            }
            return sheet;
        }
    }
}

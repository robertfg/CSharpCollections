using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Try debugger
using System.Diagnostics;

namespace Play
{
    class ProgramArrays
    {
        static void MainArrays(string[] args)
        {
            /*  *****   Jagged Arrays  *****   */

            // No initial values:
            int[] lockCombination = new int[3];
            Debug.Write("lock combination: ");
            foreach(var item in lockCombination)
            {
                Debug.Write(item + " ");
            }
            Debug.WriteLine("\r");

            // Initial values:
            int[] lockCombo = { 10, 5, 32 };
            Debug.Write("lock combo: ");
            foreach (var item in lockCombo)
            {
                Debug.Write(item + " ");
            }
            Debug.WriteLine("\r");

            // 2D Array:
            Cell[][] sheet = new Cell[100][];

            //Console.Write("sheet: { ");
            //foreach (var item in sheet)
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine(" }\r\n");

            for (int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            {
                // Create a row of 10 cells
                sheet[rowIndex] = new Cell[10];

                // Populate cells:
                for (int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
                {
                    sheet[rowIndex][colIndex] = new Cell();
                }
            }

            // This is possible, although the values would be NULL:
            //sheet[4] = new Cell[20];

            //Console.Write("sheet: { \r\n");
            //for (int i = 0; i < sheet.Length; i++)
            //{
            //    Console.Write("row[" + i + "]: { ");
            //    for (int j = 0; j < sheet[i].Length; j++)
            //    {
            //        Console.Write(sheet[i][j] + ", ");
            //    }
            //    Console.WriteLine(" }\r\n");
            //}
            //Console.WriteLine(" }\r\n");

            // Alternate
            //Console.Write("{ ");
            //foreach (Cell[] row in sheet)
            //{
            //    Console.Write("{ ");
            //    foreach (Cell cell in row)
            //    {
            //        System.Console.Write(cell + ", ");
            //    }
            //    Console.WriteLine(" }\r");
            //}
            //Console.WriteLine(" }\r\n");

            /*  *****   Multidimensional Arrays  *****   */
            Cell[,] sheet1 = new Cell[100, 10];

            for (int rowIndex = 0; rowIndex < sheet1.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < sheet1.GetLength(1); colIndex++)
                {
                    sheet1[rowIndex, colIndex] = new Cell();
                }
            }

            // Other examples of more complex arrays:
            Cell[][][] sheet2 = new Cell[100][][];
            int[,,] threeDimMatrix = new int[5, 5, 5];
            int[][,,][] yikes = new int[5][,,][];

            // Adding to an array:
            int[] ages = { 24, 31, 56 };
            int[] agesCopy = new int[4];

            // Copy starting at index 1:
            ages.CopyTo(agesCopy, 1);
            agesCopy[0] = 16;

            Console.ReadKey();
        }
    }
}

﻿using System;

namespace Recursif_TriangleDePascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            //PrintPascal(length);
            int[,] pascalTable2D = new int[length, length];
            RecursifPascal(pascalTable2D, length, 0);
        }
        /*public static void PrintPascal(int length)
        {
            int[,] pascalTable2D = new int[length, length];
            for (int row = 0; row < length; row++)
            {
                for (int i = 0; i <= row; i++)
                {
                    if (row == i || i == 0) 
                    {
                        pascalTable2D[row, col] = 1;
                        Console.Write(pascalTable2D[row, col] + " ");
                    }
                    else
                    {
                        pascalTable2D[row, i] = pascalTable2D[row - 1, i - 1] + pascalTable2D[row - 1, i];
                        Console.Write(pascalTable2D[row, i]);
                    }
                }
                Console.WriteLine("");
            }
        }*/

        public static void RecursifPascal(int[,] pascalTable2D, int length, int row)
        {
            if (row == length - 1) Console.ReadKey();
            for (int col = 0; col <= row; col++)
            {
                if (row == col || col == 0)
                {
                    pascalTable2D[row, col] = 1;
                    Console.Write(pascalTable2D[row, col] + " ");
                }
                else
                {
                    pascalTable2D[row, col] = pascalTable2D[row - 1, col - 1] + pascalTable2D[row - 1, col];
                    Console.Write(pascalTable2D[row, col] + " ");
                }
            }
            Console.WriteLine("");
            RecursifPascal(pascalTable2D, length, row + 1);
        }
    }
}

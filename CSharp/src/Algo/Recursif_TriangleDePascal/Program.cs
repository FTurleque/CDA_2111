using System;
using System.Linq;

namespace Recursif_TriangleDePascal
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPascal(10);
            int n = AskNumber("Entrez le numéro de ligne, du triangle de Pascal, que vous souhaitez afficher :");
            int[] newResult = GetPascalLine(n);
            newResult.ToList().ForEach(x => Console.Write($"{x} "));
        }

        private static int AskNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    return int.Parse(userEntry);
                }
                catch (Exception)
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre, recommencez :");
                }
            } while (true);
        }

        public static void PrintPascal(int _n)
        {
            int[,] pascalTable2D = new int[_n, _n];
            for (int row = 0; row < _n; row++)
            {
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
            }
        }


        /*public static int[] RecursifPascal(int length)
        {
            int[] pascalTable = new int[length + 1];

            if (length == 0)
            {
                return pascalTable;
                //Console.ReadKey();
            }
            else
            {
                int[] _pascalArrayBefore = RecursifPascal(length - 1);
                for (int i = 0; i < pascalTable.Length; i++)
                {
                    if (i == 0 || i == _pascalArrayBefore.Length - 1)
                    {
                        pascalTable[i] = 1;
                    }
                    else
                    {
                        pascalTable[i] = _pascalArrayBefore[length - 1] + _pascalArrayBefore[length - 1];
                    }
                }
            }
            return pascalTable;
        }*/

        public static int[] GetPascalLine(int _n)
        {
            int[] result = new int[_n + 1];
            if (_n == 0)
            {
                return new int[] { 1 };
            }
            else
            {
                int[] previousPascalLine = GetPascalLine(_n - 1);

                for (var i = 0; i < result.Length; i++)
                {
                    if (i == 0 || i == result.Length - 1)
                    {
                        result[i] = 1;
                    }
                    else
                    {
                        result[i] = previousPascalLine[i - 1] + previousPascalLine[i];
                    }
                }
                return result;
            }
        }
    }
}

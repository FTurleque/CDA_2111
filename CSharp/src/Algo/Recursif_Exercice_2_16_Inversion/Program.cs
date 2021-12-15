using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Recursif_Exercice_2_16_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrayNumber = { 1, 2, 3, 4, 5 };
            int[] arrayNumber = AskUserNumber("Entrez des nombres ou des chiffres entier séparé par un éspace :");
            int index = 0;
            int arrayLength = arrayNumber.Length - 1;
            int[] result = arrayReverse(arrayNumber, index, arrayLength);
            Console.WriteLine(Display(result, "Le resultat du tableau inversé est : "));
        }

        private static int[] AskUserNumber(string message)
        {
            int[] valiousTable;
            Console.WriteLine(message);
            do
            {
                string userNumber = Console.ReadLine();
                string[] stringValious = userNumber.Split(" ");
                valiousTable = new int[stringValious.Length];

                // Test of the user input
                try
                {
                    for (int i = 0; i < valiousTable.Length; i++)
                    {
                        valiousTable[i] = int.Parse(stringValious[i]);

                    }
                    return valiousTable;
                }
                catch (FormatException)
                {
                    // TODO: handle exception
                    Console.WriteLine("Une distance est un chiffre et une unitée de mesure séparé d'un espace. Recommencez :");
                }
            } while (true);
        }


        private static int[] arrayReverse(int[] _arrayNumber, int _index, int _arrayLength)
        {
            if (_index >= _arrayLength) return _arrayNumber;
            else
            {
                int tmp = _arrayNumber[_arrayLength];
                _arrayNumber[_arrayLength] = _arrayNumber[_index];
                _arrayNumber[_index] = tmp;
                return arrayReverse(_arrayNumber, _index + 1, _arrayLength - 1);
            }
        }

        private static string Display(int[] _arrayNumber, string message)
        {
            StringBuilder stringArray = new();
            for (int i = 0; i < _arrayNumber.Length; i++)
            {
                stringArray.Append($"{_arrayNumber[i]} ");
            }
            return message + stringArray;
        }

    }
}

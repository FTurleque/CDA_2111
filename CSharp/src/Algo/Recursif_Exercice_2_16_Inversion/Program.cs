using System;
using System.Text;

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

        /// <summary>
        /// I ask the user to enter several numbers
        /// </summary>
        /// <param name="message">String</param>
        /// <returns>Array number</returns>
        private static int[] AskUserNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userNumber = Console.ReadLine();
                string[] stringValious = userNumber.Split(" ");
                int[] valiousTable = new int[stringValious.Length];
                try
                {
                    for (int i = 0; i < valiousTable.Length; i++) valiousTable[i] = int.Parse(stringValious[i]);
                    return valiousTable;
                }
                catch (FormatException)
                {
                    // TODO: handle exception
                    Console.WriteLine("Une distance est un chiffre et une unitée de mesure séparé d'un espace. Recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// I swap number of the table
        /// </summary>
        /// <param name="_arrayNumber">Array number</param>
        /// <param name="_index">Number</param>
        /// <param name="_arrayLength">Number</param>
        /// <returns>Array result</returns>
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

        /// <summary>
        /// I display the table in making a string
        /// </summary>
        /// <param name="_arrayNumber">Array number</param>
        /// <param name="message">String</param>
        /// <returns>String result</returns>
        private static string Display(int[] _arrayNumber, string message)
        {
            StringBuilder stringArray = new();
            for (int i = 0; i < _arrayNumber.Length; i++)stringArray.Append($"{_arrayNumber[i]} ");
            return message + stringArray;
        }

    }
}

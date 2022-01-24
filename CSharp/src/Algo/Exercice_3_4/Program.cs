using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_3_4_TriD1Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicVersion();
            AdvanceVersion();
        }

        private static void AdvanceVersion()
        {
            
        }

        /// <summary>
        /// First version easy
        /// </summary>
        private static void BasicVersion()
        {
            int[] arrayNumber = AskNumber("Entrez 6 nombres différent afin de céer un tableau et le trier :");
            Console.WriteLine(Display(arrayNumber, "Avant : "));
            BubbleSort(arrayNumber);
            Console.WriteLine(Display(arrayNumber, "Après le tri : "));
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Array number</returns>
        private static int[] AskNumber(string message)
        {
            Console.WriteLine(message);
            int[] _arrayNumber = new int[6];
            for (int index = 0; index < _arrayNumber.Length; index++)
            {
                string userEntry = Console.ReadLine();
                try
                {
                    _arrayNumber[index] = int.Parse(userEntry);
                }
                catch (Exception)
                {
                    Console.WriteLine("Vous n'avez pas entré un nombre, recommencez :");
                }
            }
            return _arrayNumber;
        }

        /// <summary>
        /// Display array number
        /// </summary>
        /// <param name="_arrayNumber">Array Number</param>
        /// <param name="message"></param>
        /// <returns>String result</returns>
        private static string Display(int[] _arrayNumber, string message)
        {
            StringBuilder stringArray = new();
            for (int i = 0; i < _arrayNumber.Length; i++) stringArray.Append($"{_arrayNumber[i]} ");
            return message + stringArray;
        }

        /// <summary>
        /// I put the numbers in ascending order
        /// </summary>
        /// <param name="_arrayNumber"></param>
        private static void BubbleSort(int[] _arrayNumber)
        {
            for (int i = 0; i < _arrayNumber.Length - 1; ++i)
                for (int j = i + 1; j < _arrayNumber.Length; ++j)
                    if (_arrayNumber[j] < _arrayNumber[i])  Permutation(ref _arrayNumber[i], ref _arrayNumber[j]);
        }

        /// <summary>
        /// I swap the numbers
        /// </summary>
        /// <param name="a">Number</param>
        /// <param name="b">Number</param>
        static void Permutation(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}

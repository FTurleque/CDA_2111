using System;

namespace Exercice_3_4
{
    class Program
    {
        private static int[] arrayNumber = new int[6];

        static void Main(string[] args)
        {
            AskNumber("Entrez 6 nombres différent afin de céer un tableau et le trier :");
            Console.WriteLine(Display(arrayNumber, "Avant : "));
            BubbleSort();
            Console.WriteLine(Display(arrayNumber, "Après le tri : "));
        }

        private static void AskNumber(string message)
        {
            Console.WriteLine(message);

            int index = 0;
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                string userEntry = Console.ReadLine();
                try
                {
                    arrayNumber[index] = int.Parse(userEntry);
                    index++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Vous n'avez pas entré un nombre, recommencez :");
                }
            }
        }

        private static string Display(int[] _arrayNumber, string message)
        {
            string stringArray = "";
            for (int i = 0; i < _arrayNumber.Length; i++)
            {
                stringArray += $"{_arrayNumber[i]} ";
            }
            return message + stringArray;
        }

        private static void BubbleSort()
        {
            for (int i = 0; i < arrayNumber.Length - 1; ++i)
                for (int j = i + 1; j < arrayNumber.Length; ++j)
                {
                    if (arrayNumber[j] < arrayNumber[i])
                    {
                        Permutation(ref arrayNumber[i], ref arrayNumber[j]);
                    }
                }
        }

        static void Permutation(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}

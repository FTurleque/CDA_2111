using System;

namespace Recursif_Exercice_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = AskNumber("Algorithme récursifs sur les nombres\nPuissance entière d'un nombre réel\nEntrez un nombre entier pour 'a' :");
            int bNumber = AskNumber("Entrez un nombre entier 'b' :");
            Console.WriteLine($"{aNumber} puissance {bNumber} est {ProductOfNumbers(aNumber, bNumber)}");

        }

        private static int ProductOfNumbers(int _aNumber, int _bNumber)
        {
            if (_bNumber == 0) return _aNumber;
            else
            {
                return _aNumber * ProductOfNumbers(_aNumber, _bNumber - 1);
            }
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
                    Console.WriteLine("Vous n'avez pas entrez un nombre réel, recommencez :");
                }
            } while (true);
        }


    }
}

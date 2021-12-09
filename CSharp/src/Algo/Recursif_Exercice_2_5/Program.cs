using System;

namespace Recursif_Exercice_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = AskNumber("Algorithme récursifs sur les nombres\n\nEntrez un nombre entier pour 'a' :");
            int bNumber = AskNumber("Entrez un nombre entier 'b' :");
            Console.WriteLine($"La somme de {aNumber} et de {bNumber} est {SumOfNumbers(aNumber, bNumber)}");
        }

        private static int SumOfNumbers(int _aNumber, int _bNumber)
        {
            if (_bNumber == 0) return _aNumber;
            else if (_aNumber == 0) return _bNumber;
            else if (_aNumber < 0 & _bNumber > 0) return SumOfNumbers(_aNumber + 1, _bNumber - 1);
            else if (_aNumber > 0 & _bNumber < 0) return SumOfNumbers(_aNumber - 1, _bNumber + 1);
            else return SumOfNumbers(_aNumber + 1, _bNumber - 1);
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
                    Console.WriteLine("Vous n'avez pas entrez un nombre entier positif, recommencez :");
                }
            } while (true);
        }

    }
}

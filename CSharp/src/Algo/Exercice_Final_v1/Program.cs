using System;

namespace Exercice_Final_v1
{
    class Program
    {
        private static int result;

        static void Main(string[] args)
        {
            //int aNumber = AskNumber("Calcul du PGCD de 2 entiers positifs !\n\nEntrez un premier nombre entier positif :");
            //int bNumber = AskNumber("Entrez un second nombre entier positif :");

            //Calcul_PGCD(aNumber, bNumber);
            Console.WriteLine($"Le PGCD de 36 et 60 est : {Calcul_PGCD(36, 60)}");
            Console.WriteLine($"Le PGCD de 42 et 63 est : {Calcul_PGCD(42, 63)}");
        }

        private static int Calcul_PGCD(int _aNumber, int _bNumber)
        {
            int resultOfTheDifference;
            if (_aNumber > _bNumber) resultOfTheDifference = _aNumber - _bNumber;
            else resultOfTheDifference = _bNumber - _aNumber;

            while (!(_aNumber > 0 | _bNumber > 0))
            {
                if (_aNumber > _bNumber)
                {
                    int tmp = _bNumber - resultOfTheDifference;
                    result = resultOfTheDifference - tmp;
                    resultOfTheDifference = tmp - result;
                }
                else
                {
                    int tmp = _aNumber - resultOfTheDifference;
                    result = resultOfTheDifference - tmp;
                    resultOfTheDifference = tmp - result;
                }
            }
            return result;
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

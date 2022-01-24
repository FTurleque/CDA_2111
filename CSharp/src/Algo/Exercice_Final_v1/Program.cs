using System;

namespace Exercice_Final_v1_PGCD
{
    class Program
    {
        private static int result;

        static void Main(string[] args)
        {
            int aNumber = AskNumber("Calcul du PGCD de 2 entiers positifs !\n\nEntrez le premier nombre entier positif :");
            int bNumber = AskNumber("Entrez le second nombre entier positif :");

            Console.WriteLine($"Le PGCD de {aNumber} et {bNumber} est : {Calcul_PGCD(aNumber, bNumber)} !");
            /*            Console.WriteLine($"Le PGCD de 36 et 60 est : {Calcul_PGCD(36, 60)}");
                        Console.WriteLine($"Le PGCD de 42 et 63 est : {Calcul_PGCD(42, 63)}");
                        Console.WriteLine($"Le PGCD de 42 et 63 est : {Calcul_PGCD(561, 357)}");
                        Console.WriteLine($"Le PGCD de 42 et 63 est : {Calcul_PGCD(15, 12)}");
                        Console.WriteLine($"Le PGCD de 42 et 63 est : {Calcul_PGCD(10, 9)}");
            */
        }

        /// <summary>
        /// I find the PGCD of tow numbers
        /// </summary>
        /// <param name="_aNumber">Number</param>
        /// <param name="_bNumber">Number</param>
        /// <returns>Number result</returns>
        private static int Calcul_PGCD(int _aNumber, int _bNumber)
        {
            while (!_aNumber.Equals(_bNumber))
            {
                if (_aNumber > _bNumber) _aNumber -= _bNumber;
                else _bNumber -= _aNumber;
            }
            return _aNumber;
        }

        /// <summary>
        /// Ask a number by sending a question
        /// </summary>
        /// <param name="message">String</param>
        /// <returns>Int result</returns>
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

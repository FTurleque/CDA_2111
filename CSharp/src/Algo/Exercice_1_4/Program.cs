using System;

namespace Exercice_1_4_InversionDeValeur
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = AskNumber("Inversion de 2 valeurs\n\nChoisir un nombre pour 'a' :");
            int bNumber = AskNumber("Choisir un nombre pour 'b' :");
            Console.WriteLine($"Vous avez choisi {aNumber} pour 'a' et {bNumber} pour 'b' !");
            Console.WriteLine(InversionNumber(aNumber, bNumber));
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Return a number</returns>
        private static int AskNumber(String message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    return int.Parse(userEntry);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// Value inversion
        /// </summary>
        /// <param name="_aNumber">Number</param>
        /// <param name="_bNumber">Number</param>
        /// <returns>Return a string</returns>
        private static string InversionNumber(int _aNumber, int _bNumber)
        {
            int tmp = _aNumber;
            _aNumber = _bNumber;
            _bNumber = tmp;
            return $"Maintenant 'a' devient {_aNumber} et 'b' {_bNumber} !";
        }
    }
}

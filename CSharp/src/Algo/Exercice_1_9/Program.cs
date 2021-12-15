using System;

namespace Exercice_1_9_LesDiviseurD1Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = AskNumber("Recherche des diviseurs d’un nombre\n\nEntrer un nombre pour en récupérer tous ses diviseurs :");
            CheckAllDivisor(userNumber);
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Number</returns>
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
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// Check all divisor
        /// </summary>
        /// <param name="_userNumber">Number</param>
        private static void CheckAllDivisor(int _userNumber)
        {
            for (int divisor = 2; divisor <= _userNumber; divisor++)
            {
                if (_userNumber % divisor == 0 && divisor != _userNumber) Console.Write($"{divisor} ");
            }
        }
    }
}

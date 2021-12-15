using System;

namespace Exercice_1_6_NombresPremier
{
    class Program
    {
        static void Main(string[] args)
        {
            double userNumber = AskNumber("Nombre Premier\n\nVerifier si le nombre est premier :");
            userNumber = Math.Abs(userNumber);
            Console.WriteLine(CheckIfIsPrime(userNumber));
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Return a number</returns>
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
        /// I try to find if the number is prime
        /// </summary>
        /// <param name="_userNumber"></param>
        /// <returns>Return string result</returns>
        private static string CheckIfIsPrime(double _userNumber)
        {
            double divisor = 2;
            while (_userNumber % divisor != 0 && divisor <= Math.Sqrt(_userNumber))
            {
                divisor++;
            }

            if (divisor > Math.Sqrt(_userNumber)) return "Le chiffre est premier !";
            else return "Le chiffre n'est pas premier !";
        }
    }
}

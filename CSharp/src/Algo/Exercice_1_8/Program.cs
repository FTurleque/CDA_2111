using System;

namespace Exercice_1_8_AnneeBisextile
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = AskNumber("Année Bissextile\n\nEntrez une année pour verifier si elle est Bissextile :");
            Console.WriteLine(CheckIfIsBisextile(year));
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>A year</returns>
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
        /// I'm looking for leap year
        /// </summary>
        /// <param name="_year">Number</param>
        /// <returns>String result</returns>
        private static string CheckIfIsBisextile(int _year)
        {
            if (_year % 4 == 0 && _year % 100 != 0 || _year % 400 == 0) return "L'année est Bisextille";
            else return "L'année n'est pas Bisextille";
        }
    }
}

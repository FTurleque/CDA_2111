using System;

namespace Exercice_1_8
{
    class Program
    {
        private static string userEntry;
        private static int year;

        static void Main(string[] args)
        {
            year = AskNumber("Entrez une année pour verifier si elle est Bissextile :");
            Console.WriteLine(CheckIfIsBisextile());
        }

        private static int AskNumber(String message)
        {
            Console.WriteLine(message);
            do
            {
                userEntry = Console.ReadLine();
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

        private static string CheckIfIsBisextile()
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return "L'année est Bisextille";
            }
            else
            {
                return "L'année n'est pas Bisextille";
            }
        }
    }
}

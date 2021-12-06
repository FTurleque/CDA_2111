using System;
using System.Text;

namespace Exercice_1_9
{
    class Program
    {
        private static string userEntry;
        private static int userNumber;
        private static int divisor;

        static void Main(string[] args)
        {
            userNumber = AskNumber("Recherche des diviseurs d’un nombre\n\nEntrer un nombre pour en récupérer tous ses diviseurs :");
            CheckAllDivisor();
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

        private static void CheckAllDivisor()
        {
            for (divisor = 2; divisor <= userNumber; divisor++)
            {
                if (userNumber % divisor == 0 && divisor != userNumber) Console.Write($"{divisor} ");
            }
        }
    }
}

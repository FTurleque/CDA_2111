using System;

namespace Exercice_1_6_NombresPremier
{
    class Program
    {
        private static string userEntry;
        private static double userNumber;
        private static double divisor = 2;


        static void Main(string[] args)
        {
            userNumber = Math.Abs(userNumber);
            userNumber = AskNumber("Nombre Premier\n\nVerifier si le nombre est premier :");
            Console.WriteLine(CheckIfIsPrime());
        }

        private static int AskNumber(string message)
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

        private static string CheckIfIsPrime()
        {
            while (userNumber % divisor != 0 && divisor <= Math.Sqrt(userNumber))
            {
                divisor++;
            }

            if (divisor > Math.Sqrt(userNumber)) return "Le chiffre est premier !";
            else return "Le chiffre n'est pas premier !";
        }
    }
}

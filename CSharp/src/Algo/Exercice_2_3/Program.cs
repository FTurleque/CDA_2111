using System;

namespace Exercice_2_3
{
    class Program
    {
        private static string userEntry;
        private static int userNumber;
        private static int randomNumber;
        private static bool numberFind = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Jeu de la fourchette !");

            Random randomNb = new();
            randomNumber = randomNb.Next(0, 101);

            do
            {
                userNumber = AskNumber("Choisir un nombre entre 0 et 100 :");
                Console.WriteLine(NumberToFind());
            } while (numberFind == false);
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

        private static string NumberToFind()
        {
            if (userNumber > randomNumber) return "Le nombre à trouver est plus petit.";
            else if (userNumber < randomNumber) return "Le nombre à trouver est plus grand.";
            else
            {
                numberFind = true;
                return "Vous avez gagnez !!!!!";
            }
        }
    }
}

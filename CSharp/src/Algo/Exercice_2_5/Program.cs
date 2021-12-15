using System;

namespace Exercice_2_5_JeuDu0_2
{
    class Program
    {
        private static string userEntry;
        private static int userNumber;
        private static int numberComputer;
        private static int totalPointUser;
        private static int totalPointComputer;

        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du 0 - 2 !");
            do
            {
                numberComputer = RandomNumber();
                userNumber = AskNumber("Choisir un chiffre entre 0 et 2 :");
                WhoWinRound();
                Console.WriteLine($"Vous avez {totalPointUser} point(s)");
                Console.WriteLine($"L'ordinateur a {totalPointComputer} point(s)");
            } while (totalPointUser != 10 && totalPointComputer != 10);
            Console.WriteLine(WhoWinParty());
        }

        private static int AskNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                userEntry = Console.ReadLine();
                try
                {
                    int tmp = int.Parse(userEntry);

                    if (tmp < 3 && tmp >= 0 || tmp < 0) return tmp;
                    else
                    {
                        throw new FormatException("Vous n'avez pas entrez un chiffre entre 0 et 2, recommencez :");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        private static int RandomNumber()
        {
            Random randomNb = new();
            int randomNumber = randomNb.Next(0, 3);

            return randomNumber;
        }

        private static void WhoWinRound()
        {
            if (userNumber < 0) Environment.Exit(0);
            if (userNumber == numberComputer + 2 || userNumber == numberComputer - 2)
            {
                if (userNumber > numberComputer) totalPointUser += 1;
                else totalPointComputer += 1;
            }

            if (userNumber == numberComputer + 1 || userNumber == numberComputer - 1)
            {
                if (userNumber > numberComputer) totalPointComputer += 1;
                else totalPointUser += 1;
            }

            if (userNumber == numberComputer) Console.WriteLine("Egalitée, personne ne marque de point !");
        }

        private static string WhoWinParty()
        {
            if (totalPointUser == 10) return "Vous avez gagnez !";
            else return "Vous avez perdu !";
        }
    }
}

using System;

namespace Exercice_2_5_JeuDu0_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du 0 - 2 !");
            int totalPointUser = 0;
            int totalPointComputer = 0;
            do
            {
                int numberComputer = RandomNumber();
                int userNumber = AskNumber("Choisir un chiffre entre 0 et 2 :");
                WhoWinRound(numberComputer, userNumber, ref totalPointUser, ref totalPointComputer);
                Console.WriteLine($"Vous avez {totalPointUser} point(s)");
                Console.WriteLine($"L'ordinateur a {totalPointComputer} point(s)");
            } while (totalPointUser != 10 && totalPointComputer != 10);
            Console.WriteLine(WhoWinParty(totalPointUser));
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Return the number</returns>
        private static int AskNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
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

        /// <summary>
        /// I generate a random number
        /// </summary>
        /// <returns>Random number</returns>
        private static int RandomNumber()
        {
            Random randomNb = new();
            int randomNumber = randomNb.Next(0, 3);

            return randomNumber;
        }

        /// <summary>
        /// I check who win the round and I icreases the score
        /// </summary>
        /// <param name="_numberComputer">Number</param>
        /// <param name="_userNumber">Number</param>
        /// <param name="_totalPointUser">Number</param>
        /// <param name="_totalPointComputer">Number</param>
        private static void WhoWinRound(int _numberComputer, int _userNumber, ref int _totalPointUser, ref int _totalPointComputer)
        {
            if (_userNumber < 0) Environment.Exit(0);
            if (_userNumber == _numberComputer + 2 || _userNumber == _numberComputer - 2)
            {
                if (_userNumber > _numberComputer) _totalPointUser += 1;
                else _totalPointComputer += 1;
            }

            if (_userNumber == _numberComputer + 1 || _userNumber == _numberComputer - 1)
            {
                if (_userNumber > _numberComputer) _totalPointComputer += 1;
                else _totalPointUser += 1;
            }

            if (_userNumber == _numberComputer) Console.WriteLine("Egalitée, personne ne marque de point !");
        }

        /// <summary>
        /// I check if the user win the game
        /// </summary>
        /// <param name="_totalPointUser">Number</param>
        /// <returns>String result</returns>
        private static string WhoWinParty(int _totalPointUser)
        {
            if (_totalPointUser == 10) return "Vous avez gagnez !";
            else return "Vous avez perdu !";
        }
    }
}

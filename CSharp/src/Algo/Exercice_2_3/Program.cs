using System;

namespace Exercice_2_3_JeuDeLaFourchette
{
    class Program
    {
        private static bool numberFind = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Jeu de la fourchette !");
            Random randomNb = new();
            int randomNumber = randomNb.Next(0, 101);
            int counter = 0;
            do
            {
                int userNumber = AskNumber("Choisir un nombre entre 0 et 100 :");
                counter++;
                Console.WriteLine(NumberToFind(randomNumber, userNumber, counter));
            } while (numberFind == false);
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
                    return int.Parse(userEntry);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_randomNumber">Number</param>
        /// <param name="_userNumber">Number</param>
        /// <returns>String result</returns>
        private static string NumberToFind(int _randomNumber, int _userNumber, int _counter)
        {
            if (_userNumber > _randomNumber) return "Le nombre à trouver est plus petit.";
            else if (_userNumber < _randomNumber) return "Le nombre à trouver est plus grand.";
            else
            {
                numberFind = true;
                return $"Vous avez gagnez en {_counter} fois !";
            }
        }
    }
}

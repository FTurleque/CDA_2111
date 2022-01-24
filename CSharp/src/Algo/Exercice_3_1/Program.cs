using System;

namespace Exercice_3_1_RechercherUnNombreDansUnTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mysteryNumber = new int[] { 2, 10, 8, 13, 16, 19 };
            int userNumber = AskNumber("Rechercher un nombre dans un tableau !\nChoisir un nombre entier entre 1 et 20 :");
            Console.WriteLine(CheckIfIsFind(userNumber, mysteryNumber));
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
                    int userNb = int.Parse(userEntry);
                    if (userNb < 1 || userNb > 20) throw new Exception("Le nombre n'est pas compris entre 1 et 20.");
                    else return userNb;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// Check if the number is in the array
        /// </summary>
        /// <param name="_userNumber">Number</param>
        /// <param name="_mysteryNumber">Number</param>
        /// <returns>String result</returns>
        static string CheckIfIsFind(int _userNumber, int[] _mysteryNumber)
        {
            bool find = false;
            for (int i = 0; i < _mysteryNumber.Length; i++)
            {
                if (_mysteryNumber[i] == _userNumber)
                {
                    find = true;
                }
            }
            if (find) return "Vous avez Gagnez !";
            else return "Perdu, rejouez !";
        }
    }
}

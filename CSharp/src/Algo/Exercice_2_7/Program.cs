using System;
using System.Text;

namespace Exercice_2_7_CalculDuNombreDePersonne
{
    class Program
    {
        private static StringBuilder ageOfAllPeoples;

        static void Main(string[] args)
        {
            Console.WriteLine("Entrez l'âge de 20 personnes :");
            int[] peoples = AskNumber("Pour la personne n°");
            Console.WriteLine(CheckIfTheyAreAdult(peoples));
            Console.WriteLine(ageOfAllPeoples);
        }

        /// <summary>
        /// Request a age of peoples from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Number array</returns>
        private static int[] AskNumber(string message)
        {
            int[] ageOfPeople = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(message + (i + 1) + " :");

                string userEntry = Console.ReadLine();
                try
                {
                    ageOfPeople[i] = int.Parse(userEntry);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            }
            return ageOfPeople;
        }

        /// <summary>
        /// I check how many youger is in the array
        /// </summary>
        /// <param name="ageOfPeople">Number array</param>
        /// <returns>String result</returns>
        private static string CheckIfTheyAreAdult(int[] ageOfPeople)
        {
            int adultsNumber = 0;
            int notAdultNumber = 0;
            ageOfAllPeoples = new StringBuilder("");
            for (int i = 0; i < ageOfPeople.Length; i++)
            {
                int tmp = ageOfPeople[i];
                if (tmp < 20) notAdultNumber++;
                else adultsNumber++;
                ageOfAllPeoples.Append(tmp);
                ageOfAllPeoples.Append(" ");
            }
            if (notAdultNumber == ageOfPeople.Length) return "Il n'y a pas d'adultes !";
            else if (adultsNumber == ageOfPeople.Length) return "Il n'y a pas de jeunes !";
            else return $"Il y a des {notAdultNumber} jeunes et {adultsNumber} adultes !";
        }
    }
}

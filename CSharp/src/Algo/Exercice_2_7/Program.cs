using System;
using System.Text;

namespace Exercice_2_7
{
    class Program
    {
        private static string userEntry;
        private static int[] ageOfPeople = new int[20];
        private static int adultsNumber = 1;
        private static int minorNumber = 1;
        private static StringBuilder ageOfAllPeoples;

        static void Main(string[] args)
        {
            AskNumber("Entrez l'âge de 20 personnes \nPour la personne n°");
            Console.WriteLine(CheckIfTheyAreAdult());
            Console.WriteLine(ageOfAllPeoples);
        }

        private static void AskNumber(string message)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(message + (i + 1) + " :");

                userEntry = Console.ReadLine();
                try
                {
                    ageOfPeople[i] = int.Parse(userEntry);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            }
        }

        private static string CheckIfTheyAreAdult()
        {
            ageOfAllPeoples = new StringBuilder("");
            for (int i = 0; i < ageOfPeople.Length - 1; i++)
            {
                int tmp = ageOfPeople[i];
                if (tmp < 18)
                {
                    minorNumber++;
                }
                else
                {
                    adultsNumber++;
                }
                ageOfAllPeoples.Append(tmp);
                ageOfAllPeoples.Append(" ");
            }

            if (minorNumber == ageOfPeople.Length) return "Il n'y a pas d'adultes !";
            else if (adultsNumber == ageOfPeople.Length) return "Il n'y a pas de jeunes !";
            else return $"Il y a des {minorNumber} jeunes et {adultsNumber} adultes !";

        }
    }
}

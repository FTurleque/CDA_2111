using System;
using System.Text;

namespace Exercice_2_7_CalculDuNombreDePersonne
{
    class Program
    {
        private static string userEntry;
        private static int[] ageOfPeople = new int[20];
        private static int adultsNumber = 0;
        private static int minorNumber = 0;
        private static StringBuilder ageOfAllPeoples;

        static void Main(string[] args)
        {
            Console.WriteLine("Entrez l'âge de 20 personnes :");
            AskNumber("Pour la personne n°");
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
            for (int i = 0; i < ageOfPeople.Length; i++)
            {
                int tmp = ageOfPeople[i];
                if (tmp < 20)
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

using System;

namespace Exercice_3_1
{
    class Program
    {
        private static string userEntry;
        private static int userNumber;
        private static int[] mysteryNumber = new int[] { 2, 10, 8, 13, 16, 19};
        private static bool find = false;

        static void Main(string[] args)
        {
            userNumber = AskNumber("Rechercher un nombre dans un tableau !\nChoisir un nombre entier entre 1 et 20 :");
            Console.WriteLine(CheckIfIsFind());
        }

        private static int AskNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                userEntry = Console.ReadLine();
                try
                {
                    int userNb = int.Parse(userEntry);
                    if (userNumber < 1 || userNumber > 20)
                    {
                        throw new Exception("Le nombre n'est pas compris entre 1 et 20.");
                    }
                    else
                    {
                        return userNb;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        static string CheckIfIsFind()
        {
            for (int i = 0; i < mysteryNumber.Length; i++)
            {
                if (mysteryNumber[i] == userNumber)
                {
                    find = true;
                }
            }

            if (find)
            {
                return "Vous avez Gagnez !";
            }
            else
            {
                return "Perdu, rejouez !";
            }
        }
    }
}

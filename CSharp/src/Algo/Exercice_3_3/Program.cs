using System;

namespace Exercice_3_3_DenombrerLesLettres
{
    class Program
    {
        private static string userEntry;
        private static string textUser;
        private static int countLetter;
        private static string alphabet = "abcdefghijklmnopqrstuvwxyz";

        static void Main(string[] args)
        {
            textUser = AskTextUser("Rechercher une lettre dans un chaine de caractères !\nSaisir un texte :");
            FindOccurenceLetter();
        }

        private static string AskTextUser(string message)
        {
            do
            {
                Console.WriteLine(message);
                userEntry = Console.ReadLine();
                try
                {
                    if (!string.IsNullOrEmpty(userEntry))
                    {
                        return userEntry.ToLower();
                    }
                    else throw new Exception("Votre phrase est vide, recommencez :");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur de format : " + e.Message);
                }

            } while (true);
        }

        private static void FindOccurenceLetter()
        {
            char[] az = alphabet.ToCharArray();
            char[] convertedSentence = textUser.ToCharArray();
            foreach (char i in az)
            {
                countLetter = 0;
                foreach (char j in convertedSentence)
                {
                    if (j == i)
                    {
                        countLetter++;
                    }
                }
                Console.WriteLine($"Il y a {countLetter} {i} dans le text.");
            }
        }

    }
}

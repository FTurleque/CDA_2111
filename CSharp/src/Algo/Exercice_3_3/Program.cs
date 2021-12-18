using System;
using System.Text.RegularExpressions;

namespace Exercice_3_3_DenombrerLesLettres
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLetter = 0;
            string textUser = AskTextUser("Rechercher une lettre dans un chaine de caractères !\nSaisir un texte :");
            FindOccurenceLetter(textUser, ref countLetter);
        }

        /// <summary>
        /// Ask the user a question to enter a sentence ending with a point
        /// </summary>
        /// <param name="message">String</param>
        /// <returns>String result</returns>
        private static string AskTextUser(string message)
        {
            do
            {
                Console.WriteLine(message);
                string userEntry = Console.ReadLine();
                try
                {
                    if (!string.IsNullOrEmpty(userEntry) && Regex.IsMatch(userEntry, @"^[a-zA-Z\s]+$")) return userEntry.ToLower();
                    else throw new Exception("Votre phrase est vide, recommencez :");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur de format : " + e.Message);
                }
            } while (true);
        }

        /// <summary>
        /// Find occurence of one letter in a sentence
        /// </summary>
        /// <param name="textUser">String</param>
        /// <param name="countLetter">Int</param>
        private static void FindOccurenceLetter(string textUser, ref int countLetter)
        {
            
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] az = alphabet.ToCharArray();
            char[] convertedSentence = textUser.ToCharArray();
            foreach (char i in az)
            {
                foreach (char j in convertedSentence)
                {
                    if (j == i) countLetter++;
                }
                Console.WriteLine($"Il y a {countLetter} {i} dans le text.");
            }
        }

    }
}

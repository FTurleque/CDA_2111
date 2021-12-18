using System;
using System.Text.RegularExpressions;

namespace Exercice_3_2_RechercheUneLettreDansUneString
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSentence = AskASentence("Ecrivez une phrase en finissant par un point '.' :");
            char letterChosen = AskALetter("Choisir une lettre :");
            Console.WriteLine($"Il y a {FindOccurenceLetter(userSentence, letterChosen)} fois la lettre {letterChosen} !");
        }

        /// <summary>
        /// Ask the user a question to enter a sentence ending with a point
        /// </summary>
        /// <param name="message">String</param>
        /// <returns>String result</returns>
        private static string AskASentence(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    if ((userEntry.EndsWith(".") || !string.IsNullOrEmpty(userEntry)) && Regex.IsMatch(userEntry, @"^[\D]+$")) return userEntry;
                    else if (Regex.IsMatch(userEntry, @"^[0-9]+$")) throw new FormatException("Vous n'avez pas ecrit une phrase mais que des chiffres, recommencez :");
                    else if (Regex.IsMatch(userEntry, @"^[A-Za-z]")) return userEntry;
                    else throw new Exception("Votre phrase est vide ou vous ne finissez pas par un point !");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Erreur de format : " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur générale : " + e.Message);
                }
            } while (true);
        }

        /// <summary>
        /// Ask the user a question to enter a letter
        /// </summary>
        /// <param name="message">String</param>
        /// <returns>Letter</returns>
        private static char AskALetter(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntryChar = Console.ReadLine();
                try
                {
                    /*Regex.IsMatch(userEntry, @"^[\D]+$");*/
                    if (!string.IsNullOrEmpty(userEntryChar) && Regex.IsMatch(userEntryChar, @"^[A-Za-z]")) return char.Parse(userEntryChar);
                    else if (Regex.IsMatch(userEntryChar, @"^[0-9]+$")) throw new FormatException("Vous n'avez pas ecrit une lettre mais un chiffre, recommencez :");
                    else throw new Exception("Vous n'avez rien saisie, recommencez :");
                }
                catch (FormatException e)
                {
                    /*Console.WriteLine("Vous n'avez pas entrez une phrase, recommencez :");*/
                    Console.WriteLine("Erreur de format : " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur générale : " + e.Message);
                }
            } while (true);
        }

        /// <summary>
        /// find occurence of the letter in the sentence 
        /// </summary>
        /// <param name="_userSentence">String</param>
        /// <param name="_letterChosen">Char</param>
        /// <returns>Number occurence</returns>
        private static int FindOccurenceLetter(string _userSentence, char _letterChosen)
        {
            int occurenceNumber = 0;
            char[] convertedSentence = _userSentence.ToCharArray();
            foreach (char i in convertedSentence) if (i == _letterChosen) occurenceNumber++;
            return occurenceNumber;
        }
    }
}

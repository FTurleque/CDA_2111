using System;
using System.Text.RegularExpressions;

namespace Exercice_3_2
{
    class Program
    {
        private static string userEntry;
        private static string userEntryChar;
        private static char letterChosen;
        private static string userSentence;
        private static int occurenceNumber = 0;

        static void Main(string[] args)
        {
            userSentence = AskASentence("Ecrivez une phrase en finissant par un point '.' :");
            letterChosen = AskALetter("Choisir une lettre :");
            Console.WriteLine($"Il y a {FindOccurenceLetter()} fois la lettre {letterChosen} !");
        }

        private static string AskASentence(string message)
        {
            Console.WriteLine(message);

            do
            {
                userEntry = Console.ReadLine();
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

        private static char AskALetter(string message)
        {
            Console.WriteLine(message);

            do
            {
                userEntryChar = Console.ReadLine();
                try
                {
                    /*Regex.IsMatch(userEntry, @"^[\D]+$");*/
                    if (!string.IsNullOrEmpty(userEntryChar) && Regex.IsMatch(userEntryChar, @"^[A-Za-z]")) return char.Parse(userEntryChar);
                    else if (Regex.IsMatch(userEntry, @"^[0-9]+$")) throw new FormatException("Vous n'avez pas ecrit une lettre mais un chiffre, recommencez :");
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

        private static int FindOccurenceLetter()
        {
            Char[] convertedSentence = userSentence.ToCharArray();
            foreach (char i in convertedSentence)
            {
                if (i == letterChosen)
                {
                    occurenceNumber++;
                }
            }
            return occurenceNumber;
        }
    }
}

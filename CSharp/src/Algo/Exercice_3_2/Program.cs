using System;
using System.Text.RegularExpressions;

namespace Exercice_3_2
{
    class Program
    {
        private static string userEntry;
        private static string userSentence;
        /*Regex regex = new Regex(@"^[\D]+$");*/


        static void Main(string[] args)
        {
            AskNumber("Ecrivez une phrase en finissant par un point '.' :");
        }

        private static void AskNumber(string message)
        {
            Console.WriteLine(message);

            userEntry = Console.ReadLine();
            try
            {
                /*Regex.IsMatch(userEntry, @"^[\D]+$");*/
                if ((userEntry.EndsWith(".") || !string.IsNullOrEmpty(userEntry)) && Regex.IsMatch(userEntry, @"^[\D]+$"))
                {

                }
                else if (Regex.IsMatch(userEntry, @"^[0-9]+$")) throw new FormatException("Vous n'avez pas ecrit une phrase mais que des chiffres, recommencez :");
                else throw new Exception("Votre phrase est vide ou vous ne finissez pas par un point !");
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
        }
    }
}

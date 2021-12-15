using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Exercice_3_5_Palindrome
{
    class Program
    {
        private static string userEntry;

        static void Main(string[] args)
        {
            string wordUser = AskAWord("Verification si un mot est un Palindrome !\nEcrivez un seul mot :").ToLower();
            Console.WriteLine(PalindromeOrNot(wordUser));
        }

        private static string AskAWord(string message)
        {
            Console.WriteLine(message);
            do
            {
                userEntry = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(userEntry) || userEntry.Equals(" ")) throw new Exception("La phrase est vide !\nrecommencez :");
                    else if (Regex.IsMatch(userEntry, @"^[0-9]+$")) throw new Exception("Vous n'avez entrer que des chiffres !\nREcommencez :");
                    else if (Regex.IsMatch(userEntry, @"^[a-zA-Z]+$")) return userEntry;
                    else throw new Exception("Vous n'avez entrer un seul mot !\nRecommencez :");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }

        private static string PalindromeOrNot(string _wordUser)
        {
            bool isAPalindrome = false;
            isAPalindrome = _wordUser.SequenceEqual(_wordUser.Reverse());
            if (isAPalindrome == true) return "La chaîne de caractères est un palindrome";
            else return "La chaîne de caractères n'est pas un palindrome !";
        }
    }
}

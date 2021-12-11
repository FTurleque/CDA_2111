using System;
using System.Text.RegularExpressions;

namespace Recursif_Exercice_2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordUser = AskAWord("Verification si un mot est un Palindrome en récursif !\n\nEcrivez un seul mot :").ToLower();
            int startIndex = 0;
            int length = wordUser.Length - 1;
            Console.WriteLine($"{GetPalindrome(wordUser, startIndex, length)}");
        }

        private static string GetPalindrome(string _wordUser, int _index, int _length)
        {
            string letterLeft = _wordUser.Substring(_index, 1);
            string letterRight = _wordUser.Substring(_length, 1);
            if (!letterLeft.Equals(letterRight)) return "Ce n'est pas un Palindrome";
            else if (letterLeft.Equals(letterRight) && _index < _length - 1)
            {
                return GetPalindrome(_wordUser, _index + 1, _length - 1);
            }
            else return "C'est un Palindrome";
        }

        private static string AskAWord(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
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

    }
}

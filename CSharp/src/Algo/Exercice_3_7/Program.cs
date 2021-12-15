using System;
using System.Text.RegularExpressions;

namespace Exercice_3_7_Dichotomie
{
    class Program
    {
        private static string alphabet = "abcdefghijklmnopqrstuvwxyz";

        static void Main(string[] args)
        {
            string nameUser = AskNameUser("Recherche par dichotomie d'un élément dans un tableau classé !\nEntrez un nom sans charactères spéciaux :");
            Console.WriteLine(FindName(nameUser));
        }

        private static string AskNameUser(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    if (Regex.IsMatch(userEntry, @"^[a-zA-Z]+$")) return userEntry.ToLower();
                    else throw new Exception("Vous n'avez pas entrer un noms !\nRecommencez :");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }

        private static string FindName(string _nameUser)
        {
            string[] namePeoples = { "agathe", "berthe", "chloé", "cunégonde", "fabrice", "olga", "raymonde", "sidonie" };
            int startArray = 0;
            int endArray = namePeoples.Length - 1;
            bool nameFind = false;
            int midleArray = (startArray + endArray) / 2;

            while (namePeoples[midleArray] != _nameUser && startArray < endArray)
            {
                if (namePeoples[midleArray] == _nameUser) nameFind = true;
                else
                {
                    /*char[] _alphabet = alphabet.ToCharArray();*/
                    char[] tmpArray = namePeoples[midleArray].ToCharArray();
                    char[] tmpUser = _nameUser.ToCharArray();
                    int index = 0;
                    if (tmpArray[0] > tmpUser[0]) endArray = midleArray - 1;
                    else startArray = midleArray + 1;
                    midleArray = (startArray + endArray) / 2;
                }
            }

            if (namePeoples[midleArray] == _nameUser) return $"{_nameUser} est a l'index {midleArray} dans le tableau !";
            else return "Le nom n'est pas présent dans le tableau !";
        }
    }
}

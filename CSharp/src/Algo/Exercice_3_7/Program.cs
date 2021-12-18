using System;
using System.Text.RegularExpressions;

namespace Exercice_3_7_Dichotomie
{
    class Program
    {

        static void Main(string[] args)
        {
            string nameUser = AskNameUser("Recherche par dichotomie d'un élément dans un tableau classé !\nEntrez un nom sans charactères spéciaux :");
            Console.WriteLine(FindName(nameUser));
        }

        /// <summary>
        /// Ask the user a question to enter a name
        /// </summary>
        /// <param name="message">String</param>
        /// <returns>String result</returns>
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

        /// <summary>
        /// I check if the name is in the array and return is place
        /// </summary>
        /// <param name="_nameUser">String</param>
        /// <returns>String result</returns>
        private static string FindName(string _nameUser)
        {
            string[] namePeoples = { "agathe", "berthe", "chloe", "cunegonde", "fabrice", "olga", "raymonde", "sidonie" };
            int startArray = 0;
            int endArray = namePeoples.Length - 1;
            int midleArray = (startArray + endArray) / 2;

            while (namePeoples[midleArray] != _nameUser && startArray < endArray)
            {
                if (namePeoples[midleArray] != _nameUser) 
                {
                    char[] tmpArray = namePeoples[midleArray].ToCharArray();
                    char[] tmpUser = _nameUser.ToCharArray();
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

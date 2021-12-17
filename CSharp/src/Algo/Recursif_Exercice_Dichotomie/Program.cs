using System;
using System.Text.RegularExpressions;

namespace Recursif_Exercice_Dichotomie
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = 0;
            string[] namePeoples = { "agathe", "berthe", "chloe", "cunégonde", "olga", "raymonde", "sidonie" };
            int arrayLength = namePeoples.Length - 1;

            //string nameUser = AskNameUser("Recherche par dichotomie d'un élément dans un tableau classé !\nEntrez un nom sans charactères spéciaux :");
            string nameUser = "sidonie";
            Console.WriteLine(FindName(namePeoples, nameUser, startIndex, arrayLength));
        }

        private static string FindName(string[] _namePeoples, string _nameUser, int _startIndex, int _arrayLength)
        {
            int middleArray = (_arrayLength + _startIndex) / 2;
            Console.WriteLine(_nameUser[0]);
            Console.WriteLine(_namePeoples[middleArray][0]);
            if (_namePeoples[middleArray] == _nameUser) return $"{_nameUser} est bien dans le tableau à l'index {_startIndex} soit à la place {_startIndex + 1}.";
            else if (_nameUser[0] < _namePeoples[middleArray][0]) return FindName(_namePeoples, _nameUser, _startIndex, middleArray - 1);
            else if (_nameUser[0] > _namePeoples[middleArray][0]) return FindName(_namePeoples, _nameUser, middleArray + 1, _arrayLength);
            else return $"{_nameUser} n'est pas present dans le tableau !";
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

    }
}

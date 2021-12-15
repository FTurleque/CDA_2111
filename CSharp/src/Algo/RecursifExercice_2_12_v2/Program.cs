using System;
using System.Text.RegularExpressions;

namespace Recursif_Exercice_2_12_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = AskAString("Permutations des charactère\n\nChoisir une suite de lettres dans l'ordre alphabetique :");
            int permutationNumber = AskNumber($"Choisir le numéro de la permutation à afficher sur la chaine de charactère '{userString}' :");
            string newString = "";
            Permutation(newString, userString, ref permutationNumber);
        }

        private static void Permutation(string _newString, string _userString, ref int _permutationNumber)
        {

            if (_userString.Length == 0)
            {
                //Console.WriteLine($"La permutation {index} {_newString}");
                if (_permutationNumber == 1) Console.WriteLine($"La permutation demandé est {_newString} !");
                //index++;
                _permutationNumber--;
            }
            for (int i = 0; i < _userString.Length; i++)
            {
                /*string tmp = _userString.Substring(i, 1);
                Console.WriteLine(tmp);
                string tmp2 = _userString.Substring(0, i);
                Console.WriteLine(tmp2);
                string tmp3 = _userString.Substring(i + 1, _userString.Length - 1 - i);
                Console.WriteLine(tmp3);*/
                Permutation(_newString + _userString.Substring(i, 1), _userString.Substring(0, i) + _userString.Substring(i + 1, _userString.Length - 1 - i), ref _permutationNumber);
            }
        }

        private static string AskAString(string message)
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

        private static int AskNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    return int.Parse(userEntry);
                }
                catch (Exception)
                {
                    Console.WriteLine("Vous n'avez pas entrez un nombre entier positif, recommencez :");
                }
            } while (true);
        }


    }
}

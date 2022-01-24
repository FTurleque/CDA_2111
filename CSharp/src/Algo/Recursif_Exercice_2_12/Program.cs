using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Recursif_Exercice_2_12_PermutationChar
{
    class Program
    {
        private static int permutationNumber;
        private static int indexPerm = 0;
        private static string userString;

        static void Main(string[] args)
        {
            //Dont return good value
            userString = "abc";
            permutationNumber = AskNumber($"Choisir le numéro de permutation à afficher sur la chaine de charactère '{userString}' :");

            char[] arrayUserString = userString.ToCharArray();
            int stringLength = userString.Length - 1;
            int indexChar = 0;
            GetPermutation(arrayUserString, indexChar, stringLength);


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

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            char temp = a;
            a = b;
            b = temp;
        }

        private static void GetPermutation(char[] _arrayAlphabet, int _indexChar, int _stringLength)
        {
            if (_indexChar == _stringLength)
            {
                indexPerm++;
                string tmp = DisplayWord(_arrayAlphabet).ToString();
                Console.WriteLine($"La permutation {indexPerm} est : {tmp}");
                if (permutationNumber == indexPerm)
                {
                    Console.WriteLine(_arrayAlphabet);
                }
            }
            else
            {
                for (int i = _indexChar; i <= _stringLength; i++)
                {
                    Console.WriteLine(_arrayAlphabet);

                    Swap(ref _arrayAlphabet[_indexChar], ref _arrayAlphabet[i]);
                    GetPermutation(_arrayAlphabet, _indexChar + 1, _stringLength);
                    Swap(ref _arrayAlphabet[_indexChar], ref _arrayAlphabet[i]);

                    Console.WriteLine(_arrayAlphabet);

                }

            }
        }

        private static StringBuilder DisplayWord(char[] _word)
        {
            StringBuilder dysplayWord = new StringBuilder("");
            foreach (char letter in _word)
            {
                dysplayWord.Append(letter);
            }
            return dysplayWord;
        }



        /*private static void GetPermutation(char[] _arrayAlphabet, int _indexChar, int _stringLength)
        {
            if (_indexChar == _stringLength)
            {
                string tmp = _arrayAlphabet.ToString();
                indexPerm++;
                Console.WriteLine(_arrayAlphabet);
                //if (permutationNumber == indexPerm) Console.WriteLine(_arrayAlphabet);
                if (tmp.Equals(alphabetToFind))
                {
                    Console.WriteLine(_arrayAlphabet);
                    Console.ReadKey();
                }
            }
            else
            {
                for (int i = _indexChar; i <= _stringLength; i++)
                {
                    Swap(ref _arrayAlphabet[_indexChar], ref _arrayAlphabet[i]);
                    GetPermutation(_arrayAlphabet, _indexChar + 1, _stringLength);
                    Swap(ref _arrayAlphabet[_indexChar], ref _arrayAlphabet[i]);
                }
            }
        }
*/
    }
}

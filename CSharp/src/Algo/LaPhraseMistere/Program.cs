using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace LaPhraseMistere
{
    class Program
    {
        /*private const string alphabet = "azertyuiopqs dfghjklmwxcvbn";
        private static char[] alphabetChar = alphabet.ToCharArray();
        private static int alphabetLength = alphabet.Length;*/
        private static ArrayList newWords = new();
        private static StringBuilder wordFind = new("");

        static void Main(string[] args)
        {
            string userString = AskAString("Permutation de charactères\n\nEntrez une suite de lettre à permuter (sans espace) :");
            ArrayList userWord = new ArrayList(userString.ToCharArray());
            //Console.Clear();
            //permutationNumber = AskNumber("Choisir le nombre de permutation à effectuer :");

            /*            string toFind = "portez ce vieux whisky au juge blond qui fume";
                        char[] toFindInCharArray = toFind.ToCharArray();
                        int indexLengthToFind = toFind.Length - 1;
            */
            string[] letters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            //string[] letters = new string[] { "a", "e", "r", "t", "y", "z"};
            ArrayList words = CalculateWordPermutations(letters, userWord, 0);
            for (int i = 0; i < userString.Length; i++)
            {
                wordFind.Append(words[i]);
            }
            Console.WriteLine(wordFind);
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

        /*        public static ArrayList CalculateWordPermutations(string[] letters, ArrayList words, int index)
                {
                    bool finished = true;
                    ArrayList newWords = new ArrayList();
                    if (words.Count == 0)
                    {
                        foreach (string letter in letters)
                        {
                            words.Add(letter);
                        }
                    }

                    for (int j = index; j < words.Count; j++)
                    {
                        string word = words[j].ToString();
                        for (int i = 0; i < letters.Length; i++)
                        {
                            if (!word.Contains(letters[i]))
                            {
                                finished = false;
                                string newWord = word.Clone().ToString();
                                newWord += letters[i];
                                newWords.Add(newWord);
                            }
                        }
                    }

                    foreach (string newWord in newWords)
                    {
                        words.Add(newWord);
                    }

                    if (finished == false)
                    {
                        CalculateWordPermutations(letters, words, words.Count - newWords.Count);
                    }
                    return words;
                }
        */
        public static ArrayList CalculateWordPermutations(string[] letters, ArrayList words, int index)
        {
            
            if (words.Count == newWords.Count)
            {

            }

            for (int j = index; j < words.Count; j++)
            {
                char word = char.Parse(words[j].ToString());
                for (int i = 0; i < letters.Length; i++)
                {
                    if (word == char.Parse(letters[i]))
                    {
                        newWords.Add(letters[i]);
                        CalculateWordPermutations(letters, words, words.Count - newWords.Count);
                    }
                }
                
            }
            return newWords;
        }

    }
}

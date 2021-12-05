using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercice_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] wordToFind = AskAWord("Jeu du pendu !\nEntrez le mot Mystère ne comportant que 6 lettres différentes :");
            Console.Clear();
            char[] wordHidden = new char[wordToFind.Length];
            wordHidden = WordLetterPlaced(wordHidden);
            Console.WriteLine(DisplayWord(wordHidden));
            FindAWord(wordToFind, wordHidden);
        }

        // Vérification si le mot comporte au maximum 6 charatères different
        // A insérer
        private static char[] AskAWord(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    if (Regex.IsMatch(userEntry, $"^[a-zA-Z]+$")) return userEntry.ToCharArray();
                    else throw new Exception("Vous n'avez pas entrez un mot !\nRéessayez :");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (true);
        }

        private static char AskLetter(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    if (Regex.IsMatch(userEntry, $"[a-zA-Z]?")) return char.Parse(userEntry);
                    else throw new Exception("Vous n'avez pas entrez une lettre !\nRéessayez :");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Erreur de format : " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            } while (true);

        }

        private static char[] WordLetterPlaced(char[] _word)
        {
            for (int i = 0; i < _word.Length; i++)
            {
                _word[i] = '-';
            }
            return _word;
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



        private static void FindAWord(char[] _wordToFind, char[] _wordHidden)
        {
            int life = 0;
            do
            {
                char suggestedLetter = AskLetter("Entrez une lettre de l'alphabet :");
                for (int i = 0; i < _wordToFind.Length; i++)
                {
                    char tmp = _wordToFind[i];
                    if (tmp == suggestedLetter)
                    {
                        _wordHidden[i] = suggestedLetter;
                    }
                }
                Console.WriteLine(DisplayWord(_wordHidden));
                life++;
            } while (life != 6);
        }

    }
}

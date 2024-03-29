﻿using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercice_3_6_JeuDuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] wordToFind = AskAWord("Jeu du pendu !\nEntrez le mot Mystère comportant minimum 5 lettres :");
            Console.Clear();
            char[] wordHidden = new char[wordToFind.Length];
            wordHidden = WordLetterPlaced(wordHidden);
            Console.WriteLine(DisplayWord(wordHidden));
            Console.WriteLine(FindAWord(wordToFind, wordHidden));
        }

        /// <summary>
        /// Ask the user a question to enter a word
        /// </summary>
        /// <param name="message">String</param>
        /// <returns>Char array result</returns>
        private static char[] AskAWord(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    if (Regex.IsMatch(userEntry, $"^[a-zA-Z]*$"))
                    {
                        if (userEntry.Length > 4) return userEntry.ToCharArray();
                        else throw new Exception("Vous n'avez pas entrez assez de charachtères, recommencez avec au moins 5 lettre differentes :");
                    }
                    else throw new Exception("Vous n'avez pas entrez un mot !\nRéessayez :");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (true);
        }

        /// <summary>
        /// Ask the user a question to enter a letter
        /// </summary>
        /// <param name="message">Char</param>
        /// <returns>Char result</returns>
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

        /// <summary>
        /// I replace the word with dashes to hide it
        /// </summary>
        /// <param name="_word">Char array</param>
        /// <returns>Char array result</returns>
        private static char[] WordLetterPlaced(char[] _word)
        {

            for (int i = 0; i < _word.Length; i++) _word[i] = '-';
            return _word;
        }

        /// <summary>
        /// Display the word
        /// </summary>
        /// <param name="_word">Char array</param>
        /// <returns>String result</returns>
        private static StringBuilder DisplayWord(char[] _word)
        {
            StringBuilder dysplayWord = new StringBuilder("");
            foreach (char letter in _word) dysplayWord.Append(letter);
            return dysplayWord;
        }

        /// <summary>
        /// I check if the word contain the letter
        /// </summary>
        /// <param name="_wordToFind">Char array</param>
        /// <param name="_wordHidden">Char array</param>
        /// <returns>String result</returns>
        private static string FindAWord(char[] _wordToFind, char[] _wordHidden)
        {
            int wordFind = 0;
            int life = 6;
            do
            {
                bool find = false;
                char suggestedLetter = AskLetter($"Vous avez encore {life} Entrez une lettre de l'alphabet :");
                Console.Clear();
                for (int i = 0; i < _wordToFind.Length; i++)
                {
                    char tmp = _wordToFind[i];
                    if (tmp == suggestedLetter)
                    {
                        _wordHidden[i] = suggestedLetter;
                        wordFind++;
                        find = true;
                    }
                }
                Console.WriteLine(DisplayWord(_wordHidden));
                if (find == false) life--;
                if (life > 1) Console.WriteLine($"Il vous reste {life} chances !");
                else Console.WriteLine($"Il vous reste {life} chance !");
            } while (!(life == 0 || wordFind == _wordToFind.Length));

            if (wordFind == _wordToFind.Length) return "Vous avez gagnez, bravo !";
            else return "Vous avez perdu ! :( ";
        }
    }
}

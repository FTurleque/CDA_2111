using System;

namespace Exercice_1_7_TriDeNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = AskNumber("Tri de nombres\n\nChoisir un nombre pour 'a' :");
            int bNumber = AskNumber("Choisir un nombre pour 'b' :");
            int cNumber = AskNumber("Choisir un nombre pour 'c' :");
            Console.WriteLine($"Les chiffres dans l'ordre croissant sont : {CheckNumber(aNumber, bNumber, cNumber)} !");
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Return a number</returns>
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
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// I sort the numbers
        /// </summary>
        /// <param name="_aNumber">Number</param>
        /// <param name="_bNumber">Number</param>
        /// <param name="_cNumber">Number</param>
        /// <returns>String result</returns>
        private static string CheckNumber(int _aNumber, int _bNumber, int _cNumber)
        {
            if (_aNumber < _bNumber)
            {
                if (_cNumber < _aNumber) return $"{_cNumber} < {_aNumber} < {_bNumber}";
                else
                {
                    if (_cNumber < _bNumber) return $"{_aNumber} < {_cNumber} < {_bNumber}";
                    else return $"{_aNumber} < {_bNumber} < {_cNumber}";
                }
            }
            else
            {
                if (_cNumber < _bNumber) return $"{_cNumber} < {_bNumber} < {_aNumber}";
                else
                {
                    if (_cNumber < _bNumber) return $"{_bNumber} < {_cNumber} < {_aNumber}";
                    else return $"{_bNumber} < {_aNumber} < {_cNumber}";
                }
            }
        }
    }
}

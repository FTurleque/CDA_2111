using System;

namespace Recursif_Exercice_2_7_PuissanceEntierDunNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = AskNumber("Algorithme récursifs sur les nombres\nPuissance entière d'un nombre réel\nEntrez un nombre entier pour 'a' :");
            int bNumber = AskNumber("Entrez un nombre entier 'b' :");
            Console.WriteLine($"{aNumber} puissance {bNumber} est {PowerOfTwoIntegers(aNumber, bNumber)}");
        }

        /// <summary>
        /// I calculate the power of two number
        /// </summary>
        /// <param name="_aNumber">Number</param>
        /// <param name="_bNumber">Number</param>
        /// <returns>Number result</returns>
        private static int PowerOfTwoIntegers(int _aNumber, int _bNumber)
        {
            if (_bNumber == 0) return 1;
            else return _aNumber * PowerOfTwoIntegers(_aNumber, _bNumber - 1);
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">String</param>
        /// <returns>String result</returns>
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
                    Console.WriteLine("Vous n'avez pas entrez un nombre réel, recommencez :");
                }
            } while (true);
        }


    }
}

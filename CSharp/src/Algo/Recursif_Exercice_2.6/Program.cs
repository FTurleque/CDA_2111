using System;

namespace Recursif_Exercice_2_6_ProduitDeDeuxEntier
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = AskNumber("Algorithme récursifs sur les nombres\nProduit de deux entiers\nEntrez un nombre entier pour 'a' :");
            int bNumber = AskNumber("Entrez un nombre entier 'b' :");
            Console.WriteLine($"La produit de {aNumber} et de {bNumber} est {ProductOfNumbers(aNumber, bNumber)}");
        }

        /// <summary>
        /// I make the product o two number
        /// </summary>
        /// <param name="_aNumber"></param>
        /// <param name="_bNumber"></param>
        /// <returns></returns>
        private static int ProductOfNumbers(int _aNumber, int _bNumber)
        {
            if (_aNumber == 0) return 0;
            else return _bNumber + ProductOfNumbers(_aNumber - 1, _bNumber);
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
                    Console.WriteLine("Vous n'avez pas entrez un nombre entier positif, recommencez :");
                }
            } while (true);
        }

    }
}

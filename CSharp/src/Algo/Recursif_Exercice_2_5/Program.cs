using System;

namespace Recursif_Exercice_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = AskNumber("Algorithme récursifs sur les nombres\n\nEntrez un nombre entier pour 'a' :");
            int bNumber = AskNumber("Algorithme récursifs sur les nombres\n\nEntrez un nombre entier 'b' :");
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

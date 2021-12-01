using System;

namespace Exercice_2_7
{
    class Program
    {
        private static string userEntry;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }    
        private static int AskNumber(string message)
        {
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine($"Entrez l'a");

                userEntry = Console.ReadLine();
                try
                {
                    int tmp = int.Parse(userEntry);

                    if (tmp < 3 && tmp >= 0) return tmp;
                    else
                    {
                        throw new FormatException("Vous n'avez pas entrez un chiffre entre 0 et 2, recommencez :");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            }
        }

    }


}

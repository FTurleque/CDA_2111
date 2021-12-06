using System;

namespace Exercice_1_4
{
    class Program
    {
        private static string userEntry;
        private static int userNumber;
        private static int aNumber;
        private static int bNumber;

        static void Main(string[] args)
        {
            aNumber = AskNumber("Inversion de 2 valeurs\n\nChoisir un nombre pour 'a' :");
            bNumber = AskNumber("Choisir un nombre pour 'b' :");
            Console.WriteLine($"Vous avez choisi {aNumber} pour 'a' et {bNumber} pour 'b' !");
            InversionNumber();
            Console.WriteLine($"Maintenant 'a' devient {aNumber} et 'b' {bNumber} !");
        }

        private static int AskNumber(String message)
        {
            Console.WriteLine(message);
            do
            {
                userEntry = Console.ReadLine();
                try
                {
                    userNumber = int.Parse(userEntry);
                    return userNumber;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        private static void InversionNumber()
        {
            int tmp = aNumber;
            aNumber = bNumber;
            bNumber = tmp;
        }
    }
}

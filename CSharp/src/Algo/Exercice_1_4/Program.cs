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
            Console.WriteLine("Inversion de 2 valeurs !");
            aNumber = AskNumber("Choisir un nombre pour 'a' :");
            bNumber = AskNumber("Choisir un nombre pour 'b' :");
            Console.WriteLine($"Vous avez choisi {aNumber} pour 'a' et {bNumber} pour 'b' !");
            InversionNumber();
            Console.WriteLine($"Maintenant 'a' devient {aNumber} et 'b' {bNumber} !");
        }

        private static int AskNumber(String message)
        {
            Console.WriteLine(message);
            bool userEntryOk = false;
            do
            {
                userEntry = Console.ReadLine();
                try
                {
                    userNumber = int.Parse(userEntry);
                    userEntryOk = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (userEntryOk == false);
            return userNumber;
        }

        private static void InversionNumber()
        {
            int tmp;
            tmp = aNumber;
            aNumber = bNumber;
            bNumber = tmp;
        }
    }
}

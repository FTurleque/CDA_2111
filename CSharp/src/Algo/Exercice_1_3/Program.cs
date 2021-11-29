using System;

namespace Exercice_1_3
{
    class Program
    {
        private static string userEntry;
        private static double userNumber;
        private static double ray;
        private static double angle;


        static void Main(string[] args)
        {
            Console.WriteLine("Calcul de la surface d’un secteur circulaire");
            ray = AskNumber("Choisir un chiffre pour le rayon du cercle en cm :");
            angle = AskNumber("Choisir un chiffre pour l'angle :");
            Console.WriteLine($"La surface du secteur circulaire es de {CalculationSector()}cm");
        }

        private static double AskNumber(String message)
        {
            Console.WriteLine(message);
            bool userEntryOk = false;
            do
            {
                userEntry = Console.ReadLine();
                try
                {
                    userNumber = double.Parse(userEntry);
                    userEntryOk = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (userEntryOk == false);
            return userNumber;
        }

        private static double CalculationSector()
        {
            return Math.PI * Math.Pow(ray, 2) * (double)angle / 360;
        }

    }
}

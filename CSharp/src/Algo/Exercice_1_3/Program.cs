using System;

namespace Exercice_1_3_SurfaceSecteurCirculaire
{
    class Program
    {
        private static string userEntry;
        private static double userNumber;
        private static double ray;
        private static double angle;


        static void Main(string[] args)
        {
            ray = AskNumber("Calcul de la surface d’un secteur circulaire\n\nChoisir un chiffre pour le rayon du cercle en cm :");
            angle = AskNumber("Choisir un chiffre pour l'angle :");
            Console.WriteLine($"La surface du secteur circulaire es de {CalculationSector()}cm !");
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Return number</returns>
        private static double AskNumber(String message)
        {
            Console.WriteLine(message);
            do
            {
                userEntry = Console.ReadLine();
                try
                {
                    userNumber = double.Parse(userEntry);
                    return userNumber;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// I make a calculation
        /// </summary>
        /// <returns>Return result</returns>
        private static double CalculationSector()
        {
            return Math.PI * Math.Pow(ray, 2) * (double)angle / 360;
        }

    }
}

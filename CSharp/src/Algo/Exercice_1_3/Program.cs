using System;

namespace Exercice_1_3_SurfaceSecteurCirculaire
{
    class Program
    {
        static void Main(string[] args)
        {
            double ray = AskNumber("Calcul de la surface d’un secteur circulaire\n\nChoisir un chiffre pour le rayon du cercle en cm :");
            double angle = AskNumber("Choisir un chiffre pour l'angle :");
            Console.WriteLine($"La surface du secteur circulaire es de {CalculationSector(ray, angle)}cm !");
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Return number</returns>
        private static double AskNumber(String message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    return double.Parse(userEntry);
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
        /// <param name="_ray">Number</param>
        /// <param name="_angle">Number</param>
        /// <returns>Result</returns>
        private static double CalculationSector(double _ray, double _angle)
        {
            return Math.PI * Math.Pow(_ray, 2) * (double)_angle / 360;
        }

    }
}

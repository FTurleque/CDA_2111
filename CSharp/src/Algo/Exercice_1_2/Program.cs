using System;
using System.Text.RegularExpressions;

namespace Exercice_1_2_AirEtVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            double ray = AskNumberWithString("Calcul de l’aire et du volume d’une sphère\n\nChoisir un chiffre :");
            Console.WriteLine($"L'aire du cercle est de {AirCalculation(ray)} !");
            Console.WriteLine($"Le volume du cercle est de {VolumeCalculation(ray)} !");
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Return a number</returns>
        private static double AskNumberWithString(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();

                try
                {
                    if (Regex.IsMatch(userEntry, @"^[0-9]+$")) return double.Parse(userEntry);
                    else throw new Exception("Vous n'avez pas entrez un chiffre, recommencez :");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }

        /// <summary>
        /// Calculate the area
        /// </summary>
        /// <returns>Return area</returns>
        private static double AirCalculation(double _ray)
        {
            return 4*Math.PI*Math.Pow(_ray, 2);
        }

        /// <summary>
        /// Calculate the volume
        /// </summary>
        /// <returns>Return volume</returns>
        private static double VolumeCalculation(double _ray)
        {
            return (4 / 3) * Math.PI * Math.Pow(_ray, 3);
        }
    }
}

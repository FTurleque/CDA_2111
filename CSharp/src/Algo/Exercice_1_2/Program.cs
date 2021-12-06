using System;

namespace Exercice_1_2
{
    class Program
    {
        private static double ray;
        private static string userEntry;

        static void Main(string[] args)
        {
            AskNumberWithString("Calcul de l’aire et du volume d’une sphère\n\nChoisir un chiffre :");
            Console.WriteLine($"L'aire du cercle est de {AirCalculation()} !");
            Console.WriteLine($"Le volume du cercle est de {VolumeCalculation()} !");
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message"></param>
        private static void AskNumberWithString(string message)
        {
            Console.WriteLine(message);
            do
            {
                userEntry = Console.ReadLine();

                try
                {
                    ray = double.Parse(userEntry);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (false);
        }

        /// <summary>
        /// Calculate the area
        /// </summary>
        /// <returns>Return area</returns>
        private static double AirCalculation()
        {
            return 4*Math.PI*Math.Pow(ray, 2);
        }

        /// <summary>
        /// Calculate the volume
        /// </summary>
        /// <returns>Return volume</returns>
        private static double VolumeCalculation()
        {
            return (4 / 3) * Math.PI * Math.Pow(ray, 3);
        }
    }
}

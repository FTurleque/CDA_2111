using System;

namespace Exercice_1_2
{
    class Program
    {
        private static double ray;
        private static string userEntry;

        static void Main(string[] args)
        {
            AskNumberWithString("Choisir un chiffre :");
            Console.WriteLine($"L'aire du cercle est de {AirCalculation()}");
            Console.WriteLine($"Le volume du cercle est de {VolumeCalculation()}");
        }

        private static void AskNumberWithString(string message)
        {
            Console.WriteLine(message);

            bool userEntryOk = false;
            do
            {
                userEntry = Console.ReadLine();

                try
                {
                    ray = double.Parse(userEntry);
                    userEntryOk = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre");
                }
            } while (userEntryOk == false);
        }

        private static double AirCalculation()
        {
            return 4*Math.PI*Math.Pow(ray, 2);
        }

        private static double VolumeCalculation()
        {
            return (4 / 3) * Math.PI * Math.Pow(ray, 3);
        }
    }
}

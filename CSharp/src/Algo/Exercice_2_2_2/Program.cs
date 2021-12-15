using System;
using System.Text.RegularExpressions;

namespace Exercice_2_2_2_ConversionDegresF_C
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string unity = AskUnit("Conversion Degrés Fahrenheit (°F) <--> Degrés Celsius (°C)\nSur une plage de température saisie !\n\nSaisir une unité de mesure (C ou F) ou 'quit' pour quitter :");
                if (!unity.Equals("QUIT"))
                {
                    double minNumber = AskNumber("Saisir la valeur minimum :");
                    double maxNumber = AskNumber("Saisir la valeur maximum (doit être supérieure à la valeur minimum) :");
                    TemperatureConversion(unity, minNumber, maxNumber);
                }
                else Environment.Exit(0);
            } while (true);
        }

        /// <summary>
        /// I make a conversion
        /// </summary>
        /// <param name="_unity"></param>
        /// <param name="_minNumber"></param>
        /// <param name="_maxNumber"></param>
        private static void TemperatureConversion(string _unity, double _minNumber, double _maxNumber)
        {
            for (double i = _minNumber; i <= _maxNumber; i++)
            {
                if (_unity.Equals("C")) Console.WriteLine($"{i} °{_unity} = {i * (9d / 5d) + 32d} °F");
                else Console.WriteLine($"{i} °{_unity} = {(i - 32d) * (5d / 9d)} °C");
            }
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Number</returns>
        private static double AskNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    return double.Parse(userEntry);
                }
                catch (Exception)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// Request a unity for conversion from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Number</returns>
        private static string AskUnit(string message)
        {
            Console.WriteLine(message);
            do
            {
                try
                {
                    string userEntry = Console.ReadLine().ToUpper();
                    if (Regex.IsMatch(userEntry, @"(C|F|QUIT)")) return userEntry;
                    else throw new Exception("Vous n'avez pas entrez une unitée valide, recommencez :");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (true);
        }
    }
}

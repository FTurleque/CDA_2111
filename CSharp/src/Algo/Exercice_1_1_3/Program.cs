using System;

namespace Exercice_1_1_3_Moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] userNumbers = AskNumber("Calcul de la moyenne de 2 nombres\n\nEntrez le nombre de notes voulues séparé par un espace :");
            Console.WriteLine($"La moyenne est de {Average(userNumbers)} !");
        }

        private static double[] AskNumber(string message)
        {
            Console.WriteLine(message);

            string userEntry = Console.ReadLine();
            string[] numbersTabString = userEntry.Split(" ");
            double[] numbersTab = new double[numbersTabString.Length];

            for (int index = 0; index < numbersTabString.Length; index++)
            {
                try
                {
                    double userNumber = double.Parse(numbersTabString[index]);
                    numbersTab[index] = userNumber;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Votre {index} chiffre n'en est pas un recommencez :");
                }
            }
            return numbersTab;
        }

        private static double Average(double[] _userNumbers)
        {
            double result = 0;
            for (int index = 0; index < _userNumbers.Length; index++)
            {
               result += (double)_userNumbers[index];
            }
            return result / (double)_userNumbers.Length;
        }
    }
}

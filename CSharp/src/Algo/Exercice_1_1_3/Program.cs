using System;

namespace Exercice_1_1_3_Moyenne
{
    class Program
    {
        private static string userEntry;
        private static double userNumber;
        private static double result = 0;
        private static string[] numbersTabString;
        private static double[] numbersTab;



        static void Main(string[] args)
        {
            AskNumber("Calcul de la moyenne de 2 nombres\n\nEntrez le nombre de notes voulues séparé par un espace :");
            Console.WriteLine($"La moyenne est de {Average()} !");
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message"></param>
        private static void AskNumber(string message)
        {
            Console.WriteLine(message);

            userEntry = Console.ReadLine();
            numbersTabString = userEntry.Split(" ");
            numbersTab = new double[numbersTabString.Length];

            for (int index = 0; index < numbersTabString.Length; index++)
            {
                try
                {
                    userNumber = double.Parse(numbersTabString[index]);
                    numbersTab[index] = userNumber;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Votre {index} chiffre n'en est pas un recommencez :");
                }
            }
        }

        /// <summary>
        /// I add up numbers
        /// </summary>
        /// <returns>Return the average</returns>
        private static double Average()
        {
            for (int index = 0; index < numbersTab.Length; index++)
            {
               result += (double)numbersTab[index];
            }
            return result / (double)numbersTab.Length;
        }
    }
}

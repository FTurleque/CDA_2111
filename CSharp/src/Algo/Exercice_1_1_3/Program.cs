using System;

namespace Exercice_1_1_3
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
            AskNumber("Entrez le nombre de notes voulues séparé par un espace :");
            Console.WriteLine($"La moyenne est de {Average()}");
        }

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

        private static double Average()
        {
            for (int index = 0; index < numbersTab.Length; index++)
            {
               result = result + (double)numbersTab[index];
            }
            return result / (double)numbersTab.Length;
        }
    }
}

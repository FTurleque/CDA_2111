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
            int indexUserNumber = 0;
            Console.WriteLine(message);


            userEntry = Console.ReadLine();
            numbersTabString = userEntry.Split(' ');

            do
            {
                try
                {
                    userNumber = double.Parse(numbersTabString[indexUserNumber]);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Votre {indexUserNumber} chiffre n'en est pas un recommencez :");
                }
                indexUserNumber++;
            } while (indexUserNumber <= numbersTabString.Length - 1);

/*            for (int index = 0; index < numbersTabString.Length; index++)
            {
                try
                {
                    userNumber = double.Parse(numbersTabString[indexUserNumber]);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Votre {indexUserNumber} chiffre n'en est pas un recommencez :");
                }
            }
*/        }

        private static double Average()
        {
            int indexUserNumber = 0;
            do
            {
                result = (double)numbersTab[indexUserNumber] + (double)numbersTab[indexUserNumber + 1];
                indexUserNumber++;
            } while (indexUserNumber < numbersTab.Length);
            return result;
        }
    }
}

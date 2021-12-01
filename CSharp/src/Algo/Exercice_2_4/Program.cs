using System;

namespace Exercice_2_4
{
    class Program
    {
        private static string userEntry;
        private static int storeCount = 1;
        private static double sumSpent;

        static void Main(string[] args)
        {
            Console.WriteLine("Barnabé fait ses courses !");
            double amountOnAccount = AskNumber("Combien d'argent avez vous ?");
            GetSumSpent(amountOnAccount);
            Console.WriteLine($"Barnabé est entré dans {storeCount} magasins !");
        }

        private static double AskNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                userEntry = Console.ReadLine();
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

        private static void GetSumSpent(double remainingSum)
        {
            do
            {
                if (remainingSum >= 2)
                {
                    sumSpent = (remainingSum / 2d) + 1d;
                    remainingSum -= sumSpent;
                }
                else remainingSum -= remainingSum;

                storeCount++;
            } while (remainingSum != 0);
        }
    }
}

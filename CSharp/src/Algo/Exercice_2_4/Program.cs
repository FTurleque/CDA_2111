using System;

namespace Exercice_2_4_BarnabetFaitSesCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            int storeCount = 1;
            Console.WriteLine("Barnabé fait ses courses !");
            double amountOnAccount = AskNumber("Combien d'argent avez vous ?");
            GetSumSpent(amountOnAccount, ref storeCount);
            Console.WriteLine($"Barnabé est entré dans {storeCount} magasins !");
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Return the number</returns>
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
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// I calculate the number of stores where Barnabe has been
        /// </summary>
        /// <param name="remainingSum">Number</param>
        private static void GetSumSpent(double remainingSum, ref int storeCount)
        {
            do
            {
                if (remainingSum >= 2)
                {
                    double sumSpent = remainingSum / 2d + 1d;
                    remainingSum -= sumSpent;
                }
                else remainingSum -= remainingSum;

                storeCount++;
            } while (remainingSum != 0);
        }
    }
}

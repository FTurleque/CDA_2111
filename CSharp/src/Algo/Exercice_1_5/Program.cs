using System;

namespace Exercice_1_5_CalculeInterets
{
    class Program
    {
        static void Main(string[] args)
        {
            double account = AskNumber("Calcul d’intérêts\n\nQuelle est la somme que vous voulez placez ?");
            double yearNumber = AskNumber("Pendant combien d'année(s) ?");
            double interest = AskNumber("Quel est le taux d'intérêt en % que vous propose la banque ?");
            Console.WriteLine($"Les intérêts simples seront de {SimpleInterest(account, yearNumber, interest)} !");
            Console.WriteLine($"Les intérêts composés seront de {CompoundInterest(account, yearNumber, interest)} !");
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <returns>Return a number</returns>
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
        /// Calculate simple interest
        /// </summary>
        /// <param name="_account">Number</param>
        /// <param name="_yearNumber">Number</param>
        /// <param name="_interest">Number</param>
        /// <returns>Return result</returns>
        private static double SimpleInterest(double _account, double _yearNumber, double _interest)
        {
            return _account * (1 + _yearNumber * _interest) - _account;
        }

        /// <summary>
        /// Calculate compound interest
        /// </summary>
        /// <param name="_account">Number</param>
        /// <param name="_yearNumber">Number</param>
        /// <param name="_interest">Number</param>
        /// <returns>Return result</returns>
        private static double CompoundInterest(double _account, double _yearNumber, double _interest)
        {
            return _account * Math.Pow(1 + _interest, _yearNumber) - _account;
        }
    }
}

using System;

namespace Exercice_1_10_CalculDesNombresParfaits
{
    class Program
    {
        private static bool isPrime;

        static void Main(string[] args)
        {
            int nbOfperfectNumber = AskNumber("Calcul des nombres parfaits\n\nChoisir combien de nombres parfaits vous voulez afficher :");
            FindPerfectNumber(nbOfperfectNumber);
        }

        /// <summary>
        /// Request a number from the user by sending a question
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Return the number</returns>
        private static int AskNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    return int.Parse(userEntry);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// I try to find if the number is perfect
        /// </summary>
        private static void FindPerfectNumber(int _nbOfperfectNumber)
        {
            double nbToTest = 2;
            for (int i = 0; i < _nbOfperfectNumber; i++)
            {
                do
                {
                    CheckIfIsPrime(nbToTest);
                    if (isPrime == true)
                    {
                        double ifDivisorIsPrime = Math.Pow(2d, nbToTest) - 1d;
                        bool isPrime = CheckIfIsPrime(ifDivisorIsPrime);
                        if (isPrime == true)
                        {
                            double resultsNbPerfect = Math.Pow(2d, nbToTest - 1d) * ifDivisorIsPrime;
                            Console.WriteLine(resultsNbPerfect);
                        }
                    }
                    nbToTest++;
                } while (isPrime == false);
            }
        }

        /// <summary>
        /// I try to know if the number is prime to use the euclidean formula
        /// </summary>
        /// <param name="_nbToTest">Number</param>
        /// <returns>Boolean</returns>
        private static bool CheckIfIsPrime(double _nbToTest)
        {
            int divisor = 2;
            isPrime = false;
            while (_nbToTest % divisor != 0 && divisor <= Math.Sqrt(_nbToTest)) divisor++;

            if (divisor > Math.Sqrt(_nbToTest)) return true;
            else return false;
            /*ifDivisorIsPrime = Math.Pow(2, divisor) - 1;*/
        }

    }
}

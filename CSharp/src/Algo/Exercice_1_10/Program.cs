using System;

namespace Exercice_1_10_CalculDesNombresParfaits
{
    class Program
    {
        private static string userEntry;
        private static int nbOfperfectNumber;
        private static int divisor;
        private static double ifDivisorIsPrime;
        private static bool isPrime;
        private static double resultsNbPerfect;
        private static double nbToTest;

        static void Main(string[] args)
        {
            nbOfperfectNumber = AskNumber("Calcul des nombres parfaits\n\nChoisir combien de nombres parfaits vous voulez afficher :");
            FindPerfectNumber();
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
                userEntry = Console.ReadLine();
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
        private static void FindPerfectNumber()
        {
            nbToTest = 2;
            for (int i = 0; i < nbOfperfectNumber; i++)
            {
                do
                {
                    CheckIfIsPrime(nbToTest);
                    if (isPrime == true)
                    {
                        ifDivisorIsPrime = Math.Pow(2d, nbToTest) - 1d;
                        CheckIfIsPrime(ifDivisorIsPrime);
                        if (isPrime == true)
                        {
                            resultsNbPerfect = Math.Pow(2d, nbToTest - 1d) * ifDivisorIsPrime;
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
        /// <param name="_nbToTest"></param>
        private static void CheckIfIsPrime(double _nbToTest)
        {
            divisor = 2;
            isPrime = false;
            while (_nbToTest % divisor != 0 && divisor <= Math.Sqrt(_nbToTest))
            {
                divisor++;
            }

            if (divisor > Math.Sqrt(_nbToTest))
            {
                isPrime = true;
                /*return "Le chiffre est premier !";*/
            }
            /*ifDivisorIsPrime = Math.Pow(2, divisor) - 1;*/
        }

    }
}

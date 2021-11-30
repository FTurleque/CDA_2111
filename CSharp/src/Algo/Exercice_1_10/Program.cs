using System;

namespace Exercice_1_10
{
    class Program
    {
        private static string userEntry;
        private static int nbOfperfectNumber;
        private static int divisor;
        private static double ifDivisorIsPrime;
        private static bool isPrime;
        private static double[] resultsNbPerfect;
        private static int nbToTest;

        static void Main(string[] args)
        {
            nbOfperfectNumber = AskNumber("Choisir combien de nombres parfaits vous voulez afficher :");
            FindPerfectNumber();
        }

        private static int AskNumber(String message)
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

        private static void FindPerfectNumber()
        {
            resultsNbPerfect = new double[nbOfperfectNumber];
            for (int i = 0; i < nbOfperfectNumber; i++)
            {
                nbToTest = 1;
                do
                {
                    CheckIfIsPrime(nbToTest);
                    if (isPrime == true)
                    {
                        ifDivisorIsPrime = Math.Pow(2, nbToTest) - 1;
                        CheckIfIsPrime(ifDivisorIsPrime);
                        if (isPrime == true)
                        {
                            resultsNbPerfect[i] = Math.Pow(2, nbToTest - 1) * (ifDivisorIsPrime);
                            Console.WriteLine(resultsNbPerfect[i]);
                        }
                    }
                    nbToTest++;
                } while (isPrime == false);
            }
        }

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

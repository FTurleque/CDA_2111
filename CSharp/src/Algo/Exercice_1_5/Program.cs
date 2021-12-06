using System;

namespace Exercice_1_5
{
    class Program
    {
        private static string userEntry;
        private static double userNumber;
        private static double account;
        private static double yearNumber;
        private static double interest;

        static void Main(string[] args)
        {
            account = AskNumber("Calcul d’intérêts\n\nQuelle est la somme que vous voulez placez ?");
            yearNumber = AskNumber("Pendant combien d'année(s) ?");
            interest = AskNumber("Quel est le taux d'intérêt en % que vous propose la banque ?");
            Console.WriteLine($"Les intérêts simples seront de {SimpleInterest()} !");
            Console.WriteLine($"Les intérêts composés seront de {CompoundInterest()} !");
        }

        private static double AskNumber(String message)
        {
            Console.WriteLine(message);
            do
            {
                userEntry = Console.ReadLine();
                try
                {
                    userNumber = double.Parse(userEntry);
                    return userNumber;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entrez un chiffre, recommencez :");
                }
            } while (true);
        }

        private static double SimpleInterest()
        {
            return (account * (1 + yearNumber * interest)) - account;
        }

        private static double CompoundInterest()
        {
            return (account * Math.Pow((1 + interest), yearNumber)) - account;
        }
    }
}

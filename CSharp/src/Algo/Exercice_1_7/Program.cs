using System;

namespace Exercice_1_7
{
    class Program
    {
        private static string userEntry;
        private static int aNumber;
        private static int bNumber;
        private static int cNumber;

        static void Main(string[] args)
        {
            aNumber = AskNumber("Choisir un nombre pour 'a' :");
            bNumber = AskNumber("Choisir un nombre pour 'b' :");
            cNumber = AskNumber("Choisir un nombre pour 'c' :");
            Console.WriteLine($"Les chiffres dans l'ordre croissant sont : {CheckNumber()} !");
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

        private static string CheckNumber()
        {
            if (aNumber < bNumber)
            {
                if (cNumber < aNumber)
                {
                    return $"{cNumber} < {aNumber} < {bNumber}";
                }
                else
                {
                    if (cNumber < bNumber)
                    {
                        return $"{aNumber} < {cNumber} < {bNumber}";
                    }
                    else
                    {
                        return $"{aNumber} < {bNumber} < {cNumber}";

                    }
                }
            }
            else
            {
                if (cNumber < bNumber)
                {
                    return $"{cNumber} < {bNumber} < {aNumber}";

                }
                else
                {
                    if (cNumber < bNumber)
                    {
                        return $"{bNumber} < {cNumber} < {aNumber}";

                    }
                    else
                    {
                        return $"{bNumber} < {aNumber} < {cNumber}";

                    }

                }
            }
        }
    }
}

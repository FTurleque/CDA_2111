using System;

namespace Exercice_2_6
{
    class Program
    {
        private static string userEntry;

        static void Main(string[] args)
        {
            Console.WriteLine("Ma bicyclette !");
            Questions();
        }

        private static void Questions()
        {
            AskNumber("Fait-il beau ? (o pour Oui et n pour Non)");

            if (userEntry.Equals("o"))
            {
                Console.WriteLine("Vous avez indiqué qu'il fait beau.");
                AskNumber("La bicyclette est-elle en bon état ? (o pour Oui et n pour Non)");

                if (userEntry.Equals("o")) Console.WriteLine("La bicyclette est en bon état, je pars en balade !");
                else
                {
                    Console.WriteLine("Je vais au garage.");
                    AskNumber("Est-ce-que la réparation est rapide ? (o pour Oui et n pour Non)");

                    if (userEntry.Equals("o")) Console.WriteLine("Réparations rapides ! Je vais me balader.");
                    else Console.WriteLine("Je dois laisser ma bicyclette, je vais cueillir des joncs.");
                }
            }
            else
            {
                Console.WriteLine("Vous avez indiqué qu'il pleut.");
                AskNumber("Je vais lire un livre, est-ce-que GoT tome 1 est dans ma bibliothèque ? (o pour Oui et n pour Non)");

                if (userEntry.Equals("o")) Console.WriteLine("Le livre est dans la bibliothèque, je m'installe pour le lire");
                else
                {
                    Console.WriteLine("Je ne trouve pas le livre, je vais à la bibliothèque municipale.");
                    AskNumber("Est-il disponible à la bibliothèque municipale ? (o pour Oui et n pour Non)");

                    if (userEntry.Equals("o")) Console.WriteLine("Le livre est disponible ! Je l'emprunte.");
                    else Console.WriteLine("Le livre n'est pas disponible, j'emprunte un roman policier à la place.");

                    Console.WriteLine("Je rentre à la maison.");
                }
            }

        }

        public static void AskNumber(string message)
        {
            Console.WriteLine(message);

            do
            {
                userEntry = Console.ReadLine().ToLower();

                try
                {
                    if (userEntry.Equals("o") || userEntry.Equals("n"))
                    {

                    }
                    else
                    {
                        throw new Exception("Vous n'avez pas choisi o ou n, recommencez !");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas choisi o ou n, recommencez !");
                }

            } while (!(userEntry.Equals("o") || userEntry.Equals("n")));
        }
    }
}

using System;

namespace Tri_A_Bulle
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestTri(new int[] { }); // tableau vide
            //TestTri(new int[] { 1, 2, 3, 4, 5 }); // tableau déjà trié
            TestTri(new int[] { 5, 1, 4, 2, 3 }); // tableau en désordre, taille impaire
            TestTri(new int[] { 5, 1, 6, 4, 2, 3 }); // tableau en désordre, taille paire
        }
        static void Permuter(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void TriBulles(int[] vals)
        {
            for (int i = 0; i < vals.Length - 1; ++i)
                for (int j = i + 1; j < vals.Length; ++j)
                {
                    if (vals[j] < vals[i])
                    {
                        Permuter(ref vals[i], ref vals[j]);
                        Console.WriteLine(vals[0] + " " + vals[1] + " " + vals[2] + " " + vals[3] + " " + vals[4]);
                    }
                    Console.WriteLine(vals[0] + " " + vals[1] + " " + vals[2] + " " + vals[3] + " " + vals[4]);
                }
                    

        }
        static void Afficher(int[] tab)
        {
            for (int i = 0; i != tab.Length; ++i)
                Console.Write($"{tab[i]} ");
            if (EstTrié(tab))
                Console.WriteLine("... il est donc trié");
            else
                Console.WriteLine("... il n'est donc pas trié");
        }
        static bool EstTrié(int[] tab)
        {
            bool résultat = true;
            if (tab.Length > 1)
            {
                for (int i = 1; i != tab.Length; ++i)
                    if (tab[i] < tab[i - 1])
                        résultat = false;
            }
            return résultat;
        }
        static void TestTri(int[] tab)
        {
            Console.Write("Avant : ");
            Afficher(tab);
            TriBulles(tab);
            Console.Write("Après : ");
            Afficher(tab);
        }
    }
}

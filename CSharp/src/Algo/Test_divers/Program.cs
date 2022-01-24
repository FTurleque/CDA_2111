using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test_divers
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadAFile();

            // Utilisa  tion d'un dictionnaire
            Dictionary<int, string> chiffres = new Dictionary<int, string>()
            {
                {1, "un" },
                {2, "deux" },
                {3, "trois" }
            };

            chiffres.Remove(2);
            chiffres.Add(9, "neuf");

            foreach (KeyValuePair<int,string> pair in chiffres)
            {
                Console.WriteLine(pair);
                Console.WriteLine(pair.Value);
                Console.WriteLine(pair.Key);
            }
        }

        
        /// <summary>
        /// Test de lecture d'un fichier
        /// </summary>
        private static void ReadAFile()
        {
            // Essayer de lire uun fichier text existant
            string txt = @"C:\Users\fturl\Documents\GitHub\FTurleque\CDA_2111\CSharp\src\Algo\Test_divers\TextFile1.txt";
            if (File.Exists(txt))
            {

            }

            using (FileStream fs = File.OpenRead(txt))
            {
                byte[] bio = new byte[txt.Length];
                UTF8Encoding tmp = new UTF8Encoding(true);
                while (fs.Read(bio, 0, bio.Length) > 0)
                {
                    Console.WriteLine(tmp.GetString(bio));
                }
            }
        }

    }
}

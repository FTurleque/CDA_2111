using System;

namespace Exercice_2_1_ConversionKmMi
{
    class Program
    {
        private static string userNumber;
        private static string[] valiousTable;
        private static string valious = "";
        private static string unity = "";
        private static bool go = false;
        private static string[] tableOfUnit;
        private static string[] distanceTable;

        static void Main(string[] args)
        {
            Console.WriteLine("Conversion Kilomètres <-> Miles !");
            do
            {
                AskEntryUser("Conversion Kilomètre en Miles et inversement. \nChoisir des distances en Miles (mi) ou Kilomètres (km) séparées d'un espace ou quitter :");
                DistanceConversions();
            } while (!userNumber.Equals("quitter"));
        }

        static string AskEntryUser(string message)
        {
            Console.WriteLine(message);
            do
            {
                userNumber = Console.ReadLine().ToLower();

                if (userNumber.Equals("quitter"))
                {
                    Environment.Exit(0);
                }
                else if (userNumber.Equals("go"))
                {
                    go = true;
                }
                else
                {
                    valiousTable = userNumber.Split(" ");

                    // Test of the user input
                    try
                    {
                        int tmp = int.Parse(valiousTable[0]);
                        valious += valiousTable[0] + " ";
                        SaveUnity();

                        Console.WriteLine("Tapez go pour lancer les calculs si vous avez fini ou recommencez :");
                    }
                    catch (FormatException)
                    {
                        // TODO: handle exception
                        Console.WriteLine("Une distance est un chiffre et une unitée de mesure séparé d'un espace. Recommencez :");
                    }
                }
            } while (!go);
            return userNumber;
        }

        private static void SaveUnity()
        {
            if (valiousTable.Length < 2)
            {
                unity += "km ";
            }
            else
            {
                unity += valiousTable[1] + " ";
            }
        }


        private static void DistanceConversions()
        {
            tableOfUnit = unity.Split(" ");
            distanceTable = valious.Split(" ");

            for (int index = 0; index < distanceTable.Length - 1; index++)
            {
                string tmp = distanceTable[index];
                double numDistanceIndex = double.Parse(tmp);
                string numUnitIndex = tableOfUnit[index];

                // Display of the calculation
                if (numUnitIndex.Equals("mi"))
                {
                    Console.WriteLine(numDistanceIndex + " " + char.ToUpper(numUnitIndex[0]) + numUnitIndex[1] + " = " + numDistanceIndex * 1.609 + " Kilomètres");
                }
                else
                {
                    Console.WriteLine(numDistanceIndex + " " + char.ToUpper(numUnitIndex[0]) + numUnitIndex[1] + " = " + numDistanceIndex / 1.609 + " Miles ");
                }
            }
        }

    }
}

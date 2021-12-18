using System;

namespace Recursif_Exercice_2_15_SommeTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sumArrayNumber = { 15, 23, 70, 80, 2, 9, 50 };
            int[] sumArrayNumber = AskNumber("Somme des éléments d'un tableau\n\nEntrez des nombre separé par un espace :");
            int index = 0;
            Console.WriteLine($"La somme des nombres entré est de : {GetArraySum(sumArrayNumber, index)} !");
        }

        /// <summary>
        /// I ask the user to enter several numbers
        /// </summary>
        /// <param name="message">String</param>
        /// <returns>Array number</returns>
        private static int[] AskNumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                string[] tmp = userEntry.Split(" ");
                int[] _arrayNumber = new int[tmp.Length];
                try
                {
                    for (int i = 0; i < tmp.Length; i++) _arrayNumber[i] = int.Parse(tmp[i]);
                    return _arrayNumber;
                }
                catch (Exception)
                {
                    Console.WriteLine("Vous n'avez pas entré un nombre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// I calculate the result of the sum of the table
        /// </summary>
        /// <param name="_sumArrayNumber">Array number</param>
        /// <param name="_index">Number</param>
        /// <returns>Sum number</returns>
        private static int GetArraySum(int[] _sumArrayNumber, int _index)
        {
            if (_sumArrayNumber.Length - 1 == _index) return _sumArrayNumber[_index];
            return _sumArrayNumber[_index] + GetArraySum(_sumArrayNumber, _index + 1);
        }
    }
}

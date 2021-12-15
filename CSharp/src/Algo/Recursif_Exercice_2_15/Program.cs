using System;

namespace Recursif_Exercice_2_15_SommeTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Somme des éléments d'un tableau\n\n");
            int[] sumArrayNumber = { 15, 23, 70, 80, 2, 9, 50 };
            int index = 0;
            Console.WriteLine($"La somme du tableau est de : {GetArraySum(sumArrayNumber, index)} !");
        }

        private static int GetArraySum(int[] _sumArrayNumber, int _index)
        {
            if (_sumArrayNumber.Length - 1 == _index) return _sumArrayNumber[_index];
            return _sumArrayNumber[_index] + GetArraySum(_sumArrayNumber, _index + 1);
        }
    }
}

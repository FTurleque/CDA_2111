using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_Lambda_Expression
{
    class Program
    {
        private delegate string MyDelegate(string text);
        private static MyDelegate method;
        private delegate int Calculate(int a, int b);
        private static Calculate methode2;

        static void Main(string[] args)
        {
            // anonymous delegate
            /*var evens = Enumerable
                                        .Range(1, 100)
                                        .Where(delegate (int x) { return (x % 2) == 0; })
                                        .ToList();*/
            //lambda expression
            /*var evens2 = Enumerable
                                        .Range(1, 100)
                                        .Where(x => (x % 2) == 0)
                                        .ToList();


            
            Func<int, int> sumNumber = x => x + x;
            
            Console.WriteLine(sumNumber(5));

            
            int[] numbers = { 2, 3, 4, 5 };
            var sum = numbers.Select(x => x + x);
            Console.WriteLine(string.Join(" ", sum));

            
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };*/

            /*List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(10));

            Func<int, bool> oddCheck = x => x % 2 != 0;
            var oddNumbers = numbers.Where(oddCheck).ToList();
            oddNumbers.ForEach(x => Console.Write(x));

            Action<int> printOdd = x =>
            {
                var square = x * x;
                var cube = x * x * x;
                Console.WriteLine($"\nLe carré de {x} est {square} et le cube est {cube}");
            };
            printOdd(4);
            oddNumbers.ForEach(x => printOdd(x));

            Console.WriteLine(numbers.Sum());*/

            method = Upper;
            Console.WriteLine(method("Fab"));
            method = Lower;
            Console.WriteLine(method("FAB"));

            methode2 = (a, b) =>
            {
                return a + b;
            };

            int result = methode2(2, 5);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static string Lower(string value)
        {
            return value.ToLower();
        }

        private static string Upper(string value)
        {
            return value.ToUpper();
        }

    }
}

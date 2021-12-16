using System;
using System.Linq;

namespace Test_Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            // anonymous delegate
/*            var evens = Enumerable
                            .Range(1, 100)
                            .Where(delegate (int x) { return (x % 2) == 0; })
                            .ToList();
*/
            // lambda expression
/*            var evens2 = Enumerable
                            .Range(1, 100)
                            .Where(x => (x % 2) == 0)
                            .ToList();
*/
            //Func<int, int> sumNumber = x => x + x;
            //Console.WriteLine(sumNumber(5));

            int[] numbers = { 2, 3, 4, 5 };
            var sum = numbers.Select(x => x + x);
            Console.WriteLine(string.Join(" ", sum));
        }

    }
}

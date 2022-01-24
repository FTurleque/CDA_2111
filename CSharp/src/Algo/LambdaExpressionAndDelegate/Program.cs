using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LambdaExpressionAndDelegate
{
    class Program
    {
        // Defines a method that returns an int and has one int as an input
        // Delegate defines the signature (return type and parameters)
        public delegate int Manipulate(int a);

        // Action is just a delegate
        public delegate void MyAction();

        // Func is just a delegate with a return type
        public delegate int MyFunc();

        static void Main(string[] args)
        {
            // Invoking a normal method
            var normalMethodInvokeResult = NormalMethod(2);
            Console.WriteLine(normalMethodInvokeResult);

            // Create an instance of the delegate
            var normalMethodDelegate = new Manipulate(NormalMethod);
            var normalResult = normalMethodDelegate(3);
            Console.WriteLine(normalResult);

            // Pass a delegate method as a variable
            var anotherResult = RunAnotherMethod(normalMethodDelegate, 4);
            Console.WriteLine(anotherResult);

            // Anonymous method is a a delegate() {} and returns a delegate
            Manipulate anonymousMethodDelegate = delegate (int a) { return a * 2; };
            var anonymousResult = anonymousMethodDelegate(3);
            Console.WriteLine(anonymousResult);

            // Lambda expressions are anything with => and a left/right value
            // They can return a delegate (so a method that can invoked)
            // or an Exression of a delegate (so it can be compiled and then executed)
            Manipulate lambdaDelegate = a => a * 2;
            var lambdaResult = lambdaDelegate(5);
            Console.WriteLine(lambdaResult);

            // Nicer way to write a lambda
            Manipulate nicerLambdaDelegate = (a) => { return a * 2; };
            var nicerLambdaResult = nicerLambdaDelegate(6);
            Console.WriteLine(nicerLambdaResult);

            // Lambda can return an Expression
            Expression<Manipulate> expressionLambda = a => a * 2;
            Console.WriteLine(expressionLambda);

            // An Action is just a delegate with no input and optional input
            Action actionDelegate = () => { lambdaDelegate(2); };
            Action<int> action2Delegate = (a) => { int b = a * 2; };

            // A Func is just a delegate with a return type
            Func<int> myFunc = () => 2;

            // Remplace Manipulate with a Func
            Func<int, int> funcDelegate = a => a * 2;
            var funcResult = lambdaDelegate(5);
            Console.WriteLine(funcResult);

        }

        /// <summary>
        /// A normal loking method
        /// </summary>
        /// <param name="a">The input value</param>
        /// <returns>Returns twice the input value</returns>
        private static int NormalMethod(int a)
        {
            return a * 2;
        }

        /// <summary>
        /// Accep a method (delegate) as an input
        /// </summary>
        /// <param name="theMethod"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        private static int RunAnotherMethod(Manipulate theMethod, int a)
        {
            return theMethod(a);
        }
    }
}

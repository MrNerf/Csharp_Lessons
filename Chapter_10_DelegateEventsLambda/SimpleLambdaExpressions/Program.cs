using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SimpleLambdaExpressions
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Работа с лямбда выражениями";
            Console.ForegroundColor = ConsoleColor.Green;
            TraditionalDelegateSyntax();
            Console.WriteLine();
            LambdaSyntax();
            Console.WriteLine();
            LambdaExpressionSyntax();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            var math = new SimpleMath();
            math.SetMathHandler((msg, result) => Console.WriteLine($"Message: {msg}, Result: {result}"));
            math.Add(50, 213);
            Console.ReadLine();
        }

        private static void TraditionalDelegateSyntax()
        {
            var list = new List<int>();
            list.AddRange(new[] {10, 1, 15, 36, 72, 55, 52, 12, 14});
            Console.WriteLine("Составленный список");
            foreach (var i in list)
            {
                Console.Write($"{i} \t");
            }

            Console.WriteLine();
            Predicate<int> callbackPredicate = CallbackPredicate;
            var newList = list.FindAll(callbackPredicate);
            Console.WriteLine("Новый список");
            foreach (var i in newList)
            {
                Console.Write($"{i} \t");
            }

            Console.WriteLine();
        }

        private static bool CallbackPredicate(int obj) => (obj % 2) == 0;

        private static void LambdaSyntax()
        {
            var list = new List<int>();
            list.AddRange(new[] { 10, 1, 15, 36, 72, 55, 52, 12, 14 });
            Console.WriteLine("Составленный список");
            foreach (var i in list)
            {
                Console.Write($"{i} \t");
            }

            Console.WriteLine();

            var newList = list.FindAll(i => i % 2 == 0);
            Console.WriteLine("Новый список");
            foreach (var i in newList)
            {
                Console.Write($"{i} \t");
            }

            Console.WriteLine();
        }

        private static void LambdaExpressionSyntax()
        {
            var list = new List<int>();
            list.AddRange(new[] { 10, 1, 15, 36, 72, 55, 52, 12, 14 });
            Console.WriteLine("Составленный список");
            foreach (var i in list)
            {
                Console.Write($"{i} \t");
            }

            Console.WriteLine();

            var newList = list.FindAll(i =>
            {
                Console.WriteLine($"Текущее значение списка: {i} на проверке");
                return i % 2 == 0;
            });
            Console.WriteLine("Новый список");
            foreach (var i in newList)
            {
                Console.Write($"{i} \t");
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace SimpleDelegate
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Пример простого делегата";
            Console.ForegroundColor = ConsoleColor.Green;
            var b = new BinaryOp(SimpleMath.Add);
            var sm = new SimpleMath();
            b += sm.Sub;
            DisplayDelegateInfo(b);
            Console.WriteLine($"10+10 is {b(10,10)}");
            Console.ReadLine();
        }

        private static void DisplayDelegateInfo(Delegate del)
        {
            foreach (var @delegate in del.GetInvocationList())
            {
                Console.WriteLine($"Target: {@delegate.Target}");
                Console.WriteLine($"Method: {@delegate.Method}");
            }
        }
    }

    internal class SimpleMath
    {
        internal static int Add(int x, int y) => x + y;
        internal int Sub(int x, int y) => x - y;
    }

    public delegate int BinaryOp(int x, int y);

}

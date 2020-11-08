using System;
using System.Diagnostics.CodeAnalysis;

namespace MultiLambdaParameters
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Лямбда выражения в событиях";
            Console.ForegroundColor = ConsoleColor.Green;
            var math = new MyMath();
            math.MathEvent += (sender, args) =>
                Console.WriteLine($"Сообщение от класса: {args.Msg}, результат: {args.Result}");
            math.Add(20, 30);
            math.Add(250, 3456);
            math.Add(132125, 4612);
            Console.ReadLine();
        }
    }
}

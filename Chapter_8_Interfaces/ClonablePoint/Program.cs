using System;
using System.Diagnostics.CodeAnalysis;

namespace CloneablePoint
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование интефрейса ICloneable";
            Console.ForegroundColor = ConsoleColor.Green;
            var point1 = new Point(100, 200, "Jane");
            var point2 = (Point)point1.Clone();
            Console.WriteLine();
            Console.WriteLine("До модификации");
            Console.WriteLine($"point1 {point1}");
            Console.WriteLine($"point2 {point2}");
            Console.WriteLine();
            point2.Description.PointName = "James";
            point2.X = 9;
            Console.WriteLine();
            Console.WriteLine("После модификации");
            Console.WriteLine($"point1 {point1}");
            Console.WriteLine($"point2 {point2}");
            Console.ReadLine();
        }
    }
}

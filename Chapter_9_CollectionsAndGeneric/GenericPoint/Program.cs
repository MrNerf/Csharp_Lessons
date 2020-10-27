using System;
using System.Diagnostics.CodeAnalysis;

namespace GenericPoint
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Создание спецаильных обобщенных структур и классов";
            Console.ForegroundColor = ConsoleColor.Cyan;
            var p1 = new Point<int>(20,50);
            Console.WriteLine(p1.ToString());
            p1.ResetPoint();
            Console.WriteLine(p1.ToString());
            Console.ReadLine();
        }

        public struct Point<T>
        {
            public T X { get; set; }

            public T Y { get; set; }

            public Point(T xPos, T yPos)
            {
                X = xPos;
                Y = yPos;
            }

            public override string ToString() => $"[X, Y] = [{X}, {Y}]";

            public void ResetPoint()
            {
                X = default;
                Y = default;
            }
        }
    }
}

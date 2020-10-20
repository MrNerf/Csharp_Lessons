using System;
using System.Diagnostics.CodeAnalysis;

namespace CustomInterface
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Drawing3D(IDraw3D draw3D)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Start drawing");
            draw3D.Draw3D();
        }

        private static void Main()
        {
            Console.Title = "Пример создания собственного интерфейса";
            Console.ForegroundColor = ConsoleColor.Yellow;
            var shapes = new Shape[20];
            var rnd = new Random();
            for (var i = 0; i < shapes.Length; i++)
            {
                var localInt = rnd.Next(5);
                if (localInt > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    shapes[i] = new Hexagon($"Hexagon {i}");
                }
                else if (localInt > 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    shapes[i] = new Circle($"Circle {i}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    shapes[i] = new Triangle($"Triangle {i}");
                }
                shapes[i].Draw();
                if (shapes[i] is IPointy iShape)
                    Console.WriteLine($"->{shapes[i].PetName} has {iShape.Points} points");
                else
                    Console.WriteLine($"->{shapes[i].PetName} hasn't points");
                if (shapes[i] is IDraw3D)
                    Drawing3D((IDraw3D) shapes[i]);
                else
                    Console.WriteLine("Can't draw this shape in 3D");

            }
            Console.ReadLine();
        }
    }
}

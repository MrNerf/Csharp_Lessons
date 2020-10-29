using System;
using System.Diagnostics.CodeAnalysis;

namespace CarDelegate
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Пример делегата";
            Console.ForegroundColor = ConsoleColor.Green;
            var car = new Car("Honda", 10, 100);
            //В какой метод будут собираться отчеты от объекта
            car.RegisterWithCarEngine(OnCarEngineEvent);
            car.RegisterWithCarEngine(OnCarEngineEvent2);
            for (var i = 0; i<6; i++)
                car.Accelerate(20);
            Console.ReadLine();
        }

        private static void OnCarEngineEvent2(string msh)
        {
            Console.WriteLine($"=> {msh.ToUpper()}");
        }

        private static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine($"=> {msg}");
            Console.WriteLine("***** End Message From Car Object *****\n");
        }
    }
}

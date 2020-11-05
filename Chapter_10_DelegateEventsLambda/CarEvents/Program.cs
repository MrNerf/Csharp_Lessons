using System;
using System.Diagnostics.CodeAnalysis;

namespace CarEvents
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Первый пример использования событий";
            Console.ForegroundColor = ConsoleColor.Magenta;
            var car = new Car("Solaris", 10, 100);
            car.AboutToBlow += Car_AboutToBlow;
            car.Exploded += Car_Exploded;
            for (var i = 0; i < 6; i++) car.Accelerate(20);
            Console.ReadLine();
        }

        private static void Car_Exploded(string msgForCaller) => Console.WriteLine($"Сообщение от машины: {msgForCaller}");

        private static void Car_AboutToBlow(string msgForCaller) => Console.WriteLine($"Сообщение от машины: {msgForCaller}");
    }
}

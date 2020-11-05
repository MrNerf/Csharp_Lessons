using System;
using System.Diagnostics.CodeAnalysis;

namespace CarEventArgs
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "";
            Console.ForegroundColor = ConsoleColor.Cyan;
            var car = new Car("Honda", 10, 100);
            car.AboutToBlow += Car_AboutToBlow;
            car.Exploded += Car_Exploded;
            for (var i = 0; i < 6; i++)
            {
                car.Accelerate(20);
            }
            Console.ReadLine();
        }

        private static void Car_Exploded(object sender, CarEventArgs args)
        {
            if (sender is Car car)
                Console.WriteLine($"Машина: {car.CarName}, передает сообщение: {args.Msg}");
        }

        private static void Car_AboutToBlow(object sender, CarEventArgs args)
        {
            if (sender is Car car)
                Console.WriteLine($"Машина: {car.CarName}, передает сообщение: {args.Msg}");
        }
    }
}

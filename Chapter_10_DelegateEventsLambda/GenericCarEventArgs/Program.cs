using System;
using System.Diagnostics.CodeAnalysis;

namespace GenericCarEventArgs
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var car = new Car("Honda", 10, 100);
            car.StartEventHandler += StartEventHandler;
            car.AboutToBlow += Car_AboutToBlow;
            car.Exploded += Car_Exploded;
            for (var i = 0; i < 6; i++)
            {
                car.Accelerate(20);
            }
            Console.ReadLine();
        }

        private static void StartEventHandler(object sender, EventArgs e)
        {
            if (sender is Car car)
                Console.WriteLine($"Машина {car.CarName}, начинает разгон");
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

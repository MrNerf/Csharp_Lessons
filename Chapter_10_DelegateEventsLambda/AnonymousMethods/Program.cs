using System;
using System.Diagnostics.CodeAnalysis;

namespace AnonymousMethods
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            var cnt = 0;
            Console.Title = "Использование анонимных методов";
            Console.ForegroundColor = ConsoleColor.Green;
            var car = new Car("Toyota", 10, 100);

            #region Anonymous Methods

            car.StartEventHandler += (sender, args) => Console.WriteLine("Произошло событие");
            car.AboutToBlow += delegate (object sender, CarEventArgs args)
            {
                cnt++;
                Console.WriteLine("Счетчик предупреждений: {0}", cnt);
                if (sender is Car eventCar)
                    Console.WriteLine($"{eventCar.CarName}, скоро перегреется, ее текущая скорость: {eventCar.CurrentSpeed}");
                Console.WriteLine("Машина передает сообщение: {0}", args.Msg);
            };

            car.Exploded += (sender, args) => Console.WriteLine($"Машина передает сообщение: {args.Msg}");

            #endregion

            for (var i = 0; i < 10; i++)
            {
                car.Accelerate(10);
            }
            Console.ReadLine();
        }
    }
}

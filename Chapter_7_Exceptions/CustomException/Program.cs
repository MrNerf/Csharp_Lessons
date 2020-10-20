using System;
using System.Diagnostics.CodeAnalysis;

namespace CustomException
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Создание собственного класса исключений";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var car = new Car("Honda", 20);
            car.RadioTune(true);
            try
            {
                for (var i = 0; i < 10; i++)
                    car.Accelerate(10);
            }
            catch (CarIsDeadException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.CauseOfError);
                Console.WriteLine(exception.ErrorDateTime);
                Console.WriteLine(exception.HelpLink);
            }
            Console.ReadLine();
        }
    }
}

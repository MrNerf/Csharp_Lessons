using System;
using System.Diagnostics.CodeAnalysis;

namespace CustomEnumeratorYield
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование ключевого слова Yield";
            Console.ForegroundColor = ConsoleColor.Green;
            var myGarage = new Garage();
            //foreach (Car car in myGarage)
            //{
            //    Console.WriteLine($"Машина: {car.CarName}, движется со скоростью {car.CurrentSpeed}км/ч");
            //}

            Console.WriteLine();
            //Используем функцию для обратного вывода 
            foreach (Car theCar in myGarage.GetTheCars(true))
            {
                Console.WriteLine($"Машина: {theCar.CarName}, движется со скоростью {theCar.CurrentSpeed}км/ч");
            }

            Console.WriteLine();
            //Используем функцию для вывода
            foreach (Car theCar in myGarage.GetTheCars())
            {
                Console.WriteLine($"Машина: {theCar.CarName}, движется со скоростью {theCar.CurrentSpeed}км/ч");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace ComparableCar
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование интефейса IComparable";
            Console.ForegroundColor = ConsoleColor.Magenta;
            var garage = new Garage();
            Console.WriteLine("Вывести все машины");
            foreach (Car car in garage)
            {
                Console.WriteLine($"Машина {car.CarName}, едет со скоростью {car.CurrentSpeed}км/ч");
            }
            Console.WriteLine();
            Console.WriteLine("Вывод в обратном порядке");
            foreach (Car car in garage.ReverseOrSort(true))
            {
                Console.WriteLine($"Машина {car.CarName}, едет со скоростью {car.CurrentSpeed}км/ч");
            }
            Console.WriteLine();
            Console.WriteLine("Сортировка");
            foreach (Car car in garage.ReverseOrSort())
            {
                Console.WriteLine($"Машина {car.CarName}, едет со скоростью {car.CurrentSpeed}км/ч");
            }

            Console.WriteLine();
            Console.WriteLine("Использование интерфейса IComparer");
            var carArray = new Car[4];
            carArray[0] = new Car("Toyota", 80, 3);
            carArray[1] = new Car("Kia", 50, 4);
            carArray[2] = new Car("Ford", 60, 2);
            carArray[3] = new Car("Subaru", 85, 1);
            foreach (var car in carArray)
            {
                Console.WriteLine($"Машина {car.CarName}, едет со скоростью {car.CurrentSpeed}км/ч");
            }

            Console.WriteLine();
            Console.WriteLine("Сортировка");
            Array.Sort(carArray, new NameCompare());
            foreach (var car in carArray)
            {
                Console.WriteLine($"Машина {car.CarName}, едет со скоростью {car.CurrentSpeed}км/ч");
            }
            Console.ReadLine();
        }
    }
}

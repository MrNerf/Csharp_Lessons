using System;
using System.Diagnostics.CodeAnalysis;
using BasicInheritance.Abstract;
using BasicInheritance.Employees;

namespace BasicInheritance
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Наследование и полиморфизм";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var car = new Car(120){CurrentSpeed = 90};
            Console.WriteLine($"Текущая машина может имеет максимальную скорость: {car.MaxSpeed}км/ч, движется сос коростью {car.CurrentSpeed}км/ч");
            var miniVan = new MiniVan() {CurrentSpeed = 40, SeatCnt = 9};
            Console.WriteLine($"Мини вэн едет со скоростью {miniVan.CurrentSpeed}км/ч, вмещает в себя {miniVan.SeatCnt} человек, максимальная скорость {miniVan.MaxSpeed}км/ч");
            Console.WriteLine();
            Console.WriteLine();
            var salesPerson = new SalesPerson() {Age = 25, Name = "Fred", Id = 1, Pay = 32000.5F, SalesNumber = 7};
            Console.WriteLine(salesPerson.ToString());
            Console.WriteLine();
            Console.WriteLine();
            var managerPerson = new Manager("John",  50, 2, 60000.46F, "One", 20);
            Console.WriteLine(managerPerson.ToString());
            managerPerson.DisplayStats();
            Console.WriteLine();
            var chuck = new Manager("Chucky", 50, 92, 100000, "33-23-2322", 9000);
            chuck.DisplayStats();
            Console.WriteLine(chuck.GetBenefitCost());
            Console.WriteLine();
            Console.WriteLine("Отсюда начнется полиморфизм");
            Console.WriteLine();
            var stanManager = new Manager("Stan", 46, 3, 150000, "55-34-4322", 10000);
            stanManager.GiveBonus(5000);
            stanManager.DisplayStats();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Abstract class");
            Console.WriteLine();
            Shape[] shapes = {new Hexagon(), new Circle(), new Circle("Betty"), new Hexagon("Zelda")};
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            Console.ReadLine();
        }
    }
}

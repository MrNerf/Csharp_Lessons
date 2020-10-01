using System;
using System.Diagnostics.CodeAnalysis;

namespace Incapsulation
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Пример инкапсуляции";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var human1 = new Human {Name = "John", Age = 46, Salary = 20000};
            Console.WriteLine("Первый пример заполнения класса");
            Console.WriteLine(human1.ToString());
            Console.WriteLine();
            var human2 = new Human("Peter", 99);
            Console.WriteLine("Второй пример заполнения класса");
            Console.WriteLine(human2.ToString());
            Console.WriteLine("Пытаюсь изменить возраст сотрудника");
            human2.Age++;
            Console.WriteLine(human2.ToString());
            Console.WriteLine();
            var human3 = new Human("Vasya", 50, 1_000_000);
            Console.WriteLine("Третий пример заполнения класса");
            Console.WriteLine(human3.ToString());
            Console.WriteLine("Пытаюсь изменить возраст сотрудника");
            human3.Age++;
            Console.WriteLine(human3.ToString());
            Console.WriteLine("Пытаюсь изменить имя сотрудника");
            human3.Name = "qwertyuiolsdfghjklxcvbnm";
            Console.WriteLine(human3.ToString());
            Console.ReadLine();
        }
    }
}

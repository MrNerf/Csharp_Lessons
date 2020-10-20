using System;

namespace ClassExample
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Class program";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Example class project");
            var defaultCar = new CarSimpleClass();
            Console.WriteLine(defaultCar.ToString());
            defaultCar.CarName = "Subaru";
            defaultCar.Speed = 190;
            defaultCar.SpeedUp();
            Console.WriteLine(defaultCar.ToString());
            var newCar = new CarSimpleClass("Volvo" , 170);
            Console.WriteLine(newCar.ToString());
            var thisCar = new CarSimpleClass("Audi");
            Console.WriteLine(thisCar.ToString());
            var basicChain = new ConstructorChain();
            Console.WriteLine(basicChain.ToString());
            var argumentChain = new ConstructorChain(2);
            Console.WriteLine(argumentChain.ToString());
            var fullChain = new ConstructorChain("Peter", 8);
            Console.WriteLine(fullChain.ToString());
            var staticClass = new StaticClassEx(5000);
            var staticClass1 = new StaticClassEx(8000);
            Console.WriteLine($"Percent now = {StaticClassEx.DisplayPercent()}");
            Console.WriteLine(staticClass1.ToString());
            Console.WriteLine(staticClass.ToString());
            StaticClassEx.SetPercent(0.1m);
            var staticClass2 = new StaticClassEx(123456789);
            Console.WriteLine(staticClass2.ToString());
            Console.ReadLine();
        }
    }
}

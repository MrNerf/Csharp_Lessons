using System;

namespace CustomEnumerator
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Custom enumerator";
            Console.ForegroundColor = ConsoleColor.Green;
            var garage = new Garage();
            foreach (Car car in garage)
                Console.WriteLine(car.CarName + " " + car.CurrentSpeed);
            var enumerator = garage.GetEnumerator();
            enumerator.MoveNext();
            var enumeratorCurrent = (Car)enumerator.Current;
            Console.WriteLine(enumeratorCurrent?.CarName);
            Console.ReadLine();
        }
    }
}

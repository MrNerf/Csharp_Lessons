using System;
using System.Diagnostics.CodeAnalysis;

namespace CustomGenericMethods
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Создание собственных обобщенных методов";
            Console.ForegroundColor = ConsoleColor.Yellow;
            var a = 5;
            var b = 10;
            Console.WriteLine($"A={a}, B={b}");
            Swap(ref a, ref b); //using Swap<int>
            Console.WriteLine($"A={a}, B={b}");
            string s1 = " Hello ", s2 = " Genereal Kenobi ";
            Console.WriteLine(s1+s2);
            Swap(ref s1,ref s2); //using Swap<string>
            Console.WriteLine(s1 + s2);
            Console.WriteLine();
            DisplayBaseClass<int>();
            DisplayBaseClass<Guid>();
            DisplayBaseClass<Exception>();
            Console.ReadLine();
        }

        #region Methods

        private static void Swap<T>(ref T param1, ref T param2)
        {
            Console.WriteLine($"Тип параметра: {typeof(T)}");
            var temp = param1;
            param1 = param2;
            param2 = temp;
        }

        private static void DisplayBaseClass<T>()
        {
            Console.WriteLine($"Тип параметра: {typeof(T)}, базовый тип: {typeof(T).BaseType}");
        }

        #endregion
    }
}

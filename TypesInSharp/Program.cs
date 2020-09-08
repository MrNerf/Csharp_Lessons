using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;

namespace TypesInSharp
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "First C# app";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep(10500, 500);
            ShowEnvironment();
            Console.WriteLine();
            DataTypeFunctionality();
            Console.WriteLine();
            UseBigInteger();
            Console.WriteLine();
            DigitSeparators();
            Console.WriteLine();
            StringInterpolation();
            Console.WriteLine();
            CheckedExpression();
            Console.WriteLine();
            LinqType();
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void ShowEnvironment()
        {
            Console.WriteLine("Данные об устройстве");
            Console.WriteLine("Machine Name {0}", Environment.MachineName);
            foreach(var drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS version: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processor: {0}", Environment.ProcessorCount);
            Console.WriteLine("dotNet version: {0}", Environment.Version);
            Console.WriteLine("Working time: {0}", Environment.TickCount);
        }

        private static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data Type Functionality");
            Console.WriteLine("Max int value: {0}", int.MaxValue);
            Console.WriteLine("Min int value: {0}", int.MinValue);
            Console.WriteLine("Max double value: {0}", double.MaxValue);
            Console.WriteLine("Min double value: {0}", double.MinValue);
            Console.WriteLine("Epsilon: {0}", double.Epsilon);
            Console.WriteLine("Infinity: {0}", double.PositiveInfinity);
        }

        private static void UseBigInteger()
        {
            Console.WriteLine("=> Using big integer type");
            var bigInteger = BigInteger.Parse("99999999999999999999999999999999999999999999999999999998");
            Console.WriteLine("Значение числа {0}", bigInteger);
            Console.WriteLine("Число четное: {0}", bigInteger.IsEven);
            Console.WriteLine("Число степень двойки: {0}", bigInteger.IsPowerOfTwo);
        }

        private static void DigitSeparators()
        {
            Console.WriteLine("=> Digit separators");
            Console.WriteLine("Int {0}", 123_456);
            Console.WriteLine("Long {0}", 123_456_789L);
            Console.WriteLine("Float {0}", 123_456.1234F);
            Console.WriteLine("Decimal {0}", 123_456.12M);
            Console.WriteLine("Bool 64: {0}", 0b0100_0000);

        }

        private static void StringInterpolation()
        {
            Console.WriteLine("Другой способ подставновки перменных в выходнйю строку");
            const int number = 25;
            const string text = "Какой-то текст";
            Console.WriteLine($"Вывод числа: {number}, и какого-то текста: {text}");
        }

        private static void CheckedExpression()
        {
            const byte b1 = 100;
            byte b2 = 250;
            try
            {
                var result = checked((byte)(b1 + b2));
                Console.WriteLine($"Первый байт = {b1}, Второй байт = {b2}, Резултат = {result}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                b2 = b1;
                var result = checked((byte)(b1 + b2));
                Console.WriteLine($"Первый байт = {b1}, Второй байт = {b2}, Резултат = {result}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void LinqType()
        {
            int[] numbers = {10,20,30,40};
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Valuses in subset:");
            foreach (var i in subset)
            {
                Console.Write($"{i}");
            }

            Console.WriteLine();

            Console.WriteLine($"subset is a: {subset.GetType().Name}");
            Console.WriteLine($"subset is defined in: {subset.GetType().Namespace}");
        }
    }
}

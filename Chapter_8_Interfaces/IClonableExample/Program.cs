using System;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace IClonableExample
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Пример полиморфизма на интерфейсе ICloneable";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string str = "Hello";
            var macOs = new OperatingSystem(PlatformID.MacOSX, new Version());
            var sqlCnn = new SqlConnection();
            //methods
            CloneMethod(str);
            CloneMethod(macOs);
            CloneMethod(sqlCnn);
            Console.ReadLine();
        }

        private static void CloneMethod(ICloneable cloneable)
        {
            var cloneObj = cloneable.Clone();
            Console.WriteLine($"Клонированный объект: {cloneObj}, тип: {cloneObj.GetType().FullName}");
        }
    }
}

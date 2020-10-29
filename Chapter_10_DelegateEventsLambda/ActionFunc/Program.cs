using System;

namespace ActionFunc
{
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Action and Func delegate";
            Console.ForegroundColor = ConsoleColor.Green;
            var action = new Action<string, ConsoleColor, int>(Display);
            action("My Action Work!!!", ConsoleColor.Cyan, 10);
            var func = new Func<int,int,string>(SumToString);
            Console.WriteLine($"Result of func delegate {func(5,250)}");
            Console.ReadLine();
        }

        private static string SumToString(int x, int y) => (x + y).ToString();

        private static void Display(string message, ConsoleColor color, int cnt)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            for (var i = 0; i < cnt; i++)
            {
                Console.WriteLine($"Message: {message}, Iteration: {i}");
            }
            Console.ForegroundColor = prevColor;
        }
    }
}

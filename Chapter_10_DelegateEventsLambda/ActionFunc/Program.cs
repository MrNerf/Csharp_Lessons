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

            for (var i = 1; i < 37; i++)
                Console.WriteLine($"Day: {i}, need to run {LoopCounter(i)} laps");
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

        private static int LoopCounter(int day)
        {
            // Базовая защита на дурачка
            if (day <= 0)
                return 0;
            if (day < 7)
                return day;
            // Выделяем часть недели

            var weekCnt = Math.Ceiling((decimal)day / 6);
            // Находим последний день недели
            var dayInc = 6 * (weekCnt - 1);
            // Результат предствален, как номер недели плюс разница между текущим днем и последним днем прошлой недели
            var result = weekCnt + (day - dayInc - 1);

            return (int) result;
        }
    }
}

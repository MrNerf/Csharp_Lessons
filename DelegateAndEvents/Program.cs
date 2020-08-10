using System;
using System.Diagnostics.CodeAnalysis;

namespace DelegateAndEvents
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    internal class Program
    {
        //private EventHandler
        private static void Main()
        {
            Console.WriteLine("Delegate and events example application");
            Console.WriteLine("Type \"1\" for delegate examples");
            Console.WriteLine("Type \"2\" for event examples");
            Console.WriteLine("Type \"0\" to close application");
            while (true)
            {
                Console.Write("Type number: ");
                var key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        DelegateClassExample.ShowDelegateExample();
                        break;
                    case "2":
                        var person = new EventPersonExample
                        {
                            Name = "Peter"
                        };
                        person.SleepHandler+= SleepHandler;
                        person.Handler += Handler;
                        Console.WriteLine("Input time");
                        var time = Console.ReadLine();
                        person.TakeTime(Convert.ToInt32(time));
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("enter correct number");
                        break;
                }
            }
        }

        private static void Handler(object sender, EventArgs e)
        {
            if (!(sender is EventPersonExample))
            {
                Console.WriteLine("error");
            }

            Console.WriteLine((EventPersonExample)sender + " is working");
        }

        private static void SleepHandler(object sender, EventArgs e)
        {
            if (!(sender is EventPersonExample))
            {
                Console.WriteLine("Some Error");
            }

            Console.WriteLine($"{((EventPersonExample)sender).Name} is sleeping");
        }
    }
}

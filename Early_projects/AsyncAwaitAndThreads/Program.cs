using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitAndThreads
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    internal class Program
    {

        // example of lock parameter (must be reference type)
        private static int _x;
        private static readonly object Locker = new object();
        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("AsyncAwait and Thread example application");
            Console.WriteLine("Type \"1\" for one thread example");
            Console.WriteLine("Type \"2\" for two threads example");
            Console.WriteLine("Type \"3\" for Async/Await example");
            Console.WriteLine("Type \"4\" for multi parametrized thread example");
            Console.WriteLine("Type \"5\" for lock thread example");
            Console.WriteLine("Type \"6\" for semaphore thread example");
            Console.WriteLine("Type \"0\" to close application");
            while (true)
            {
                Console.Write("Input number");
                var key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.WriteLine("One thread example");
                        // initialize new thread for function
                        var thread = new Thread(LongFunction);
                        thread.Start();
                        Thread.Sleep(1000);
                        break;
                    case "2":
                        Console.WriteLine("Two thread example");
                        // initialize new thread with parameter
                        var thread1 = new Thread(LongFunction);
                        var thread2 = new Thread(LongFunction2);
                        thread1.Start();
                        thread2.Start(50000000);
                        Thread.Sleep(1000);
                        break;
                    case "3":
                        Console.WriteLine("Two tasks example");
                        var task = LongFunctionTask();
                        Console.WriteLine(task.IsCompleted);
                        // call asynchronous method
                        var result = SaveFileTask("log.txt");
                        Console.WriteLine(result.Result);
                        break;
                    case "4":
                        Console.WriteLine("Multi parametrized thread example");
                        /*
                         * Создание потока с различным количеством входных параметров
                         * Для этого создается отдельный класс
                         * объект класса можно передавать в качестве параметра потока
                         * или вызвать отдельный метод,
                         * предварительно указав значения параметров в конструкторе
                         */
                        var counter = new ThreadClass(20, 5);
                        var thread3 = new Thread(counter.Count);
                        thread3.Start();
                        Thread.Sleep(10000);
                        break;
                    case "5":
                        Console.WriteLine("Lock example");
                        // Пример создания lock объекта
                        for (var i = 0; i < 5; i++)
                        {
                            var myThread = new Thread(Count)
                            {
                                Name = "Поток " + i
                            };
                            myThread.Start();
                        }
                        
                        break;
                    case "6":
                        Console.WriteLine("Semaphore example");
                        SemaphoreClass.ExampleSemaphore();
                        Thread.Sleep(10000);
                        break;
                    case "0":
                        Console.WriteLine("exit...");
                        return;
                    default:
                        Console.WriteLine("enter correct number");
                        break;
                }
            }
        }

        #region Asynchronous methods

        private static async Task LongFunctionTask()
        {
            await Task.Run(LongFunction);
            Console.WriteLine("in Asynchronous method");
        }

        private static async Task<bool> SaveFileTask(string path)
        {
            var result = await Task.Run(() => SaveFile(path));
            return result;
        }
        #endregion

        #region Synchronous methods 

        // simple example of thread
        private static void LongFunction()
        {
            var cnt = 0;
            for (var i = 0; i < 50000000; i++)
            {
                if (i % 10000000 != 0) continue;
                cnt++;
                Console.WriteLine(cnt);
            }
        }

        //example of parametrized thread function 
        private static void LongFunction2(object maxValue)
        {
            var cnt = 5;
            for (var i = 0; i < (int)maxValue; i++)
            {
                if (i % 10000000 != 0) continue;
                cnt--;
                Console.WriteLine(cnt);
            }
        }

        private static bool SaveFile(string path)
        {
            var rnd = new Random();
            var text = "";
            for (var i = 0; i < 30000; i++)
            {
                text += rnd.Next();
                text += "\r\n";
            }

            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine(text);
            }

            return true;
        }

        public static void Count()
        {
            lock (Locker)
            {
                _x = 1;
                for (var i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, _x);
                    _x++;
                    Thread.Sleep(100);
                }
            }
        }

        #endregion

    }
}

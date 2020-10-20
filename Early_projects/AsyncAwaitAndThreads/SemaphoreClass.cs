using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace AsyncAwaitAndThreads
{
    public static class SemaphoreClass
    {
        public static void ExampleSemaphore()
        {
            for (var i = 1; i < 6; i++)
            {
                var _ = new Reader(i);
            }
        }
    }

    [SuppressMessage("ReSharper", "CommentTypo")]
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Reader
    {
        // создаем семафор
        private static readonly Semaphore Sem = new Semaphore(3, 3);
        private int _count = 3;// счетчик чтения

        public Reader(int i)
        {
            var myThread = new Thread(Read) {Name = $"Читатель {i}"};
            myThread.Start();
        }

        public void Read()
        {
            while (_count > 0)
            {
                Sem.WaitOne();

                Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

                Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

                Sem.Release();

                _count--;
                Thread.Sleep(1000);
            }
        }
    }
}

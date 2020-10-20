using System;
using System.Threading;

namespace AsyncAwaitAndThreads
{
    public class ThreadClass
    {
        private readonly int _x;
        private readonly int _y;

        public ThreadClass(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public  void Count()
        {
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine("Thread №2");
                Console.WriteLine(i*_x*_y);
                Thread.Sleep(500);
            }
        }
    }
}

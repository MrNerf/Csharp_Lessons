using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class StaticClassEx
    {
        private static decimal _percent;
        private readonly int _sum;

        static StaticClassEx()
        {
            Console.WriteLine("Static constructor");
            _percent = 0.07M;
        }

        public StaticClassEx(int sum) => _sum = sum;

        public static decimal DisplayPercent() => _percent;

        public static void SetPercent(decimal percent) => _percent= percent;

        public override string ToString() => "Sum on account: " + _sum + ", percent: " + _percent;
    }
}

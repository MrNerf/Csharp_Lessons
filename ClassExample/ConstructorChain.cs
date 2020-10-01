using System;

namespace ClassExample
{
    public class ConstructorChain
    {
        private readonly string _driverName;
        private readonly int _intensity;

        public ConstructorChain() : this("Human", 5) { }
        public ConstructorChain(string driverName) : this(driverName, 1) { }
        public ConstructorChain(int intensity) : this("Default", intensity) { }

        public ConstructorChain(string driverName, int intensity)
        {
            if (intensity > 10)
                intensity = 10;
            _driverName = driverName;
            _intensity = intensity;
            Console.WriteLine("It's a trap John!");
        }

        public override string ToString()
        {
            return "Driver name: " + _driverName + ", intensity: " + _intensity;
        }
    }
}

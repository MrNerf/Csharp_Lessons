using System;

namespace BasicInheritance.Abstract
{
    public class Hexagon : Shape
    {
        public Hexagon() { }

        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");
        }
    }
}

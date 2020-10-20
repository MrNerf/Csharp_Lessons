using System;

namespace CustomInterface
{
    public class Hexagon : Shape, IPointy, IDraw3D
    {
        #region ctors

        public Hexagon() { }

        public Hexagon(string name) : base(name) { }

        #endregion

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the hexagon");
        }

        public byte Points => 6;

        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D");
        }
    }
}

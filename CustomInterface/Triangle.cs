using System;

namespace CustomInterface
{
    public class Triangle : Shape, IPointy
    {
        #region ctors

        public Triangle() { }

        public Triangle(string name) : base(name) { }
        
        #endregion

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the triangle");
        }

        public byte Points => 3;
    }
}

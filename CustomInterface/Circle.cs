using System;

namespace CustomInterface
{
    public class Circle : Shape, IDraw3D
    {
        #region ctors

        public Circle() { }

        public Circle(string name) : base(name) { }

        #endregion

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the circle");
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D");
        }
    }
}
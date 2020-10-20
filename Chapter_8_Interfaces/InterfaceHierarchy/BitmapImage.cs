using System;

namespace InterfaceHierarchy
{
    public class BitmapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Simple Drawing");
        }

        public void DrawInBox(int top, int bottom, int left, int right)
        {
            Console.WriteLine("Advanced Drawing with parameters");
        }

        public void DrawUpsideBox()
        {
            Console.WriteLine("Advanced Drawing");
        }
    }
}

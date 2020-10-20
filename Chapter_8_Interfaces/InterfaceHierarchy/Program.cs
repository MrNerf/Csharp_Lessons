using System;
using System.Diagnostics.CodeAnalysis;

namespace InterfaceHierarchy
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Иерархия интерфейсов";
            var myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBox(100,0,0,0);
            myBitmap.DrawUpsideBox();
            Console.ReadLine();
        }
    }
}

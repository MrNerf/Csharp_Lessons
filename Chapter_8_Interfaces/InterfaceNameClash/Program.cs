using System;

namespace InterfaceNameClash
{
    internal class Program
    {
        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var octagon = new Octagon();
            var itForm = (IDrawToForm) octagon;
            itForm.Draw();
            Console.WriteLine();
            ((IDrawToMemory)octagon).Draw();
            Console.WriteLine();
            if (octagon is IDrawToPrinter iPrinter)
                iPrinter.Draw();
            Console.ReadLine();
        }
    }
}

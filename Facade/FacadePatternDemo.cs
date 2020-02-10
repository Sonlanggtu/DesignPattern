using System;

namespace Facade
{
    class FacadePatternDemo
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawTriangle();
            shapeMaker.DrawSquare();
            shapeMaker.DrawRectangle();

            Console.WriteLine("Keypress [Enter] the end ..............");
            Console.ReadKey();
        }
    }
}

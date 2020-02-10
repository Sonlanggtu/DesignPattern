using System;

namespace Factory
{
    public class Factory
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            shapeFactory.GetShape("circle");
            shapeFactory.GetShape("square");
            Console.WriteLine("Press[Enter]............... End");
            Console.ReadKey();
            Console.ReadLine();
            
        }
    }

}

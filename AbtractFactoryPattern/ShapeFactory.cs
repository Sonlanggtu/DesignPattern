using System;
using System.Collections.Generic;
using System.Text;

namespace AbtractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(String shapeType)
        {
            if (shapeType.Equals("triangle"))
            {
                return new Triangle();
            }
            else if (shapeType.Equals("square"))
            {
                return new Square();
            }
            else
            {
                Console.WriteLine("Khong co hinh nay .......... ");
                return null;
            }
        }
    }
}

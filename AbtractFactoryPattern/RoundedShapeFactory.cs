using System;
using System.Collections.Generic;
using System.Text;

namespace AbtractFactoryPattern
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(String shapeType)
        {
            if (shapeType.Equals("roundedtriangle"))
            {
                return new Triangle();
            }
            else if (shapeType.Equals("roundedsquare"))
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

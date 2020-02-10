using System;
using System.Collections.Generic;
using System.Text;

namespace AbtractFactoryPattern
{
    public class AbstractFactoryPatternDemo
    {
        public static void Main()
        {
            //var factoryProducer = FactoryProducer.GetFactory(true);
            //RoundedShapeFactory roundedShapeFactory = new RoundedShapeFactory();
            //roundedShapeFactory.GetShape("roundedtriangle");

            FactoryProducer.GetFactory(false);
            ShapeFactory shapeFactory = new ShapeFactory();
            shapeFactory.GetShape("triangle");
            Console.WriteLine("Key Press [Enter] the End ................");
            Console.ReadLine();
        }
    }
}

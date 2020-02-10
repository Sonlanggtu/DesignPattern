using System;
using System.Collections.Generic;
using System.Text;

namespace AbtractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool round)
        {
            if (round)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}

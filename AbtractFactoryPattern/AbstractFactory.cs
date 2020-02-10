using System;
using System.Collections.Generic;
using System.Text;

namespace AbtractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shapeType);
    }
}
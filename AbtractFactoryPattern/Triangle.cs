using System;
using System.Collections.Generic;
using System.Text;

namespace AbtractFactoryPattern
{
    public class Triangle : IShape
    {
        public Triangle()
        {
            Console.WriteLine("Create object draw(): Triangle complete");
        }
        public void draw()
        {
            Console.WriteLine("Create methob draw(): Triangle complete");
        }
    }
}

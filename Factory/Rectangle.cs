using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Rectangle : IShape
    {
        public Rectangle()
        {
            Console.WriteLine("Create object Rectangle complete");
        }

        public void draw()
        {
            Console.WriteLine("access method Rectangle complete");
        }
    }
}
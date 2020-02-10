using System;
using System.Collections.Generic;
using System.Text;

namespace AbtractFactoryPattern
{
    public class Square : IShape
    {
        public Square()
        {
            Console.WriteLine("Create object draw(): Square complete");
        }
        public void draw()
        {
            Console.WriteLine("Create methob draw(): Square complete");
        }
    }
}
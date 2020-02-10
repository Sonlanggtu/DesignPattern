using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Square : IShape
    {
        public Square()
        {
            Console.WriteLine("Create object Square complete");
        }

        public void draw()
        {
            Console.WriteLine("access method Square complete");
        }
    }
}
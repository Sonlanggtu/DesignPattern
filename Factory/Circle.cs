using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Circle : IShape
    {
        public Circle()
        {
            Console.WriteLine("Create object Circle complete");
        }

        public void draw()
        {
            Console.WriteLine("create method circle complete");
        }
    }
}
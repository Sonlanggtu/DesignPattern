using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("access method draw class circle");
        }
    }
}

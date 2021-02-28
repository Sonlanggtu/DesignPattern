using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("access method draw class Rectangle");
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Retangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("access method draw class Retangle"); 
        }
    }
}

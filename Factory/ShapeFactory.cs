using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string value)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                if (value == "rectangle")
                {
                    return new Rectangle();
                   
                }
                else if(value == "square")
                {
                    return new Square();
                }
                else if (value == "circle")
                {
                    return new Circle();
                }
                else
                {
                    Console.WriteLine("khong co hinh nay");
                    return null;
                }
            }
        }  
    }
}
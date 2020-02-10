using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class ShapeMaker
    {
        private IShape _triangle;
        private IShape _square;
        private IShape _retangle;

        public ShapeMaker()
        {
            _triangle = new Triangle();
            _square = new Square();
            _retangle = new Retangle();
        }

        public void DrawTriangle()
        {
            _triangle.draw();
        }

        public void DrawSquare()
        {
            _square.draw();
        }

        public void DrawRectangle()
        {
            _retangle.draw();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape _decoratedShape;
        public ShapeDecorator(IShape decoratedShape)
        {
            _decoratedShape = decoratedShape;
        }

        public void Draw()
        {
            _decoratedShape.Draw();
        }
    }
}

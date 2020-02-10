using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public int ExcuteStrategy(int numberone, int numbertwo)
        {
            return _strategy.DoOpention(numberone, numbertwo);
        }
    }
}

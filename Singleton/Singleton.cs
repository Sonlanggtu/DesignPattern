using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        public static Singleton instance = new Singleton();
        private Singleton()
        {
            
        }

        public string GetValue(string value)
        {
            return "value return" + value;
        }
    }
}

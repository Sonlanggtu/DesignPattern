using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class OperationMultiply : IStrategy
    {
        public int DoOpention(int numberone, int numbertwo)
        {
            return numberone * numbertwo;
        }
    }
}

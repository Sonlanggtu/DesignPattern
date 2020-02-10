using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyPatternDemo
    {
        public static void Main()
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.ExcuteStrategy(10, 5));

            Context context2 = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 = " + context2.ExcuteStrategy(10, 5));

            Context context3 = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = " + context3.ExcuteStrategy(10, 5));

            Console.WriteLine("Keypress [Enter] the end .................. ");
            Console.ReadKey();
        }
    }
}

using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Singleton.instance.GetValue("Hello world"));
        }
    }
}

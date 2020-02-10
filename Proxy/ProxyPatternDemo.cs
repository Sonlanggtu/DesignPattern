using System;

namespace Proxy
{
    class ProxyPatternDemo
    {
        public static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            // image will be loaded from disk
            image.Display();
            Console.WriteLine("");


            // image will not be loaded from disk
            image.Display();

            Console.WriteLine("Keypress [Enter] the end ...........");
            Console.ReadKey();
        }
    }
}

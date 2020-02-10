using System;

namespace Observer
{
    class ObserverPatternDemo
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.SetState(15);
            Console.WriteLine("First state change: 10");
            subject.SetState(10);

            Console.WriteLine("Keypress [ENTER] the End ..................");
            Console.ReadKey();
        }
    }
}

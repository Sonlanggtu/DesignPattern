using System;

namespace Mediator
{
    class MediatorPatternDemo
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User jonson = new User("Joinson");

            robert.SendMessage("Hi! Join!");
            jonson.SendMessage("Hello! Robert");

            Console.WriteLine("Keypress [ENTER] The End .............");
            Console.ReadKey();
        }
    }
}

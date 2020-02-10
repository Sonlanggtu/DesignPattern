using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine(new DateTime().ToString() + "[ " + user.Name + "]: " + message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class User
    {
        public User(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}

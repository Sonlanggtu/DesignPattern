using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class TPBank : Bank
    {
        private IAccount account;
        public TPBank(IAccount account) : base(account)
        {
            this.account = account;
        }

        public override void OpenAccount()
        {
            Console.WriteLine("This is Account TPBank .................. ");
            account.OpenAccount();
        }
    }
}

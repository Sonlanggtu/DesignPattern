using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Vietcombank : Bank
    {
        private IAccount account;
        public Vietcombank(IAccount account) : base(account)
        {
            this.account = account;
        }

        public override void OpenAccount()
        {
            Console.WriteLine("This is Account Vietcombank .... ");
            account.OpenAccount();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Bank
    {
        protected IAccount _account;

        protected Bank(IAccount account)
        {
            _account = account;
        }

        public abstract void OpenAccount();
    }
}

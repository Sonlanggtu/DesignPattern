using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class BridgePatternDemo
    {
        public static void Main()
        {
            Bank vietcombank = new Vietcombank(new CheckingAccount());
            vietcombank.OpenAccount();

            Bank tPBank = new TPBank(new SavingAccount());
            tPBank.OpenAccount();

            Console.WriteLine("KeyPess [Enter] the end ........................ ");
            Console.ReadKey();
        }
    }
}

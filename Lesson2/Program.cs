using System;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount(AccountTypes.CreditCardAccount);
            BankAccount account3 = new BankAccount((Int64)148524632841);
            BankAccount account4 = new BankAccount((float)1100);
            account1.Print();
            account2.Print();
            account3.Print();
            account4.Print();
            Console.ReadKey();
        }
    }
}

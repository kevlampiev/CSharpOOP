using System;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount( AccountTypes.DemandDeposit, 400);
            BankAccount account2 = new BankAccount( AccountTypes.CreditCardAccount, -500);
            account1.Print();
            account2.Print();
            Console.ReadKey();
        }
    }
}

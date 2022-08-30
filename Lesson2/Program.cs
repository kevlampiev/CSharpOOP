using System;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Standard contructor");
            account.Print();
            account.AccountNumber = 148777;
            account.AccountType = AccountTypes.CreditCardAccount;
            account.Balance = -500;
            Console.WriteLine("After properties modification");
            account.Print();

            Console.ReadKey();
        }
    }
}

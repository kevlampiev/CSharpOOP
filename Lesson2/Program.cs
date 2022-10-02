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
            Console.WriteLine("After properties modification with invalid remain");
            account.Print();

            account.Balance = 1000;
            Console.WriteLine("After properties modification with valid remain");
            account.Print();

            WithdrawMoney(account, 700);
            WithdrawMoney(account, 500);

            account.TopUpTheAccount(250);
            Console.WriteLine("Have just added 500$");
            account.Print();
            WithdrawMoney(account, 500);

            Console.ReadKey();
        }

        static void WithdrawMoney(BankAccount acc, float summ) 
        {
            bool withdrawalResult = acc.WithdrawFromTheAccount(summ);
            if (withdrawalResult)
            {
                Console.WriteLine($"successful withdrawal of {summ}$");
                acc.Print();
            }
            else
            {
                Console.WriteLine($"Cannot withdraw {summ}$ from this account");
            }
        }
    }
}

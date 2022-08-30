using System;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(407810500000000148, AccountTypes.DemandDeposit, 400);
            account.Print();
            Console.ReadKey();
        }
    }
}

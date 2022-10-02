using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Lesson2;

namespace Lesson3
{
    public class ExtendedBankAccount : BankAccount
    {
        public ExtendedBankAccount(float summ) : base(summ) { }
        public ExtendedBankAccount():base() { }

        public bool TopUpFromAccount(BankAccount account, float summ)
        {
            if (summ < 0)
            {
                Console.WriteLine("Не могу перевести на счет отрицательную сумму");
                return false;
            }
            if (!account.WithdrawFromTheAccount(summ)) 
            {
                Console.WriteLine($"Недостаточно денег на счете списания {account.AccountNumber}");
                return false;
            };
            this.TopUpTheAccount(summ);
            return true;
        }
    }
}

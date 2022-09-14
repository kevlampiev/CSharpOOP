using System;
using System.Collections.Generic;
using System.Text;
using Lesson3;

namespace lesson6
{
    /// <summary>
    /// bank account. New generation
    /// </summary>
    public class BankAccountNG:ExtendedBankAccount
    {
        public static bool operator ==(BankAccountNG a, BankAccountNG b)
        {
            if ((object)a == null || (object)b == null) return false;
            return (a.AccountNumber == b.AccountNumber) && (a.AccountType == b.AccountType); //Ну, в принципе, все. Остальное - от лукавого 
        }

        public static bool operator !=(BankAccountNG a, BankAccountNG b)
        {
            if ((object)a == null || (object)b == null) return true;
            return (a.AccountNumber != b.AccountNumber) || (a.AccountType != b.AccountType); //Ну, в принципе, все. Остальное - от лукавого 
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj as BankAccountNG);
        }

        public bool Equals(BankAccountNG anotherAccount)
        { 
            return (anotherAccount != null) && (AccountNumber == anotherAccount.AccountNumber) && (AccountType == anotherAccount.AccountType);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AccountNumber, Balance, AccountType);
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine(" Это был продвинутый аккаунт ");
        }


    }
}

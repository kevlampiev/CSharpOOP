﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    /// <summary>
    /// Типы бавнковских счетов
    /// </summary>
    enum AccountTypes 
    { 
        DemandDeposit,
        TermDeposit,
        CreditCardAccount,
        TemporaryAcount
    }
    internal class BankAccount
    {
        //Поля
        private readonly Int64 accountNumber;
        private float balance = 0;
        private readonly AccountTypes accountType = AccountTypes.DemandDeposit;

        private static Int64 defaultAccountNo = 0;

        public string AccountNumber { get { return accountNumber.ToString(); } }
        public string AccountType { get { return accountType.ToString(); } }
        public float Balance { get { return balance; } set { if (value > 0) { balance = value; } } }

/*        public BankAccount(Int64 accountNo, AccountTypes accountType, float balance) 
        { 
            this.accountNumber = accountNo;
            this.accountType = accountType;
            this.balance = (balance>0)?balance:0; 
        }

        public BankAccount(long accountNumber, float balance, AccountTypes accountType)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
        }
*/
        /// <summary>
        /// Выводит данные о счете и его состоянии
        /// </summary>
        public void Print() 
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($" Account No: {this.AccountNumber} \n Account Type: {this.AccountType} \n Remain: {this.Balance}");
            Console.WriteLine("-------------------------------------------------");
        }

        private Int64 GetNewAccountNumber() 
        {
            return defaultAccountNo++;
        }

        public BankAccount(AccountTypes accountType, float balance) 
        {
            this.accountNumber = GetNewAccountNumber();
            this.accountType = accountType;

            this.balance = balance;
        }

        public BankAccount() : this(AccountTypes.DemandDeposit, 0) { }

        public BankAccount(long accountNumber):this()
        {
            this.accountNumber = accountNumber;
        }

        public BankAccount(AccountTypes accountType) : this()
        {
            this.accountType = accountType;
        }
        public BankAccount(float balance) : this()
        {
            this.balance = balance;
        }

    }
}
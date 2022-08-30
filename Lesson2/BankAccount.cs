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
        private Int64 accountNumber;
        private float balance = 0;
        private AccountTypes accountType = AccountTypes.DemandDeposit;

        private static Int64 defaultAccountNo = 0;

        public long AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public AccountTypes AccountType { get { return accountType; } set { accountType = value; } }
        public float Balance { get { return balance; } set { if (value > 0) { balance = value; } } }


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

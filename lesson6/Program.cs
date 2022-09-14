using System;
using KEvlampiev.ConsoleUtils;

namespace lesson6
{
    internal class Program
    {

        public static void PointOne()
        {
            ConsoleToolKit.DisplayHeader("Задание 1");
            BankAccountNG bankAccount1 = new BankAccountNG();
            BankAccountNG bankAccount2 = new BankAccountNG();
            bankAccount1.Print();
            bankAccount2.Print();

            Console.WriteLine($" bank account 1 == bank account 2  --{bankAccount1 == bankAccount2}");
            Console.WriteLine($" bank account 1 != bank account 2  --{bankAccount1 != bankAccount2}");
            Console.WriteLine($" bank account 1 equals to bank account 2  --{bankAccount1.Equals(bankAccount2)}");

            Console.WriteLine($"Hash code of account 1 is {bankAccount1.GetHashCode()}");
            Console.WriteLine($"Hash code of account 2 is {bankAccount2.GetHashCode()}");
           
        }
        static void Main(string[] args)
        {
            PointOne();
            Console.ReadKey();

        }
    }
}

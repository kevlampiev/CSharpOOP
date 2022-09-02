using System;

namespace Lesson3
{
    internal class Program
    {
        static void DisplayHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(header);
            Console.WriteLine(new string('-', 80));
            Console.ResetColor();

        }

        static void PointOne()
        {
            DisplayHeader("Задание 1. Создание двух счетов, списание с одного и зачисление на второй");
            ExtendedBankAccount account1 = new ExtendedBankAccount(600);
            ExtendedBankAccount account2 = new ExtendedBankAccount(100);
            Console.WriteLine("Счет списания до перевода");
            account1.Print();
            Console.WriteLine("Счет зачисления до перевода");
            account2.Print();

            account2.TopUpFromAccount(account1, 400);
            Console.WriteLine("Счет списания после перевода");
            account1.Print();
            Console.WriteLine("Счет зачисления после перевода");
            account2.Print();
        }

        static void Main(string[] args)
        {
            PointOne();
            Console.ReadKey();
        }
    }
}

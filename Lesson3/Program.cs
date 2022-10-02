using System;
using System.Text;

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

        static string FlipTheString(string sourceStr)
        {
            StringBuilder newStr = new StringBuilder(sourceStr.Length);
            for (int i = sourceStr.Length-1; i >=0; i--)
            {
                newStr.Append(sourceStr[i]);
            }
            return newStr.ToString();

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

        static void PointTwo()
        {
            DisplayHeader("Задание 2. Создание метода, разворачивающего строку");
            string sourceString = "Главрыба";

            Console.WriteLine(sourceString + " <=> "+FlipTheString(sourceString));

        }

        static void PointThree()
        {
            DisplayHeader("Задание 3. Выбрать все email из файла ");
            EmailCollector emailCollector = new EmailCollector("D:\\CSharpProj\\OOP\\CSharpOOP\\Lesson3\\datafile.txt",
                "D:\\CSharpProj\\OOP\\CSharpOOP\\Lesson3\\email.\txt");
            emailCollector.Handle();
            emailCollector.DisplayREsults();
        }

        static void Main(string[] args)
        {
            PointOne();
            PointTwo();
            PointThree();
            Console.WriteLine("Нажмите ч-н для выхода....");
            Console.ReadKey();
        }
    }
}

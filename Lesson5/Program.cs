using System;

namespace Lesson5
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
            DisplayHeader("Задание 1. Класс рациональных чисел");
            RationalNumber numberOne = new RationalNumber(4, 6);
            RationalNumber numberTwo = new RationalNumber(5, 7);
            RationalNumber numberThree = new RationalNumber(2, 3);

            Console.WriteLine($"Firts rational number {numberOne}");
            Console.WriteLine($"Second rational number {numberTwo}");
            Console.WriteLine($"Third rational number {numberThree}");

            Console.WriteLine($"First and second are equal {numberOne == numberTwo}");
            Console.WriteLine($"First and third are equal {numberOne == numberThree}");
            Console.WriteLine($"First and second are NOT equal {numberOne != numberTwo}");
            Console.WriteLine($"First and third are NOT equal {numberOne != numberThree}");

            Console.WriteLine($"The result of applying Equals to first and second is {numberOne.Equals(numberTwo)}");
            Console.WriteLine($"The result of applying Equals to first and third is {numberOne.Equals(numberThree)}");

            Console.WriteLine($"Result of {numberOne.ToString()} + {numberTwo.ToString()} is {(numberOne + numberTwo).ToString()}");
            Console.WriteLine($"Increment of {numberOne.ToString()} is {(++numberOne).ToString()}");
        }

        static void PointTwo() 
        {
            DisplayHeader("Задание 2. Класс комплексных чисел");
            ImaginaryNumber a = new ImaginaryNumber(4, 6);
            ImaginaryNumber b = new ImaginaryNumber(1, - 7.5);
            Console.WriteLine($" a = {a.ToString()}");
            Console.WriteLine($" b = {b.ToString()}");
            Console.WriteLine($" a == b? = {a == b}");
            Console.WriteLine($" a != b? = {a != b}");
            Console.WriteLine($" a-b = {(a - b).ToString()}");
            Console.WriteLine($" a+b = {(a + b).ToString()}");
            Console.WriteLine($" a*b = {(a * b).ToString()}");
            Console.WriteLine($" a/b = {(a / b).ToString()}");
        }

        static void Main(string[] args)
        {

            PointOne();
            PointTwo();
            Console.ReadKey();
        }
    }
}

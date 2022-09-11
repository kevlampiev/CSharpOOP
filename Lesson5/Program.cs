using System;

namespace Lesson5
{
    internal class Program
    {
        static void PointOne()
        {
            Console.WriteLine("Задание 1. Класс рациональных чисел");
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

        static void Main(string[] args)
        {

            PointOne();
            Console.ReadKey();
        }
    }
}

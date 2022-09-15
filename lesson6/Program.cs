using System;
using System.Collections.Generic;
using KEvlampiev.ConsoleUtils;
using lesson6.Figures;

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


        public static void PointTwo() 
        {
            ConsoleToolKit.DisplayHeader("Задание 2");

            List<Point> figureCollection = new List<Point>();
            figureCollection.Add(new Point());
            figureCollection.Add(new Point());
            figureCollection.Add(new Circle(5)); 
            figureCollection.Add(new Circle(1,1,FigureColors.blue, 5));
            figureCollection.Add(new Rectangle(1, 3, FigureColors.blue, 5,3));
            figureCollection.Add(new Rectangle(7));

            foreach (Point el in figureCollection) 
            {
                el.Render();
                Console.WriteLine(el.Square);
            }
        }


        static void Main(string[] args)
        {
            PointOne();
            PointTwo();
            Console.ReadKey();
        }
    }
}

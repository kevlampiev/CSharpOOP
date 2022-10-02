using System;
using System.Collections.Generic;
using KEvlampiev.ConsoleUtils;
using Lesson7.Figures;

namespace Lesson7
{
    internal class Program
    {
        static void PointOne() 
        {
            ConsoleToolKit.DisplayHeader("Задание 1");
            string someStr = "абвгд abcdef";

            List<ICoder> coders = new List<ICoder>();
            coders.Add(new ACoder());
            coders.Add(new BCoder());

            foreach (ICoder coder in coders) 
            {
                Console.WriteLine(coder.GetType());
                string newStr = coder.Encode(someStr);
                Console.Write(someStr + " -> ");
                Console.Write(newStr + " -> ");
                Console.WriteLine(coder.Decode(newStr));
            }
        }


        public static void PointTwo()
        {
            ConsoleToolKit.DisplayHeader("Задание 2");

            List<ITwoDimensionFigure> figureCollection = new List<ITwoDimensionFigure>();
            figureCollection.Add(new Circle(5));
            figureCollection.Add(new Circle(1, 1, FigureColors.blue, 5));
            figureCollection.Add(new Rectangle(1, 3, FigureColors.blue, 5, 3));
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

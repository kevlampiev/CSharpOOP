using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6.Figures
{
    public class Point:Figure
    {
        /// <summary>
        /// Метод вычисления площади
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        protected virtual double GetSquare() 
        {
            return 0;
        }

        /// <summary>
        /// Метод вычисления периметра
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        protected virtual double GetPerimeter() 
        {
            return 0;        
        }

        //Площадь фигуры
        public double Square { get=>GetSquare();}
        //Площадь фигуры
        public double Perimeter { get=>GetPerimeter();}

        private string _figureName;

        protected string GetFigureName() 
        { 
            return System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name;
        }

        public Point(int x, int y, FigureColors color, bool visible) : base(x, y, color, visible) 
        {
            _figureName = GetFigureName();
        }

        public Point(int x, int y, FigureColors color):this(x, y, color, true) { }

        public Point(FigureColors color):this(0,0,color) { }

        public Point() : this(FigureColors.red) { }

        public override string ToString()
        { 
            return _figureName+"\t "+base.ToString();
        }

    }
}

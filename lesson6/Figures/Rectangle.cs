using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6.Figures
{
    internal class Rectangle:Point
    {
        private double _edgeA;
        private double _edgeB;

        public double EdgeA { get => _edgeA; set { if (value >= 0) _edgeA = value; } }
        public double EdgeB { get => _edgeB; set { if (value >= 0) _edgeB = value; } }
        protected override double GetPerimeter()
        {
            return 2 * (_edgeA + _edgeB);
        }

        protected override double GetSquare()
        {
            return _edgeB*_edgeA;
        }

        public Rectangle(int x, int y, FigureColors color, bool visible, double edgeA, double edgeB) : base(x, y, color, visible)
        {
            if (edgeA > 0)
            {
                _edgeA = edgeA;
            }
            else
            {
                throw new ArgumentException($"Сторона прямоугольника не может быть нулевой или отрицательнгой. Задано {edgeA}");
            }
            
            if (edgeB > 0)
            {
                _edgeB = edgeB;
            }
            else
            {
                throw new ArgumentException($"Сторона прямоугольника не может быть нулевой или отрицательнгой. Задано {edgeB}");
            }
        }

        public Rectangle(int x, int y, FigureColors color, bool visible, double edge) : this(x, y, color, true, edge, edge) { }
        public Rectangle(int x, int y, FigureColors color, double edgeA, double edgeB) : this(x, y, color, true, edgeA, edgeB) { }
        public Rectangle(FigureColors color, double edge) : this(0, 0, color, true, edge) { }
        public Rectangle(double edgeA, double edgeB) : this(0, 0, FigureColors.red, true, edgeA, edgeB) { }
        public Rectangle(double edge) : this(edge, edge) { }
        public Rectangle() : this(1, 1) { }

        public override string ToString()
        {
            return base.ToString() + "\t edges =" + EdgeA + "*" +EdgeB;
        }
    }
}


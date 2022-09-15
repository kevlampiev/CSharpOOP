using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lesson6.Figures
{
    public class Circle : Point
    {
        private double _radius;

        public double Radius { get => _radius; set { if (value >= 0) _radius = value; } }
        protected override double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        protected override double GetSquare()
        {
            return Math.PI * _radius * _radius;
        }

        public Circle() : base()
        {
            Radius = 1;
        }      
        public Circle(int x, int y, FigureColors color, bool visible, double radius) : base(x, y, color, visible)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
            else
            {
                throw new ArgumentException($"Радиус не может быть нулевым или отрицательным. Задан {radius}");
            }
        }

        public Circle(int x, int y, FigureColors color, double radius) : this(x, y, color, true, radius) { }
        public Circle(FigureColors color, double radius) : this(0, 0, color, true, radius) { }
        public Circle(double radius) : this(0, 0, FigureColors.red, true, radius) { }

        public override string ToString() 
        { 
            return base.ToString() + "\tradius =" + Radius;
        }
        
        
    }
}

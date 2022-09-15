using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lesson6.Figures
{
    public enum FigureColors {red, blue, green, yellow, cyan, white, black };
    public class Figure
    {
        //Координаты. Чтобы было что двигать 
        private int _x = 0;
        private int _y = 0;

        public int X { get; }
        public int Y { get; }
        public Figure(int x, int y) 
        { 
            _x = x;
            _y = y;
            FigureColor = FigureColors.red;
            Visible = true;
        }

        public Figure(int x, int y, FigureColors figureColor, bool visible) :this(x,y)
        {
            FigureColor = figureColor;
            Visible = visible;
        }

        public Figure(int x, int y, FigureColors figureColor) : this(x, y, figureColor, true)
        {
        }

        public Figure() 
        {
            FigureColor = FigureColors.red;
            Visible = true;
        }

        public FigureColors FigureColor { get; set; }
        public bool Visible { get; set; }

        public void MoveHorizontal(int dX) 
        { 
            _x +=dX;
        }
        
        public void MoveVertical(int dY) 
        { 
            _x +=dY;
        }

        public virtual void Render() 
        {
            /* Не сработало, а жаль
           var fields = this.GetType().GetFields().ToList();
           foreach (FieldInfo field in fields) 
           { 
               Console.WriteLine(field.Name," - ", field.GetValue(this).ToString());
           }
           */
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"x={_x} \ty={_y} \tcolor={FigureColor} \tvisible={Visible}";
        }


    }
}

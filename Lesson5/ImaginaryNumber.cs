using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    internal class ImaginaryNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public ImaginaryNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public static bool operator ==(ImaginaryNumber a, ImaginaryNumber b)
        {
            return (a.RealPart == b.RealPart) && (a.ImaginaryPart == b.ImaginaryPart);
        }
        
        public static bool operator !=(ImaginaryNumber a, ImaginaryNumber b)
        {
            return (a.RealPart != b.RealPart) || (a.ImaginaryPart != b.ImaginaryPart);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ImaginaryNumber);
        }

        public bool Equals(ImaginaryNumber someNumber)
        {
            return (RealPart == someNumber.RealPart) && (ImaginaryPart == someNumber.ImaginaryPart);
        }

        public double Module() 
        { 
            return Math.Sqrt(RealPart*RealPart + ImaginaryPart*ImaginaryPart);
        }

        public ImaginaryNumber ConjugateNumbers()
        {
            return new ImaginaryNumber(this.RealPart, -this.ImaginaryPart);
        }

        public static ImaginaryNumber operator +(ImaginaryNumber a, ImaginaryNumber b) 
        {
            return new ImaginaryNumber(a.RealPart + b.RealPart, a.ImaginaryPart + b.ImaginaryPart);
        }
        
        public static ImaginaryNumber operator -(ImaginaryNumber a, ImaginaryNumber b) 
        {
            return new ImaginaryNumber(a.RealPart - b.RealPart, a.ImaginaryPart - b.ImaginaryPart);
        }
        
        public static ImaginaryNumber operator *(ImaginaryNumber a, ImaginaryNumber b) 
        {
            return new ImaginaryNumber(a.RealPart*b.RealPart - a.ImaginaryPart*b.ImaginaryPart, 
                a.ImaginaryPart*b.RealPart + b.ImaginaryPart*a.RealPart);
        }

        public static ImaginaryNumber operator /(ImaginaryNumber a, ImaginaryNumber b) 
        {
            ImaginaryNumber result = a * b.ConjugateNumbers();
            double divider = (b.Module() * b.Module());
            result.RealPart /= divider;
            result.ImaginaryPart /= divider;
            return result;
        }


        //Ну, есть еще о чем подумать, конечно 
        public override string ToString()
        {
            string rPart = (RealPart != 0) ? RealPart.ToString() : "";
            string imPart;
            if (ImaginaryPart == 0)
            { imPart = ""; }
            else if (ImaginaryPart > 0) 
            { 
                imPart = " + i*"+ImaginaryPart.ToString();
            } 
            else 
            { 
                imPart = " - i*" + Math.Abs(ImaginaryPart).ToString();
            }
            return rPart+imPart;
        }

    }
}

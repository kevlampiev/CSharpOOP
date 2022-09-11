using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lesson5
{
    internal class RationalNumber
    {
        private int _numerator;
        private int _denominator;

        public int Numerator {get {return _numerator;} set { _numerator = value; } }
        public int Denominator 
        {
            get {return _denominator;} 
            set {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен нулю");
                }
                else 
                {
                    _denominator = value;
                }
                } 
        }

        public RationalNumber(int numerator, int denominator)
        {
            _numerator = numerator;
            if (denominator == 0) 
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю");
            } 
            else 
            {
                _denominator = denominator;
            }
            //сгоняем лишнее
            ShortenTheFraction();

        }
        /// <summary>
        /// Вспомогательная функция для сокращения дроби (согнать лишнее). Применять очень аккуратно, только когда дробь полностью сформирована
        /// </summary>
        protected void ShortenTheFraction() 
        {
            int divisor = (int)BigInteger.GreatestCommonDivisor(_numerator, _denominator);
            if (Math.Abs(divisor) != 1)
            {
                _numerator /= divisor;
                _denominator /= divisor;
            }
        }

        public static bool operator ==(RationalNumber a, RationalNumber b) 
        { 
            return (a._denominator*b._numerator == b._denominator*a._numerator);
        }
        
        public static bool operator !=(RationalNumber a, RationalNumber b) 
        { 
            return (a._denominator*b._numerator != b._denominator*a._numerator);
        }

        public override bool Equals(object obj)
        {
//            return base.Equals(obj);
                return Equals(obj as RationalNumber);
        }

        public bool Equals(RationalNumber someNumber)
        {
            return (_denominator * someNumber._numerator == someNumber._denominator * _numerator);
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return ((a._numerator * b._denominator - a._denominator*b._numerator)>0);
        }
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return ((a._numerator * b._denominator - a._denominator*b._numerator)<0);
        }
        
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return ((a._numerator * b._denominator - a._denominator*b._numerator)>=0);
        }
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return ((a._numerator * b._denominator - a._denominator*b._numerator)<=0);
        }
        
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a._numerator*b._denominator + a._denominator*b._numerator, a._denominator*b._denominator);
        } 
        
        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a._numerator*b._denominator - a._denominator*b._numerator, a._denominator*b._denominator);
        }

        public static RationalNumber operator ++(RationalNumber a)
        {
            return new RationalNumber(a._numerator + a._denominator,a._denominator);
        }
        
        public static RationalNumber operator --(RationalNumber a)
        {
            return new RationalNumber(a._numerator - a._denominator,a._denominator);
        }

        public override string ToString() 
        {
            return _numerator + "/" + _denominator;
        }
    }
}

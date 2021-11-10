using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Task1
{
    internal class RationalNumber
    {
        private RationalNumber()
        {
        }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0) return;
            Numeration = numerator;
            Denominator = denominator;
        }

        public int Numeration { get; set; }

        public int Denominator { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            var number = (RationalNumber)obj;

            double decimalRepresentation1 = Numeration / Denominator;
            double decimalRepresentation2 = number.Numeration / number.Denominator;

            return Math.Abs(decimalRepresentation1 - decimalRepresentation2) < 0.001;
        }

        public override string ToString()
        {
            double result = Numeration / Denominator;
            return new string(Convert.ToString(result));
        }

        /// <summary>
        ///     Получение НОД от двух чисел
        /// </summary>
        /// <param name="newNumeration"> Преобразованный числитель</param>
        /// <param name="newDenominator"> Преобразлванный знаменатель</param>
        /// <returns>НОД двух чисел</returns>
        private static int GCD(int newNumeration, int newDenominator)
        {
            if (newNumeration == newDenominator) return newNumeration;
            if (newNumeration == 1 || newDenominator == 1) return 1;
            if (newNumeration % 2 == 0 && newDenominator % 2 == 0)
                return 2 * GCD(newNumeration / 2, newDenominator / 2);
            if (newNumeration % 2 == 0 && newDenominator % 2 != 0) return GCD(newNumeration / 2, newDenominator);
            if (newNumeration % 2 != 0 && newDenominator % 2 == 0) return GCD(newNumeration, newDenominator / 2);
            return GCD(newDenominator, Math.Abs(newNumeration - newDenominator));
        }

        /// <summary>
        ///     Получение кол-ва знаков после запятой
        /// </summary>
        /// <param name="number"></param>
        /// <returns>
        ///     0, если знаков после запятой нет. Иначе кол-во знаков после запятой
        /// </returns>
        private static int GetDecimalDigitsCount(double number)
        {
            var separator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            var str = number.ToString(separator).Split(separator);
            return str.Length == 2 ? str[1].Length : 0;
        }

        /// <summary>
        ///     Convert RationalNumber to floatValue
        /// </summary>
        /// <param name="rationalNumber"></param>
        public static implicit operator float(RationalNumber rationalNumber)
        {
            return Math.Abs(rationalNumber.Numeration / rationalNumber.Denominator);
        }

        /// <summary>
        ///     Convert value from float to RationalNumber
        /// </summary>
        /// <param name="val"> Float value to convert</param>
        public static explicit operator RationalNumber(float val)
        {
            var decimalDigitsCount = GetDecimalDigitsCount(val);
            if (decimalDigitsCount == 0)
                return new RationalNumber
                {
                    Numeration = (int)val,
                    Denominator = 1
                };

            var newNumeration = (int)(val * Math.Pow(10, decimalDigitsCount));
            var newDenominator = (int)Math.Pow(10, decimalDigitsCount);

            return new RationalNumber
            {
                Numeration = newNumeration / GCD(newNumeration, newDenominator),
                Denominator = newDenominator / GCD(newNumeration, newDenominator)
            };
        }

        /// <summary>
        ///     Convert RationalNumber to int Value
        /// </summary>
        /// <param name="rationalNumber"> Rational number to convert</param>
        public static implicit operator int(RationalNumber rationalNumber)
        {
            return Math.Abs(rationalNumber.Numeration / rationalNumber.Denominator);
        }

        /// <summary>
        ///     Convert value from int to RationalNumber
        /// </summary>
        /// <param name="val"> Int value to convert</param>
        public static explicit operator RationalNumber(int val)
        {
            return new RationalNumber
            {
                Numeration = val,
                Denominator = 1
            };
        }

        /// <summary>
        /// addition two rational number
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns> Sum of two rational number</returns>
        public static RationalNumber operator +(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return new RationalNumber
            {
                Numeration = rationalNumber1.Numeration * rationalNumber2.Denominator +
                             rationalNumber1.Denominator * rationalNumber2.Numeration,
                Denominator = rationalNumber1.Denominator * rationalNumber2.Denominator
            };
        }

        /// <summary>
        /// subtraction two rational number
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns> difference of two numbers</returns>
        public static RationalNumber operator -(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return new RationalNumber
            {
                Numeration = rationalNumber1.Numeration * rationalNumber2.Denominator -
                             rationalNumber1.Denominator * rationalNumber2.Numeration,
                Denominator = rationalNumber1.Denominator * rationalNumber2.Denominator
            };
        }

        public static RationalNumber operator ++(RationalNumber rationalNumber)
        {
            rationalNumber.Numeration += rationalNumber.Denominator;
            return rationalNumber;
        }

        public static RationalNumber operator --(RationalNumber rationalNumber)
        {
            rationalNumber.Numeration -= rationalNumber.Denominator;
            return rationalNumber;
        }

        public static int operator %(RationalNumber numeration, float denominator)
        {
            
            return 0;
        }

        /// <summary>
        /// multiplication two rational number
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns>multiplication of two numbers</returns>
        public static RationalNumber operator *(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return new RationalNumber
            {
                Numeration = rationalNumber1.Numeration * rationalNumber2.Numeration,
                Denominator = rationalNumber1.Denominator * rationalNumber2.Denominator
            };
        }

        /// <summary>
        /// division of two rational number
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns>division of two numbers</returns>
        public static RationalNumber operator /(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return new RationalNumber
            {
                Numeration = rationalNumber1.Numeration * rationalNumber2.Denominator,
                Denominator = rationalNumber1.Denominator * rationalNumber2.Numeration
            };
        }

        public static bool operator >(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return (float)Math.Abs(rationalNumber1.Numeration / rationalNumber1.Denominator) > 
                   (float)Math.Abs(rationalNumber2.Numeration / rationalNumber2.Denominator);
        }

        public static bool operator <(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return (float)Math.Abs(rationalNumber1.Numeration / rationalNumber1.Denominator) <
                   (float)Math.Abs(rationalNumber2.Numeration / rationalNumber2.Denominator);
        }

        public static bool operator >=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return (float)Math.Abs(rationalNumber1.Numeration / rationalNumber1.Denominator) >=
                   (float)Math.Abs(rationalNumber2.Numeration / rationalNumber2.Denominator);
        }

        public static bool operator <=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return (float)Math.Abs(rationalNumber1.Numeration / rationalNumber1.Denominator) >=
                   (float)Math.Abs(rationalNumber2.Numeration / rationalNumber2.Denominator);
        }
    }
}
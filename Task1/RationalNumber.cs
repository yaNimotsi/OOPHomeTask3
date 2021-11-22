using System;
using System.Globalization;

namespace Task1
{
    public class RationalNumber : IComparable
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

        /// <summary>
        /// Override method Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            var number = (RationalNumber)obj;

            double decimalRepresentation1 = (float)Numeration / Denominator;
            double decimalRepresentation2 = (float)number.Numeration / number.Denominator;

            return decimalRepresentation1.CompareTo(decimalRepresentation2) == 0;
        }

        /// <summary>
        /// Override method to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            double result = (float)Numeration / Denominator;
            return new string(result.ToString(CultureInfo.CurrentCulture));
        }

        /// <summary>
        ///     Получение НОД от двух чисел
        /// </summary>
        /// <param name="newNumeration"> Преобразованный числитель</param>
        /// <param name="newDenominator"> Преобразлванный знаменатель</param>
        /// <returns>НОД двух чисел</returns>
        // ReSharper disable once InconsistentNaming
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
        /// Сравнение рациональных чисел
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            RationalNumber rationalNumber = obj as RationalNumber;

            if (rationalNumber != null)
            {
                return (this.Numeration / this.Denominator).CompareTo
                    (rationalNumber.Numeration / rationalNumber.Denominator);
            }
            else
            {
                throw new ArgumentException("Oject is not a Rational Number");
            }
        }

        /// <summary>
        ///     Convert RationalNumber to floatValue
        /// </summary>
        /// <param name="rationalNumber"></param>
        public static implicit operator float(RationalNumber rationalNumber)
        {
            return (float)rationalNumber.Numeration / rationalNumber.Denominator;
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
        /// Convert RationalNumber to int Value
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

        /// <summary>
        /// Increment to rationalNumber
        /// </summary>
        /// <param name="rationalNumber"></param>
        /// <returns></returns>
        public static RationalNumber operator ++(RationalNumber rationalNumber)
        {
            rationalNumber.Numeration += rationalNumber.Denominator;
            return rationalNumber;
        }

        /// <summary>
        /// Decrement to rational number
        /// </summary>
        /// <param name="rationalNumber"></param>
        /// <returns></returns>
        public static RationalNumber operator --(RationalNumber rationalNumber)
        {
            rationalNumber.Numeration -= rationalNumber.Denominator;
            return rationalNumber;
        }

        /// <summary>
        /// the remainder of the division Rational number
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static int operator %(RationalNumber val1, RationalNumber val2)
        {
            var newVal1 = val1.Numeration / val1.Denominator;
            var newVal2 = val2.Numeration / val2.Denominator;

            return newVal1 % newVal2;
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

        /// <summary>
        /// comparison of rational numbers
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator >(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            var val1 = (float)rationalNumber1.Numeration / rationalNumber1.Denominator;
            var val2 = (float)rationalNumber2.Numeration / rationalNumber2.Denominator;

            if (val1.CompareTo(val2) == 1) return true;

            return false;
        }

        /// <summary>
        /// comparison of rational numbers
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator <(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            var val1 = (float)rationalNumber1.Numeration / rationalNumber1.Denominator;
            var val2 = (float)rationalNumber2.Numeration / rationalNumber2.Denominator;

            if (val1.CompareTo(val2) == -1) return true;

            return false;
        }

        /// <summary>
        /// comparison of rational numbers
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator >=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            var val1 = (float)rationalNumber1.Numeration / rationalNumber1.Denominator;
            var val2 = (float)rationalNumber2.Numeration / rationalNumber2.Denominator;

            if (val1.CompareTo(val2) == 0 || val1.CompareTo(val2) == 1) return true;

            return false;
        }

        /// <summary>
        /// comparison of rational numbers
        /// </summary>
        /// <param name="rationalNumber1"></param>
        /// <param name="rationalNumber2"></param>
        /// <returns></returns>
        public static bool operator <=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            var val1 = (float)rationalNumber1.Numeration / rationalNumber1.Denominator;
            var val2 = (float)rationalNumber2.Numeration / rationalNumber2.Denominator;

            if (val1.CompareTo(val2) == -1 || val1.CompareTo(val2) == 0) return true;

            return false;
        }
    }
}
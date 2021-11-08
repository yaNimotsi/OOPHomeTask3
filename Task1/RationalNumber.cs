using System;

namespace Task1
{
    class RationalNumber
    {
        private int _numerator;
        private int _denominator;

        public int Numeration
        {
            get => _numerator;
            set => _numerator = value;
        }

        public int Denominator
        {
            get => _denominator;
            set => _denominator = value;
        }

        private RationalNumber()
        {

        }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0) return;
            _numerator = numerator;
            _denominator = denominator;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            var number = (RationalNumber)obj;

            double decimalRepresentation1 = Numeration / Denominator;
            double decimalRepresentation2 = number.Numeration / number.Denominator;

            return Math.Abs(decimalRepresentation1 - decimalRepresentation2) < 0.001;
        }
    }
}

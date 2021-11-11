using System;
using System.Globalization;

namespace ComplexNumber
{
    class ComplexNumber
    {
        private double _realPart;
        private double _imaginaryPart;
        private bool _isComplex;

        private const double AccuracyOfComparison = 0.01;

        public double RealPart
        {
            get => _realPart; 
            set => _realPart = value;
        }

        public double ImaginaryPart
        {
            get => _imaginaryPart;
            set => _imaginaryPart = value;
        }

        public bool IsComplex
        {
            get => _isComplex;
        }

        private ComplexNumber()
        {
            
        }

        public ComplexNumber(double realNumber, double imaginaryPart)
        {
            _realPart = realNumber;
            _imaginaryPart = imaginaryPart;
            _isComplex = true;
        }

        public static ComplexNumber operator +(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber()
            {
                RealPart = number1.RealPart + number2.RealPart,
                ImaginaryPart = number1.ImaginaryPart + number2.ImaginaryPart
            };
        }

        public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber()
            {
                RealPart = number1.RealPart - number2.RealPart,
                ImaginaryPart = number1.ImaginaryPart - number2.ImaginaryPart
            };
        }

        public static ComplexNumber operator *(ComplexNumber number1, ComplexNumber number2)
        {
            if (Math.Abs(number1._realPart - number2._realPart) < 0.001 && Math.Abs(number1._imaginaryPart - (number2._imaginaryPart) * (-1)) < 0.001)
            {
                return new ComplexNumber()
                {
                    RealPart = number1.RealPart * number2.RealPart + (number1.ImaginaryPart * number2.ImaginaryPart) * (-1),
                    ImaginaryPart = number1.ImaginaryPart * number2.RealPart + number1.RealPart * number2.ImaginaryPart,
                    _isComplex = false
                };
            }

            return new ComplexNumber()
            {
                RealPart = number1.RealPart * number2.RealPart + (number1.ImaginaryPart * number2.ImaginaryPart) * (-1),
                ImaginaryPart = number1.ImaginaryPart * number2.RealPart + number1.RealPart * number2.ImaginaryPart,
                _isComplex = true
            };

        }

        public override string ToString()
        {
            var result = _realPart.ToString(CultureInfo.InvariantCulture);

            if (_imaginaryPart > 0)
            {
                result += $"+{_imaginaryPart}i";
            }
            else
            {
                result += $"{_imaginaryPart}i";
            }

            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            var complexNumber = (ComplexNumber)obj;

            if (Math.Abs(_realPart - complexNumber._realPart) < AccuracyOfComparison
                && Math.Abs(_imaginaryPart - ImaginaryPart) < AccuracyOfComparison)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            var result = 0;
            if (_realPart != 0)
            {
                result += _realPart.GetHashCode();
            }

            if (ImaginaryPart != 0)
            {
                result += ImaginaryPart.GetHashCode();
            }

            return result += _isComplex.GetHashCode();
        }
    }
}

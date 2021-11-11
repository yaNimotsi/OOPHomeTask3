using System;
using System.Globalization;

namespace ComplecxNumber
{
    class ComplexNumber
    {
        private double _realPart;
        private double _imaginaryPart;
        private bool _complex;

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

        public bool isComplex
        {
            get => _complex;
        }

        private ComplexNumber()
        {
            
        }

        public ComplexNumber(double realNumber, double imaginaryPart)
        {
            _realPart = realNumber;
            _imaginaryPart = imaginaryPart;
            _complex = true;
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
                    _complex = false
                };
            }

            return new ComplexNumber()
            {
                RealPart = number1.RealPart * number2.RealPart + (number1.ImaginaryPart * number2.ImaginaryPart) * (-1),
                ImaginaryPart = number1.ImaginaryPart * number2.RealPart + number1.RealPart * number2.ImaginaryPart,
                _complex = true
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
    }
}

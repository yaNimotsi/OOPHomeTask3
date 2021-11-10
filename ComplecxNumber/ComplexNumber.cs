namespace ComplecxNumber
{
    class ComplexNumber
    {
        private double _realPart;
        private double _imaginaryPart;

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

        private ComplexNumber()
        {
            
        }

        public ComplexNumber(double realNumber, double imaginaryPart)
        {
            _realPart = realNumber;
            _imaginaryPart = imaginaryPart;
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
            return new ComplexNumber()
            {
                RealPart = number1.RealPart * number2.RealPart + (number1.ImaginaryPart * number2.ImaginaryPart)*(-1),
                ImaginaryPart = number1.ImaginaryPart * number2.RealPart + number1.RealPart * number2.ImaginaryPart
            };
        }
    }
}


using Task1;

using Xunit;

namespace TestToLesson5._1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 8, 6, 16, true)]
        [InlineData(1, 99, 1, 1, false)]
        [InlineData(3, 8, 4, 16, true)]
        public void GreaterOrEqual_test(int numeration1, int denominator1, int numeration2, int denominator2,
            bool expected)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var result = rationalNumber1 >= rationalNumber2;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 99, 1, 1, true)]
        [InlineData(1, 2, 11, 20, true)]
        [InlineData(7, 8, 3, 16, false)]
        public void LessOrEqual_test(int numeration1, int denominator1, int numeration2, int denominator2,
            bool expected)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var result = rationalNumber1 <= rationalNumber2;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 2, 9, 23, true)]
        [InlineData(1, 2, 1, 2, false)]
        [InlineData(3, 4, 4, 4, false)]
        public void Greater_test(int numeration1, int denominator1, int numeration2, int denominator2, 
            bool expected)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var result = rationalNumber1 > rationalNumber2;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 99, 1, 1, true)]
        [InlineData(1, 2, 11, 20, true)]
        [InlineData(6, 8, 7, 8, true)]
        public void Less_test(int numeration1, int denominator1, int numeration2, int denominator2, 
            bool expected)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var result = rationalNumber1 < rationalNumber2;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 0.375)]
        [InlineData(1, 2, 11, 20, 1)]
        [InlineData(6, 8, 7, 8, 1)]
        public void Multiplication_Test(int numeration1, int denominator1, int numeration2, int denominator2,
            double expected)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var result = rationalNumber1 * rationalNumber2;

            Assert.Equal(result, expected);
        }
    }
}

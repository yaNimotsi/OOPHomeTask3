
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
        [InlineData(1, 2, 3, 4, 3, 8)]
        [InlineData(1, 2, 11, 20, 11, 40)]
        [InlineData(6, 8, 7, 8, 42, 64)]
        public void Multiplication_Test(int numeration1, int denominator1, int numeration2, int denominator2,
            int expectedNuNumeration, int expectedDenominator)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var expected = new RationalNumber(expectedNuNumeration, expectedDenominator);

            var result = rationalNumber1 * rationalNumber2;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 4, 6)]
        [InlineData(1, 2, 11, 20, 20, 22)]
        [InlineData(6, 8, 7, 8, 48, 56)]
        public void Division_Test(int numeration1, int denominator1, int numeration2, int denominator2,
            int expectedNuNumeration, int expectedDenominator)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var expected = new RationalNumber(expectedNuNumeration, expectedDenominator);

            var result = rationalNumber1 / rationalNumber2;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(15, 3, 3, 1, 2)]
        [InlineData(1, 2, 11, 20, 0)]
        [InlineData(9, 8, 7, 8, 0)]
        public void ReminderDivision_Test(int numeration1, int denominator1, int numeration2, int denominator2,
            int expected)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var result = rationalNumber1 % rationalNumber2;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 2, -1, 2)]
        [InlineData(5, 2, 3, 2)]
        [InlineData(6, 8, -1, 4)]
        public void Decrement_Test(int numeration1, int denominator1, int expectedNuNumeration, int expectedDenominator)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);

            var expected = new RationalNumber(expectedNuNumeration, expectedDenominator);

            var result = rationalNumber1--;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 2, 3, 2)]
        [InlineData(5, 2, 7, 2)]
        [InlineData(6, 8, 14, 8)]
        public void Increment_Test(int numeration1, int denominator1, int expectedNuNumeration, int expectedDenominator)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);

            var expected = new RationalNumber(expectedNuNumeration, expectedDenominator);

            var result = rationalNumber1++;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 2, 3, 4, -2, 8)]
        [InlineData(1, 2, 11, 20, -1, 20)]
        [InlineData(9, 8, 7, 8, 1, 4)]
        public void Subtractions_Test(int numeration1, int denominator1, int numeration2, int denominator2,
            int expectedNuNumeration, int expectedDenominator)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var expected = new RationalNumber(expectedNuNumeration, expectedDenominator);

            var result = rationalNumber1 - rationalNumber2;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 4)]
        [InlineData(1, 2, 11, 20, 11, 10)]
        [InlineData(9, 8, 7, 8, 2, 1)]
        public void Addition_Test(int numeration1, int denominator1, int numeration2, int denominator2,
            int expectedNuNumeration, int expectedDenominator)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var expected = new RationalNumber(expectedNuNumeration, expectedDenominator);

            var result = rationalNumber1 + rationalNumber2;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(6, 2, 3)]
        [InlineData(9, 8, 1)]
        public void ConvertToInt_Test(int numeration, int denominator,
            int expected)
        {
            var rationalNumber = new RationalNumber(numeration, denominator);

            var result = (int)rationalNumber;

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(6, 6, 1)]
        [InlineData(0, 0, 1)]
        public void ConvertFromInt_Test(int intNumber,
            int expectedNumber, int expectedDenominator)
        {
            var expected = new RationalNumber(expectedNumber, expectedDenominator);

            var result = (RationalNumber)intNumber;

            Assert.Equal(result, expected);
        }
    }
}

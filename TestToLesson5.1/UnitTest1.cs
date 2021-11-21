using System;

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
        public void Greater_test(int numeration1, int denominator1, int numeration2, int denominator2, bool expected)
        {
            var rationalNumber1 = new RationalNumber(numeration1, denominator1);
            var rationalNumber2 = new RationalNumber(numeration2, denominator2);

            var result = rationalNumber1 >= rationalNumber2;

            Assert.Equal(result, expected);
        }
    }
}

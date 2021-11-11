using System;

namespace ComplecxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var complexNumber1 = new ComplexNumber.ComplexNumber(4, 5);
            var complexNumber2 = new ComplexNumber.ComplexNumber(6, -7);

            Console.WriteLine($"number1 = {complexNumber1.ToString()}" +
                              $" number2 = {complexNumber2.ToString()} \r\n" +
                              $"Is this value equals? {complexNumber1.Equals(complexNumber2)}");

            Console.WriteLine();

            var complexNumber3 = new ComplexNumber.ComplexNumber(-3, 4);

            Console.WriteLine($"number1 = {complexNumber3.ToString()}" +
                              $" number2 = {complexNumber3.ToString()} \r\n" +
                              $"Is this value equals? {complexNumber3.Equals(complexNumber3)}");

            Console.ReadLine();
        }
    }
}

using System;

namespace ComplexNumber
{
    class Program
    {
        static void Main()
        {
            var complexNumber1 = new global::ComplexNumber.ComplexNumber(4, 5);
            var complexNumber2 = new global::ComplexNumber.ComplexNumber(6, -7);

            Console.WriteLine($"number1 = {complexNumber1}" +
                              $" number2 = {complexNumber2} \r\n" +
                              $"Is this value equals? {complexNumber1.Equals(complexNumber2)}");

            Console.WriteLine();

            var complexNumber3 = new global::ComplexNumber.ComplexNumber(-3, 4);

            Console.WriteLine($"number1 = {complexNumber3}" +
                              $" number2 = {complexNumber3} \r\n" +
                              $"Is this value equals? {complexNumber3.Equals(complexNumber3)}");


            Console.WriteLine($"Check how work sum to Complex number \r\n" +
                              $"");

            Console.ReadLine();
        }
    }
}

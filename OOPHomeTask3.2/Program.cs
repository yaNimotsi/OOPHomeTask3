using System;

namespace OOPHomeTask3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Start string";

            var newStr = DoInverseString(str);

            Console.WriteLine(string.Equals(newStr, "gnirts tratS")
                ? "Inverse method is correct"
                : "Inverse method is uncorrect");

            Console.ReadLine();
        }

        private static string DoInverseString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            var reversArr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                reversArr[i] = str[str.Length - 1 - i];
            }

            return new string(reversArr);
        }
    }
}
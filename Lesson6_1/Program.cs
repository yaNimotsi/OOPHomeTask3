using System;

namespace Lesson6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount("Holder1", 125.63);
            var account2 = new BankAccount("Holder2", 125.63);

            //Не равны, тк разные номера аккаунтов
            Console.WriteLine($"Is accounts equal {account1 == account2}");

            //Вернет true, тк разные номера аккаунтов
            Console.WriteLine($"Is accounts not equal {account1 != account2}");

            //Вернет false, тк разные номера аккаунтов
            Console.WriteLine($"Is account equal {account1.Equals(account2)}");
            //Вернет true, тк аккаунты идентичны
            Console.WriteLine($"Is account equal {account1.Equals(account1)}");


            Console.WriteLine($"Account hash code {account1.GetHashCode()}");

            Console.WriteLine($"Account info: \r\n" +
                              $"{account1.ToString()}");

            Console.ReadLine();
        }
    }
}

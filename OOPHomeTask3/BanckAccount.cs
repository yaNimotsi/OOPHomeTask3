using System;

namespace OOPHomeTask3
{
    class BankAccount
    {
        public static long AccountNumber { get; private set; }

        public double Balance { get; set; }

        public TypeBankAccount TypeBankAccount { get; }

        public BankAccount()
        {
            GenerateAccountNumber();
        }
        public BankAccount(double balance) : this()
        {
            Balance = balance;
        }
        public BankAccount(TypeBankAccount typeBankAccount) : this()
        {
            TypeBankAccount = typeBankAccount;
        }
        public BankAccount(double balance, TypeBankAccount typeBankAccount) : this()
        {
            Balance = balance;
            TypeBankAccount = typeBankAccount;
        }

        private void GenerateAccountNumber()
        {
            AccountNumber++;
        }

        /// <summary>
        /// Read account data
        /// </summary>
        public void GetAccountInformation()
        {
            Console.WriteLine($"Account number is: {AccountNumber}");
            Console.WriteLine($"Account balance is: {Balance}");
            Console.WriteLine($"Account type is: {TypeBankAccount}");
        }
        /// <summary>
        /// Increase the balance on value
        /// </summary>
        /// <param name="valToIncrease">Value to increase balance</param>
        public void IncreaseBalance(double valToIncrease)
        {
            Balance += valToIncrease;
            Console.WriteLine();
            Console.WriteLine($"Balance is increase on value {valToIncrease}");
            Console.WriteLine();

            GetAccountInformation();
        }

        /// <summary>
        /// Reduce the balance on value
        /// </summary>
        /// <param name="valToReduce"> Value to reduce</param>
        public void ReduceBalance(double valToReduce)
        {
            if (valToReduce <= Balance)
            {
                Balance -= valToReduce;
                Console.WriteLine();
                Console.WriteLine($"Balance is reduce on value {valToReduce}");

                GetAccountInformation();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Balance is less the your value");
                Console.WriteLine($"Balance is {Balance}, value to reduce is {valToReduce}");
            }
        }
    }

    public enum TypeBankAccount
    {
        Deposit = 1,
        Contribution = 2,
        CreditAccount = 3
    }
}
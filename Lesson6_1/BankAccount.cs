using System;
using System.Dynamic;

namespace Lesson6_1
{
    class BankAccount
    {
        private static int _number;
        private int _accountNumber;
        private string _accountHolder;
        private double _accountBalance;

        public int AccountNumber
        {
            get => _accountNumber;
        }

        public string AccountHolder { 
            get => _accountHolder;
            set => _accountHolder = value;
        }

        public double AccountBalance
        {
            get => _accountBalance; 
            set => _accountBalance = value;
        }

        private BankAccount()
        {
            
        }

        public BankAccount(string accountHolder, double accountBalance)
        {
            _accountNumber = ++_number;
            _accountHolder = accountHolder;
            _accountBalance = accountBalance;
        }

        public static bool operator ==(BankAccount account1, BankAccount account2)
        {
            return Equals(account1, account2);
        }

        public static bool operator !=(BankAccount account1, BankAccount account2)
        {
            return !(Equals(account1, account2));
        }

        private bool Equals(BankAccount other)
        {
            return _accountHolder == other._accountHolder && _accountBalance.Equals(other._accountBalance) && AccountHolder == other.AccountHolder && AccountBalance.Equals(other.AccountBalance);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((BankAccount)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AccountNumber, _accountHolder, _accountBalance);
        }

        public override string ToString()
        {
            return new string($"Account number is {AccountNumber} \r\n" +
                              $"Account Holder is {_accountHolder} \r\n" +
                              $"Account balance is {_accountBalance}");
        }
    }
}

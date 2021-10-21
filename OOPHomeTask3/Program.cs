namespace OOPHomeTask3
{
    class Program
    {
        static void Main()
        {
            var account1 = new BankAccount(100, TypeBankAccount.Deposit);
            var account2 = new BankAccount(100, TypeBankAccount.Deposit);

            account2.RemoveCashToAccount(account1, 33.3);
        }
    }
}

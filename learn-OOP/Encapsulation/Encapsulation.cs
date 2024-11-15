

namespace learn_OOP.Encapsulation
{
    public class Account
    {
        private double balance;
        private string accountNumber;
        private string accountHolderName;
        private string accountType;

        public Account(double balance, string accountNumber, string accountHolderName, string accountType)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.accountType = accountType;
        }

       

        public double GetBalance()
        {
            return balance;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public string GetAccountHolderName()
        {
            return accountHolderName;
        }

        public string GetAccountType()
        {
            return accountType;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }



}

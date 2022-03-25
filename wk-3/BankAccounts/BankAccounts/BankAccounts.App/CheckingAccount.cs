namespace BankAccounts
{
    class CheckingAccount : Account
    {
        //Fields

        //Constructor
        public CheckingAccount(string accountName, double accountBalance)
        {
            this.accountName = accountName;
            this.Deposit(accountBalance, "First Deposit");
            this.interestRate = 0.002;
        }

        //Methods

        public void ApplyInterest()
        {
            this.Deposit(Math.Round((this.accountBalance * this.interestRate),2), "Interest Payment");
        }
    }
}
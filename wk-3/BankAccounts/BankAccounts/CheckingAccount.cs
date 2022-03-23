namespace BankAccounts
{
    class CheckingAccount : Account
    {
        //Fields

        //Constructor
        public CheckingAccount(string accountName, int accountNumber, double accountBalance)
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.interestRate = 0.02;
        }

         //Methods

        public override void Withdrawl(double withdrawl)
        {
            if (withdrawl < 0)
            {
                Console.WriteLine("Withdrawls must be a positive value");
                Console.WriteLine("Transaction Canceled");
                return;
            }
            else if((this.accountBalance - withdrawl) < 0)
            {
                Console.WriteLine("Balance in account may not go below 0.");
                Console.WriteLine("Transaction Canceled");
                return;
            }
            else
            {
                this.accountBalance -= withdrawl;
                this.Record(-withdrawl);
            }            
            //throw new NotImplementedException();
         } 

        public override void Deposit(double deposit)
        {
            if(deposit < 0)
            {
                Console.WriteLine("Deposits must be a positive value");
                Console.WriteLine("Transaction Canceled");
                return;
            }
            else
            {
                this.accountBalance += deposit;
                this.Record(+deposit);
            }
            //throw new NotImplementedException();
        } 

        public void ApplyInterest()
        {
            this.accountBalance += Math.Round((this.accountBalance * this.interestRate),2);
        }
    }
}
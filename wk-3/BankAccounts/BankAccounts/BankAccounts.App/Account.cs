namespace BankAccounts
{
     abstract class Account
     {
        //abstract class object cannot be found

        //Fields
        private static int accountSeed = 1234567890;
        public string? accountName;
        protected int accountNumber;
        protected double accountBalance
        {
            get
            {
                doublebalance = 0;
                foreach (var item in alltransaction)
                {
                    balance += item.Amount;
                }
                return balance;

            }
        }
        protected double interestRate;

        private List<Transaction> allTransactions = new List<Transaction>();

        public XmlSerializer Serializer { get; } = new ( typeof( List<Transaction>));

        //Constructor   
        protected Account()
        {
            this.accountNumber = accountSeed;
            accountSeed++;
        }

        //Methods
        public int GetAccountNumber()
        {
            return this.accountNumber;
        }

        public double GetAccountBalance()
        {
            return this.accountBalance;
        }

        public double GetInterestRate()
        {
             return this.interestRate;
        }

        public void Withdrawl(double withdrawl, string note = "")
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
                // this.accountBalance -= withdrawl;
                // this.Record(-withdrawl);

                var withdrawl = new Transaction(-amount, DateTime.Now, note);
                allTransactions.Add
            }            
            //throw new NotImplementedException();
        } 
        

        public void Deposit (double deposit)
        {
            if(deposit < 0)
            {
                Console.WriteLine("Deposits must be a positive value");
                Console.WriteLine("Transaction Canceled");
                return;
            }
            else
            {
                // this.accountBalance += deposit;
                // this.Record(+deposit);

                var deposit = new Transaction(+amount, DateTime.Now, note);
                allTransactions.Add(deposit);
            }
            //throw new NotImplementedException();
        }
        

        protected void Record(double TransactionAmmount)
        {
            DateTime Current = DateTime.Now;

            string[] content = {(Current.ToString("F")) + "\t" + this.accountNumber + "\t" + this.accountName + "\t" 
            + TransactionAmmount + "\t" + this.accountBalance};            

            string path = @".\TransactionRecords.txt";

            if( !File.Exists(path) )
            {
                //Create and write to new file
                File.WriteAllLines(path, content);
            }
            else
            {
                //Append the existing file
                File.AppendAllLines(path, content);
            }
        }

        public void SerializeXml()
        {
            var newStringWriter = new StringWriter();
            Serializer.Serialize(newStringWriter, allTransactions);
            newStringWriter.Close();
            
            string path = $"./Transaction-{this.accountNumber}.xml";
            File.WriteAllText(path, newStringWriter.ToString());
        }
    }      
}
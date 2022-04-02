namespace Project0.Logic
{
     public class Customer
    {
        //Fields
        private int customerId;
        private string customerUsername;
        private string customerPassword;
        private string customerFirstName;
        private string customerLastName;

        //Constructor
        //
        public Customer() { }

        public Customer(int customerId, string customerUsername, string customerPassword, string customerFirstName, string customerLastName)
        {
            this.customerId = customerId;
            this.customerUsername = customerUsername;
            this.customerPassword = customerPassword;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;        
        }
        //Methods
        public int GetCustomerId()
        {
            return this.customerId;
        }

        public string GetCustomerUsername()
        {
            return this.customerUsername;
        }

        public string GetCustomerPassword()
        {
            return this.customerPassword;
        }

        public string GetCustomerFirstName()
        {
            return this.customerFirstName;
        }

        public string GetCustomerLastname()
        {
            return this.customerLastName;
        }

        public void customerHistoryPurchase(int customerId)
        {
            Console.WriteLine("The customer #" + customerId + "'s past purchases are:");
        }
    }
}
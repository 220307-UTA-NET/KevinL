namespace Project0
{
    class Customer
    {
        //Fields
        private int customerId;
        private string customerUsername;
        private string customerPassword;
        private string customerFirstName;
        private string customerLastName;

        //Constructor        
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
    }
}
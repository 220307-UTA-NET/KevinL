namespace Project0
{
    class Location
    {
        //Fields
        private int storeLocationId;
        private string storeLocation;

        //Constructor        
        //Methods
        public int GetStoreLocationId()
        {
            return this.storeLocationId;
        } 

        public string GetStoreLocation()
        {
            return this.storeLocation;
        } 

        public void locationHistoryPurchase(int storeLocationId)
        {
             Console.WriteLine("The location #" + storeLocationId + "'s past purchases are:");
        }
    }
}
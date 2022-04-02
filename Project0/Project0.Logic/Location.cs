using System.Xml.Serialization;

namespace Project0
{
    class Location
    {
        //Fields
        private int storeLocationId;
        private string storeLocation;

        //Constructor        
        
        public int GetStoreLocationId()
        {
            return this.storeLocationId;
        } 

        public string GetStoreLocation()
        {
            return this.storeLocation;
        } 

        //Methods

        public void locationHistoryPurchase(int storeLocationId)
        {
             Console.WriteLine("The location #" + storeLocationId + "'s past purchases are:");
        }
    }
}
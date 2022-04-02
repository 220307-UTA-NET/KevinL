using System.Xml.Serialization;

namespace Project0.Logic
{
     public class Location
    {
        //Fields
        private int storeLocationId;
        private string storeLocation;

        //Constructor
        
        public Location() { }

        public Location(int storeLocationId, string storeLocation)
        {
            this.storeLocationId = storeLocationId;
            this.storeLocation = storeLocation;
        }

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
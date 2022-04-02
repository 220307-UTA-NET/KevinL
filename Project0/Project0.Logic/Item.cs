namespace Project0.Logic
{
    class Item
    {
        //Fields
        private int itemId;
        private string itemName;
        private double itemPrice;
        private string itemDescription;

        //Constructor
        public Item() { }
        public Item(int itemId, string intName, double itemPrice, string itemDescription) 
        {
            
            this.itemId = itemId;
            this.itemName = intName;
            this.itemPrice = itemPrice;
            this.itemDescription = itemDescription;
        }

        //Methods
        public int GetItemId()
        {
            return this.itemId;
        }

        public string GetItemName()
        {
            return this.itemName;
        }

        public double GetItemPrice()
        {
            return this.itemPrice;
        }

        public string GetItemDescription()
        {
            return this.itemDescription;
        }

    }
}
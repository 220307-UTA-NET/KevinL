namespace Project0
{
    class Item
    {
        //Fields
        private int itemId;
        private string itemName;
        private double itemPrice;
        private string itemDescription;

        //Constructor        
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
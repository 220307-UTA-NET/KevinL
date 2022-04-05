namespace Project0.Logic
{
     public class Item
    {
        //Fields
        private int itemId;
        private string itemName;
        private decimal itemPrice;
        private string itemDescription;
        private int itemQuantity;

        //Constructor
        public Item() { }
        public Item(int itemId, string intName, decimal itemPrice, string itemDescription, int itemQuantity) 
        {
            
            this.itemId = itemId;
            this.itemName = intName;
            this.itemPrice = itemPrice;
            this.itemDescription = itemDescription;
            this.itemQuantity = itemQuantity;
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

        public decimal GetItemPrice()
        {
            return this.itemPrice;
        }

        public string GetItemDescription()
        {
            return this.itemDescription;
        }

        public int GetItemQuantity()
        {
            return this.itemQuantity;
        }

        public static implicit operator Item(int v)
        {
            throw new NotImplementedException();
        }

        public void SetItemQuantity(int itemQuantity)
        {
            this.itemQuantity = itemQuantity;
        }
    }
}
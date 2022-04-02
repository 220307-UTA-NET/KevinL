using System.Xml.Serialization;

namespace Project0.Logic
{
    class Order
    {
        //Fields

        private int orderId;
        private int storeLocationId;
        private int customerId;
        private string itemName;
        private int orderTotal;

        public Order() { }

        public Order(int orderId, int storeLocationId, int customerId, string itemName,int orderTotal)
        {
            this.orderId = orderId;
            this.storeLocationId = storeLocationId;
            this.customerId = customerId;
            this.itemName = itemName;
            this.orderTotal = orderTotal;

        }

                
        internal List<Order> allOrders = new List<Order>();
        protected void orderHistory()
        {
            DateTime current = DateTime.Now;
            string[] content = {};
            string path = @".\OrderHistory.txt";

           /* if(!File.Exist(path))
            {
                File.WriteAllLines(path, content);
            }
            else
            {
                File.AppendLines(path,content);
            }*/
        }
    }

}
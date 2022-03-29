using System.Xml.Serialization;

namespace Project0
{
    class Order
    {
        //Fields
                
        internal List<Order> allOrders = new List<Order>();
        protected void orderHistory()
        {
            DateTime current = DateTime.Now;
            string[] content = {};
            string path = @".\OrderHistory.txt";

            if(!File.Exist(path))
            {
                File.WriteAllLines(path, content);
            }
            else
            {
                File.AppendLines(path,content);
            }
        }
    }

}
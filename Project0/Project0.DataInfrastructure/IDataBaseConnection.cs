using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project0.Logic;


namespace Project0.DataInfrastructure
{
    public interface IDataBaseConnection
    {
       void newCustomer(string customerFirstName, string customerLastname, string customerUsername, string customerPassword)
       {
              throw new NotImplementedException();
       }       
       
        bool customerFound(string customerUsername, string customerPassword);
        List<Item> getItemId(string storeLocation);

        public List<Item> inventory(string storeLocation);

        public void cartItems(int item);
    }
}

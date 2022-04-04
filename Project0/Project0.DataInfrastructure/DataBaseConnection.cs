using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Project0.Logic;

namespace Project0.DataInfrastructure
{
    public class DataBaseConnection : IDataBaseConnection
    {
        private readonly string source = "Server=tcp:03072022revature.database.windows.net,1433;Initial Catalog=03072022Project0;Persist Security Info=False;User ID=klee5760;Password=Bo1Go21010!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
      
        public DataBaseConnection(string source)
        {
            //connection = new SqlConnection(source);
            // connection.Open();
            this.source = source ?? throw new ArgumentNullException(nameof(source));
        }

        //For the register new customer part 
        public void newCustomer(string customerFirstName, string customerLastName, string customerUsername, string customerPassword)
        {

            using SqlConnection connect = new SqlConnection(this.source);
            connect.Open();

            string cmdText = @"INSERT INTO Customers(customerFirstName,customerLastName,customerUsername,customerPassword) VALUES(@customerFirstName,@customerLastName,@customerUsername,@customerPassword);";

            using SqlCommand cmd = new SqlCommand(cmdText, connect);

             cmd.Parameters.AddWithValue("@customerFirstName", customerFirstName);
             cmd.Parameters.AddWithValue("@customerLastName", customerLastName);
             cmd.Parameters.AddWithValue("@customerUsername", customerUsername);
             cmd.Parameters.AddWithValue("@customerPassword", customerPassword);

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        //For the customer login part
       public bool customerFound(string customerUsername, string customerPassword)
       {
            using SqlConnection connect = new SqlConnection(this.source);
            connect.Open();
            string query = @"SELECT * FROM Customers WHERE Customers.customerUsername = @customerUsername AND Customers.customerPassword = @customerPassword;";
            SqlCommand cmd = new (query, connect);
            cmd.Parameters.AddWithValue("@customerUsername", customerUsername);
            cmd.Parameters.AddWithValue("@customerPassword", customerPassword);
            using SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                int customerId = dr.GetInt32(0);
                return true;
            }
                connect.Close();
                return false;                               
       }


        //To get the itemId for the inventory and the shooping cart 
        public List<Item> getItemId(string storeLocation)
        {
            List<Item> list = new List<Item>();
            using SqlConnection connect = new SqlConnection(this.source);
            connect.Open();
            string query = @"SELECT * FROM Inventory INNER JOIN Locations ON Locations.storeLocationId = Inventory.storeLocationId INNER JOIN Items ON Items.itemId = Inventory.itemId WHERE storeLocation = @storeLocation;";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@storeLocation",storeLocation);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                int itemId = dr.GetInt32(1);
                string itemName = dr.GetString(6);
                decimal itemPrice = dr.GetDecimal(7);
                string itemDescription = dr.GetString(8);
                int itemQuantity = dr.GetInt32(2);
                list.Add(new(itemId, itemName, itemPrice, itemDescription, itemQuantity));
            }
            dr.Close();
            return list;
        }

        //To show the inventory of the selected location
        public List<Item> inventory(string storeLocation)
        {
            List<Item> list = new List<Item>();
            using SqlConnection connect = new SqlConnection(this.source);
            connect.Open();
            string query = @"SELECT * FROM Inventory INNER JOIN Locations ON Locations.storeLocationId = Inventory.storeLocationId INNER JOIN Items ON Items.itemId = Inventory.itemId WHERE storeLocation = @storeLocation;";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@storeLocation", storeLocation);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int itemId = dr.GetInt32(1);
                string itemName = dr.GetString(6);
                decimal itemPrice = dr.GetDecimal(7);
                string itemDescription = dr.GetString(8);
                int itemQuantity = dr.GetInt32(2);
                list.Add(new(itemId, itemName, itemPrice, itemDescription, itemQuantity));
            }
            dr.Close();
            return list;
        }




       /*public int cartPrice(List<int> cart)
        {
            int cost = 0;
            foreach (int i in cart)
            {
                string query = $"SELECT itemPrice FROM Item WHERE itemId = '{i}';";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cost += Convert.ToInt32(dr[0].ToString());
                }
                int cartCost = cost;
                return cartCost;
            }
        }*/

        //For the customer's shopping cart
        public void cartItems(int item)
        {
            using SqlConnection connect = new SqlConnection(this.source);
            connect.Open();
            List<string> items = new List<string>();
            string query = $"SELECT itemName, itemPrice FROM items WHERE itemId = '{item}';";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                items.Add(dr[0].ToString() + "\t" + dr[1].ToString());
            }
            dr.Close();
            foreach (string i in items)
            {
                Console.WriteLine(i);
            }
        }

        //Database for the past order of the certain location store
        public void getStoreOrder(int storeLocationId)
        {
            using SqlConnection connect = new SqlConnection(this.source);
            connect.Open();
            string query = $"SELECT * FROM PastOrders WHERE storeLocationId = '{storeLocationId}';";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("lineId\t\t\torderId\t\tstoreId customerId\t\titemName\torderTotal\n");
            while(dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + "\t" + dr[1].ToString() + "\t" + dr[2].ToString() + "\t"
                   + dr[3].ToString() + "\t\t" + dr[4].ToString() + "\t" + dr[5].ToString());
            }
            dr.Close();
        }

        //Database for the past order of the certain customer's
        public void getCustomerOrder(int customerId)
        {
            using SqlConnection connect = new SqlConnection(this.source);
            connect.Open();
            string query = $"SELECT * FROM PastOrders WHERE customerId = '{customerId}';";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("lineId\t\t\torderId\t\tstoreId customerId\t\titemName\torderTotal\n");
            while (dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + "\t" + dr[1].ToString() + "\t" + dr[2].ToString() + "\t"
                   + dr[3].ToString() + "\t\t" + dr[4].ToString() + "\t" + dr[5].ToString());
            }
            dr.Close();
        }
    }
}

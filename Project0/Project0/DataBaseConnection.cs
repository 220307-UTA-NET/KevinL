using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project0
{
    internal class DataBaseConnection : IDataBaseConnection
    {
        private readonly string source = "Data source = LAPTOP-16481HHS\\SQLEXPRESS; intial Catalog = 03072022-P0; integrated security = true";
        private readonly SqlConnection connection;

        public DataBaseConnection()
        {
            connection = new SqlConnection(source);
            connection.Open();
        }

        public void newCustomer(string customerFirstName, string customerLastname, string customerUsername, string customerPassword)
        {
            bool customerAlreadyRegister = false;

            if(customerAlreadyRegister == true)
            {

            }
            else
            {
                string query = $"";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();               
            }

        }

       public bool customerFound(string customerUsername, string customerPassword)
       {
            string query = $"SELECT * FROM Customers WHERE customerUsername = '{customerUsername}' AND customerPassword = '{customerPassword}';";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }                    
       }

       /* public int cartPrice(List<int> cart)
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

        public void cartItems(int item)
        {
            List<string> items = new List<string>();
            string query = $"SELECT itemName, itemPrice FROm items WHERE itemId = '{item}';";
            SqlCommand cmd = new SqlCommand(query, connection);
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


    }
}

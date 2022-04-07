using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project0.Logic;
using Project0.DataInfrastructure;
using System.Data.SqlClient;

namespace Project0
{
    public static class Global
    {
        public static List<Item> cart = new List<Item>();
        public static decimal totalCartPrice = 0.00M;
    }
    public class StoreLogic
    {
        IDataBaseConnection connection;

        public StoreLogic(IDataBaseConnection connection)
        {
            this.connection = connection;
        }        

        //The user enteres the first selection menu
        public void firstMenu()
        {
            bool userOperate = true;

            do
            {
                Global.cart.Clear();
                Global.totalCartPrice = 0.00M;
                Console.WriteLine("Select the number that what would you like to do:\n " +
                "[1] Login [2] Register [3] View history [0] Exit");
                string userFirstInput = Console.ReadLine();

                switch (userFirstInput)
                {
                    //User selects to login                
                    case "1":
                        login();
                        break;

                    //User selects to register as a new customer
                    case "2":
                        register();
                        break;

                    //User selects to look at the order history
                    case "3":
                        historyMenu();
                        break;

                    //User selects to exit the program
                    case "0":
                        userOperate = false;
                        Console.WriteLine("Thank you for shopping at Kevin Lee's Korean store");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input! Please Select one of the numbers! (0 - 3)");
                        break;
                }
            } while (userOperate == true);
        }

        //The user login menu
        public void login()
        {
            bool loginComplete = false;
            do
            {
                Console.WriteLine("Enter your customer username");
                string customerUsername = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string customerPassword = Console.ReadLine();               

                if(this.connection.customerFound(customerUsername, customerPassword))
                  {
                     Console.WriteLine("Welcome, you are clear to enter to the main menu.");
                     mainMenu();
                     loginComplete = true;

                  }
                  else 
                  {
                      Console.WriteLine("I'm sorry, the user does not exist. Please try again or register.");
                  }

            } while (!loginComplete);            
        }

        //The user registers as a new customer
        public void register()
        {
            bool registerComplete = false;

            do
            {
                Console.WriteLine("Welcome to the registeration menu.");
                Console.WriteLine("Enter your customer firstname");
                string customerFirstName = Console.ReadLine();
                Console.WriteLine("Enter your customer lastname");
                string customerLastName = Console.ReadLine();
                Console.WriteLine("Enter your customer username");
                string customerUsername = Console.ReadLine();
                Console.WriteLine("Enter your customer password");
                string customerPassword = Console.ReadLine();
                string result = "";
                

                 if (this.connection.customerFound(customerUsername, customerPassword))
                  {
                      Console.WriteLine("I'm sorry, but this customer username already exists. Please try again.");
                        

                  }
                  else
                  {

                    connection.newCustomer(customerFirstName, customerLastName, customerUsername, customerPassword);              
                                      
                    Console.WriteLine("Welcome, " + customerFirstName + " " + customerLastName + "! " +
                     "Before you enter the store, we will like to login first for security reason.");
                      registerComplete = true;
                  }
                login();

            } while (!registerComplete);           
        }

        //The logic that shows the history of a customer or a store
        public void historyMenu()
        {
            bool viewOrderFinished = false;
            do
            {
                Console.WriteLine("Which kind of history you want to see?\n [1]Customer\n [2]Store\n [0]To go back to first menu\n");
                string userHistoryInputMenu = Console.ReadLine();

                switch (userHistoryInputMenu)
                {
                    //User wants to watch the customer's history
                    case "1":
                        Console.WriteLine("Enter your customer Id number");
                        int customerId = int.Parse(Console.ReadLine());
                        Customer customer = new Customer();
                        customer.customerHistoryPurchase(customerId);
                        Console.WriteLine();
                        //DataBaseConnection dbcustomer = new DataBaseConnection(source);
                        //dbcustomer.getCustomerOrder(customerId);

                        break;

                    //User wants to watch the history of the certain store location 
                    case "2":
                        Console.WriteLine("Enter the store Id number");
                        int storeLocationId = int.Parse(Console.ReadLine());
                        Location location = new Location();
                        location.locationHistoryPurchase(storeLocationId);
                        Console.WriteLine();
                        //DataBaseConnection dbstore = new DataBaseConnection(source);
                        //dbstore.getStoreOrder(storeLocationId);
                        break;

                    //If the user wants to go back to the first menu
                    case "0":
                        viewOrderFinished = true;
                        break;
                }

            } while (!viewOrderFinished);

        }

        //After user successfully logs in, the system lets the user enter the main menu
        public void mainMenu()
        {
            bool userMainMenuSelected = false;
            do
            {
                Console.WriteLine("Welcome to the main menu. Select the number that what would you like to do:\n " +
                "[1] Shopping\n [0] Go back to the first menu");
                string userMainMenuInput = Console.ReadLine();

                switch (userMainMenuInput)
                {
                    //Customer enters the seletion menu of the location.
                    case "1":
                        storeLocationSelect();
                        userMainMenuSelected = true;
                        break;

                    //Goes back to the first menu
                    case "0":
                        firstMenu();
                        break;

                    default:
                        Console.WriteLine("Invalid input! Please Select one of the numbers! (0 - 1)");
                        break;
                }
            } while (!userMainMenuSelected);

        }

        //A selection menu which allows user to select the location
        public void storeLocationSelect()
        {
            bool userSelectedStoreLocation = false;
            do
            {
                Console.WriteLine("Which location do you want to shop? Select the number where you want to shop\n " +
                "[1] Washington D.C.\n [2] Philadelphia\n [3] New York City\n [4] Boston\n [0] Go back to the Main Menu");

                string userStoreLocationInput = Console.ReadLine();
                string storeLocation = "";

                switch (userStoreLocationInput)
                {
                    case "1":
                        storeLocation = "Washington D.C.";
                        userSelectedStoreLocation = true;
                        break;

                    case "2":
                        storeLocation = "Philadelphia";
                        userSelectedStoreLocation = true;
                        break;

                    case "3":
                        storeLocation = "New York City";
                        userSelectedStoreLocation = true;
                        break;

                    case "4":
                        storeLocation = "Boston";
                        userSelectedStoreLocation = true;
                        break;

                    case "0":
                        mainMenu();
                        userSelectedStoreLocation = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input! Please Select one of the numbers! (0 - 4)");
                        break;
                }
                this.shoppingCart(storeLocation);

            } while (!userSelectedStoreLocation);            
        }

        //User enters the shopping cart menu after choosing the store location
        public void shoppingCart(string storeLocation)
        {   
            //The system shows the customer's shopping cart in order to allow the customer decide  
            Console.WriteLine("Your shopping cart contains: ");
            foreach (Item item in Global.cart)
            {
                Console.WriteLine(item.GetItemId() + " " + item.GetItemName() + " " + item.GetItemPrice() + " " + item.GetItemDescription() + " " + item.GetItemQuantity());
            }
            //this.connection.cartItems(int item);
            // List<Item> cart = new List<Item>();
            int totalItemCount = 0;
            List<Item> itemIdList = new List<Item>();
            //itemIdList = connection.getItemId(storeLocation);

            bool userShopping = true;
            do
            {
                Console.WriteLine("Select the number what you want to do:\n " +
                "[1]Add product\n [2]Remove product\n [3]Empty the shopping cart\n [4]Proceed to the checkout\n" +
                " [0]Empty the shopping cart and go back to Main Menu");

                string userShoppingInput = Console.ReadLine();

                switch (userShoppingInput)
                {
                    //User wants to add items in cart
                    case "1":
                        addItemCart(totalItemCount, Global.totalCartPrice, storeLocation);
                        break;

                    //User wants to remove items in cart
                    case "2":
                        removeItemCart(totalItemCount, Global.totalCartPrice, storeLocation);
                        break;

                    //User wants to clear the shopping cart
                    case "3":
                        Global.cart.Clear();
                        totalItemCount = 0;
                        Global.totalCartPrice = 0.00M;
                        break;

                    //Customer wants to checkout
                    case "4":
                        checkout(totalItemCount, Global.totalCartPrice, storeLocation);
                        userShopping = false;
                        break;

                    //Customer want to stop shop and got back to the main menu. Moreover, the shopping cart will clear.  
                    case "0":
                        mainMenu();
                        Global.cart.Clear();
                        userShopping = false;
                        totalItemCount = 0;
                        Global.totalCartPrice = 0.00M;
                        break;


                    default:
                        Console.WriteLine("Invalid input! Please Select one of the numbers! (0 - 4)");
                        break;
                }
            } while (userShopping == true);           
        }

        //User wants to add an item
        public void addItemCart(int totalItemCount, decimal totalCartPrice, string storeLocation)
        {

            //The system shows the inventory of the first in order to customer to add item 
            List<Item> inventory = this.connection.inventory(storeLocation);
            string customerAddQuantity;
            decimal customerItemQuantityPrice;
            decimal itemPrice = 0.00M;
            List<Item> itemIdList = new List<Item>();
            foreach (Item item in inventory)
            {
                Console.WriteLine(item.GetItemId() + " " + item.GetItemName() + " " + item.GetItemPrice() + " " + item.GetItemDescription() + " " +item.GetItemQuantity());
            }
           

            Console.WriteLine("Press the number that you want to add.(0 to cancel and go back to the shopping cart menu)");
            string addItemId = Console.ReadLine();
            int addItemIdConverted = Int32.Parse(addItemId);

            //If the user types incorrect input
            if(addItemIdConverted > 11 || addItemIdConverted < 0)
            {
                Console.WriteLine("Invalid input! Please type the correct itemId number! (1 - 11) or 0 to go back to the shopping cart menu");
                addItemCart(totalItemCount, totalCartPrice, storeLocation);
            }

            //The user wants to to go back to shopping cart menu
            else if(addItemId == "0")
            {
                shoppingCart(storeLocation);
            }

            //The system asks the user if he user really want to add the selected item
            else
            {
                Console.WriteLine("Do you want to add an item to your cart?\n " +
                "[1] Yes\n [2] No\n");
                string addItems = Console.ReadLine();

                //The user wants to add item 
                if (addItems == "1")
                {
                    //The system asks how many does the customer asks.
                    Console.WriteLine("How many do you want to add?");

                   customerAddQuantity = Console.ReadLine();
                   int customerAddQuantityConverted = Int32.Parse(customerAddQuantity);

                    //The system lets the customer up to 10 per each item quantity.
                    if (customerAddQuantityConverted <= 10)
                    {
                        customerItemQuantityPrice = customerAddQuantityConverted * itemPrice;
                        Global.totalCartPrice += customerItemQuantityPrice;
                        totalItemCount += customerAddQuantityConverted;
                        Item selecteditem = new Item(addItemIdConverted, inventory[addItemIdConverted-1].GetItemName(), inventory[addItemIdConverted-1].GetItemPrice(), inventory[addItemIdConverted-1].GetItemDescription(), customerAddQuantityConverted);
                        Global.cart.Add(selecteditem);
                    }

                    //The system won't let you take more than 10 per item.
                    else if (customerAddQuantityConverted > 10 || customerAddQuantityConverted < 0)
                    {
                        Console.WriteLine("I'm sorry, but for now we can only accept up to 10 per item for now.");
                        addItemCart(totalItemCount, totalCartPrice, storeLocation);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please type numbers 1-10. Or type 0 to cancel the add");
                        addItemCart(totalItemCount, totalCartPrice, storeLocation);
                    }

                }
                //The user doesn't wants to add an item
                else if (addItems == "2")
                {
                    addItemCart(totalItemCount, totalCartPrice, storeLocation);
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please type the number again (1 or 2)");
                }
            }          

            shoppingCart(storeLocation);
        }

        //The user wants to remove an item
        public void removeItemCart(int totalItemCount, decimal totalCartPrice ,string storeLocation)
        {

            //The system shows the customer's shopping cart first in order to the user which item to remove 
            Console.WriteLine("Your shopping cart contains: ");
            foreach (Item item in Global.cart)
            {
                Console.WriteLine(item.GetItemId() + " " + item.GetItemName() + " " + item.GetItemPrice() + " " + item.GetItemDescription() + " " + item.GetItemQuantity());
            }
            totalItemCount = Global.cart.Count;
            List<Item> itemIdList = new List<Item>();

            //Since there is no item in the shooping cart, the system won't let the user to proceed and send back to shopping cart menu 
            if (totalItemCount <= 0)
            {
                Console.WriteLine("I'm sorry, since there is no item in your cart to remove, we will send back to the shopping cart menu");
                shoppingCart(storeLocation);
                
            }

            else
            {
                Console.WriteLine("Press the number that you want to remove.(0 to cancel and go back to the shopping cart menu)");
                string removeItemId = Console.ReadLine();
                int removeIntIdConverted = Int32.Parse(removeItemId);

                foreach (Item item in Global.cart)
                {
                    Console.WriteLine(item.GetItemId() + " " + item.GetItemName() + " " + item.GetItemPrice() + " " + item.GetItemDescription() + " " + item.GetItemQuantity());

                    if(item.GetItemId() == removeIntIdConverted)
                    {
                        Console.WriteLine("How many do you want to remove?");
                        int customerRemoveItemQuantity = 0;
                        int individualItemInCart = 0;
                        customerRemoveItemQuantity = Int32.Parse(Console.ReadLine());
                        if (item.GetItemQuantity() < customerRemoveItemQuantity)
                        {
                            Console.WriteLine("There are no more item to remove!");
                            Global.cart.Remove(item);
                            shoppingCart(storeLocation);
                        }
                        else
                        {

                            item.SetItemQuantity(item.GetItemQuantity() - customerRemoveItemQuantity);
                            /*Global.totalCartPrice -= customerRemoveItemQuantity * individualItemInCart;
                            totalItemCount -= individualItemInCart;
                            Item selecteditem = new Item(removeIntIdConverted, Global.cart[removeIntIdConverted - 1].GetItemName(), Global.cart[removeIntIdConverted - 1].GetItemPrice(), Global.cart[removeIntIdConverted - 1].GetItemDescription(), customerRemoveItemQuantity);
                            Global.cart.Remove(selecteditem);*/
                        }
                            
                    }
                    else if(removeIntIdConverted == 0)
                    {
                        shoppingCart(storeLocation);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input! Please type the correct input!");
                        removeItemCart(totalItemCount, totalCartPrice,  storeLocation);
                    }
                }
               /* if (findId == null)
                {
                    Console.WriteLine("Invalid Input! Please type the correct input!");
                }

                //
                else
                {
                    int customerRemoveItemQuantity = 0;
                    int individualItemInCart = 0;

                    //If the quantity of the selected is less than customer's quantity 
                    if (individualItemInCart < customerRemoveItemQuantity)
                    {
                        Console.WriteLine("There are no more item to remove!");
                    }
                    else 
                    {
                        Console.WriteLine("How many do you want to remove?");

                        customerRemoveItemQuantity = Int32.Parse(Console.ReadLine());

                        Global.totalCartPrice -= customerRemoveItemQuantity * individualItemInCart;
                        totalItemCount -= individualItemInCart;
                        Item selecteditem = new Item(removeIntIdConverted, Global.cart[removeIntIdConverted - 1].GetItemName(), Global.cart[removeIntIdConverted - 1].GetItemPrice(), Global.cart[removeIntIdConverted - 1].GetItemDescription(), customerRemoveItemQuantity);
                        Global.cart.Remove(selecteditem);
                    }
                    
                }*/
                    
            }
            
            shoppingCart(storeLocation);
        }

        //User enters to checkout menu 
        public void checkout(int totalItemCount, decimal totalCartPrice, string storeLocation)
        {
            foreach (Item item in Global.cart)
            {
                Console.WriteLine(item.GetItemId() + " " + item.GetItemName() + " " + item.GetItemPrice() + " " + item.GetItemDescription() + " " + item.GetItemQuantity());


                //If there is no item is the cart, the process will not let you proceed and send you back to shopping cart menu.
                if (item.GetItemQuantity() == 0)
                {
                    Console.WriteLine("I'm sorry, we cannot proceed checkout without any item(s). We will send you back to shopping cart menu.");
                    shoppingCart(storeLocation);
                }

                //The customer wants to proceed to payment or not and go back to shooping cart menu to edit 
                else
                {
                    Console.WriteLine("Would you like to proceed to pay?\n [1]Yes\n [0]No and go back to shopping cart menu");
                    string proceedPayment = Console.ReadLine();

                    switch (proceedPayment)
                    {
                        //The customer wants to proceed to the payment
                        case "1":
                            purchase();
                            break;

                        //the customer wants to go back to the shopping cart menu and edit the shopping cart.
                        case "0":
                            shoppingCart(storeLocation);
                            break;

                        default:
                            Console.WriteLine("Invalid input! Please Select one of the numbers! (0 - 1)");
                            break;

                    }
                }
            }
            
        }

        //The process of purchase.
        public void purchase()
        {
            Console.WriteLine();
            string cost = /*connection.cartPrice(cart).ToString();*/null;
            int intCost = /*connection.cartPrice(cart);*/0;
            Console.WriteLine("\t" + cost);
            bool customerPaid = false;
            do
            {
                Console.WriteLine("Enter your money:\n");
                string payment = Console.ReadLine();
                int intPayment = /*customer.IntConversion(payment);*/0;
                if (payment == cost)
                {
                    Console.WriteLine();
                    customerPaid = true;
                }
                else if (intPayment > intCost)
                {
                    int change = intPayment - intCost;
                    Console.WriteLine($"Paymentaccepted.\nHere is your change: {change}\n");
                    customerPaid = true;
                    mainMenu();

                }
                else
                {
                    Console.WriteLine("Payment is not accepted.\n Please enter correct amount.\n");
                }

            } while (!customerPaid);
        }

    }

}

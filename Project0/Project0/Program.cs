using System;
using System.IO;
using Project0.Logic;

namespace Project0
{
    class Program
    {

        private static DataBaseConnection connection = new DataBaseConnection();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, thank you for using Kevin Lee's Korean Store");
            firstMenu();
        } 
        //The user enteres the first selection menu
        static void firstMenu()
        {
            bool userOperate = true;

            do
            {
                Console.WriteLine("Select the number that what would you like to do:\n "+
                "[1] Login [2] Register [3] View history [0] Exit");
                string userFirstInput = Console.ReadLine();


                switch(userFirstInput)
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
            }while(userOperate == true);

        }

         //The user login menu
        static void login()
        {
            bool loginComplete = false;
            do
            {
                Console.WriteLine("Enter your customer username");
                string customerUsername = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string customerPassword = Console.ReadLine();

                Console.WriteLine("Login success, welcome, you are clear to enter to the main menu.");
                loginComplete = true;
                mainMenu();


                /*if(connection.customerFound(customerUsername, customerPassword))
                {
                    Console.WriteLine("Login success, welcome, you are clear to enter to the main menu.");
                    loginComplete = true;
                    mainMenu();
                    
                }
                else
                {
                    Console.WriteLine("I'm sorry, but the user does not exist. Please try again or register.");
                    firstMenu();
                }*/

            } while (!loginComplete);            
        }

        //The user registers as a new customer
        static void register()       
        {

            bool registerComplete = false;

            do
            {
                Console.WriteLine("Enter your customer firstname");
                string customerFirstname = Console.ReadLine();
                Console.WriteLine("Enter your customer lastname");
                string customerLastname = Console.ReadLine();
                Console.WriteLine("Enter your customer username");
                string customerUsername = Console.ReadLine();
                Console.WriteLine("Enter your customer password");
                string customerPassword = Console.ReadLine();

                Console.WriteLine("Welcome, " + customerFirstname + " " + customerLastname + "! " +
                "Before you enter the store, we will like to login first for security reason.");
                registerComplete = true;
                login();

            } while (!registerComplete);
            

        }
            
        //The logic that shows the history of a customer or a store
        static void historyMenu()
        {

            bool viewOrderFinished = false;
            do
            {
                Console.WriteLine("Which kind of history you want to see?\n [1]Customer\n [2]Store\n [0]To go back to first menu\n");
                string userHistoryInputMenu = Console.ReadLine();

                switch(userHistoryInputMenu)
                {
                    //User wants to watch the customer's history
                    case "1":
                    Console.WriteLine("Enter your customer Id number");
                    int customerId = int.Parse(Console.ReadLine());
                    Customer customer = new Customer();
                    customer.customerHistoryPurchase(customerId); 
                    Console.WriteLine();
                    break;

                    //User wants to watch the history of the certain store location 
                    case "2":
                    Console.WriteLine("Enter the store Id number");
                    int storeLocationId = int.Parse(Console.ReadLine());
                    Location location = new Location();
                    location.locationHistoryPurchase(storeLocationId);
                    Console.WriteLine();
                    break;

                    //If the user wants to go back to the first menu
                    case "0":
                    viewOrderFinished = true;
                    break;
                }

            }while(!viewOrderFinished);               
        }

        //The first and the main menu which the user after successfully logs in or register
        static void mainMenu()
        {
            bool userMainMenuSelected = false;
            do{
                Console.WriteLine("Welcome to the main menu. Select the number that what would you like to do:\n "+
                "[1] Shopping\n [0] Go back to the first menu");
                string userMainMenuInput = Console.ReadLine();

                switch(userMainMenuInput)
                {
                    case "1":
                    storeLocationSelect();
                    userMainMenuSelected = true;
                    break;

                    case "0":
                    firstMenu();
                    break;

                    default:
                    Console.WriteLine("Invalid input! Please Select one of the numbers! (0 - 1)");                   
                    break; 
                }
            }while(!userMainMenuSelected);      
        }

        //A selection menu which allows user to select the location
        static void storeLocationSelect()
        {

            bool userSelectedStoreLocation = false;
            do
            {
                Console.WriteLine("Which location do you want to shop? Select the number where you want to shop\n "+
                "[1] Washington D.C.\n [2] Philadelphia\n [3] New York City\n [4] Boston\n [0] Go back to the Main Menu");
                string userStoreLocationInput = Console.ReadLine();

                switch(userStoreLocationInput)
                {
                    case "1":
                    string storeLocation = "Washington D.C.";
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

            } while(!userSelectedStoreLocation);  
            shoppingCart();
        }

        static void shoppingCart()
        {

            List<int> cart = new List<int>();
            int cartCost=  0;
            int itemCount = 0;
            List<int> itemIdList = new List<int>();
            //itemIDList = _connection.GetItemIDs(itemIDList);
            List<int>realItemId = itemIdList; 


            bool userShopping = true;
            do
            {
                Console.WriteLine("Select the number what you want to do:\n " +
                "[1]Add product\n [2]Remove product\n [3]View shopping cart\n [4]Empty the shopping cart\n [5]Proceed to the checkout\n" +
                " [0]Empty the shopping cart and go back to Main Menu");

                string userShoppingInput = Console.ReadLine();

                switch(userShoppingInput)
                {

                    case "1":
                        addItemCart();
                    break;

                    case "2":
                        removeItemCart();
                    break;

                    case "3":
                    break;

                    case "4":
                        cartCost = 0;
                        itemCount = 0;
                        Console.WriteLine("Your cart was reseted.");
                        break;

                    case "5":
                    checkout();
                    userShopping = false; 
                    break;

                    case "0":
                    mainMenu();
                    userShopping = false;
                        cartCost = 0;
                        itemCount = 0;
                    break;


                    default:
                    Console.WriteLine("Invalid input! Please Select one of the numbers! (0 - 5)");
                    break;
                }


            }while(userShopping == true);
                     
           
        }

        static void addItemCart()
        {
            Console.WriteLine("Press the number that you want to add.");


            Console.WriteLine("Do you want to add an item to your cart?\n " +
            "[1] Yes\n [2] No\n");
            string addItems = Console.ReadLine();
            Console.WriteLine();
        }

        static void removeItemCart()
        {
            int itemCount = 0;
            if(itemCount <= 0)
            {
                Console.WriteLine("I'm sorry, since there is no cart to add, we will send back to the shooping cart menu");
                shoppingCart();
            }
            else
            {
                Console.WriteLine("Press the number that you want to remove.");

            }
            
        }
       
        static void checkout()
        {
            int totalItemCount = 0;
            double totalPrice = 0.00;

            if(totalItemCount == 0)
            {
                Console.WriteLine("I'm sorry, we cannot proceed checkout without any item(s). We will send you back to shopping cart menu.");
                shoppingCart();                
            }
            else
            {
                Console.WriteLine("Would you like to proceed to pay?\n [1]Yes\n [0]No and go back to shopping cart menu");
                string proceedPayment = Console.ReadLine();

                switch(proceedPayment)
                {
                    case "1":
                    purchase();
                    break;

                    case "0":
                    shoppingCart();
                    break;

                    default:
                    Console.WriteLine("Invalid input! Please Select one of the numbers! (0 - 1)");
                    break;              
                
                }
            }
        }

        static void purchase()
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
                if(payment == cost)
                {
                    Console.WriteLine();
                    customerPaid = true;
                }
                else if (intPayment > intCost)
                {
                    int change = intPayment - intCost;
                    Console.WriteLine($"Paymentaccepted.\nHere is your change: {change}\n");
                    customerPaid = true;
                }
                else
                {
                    Console.WriteLine("Payment is not accepted.\n Please enter correct amount.\n");
                }

            } while (!customerPaid);
        }
    }
}


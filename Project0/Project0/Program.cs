using System;
using System.IO;

namespace Project0
{
    class Program
    {
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
            Console.WriteLine("Enter your customer username");
            string customerUsername = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string customerPassword = Console.ReadLine();
        }

        //The user registers as a new customer
        static void register()
        {
            Console.WriteLine("Enter your customer firstname");
            string customerFirstname = Console.ReadLine();
            Console.WriteLine("Enter your customer lastname");
            string customerLastname = Console.ReadLine();
            Console.WriteLine("Enter your customer username");
            string customerUsername = Console.ReadLine();
            Console.WriteLine("Enter your customer password");
            string customerPassword = Console.ReadLine();

            Console.WriteLine("Welcome, " + customerFirstname + " " + customerLastname + "! ");
            mainMenu();

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
                    case "0":
                    mainMenu();
                    break;

                    default:
                    Console.WriteLine("Invalid input! Please Select one of the numbers! (0 - 4)");                   
                    break;  
                }              

            } while(!userSelectedStoreLocation);                
        }
    }
}


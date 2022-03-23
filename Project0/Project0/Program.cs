using System;
using System.IO;

namespace Project0
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, thank you for using Kevin Lee's Korean Store");

            bool userOperate = true;

            do
            {
                Console.WriteLine("Select the number that what would you like to do:\n "+
                "[1] Login [2]Register [3]View history [0]Exit");
                int userMenuInput = int.Parse(Console.ReadLine());

                switch(userMenuInput)
                {
                    case 1:
                    break;

                    case 2:
                    break;

                    case 3:
                    break;

                    case 0:
                        userOperate = false;
                        Environment.Exit(0);
                    break;

                    default:
                    
                    break;

                }




            }while(userOperate == true);
        }
    }
}

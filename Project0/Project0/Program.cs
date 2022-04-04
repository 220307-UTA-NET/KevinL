using System;
using System.IO;
using Project0.Logic;
using Project0.DataInfrastructure;

namespace Project0
{
    class Program
    {
        

        static void Main()
        {
            string source = "Server=tcp:03072022revature.database.windows.net,1433;Initial Catalog=03072022Project0;Persist Security Info=False;User ID=klee5760;Password=Bo1Go21010!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            IDataBaseConnection connection = new DataBaseConnection(source);
            StoreLogic sl = new StoreLogic(connection);

            Console.WriteLine("Hello, thank you for using Kevin Lee's Korean Store");
            sl.firstMenu();
        }      
    }
}


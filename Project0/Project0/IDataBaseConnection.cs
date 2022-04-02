using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0
{
    internal interface IDataBaseConnection
    {
        void newCustomer(string customerFirstName, string customerLastname, string customerUsername, string customerPassword);
    }
}

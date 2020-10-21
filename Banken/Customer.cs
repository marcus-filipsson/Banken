using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Customer
    {

        //här så sparas kundens namn.
        // här sparas hur mycket pengar kunden har.
        public string name;
        public int balance;
        public Customer()
        {
        }
        public Customer(string name)
        {
            this.name = name;
            this.balance = 0;
        }
        public Customer(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public void SetUserInfoByString(string row)
        {
            string[] items = row.Split(',');
            this.name = items.First();
            this.balance = int.Parse(items.Last());
        }
        public string GetUserInfoString()
        {
            return name + ',' + balance;
        }
    





         //här så sparas kundens namn.
         // här sparas hur mycket pengar kunden har.



       

        public String ShowCustomer ()
        {
            return name + balance; // här retuneras namnet på kunden och hur mycket pengar den har i ShowCustomer.
        }

    }
}
